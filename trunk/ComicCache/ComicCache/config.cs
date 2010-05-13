using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace ComicCache
{
    public class Config
    {
		#region Constructors
    	public Config() {
			Load();
        }
    	#endregion
    	#region Methods
    	public void Load(){
    		try {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(KEY);
            if (reg == null)
                return;
            folderpath = (string)reg.GetValue("folderpath", folderpath);
            covers = (int)reg.GetValue("cachesize", covers);
            intervalnum = (int)reg.GetValue("intervalnum", intervalnum);
            intervaltype = (string)reg.GetValue("intervaltype", intervaltype);
            comicpath = (string)reg.GetValue("comicpath", comicpath);
            cachetype = (string)reg.GetValue("cachetype",cachetype);
            reg.Close();
    		} catch (Exception ex) {
    			Log.Instance.Write(ex.Message);
    		} finally {
    			
    		}
   	
    	}
        public void Save() {
    		try {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(KEY);
            reg.SetValue("folderpath", folderpath,RegistryValueKind.String);
            reg.SetValue("cachesize", covers, RegistryValueKind.DWord);
            reg.SetValue("comicpath", comicpath, RegistryValueKind.String);
            reg.SetValue("intervalnum", intervalnum, RegistryValueKind.DWord);
            reg.SetValue("intervaltype", intervaltype, RegistryValueKind.String);
            reg.SetValue("cachetype",cachetype, RegistryValueKind.String);
            
            reg.Close();
   			
    		} catch (Exception ex) {
    			Log.Instance.Write(ex.Message);
    		} finally {
    			
    		}
        }
        public string FolderPath
        {
            get { return folderpath; }
            set { folderpath = value; }
        }
		#endregion
        #region Properties

        
        
        public double Intervalabs
        {
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
		public int Covers {
			get { return covers; }
			set { covers = value; }
		}        
		public int Intervalnum {
			get { return intervalnum; }
			set { intervalnum = value; }
		}
		public string Intervaltype {
			get { return intervaltype; }
			set { intervaltype = value; }
		}
        private double intervalabs=0;
        private int covers=1;
        private int intervalnum=0;
        private string intervaltype ="Minutes";
        //private string interval;
        private string folderpath="";
        private string comicpath="";
        private string cachetype="";
        
		public string Cachetype {
			get { return cachetype; }
			set { cachetype = value; }
		}
        private static readonly string KEY = "Software\\ComicCache";  
        #endregion 
    }
   
}
