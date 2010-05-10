using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace ComicCache
{
    public class Config
    {
        public Config() {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(KEY);
            if (reg == null)
                return;
            folderpath = (string)reg.GetValue("folderpath", folderpath);
            interval = (int)reg.GetValue("interval", interval);
            comicpath = (string)reg.GetValue("comicpath", comicpath);
            reg.Close();
        }
        public void Save() {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(KEY);
            reg.SetValue("folderpath", folderpath,RegistryValueKind.String);
            reg.SetValue("comicpath", comicpath, RegistryValueKind.String);
            reg.SetValue("interval", interval, RegistryValueKind.DWord);
            reg.Close();
        }
        public string FolderPath
        {
            get { return folderpath; }
            set { folderpath = value; }
        }
        public int Interval
        {
            get { return interval; }
            set { interval = value; }
        }
        public string ComicPath
        {
            get { return comicpath; }
            set { comicpath = value; }
        }
        private int interval;
        private string folderpath;
        private string comicpath;
        private static readonly string KEY = "Software\\ComicCache";  
    }
   
}
