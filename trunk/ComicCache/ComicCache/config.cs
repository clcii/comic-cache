using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Drawing;
using System.ComponentModel;
using Microsoft.Win32;

namespace ComicCache
{
	//[Serializable()]
	public class Config //: ISerializable
    {
	
		#region Constructors
    	public Config() {

        }
    	#endregion
    	#region Methods
    	public static Config Load(){
    		try {
    			if (File.Exists(settingsFile)) {
    				Stream stream = File.Open(settingsFile, FileMode.Open);
    				XmlSerializer xs = new XmlSerializer(typeof(Config));
                    Config cpycfg;
                    try
                    {
                        cpycfg = (Config)xs.Deserialize(stream);
                    }
                    catch (Exception ex)
                    {
                        Log.Instance.Write(ex.Message);
                        Log.Instance.Write("Loading default");
                        cpycfg = new Config();
                    }
    				
    				stream.Close();
    				return cpycfg;
    				}
    			else
    				{
    			 		return new Config();
    				}
    			}
    		catch (Exception ex) {
    			Log.Instance.Write(ex.Message);
    			return null;
    		} finally {
    			
    		}
   	
    	}
        public void Save() {
    		try {
    			if (Directory.Exists(settingsFolder) == false){
						Directory.CreateDirectory(settingsFolder);
					}	
    			XmlSerializer xs = new XmlSerializer(typeof(Config));
    			TextWriter tw = new StreamWriter(settingsFile);
    			xs.Serialize(tw,this);
    			tw.Close();
   			
    		} catch (Exception ex) {
    			Log.Instance.Write(ex.Message);
    		} finally {
    			
    		}
        }
        public bool IsValid(){

            bool result = true;
            
            result = Directory.Exists(settingsFolder);
            if (!result)
            {
                errormessage = "Settings Folder does not exist";
                return result;
            }
            
            result = Directory.Exists(FolderPath);
            if (!result)
            {
                errormessage = "Destination Folder does not exist";
                return result;
            }
            foreach (string sfolder in this.ComicPaths) {
                result = Directory.Exists(sfolder);
                if (!result)
                {
                    errormessage = "Comics Folder does not exist";
                    return result;
                }
         
            
            }
            result = Intervalnum > 0;
            if (!result)
            {
                errormessage = "No time interval indicated";
                return result;
            }
            result = Covers > 0 ;
            if (!result)
            {
                errormessage = "Zero covers to be produced";
                return result;
            }
            
            result = Intervaltype != "";
            if (!result)
            {
                errormessage = "Type of interval not indicated";
                return result;
            }

            if (this.Resize)
            {
                result = this.selectedResizeStyle != ResizeStyle.None;
                if (!result)
                {
                    errormessage = "New size not inidcated: Screen, Common, or Custom";
                    return result;
                }
                

            }

            if (this.SelectedResizeStyle == ResizeStyle.Common)
            {
                result = (this.selectedCommonResizeSize != "");
                if (!result)
                {
                    errormessage = "Type of Common Resize not indicated";
                    return result;
                }
            }
            if (this.SelectedResizeStyle == ResizeStyle.Custom) {
                result = (this.SelectedCustomResizeX > 0) & (this.SelectedCustomResizeY > 0);
                if (!result)
                {
                    errormessage = "Type of Custom Resize not indicated or invalid";
                    return result;
                }
            }
            result = this.ImageFormat != null;
            if(!result)
                {
                errormessage = "Type of image format not indicated";            
                return result;
                }

            return result;

        }
    	#endregion
        #region Properties
        public static string settingsFolder{
        	get { //return Path.Combine(Application.LocalUserAppDataPath, Application.ProductName + "\\");
                //return Application.UserAppDataPath;
                return Path.GetDirectoryName(Application.ExecutablePath);
            }
        
        }
        public static string settingsFile{
        	get { return Path.Combine(settingsFolder, Application.ProductName +".xml");}
        
        }
        
		public int Intervalnum {
			get { return intervalnum; }
			set { intervalnum = value; }
		}
		public string Intervaltype {
			get { return intervaltype; }
			set { intervaltype = value; }
		}        
        public System.Drawing.Imaging.ImageFormat ImageFormat{
        	get{ 
        		System.Drawing.Imaging.ImageFormat result = null;
        		switch (cachetype) {
        			case "jpg":
        				result = System.Drawing.Imaging.ImageFormat.Jpeg;
        				break;
        			case "bmp":
        				result = System.Drawing.Imaging.ImageFormat.Bmp;
        				break;
        			case "png":
        				result = System.Drawing.Imaging.ImageFormat.Png;
        				break;
        			}
        			return result;
        		}
        		
        	}
        public string FolderPath{
            get { return folderpath; }
            set { folderpath = value; }
        }
         
        public double Intervalabs{
            get { 
        		TimeSpan ts = new TimeSpan();
        		string timestring = Convert.ToString((double)intervalnum) + " " + intervaltype;
        		Log.Instance.Write(timestring);
        		//TimeSpan.TryParse(timestring, out ts);
        		
        		switch (intervaltype.ToLower()) {
        			case "seconds":
        				ts += TimeSpan.FromSeconds((double)intervalnum);
        				break;
        			case "minutes":
        				ts += TimeSpan.FromMinutes((double)intervalnum);
       					break;
        			case "hours":
       					ts += TimeSpan.FromHours((double)intervalnum);
       					break;
        			case "days":
       					ts += TimeSpan.FromDays((double)intervalnum);
       					break;
        		}
        		Log.Instance.Write(Convert.ToString(ts));
        		intervalabs = (double)ts.TotalMilliseconds;
        		
        		return intervalabs; }
        }
        public string ComicPath
        {
            get { return comicpath; }
            set { comicpath = value; }
        }
        public List<string> ComicPaths
        {
            get {
                List<string> results = new List<string>();
                results.AddRange(comicpath.Split(';'));
                return results;
            }
        }
        public int Covers {
			get { return covers; }
			set { covers = value; }
		}        
		public bool Resize {
			get { return resize; }
			set { resize = value; }
		}
		public ResizeStyle SelectedResizeStyle {
			get { return selectedResizeStyle; }
			set { selectedResizeStyle = value; }
		}
        public ResizeRatioType SelectedResizeRatioType {
            get { return selectedResizeRatioType; }
            set { selectedResizeRatioType = value; }
        }
		public string SelectedCommonResizeSize {
			get { return selectedCommonResizeSize; }
			set { selectedCommonResizeSize = value; }
		}	
		public int SelectedCustomResizeX {
			get { return selectedCustomResizeX; }
			set { selectedCustomResizeX = value; }
		}
		public int SelectedCustomResizeY {
			get { return selectedCustomResizeY; }
			set { selectedCustomResizeY = value; }
		}
        [XmlIgnore]
        public Color BackGroundColor
        {
            get { return backgroundcolor; }
            set { backgroundcolor = value; }
        }
        [XmlElement("BackGroundColor")]
        public string BackGroundColorHtml
        {
            get { return ColorTranslator.ToHtml(BackGroundColor); }
            set { BackGroundColor = ColorTranslator.FromHtml(value); }
        }


        public bool Filterenabled
        {
            get { return filterenabled; }
            set { filterenabled = value; }
        }
        public string Filefilter
        {
            get {return filefilter; }
            set { filefilter = value; }
        }
		public string SettingsFile {
			get { return settingsFile; }
		}
        public string ErrorMessage
        {
            get { return errormessage; }
            set { errormessage = value; }
        }
        public bool CropfFllForBG
        {
            get { return cropfillforBG; }
            set { cropfillforBG = value; }
        }
        

        private string errormessage = "";
        private string selectedCommonResizeSize = "";
        private int selectedCustomResizeX = 0;
        private int selectedCustomResizeY = 0;
        private string filefilter = "";
        private bool filterenabled = false;
        private bool cropfillforBG = false;
        private Color backgroundcolor = Color.Black;
        private bool resize = false;
        private ResizeStyle selectedResizeStyle = ResizeStyle.None;
        private ResizeRatioType selectedResizeRatioType = ResizeRatioType.Keep;
        private double intervalabs=0;
        private int covers=1;
        private int intervalnum=0;
        private string intervaltype ="Minutes";
        private string folderpath="";
        private string comicpath="";
        private string cachetype = "jpg";
        private Size imageresizesize = new Size();

        public Size ImageResizeSize
        {
            get {
                switch (SelectedResizeStyle)
                    {
                        case ResizeStyle.None:
                            imageresizesize = new Size();
                            break;
                        case ResizeStyle.CurrentScreen:
                            imageresizesize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                            break;
                        case ResizeStyle.Common:
                            if (selectedCommonResizeSize != "")
                            {
                                string w = SelectedCommonResizeSize.Split(Convert.ToChar("x"))[0];
                                string h = SelectedCommonResizeSize.Split(Convert.ToChar("x"))[1];
                                int iw = Convert.ToInt16(w);
                                int ih = Convert.ToInt16(h);
                                imageresizesize = new Size(iw, ih);
                            }
                            else {
                                imageresizesize = new Size();
                            }

                            
                            break;
                        case ResizeStyle.Custom:
                            imageresizesize = new Size(SelectedCustomResizeX, SelectedCustomResizeY);
                            break;
                        default:
                            imageresizesize = new Size();
                            break;
                    }
                
                
                return imageresizesize; }
            set { imageresizesize = value; }
        }

		public string Cachetype {
			get { return cachetype; }
			set { cachetype = value; }
		}
        //private static readonly string KEY = "Software\\ComicCache";  
        #endregion 
    
	}
   
}
