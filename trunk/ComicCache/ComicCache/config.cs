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
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(KEY);
            if (reg == null)
                return;
            folderpath = (string)reg.GetValue("folderpath", folderpath);
            intervalabs = (int)reg.GetValue("interval", intervalabs);
            comicpath = (string)reg.GetValue("comicpath", comicpath);
            reg.Close();
        }
    	#endregion
    	#region Methods
        public void Save() {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(KEY);
            reg.SetValue("folderpath", folderpath,RegistryValueKind.String);
            reg.SetValue("comicpath", comicpath, RegistryValueKind.String);
            reg.SetValue("interval", intervalabs, RegistryValueKind.DWord);
            reg.Close();
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
        private double intervalabs;
        private int covers;
        private int intervalnum;
        private string intervaltype;
        //private string interval;
        private string folderpath;
        private string comicpath;
        private static readonly string KEY = "Software\\ComicCache";  
        #endregion 
    }
   
}
