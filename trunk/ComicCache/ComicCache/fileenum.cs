using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ComicCache
{
    class fileenum
    {
        public fileenum(string folderstring, List<string> extentions) 
        {
            Extentions = extentions;
            List<string> allFolders = new List<string>();
            allFolders.AddRange(folderstring.Split(';'));
            foreach (string fld in allFolders)
	            {
		            if (fld.StartsWith("!"))
	                {
		                ExcludeFolders.Add(fld.TrimStart('!'));
            	    }
                    else
                    {
                        BaseFolders.Add(fld);
                    }
	            }
             Fill();
        }
        
        public void Fill()
        {
            foreach (string fld in BaseFolders)
	        {
                GetFolder(fld);
	        }
        }
        private void GetFiles(string fld) 
        {
            foreach (string ext in Extentions)
            {
                allfiles.AddRange(Directory.GetFiles(fld,"*" + ext, SearchOption.TopDirectoryOnly));    
            }
            
        }
        private void GetFolder(string fld) 
        {
            GetFiles(fld);
            foreach (string newfld in Directory.GetDirectories(fld))
            {
                if (!ExcludeFolders.Contains(newfld))
                {
                    GetFolder(newfld);
                }
            }
        }
        public List<string> AllFiles
        {
            get { return allfiles; }
            set { allfiles = value; }
        }
        public string GetNextFile() 
        {
            string result = "";
            if (allfiles.Count ==0)
            {
                Fill();
            }
            Random rnd = new Random();
            int filenumber = rnd.Next(0, allfiles.Count - 1);
            result = allfiles[filenumber];
            allfiles.RemoveAt(filenumber);
            return result;


        }
        string filter = "";
        List<string> allfiles = new List<string>();
        List<string> BaseFolders = new List<string>();
        List<string> ExcludeFolders = new List<string>();
        List<string> Extentions = new List<string>();
    }


}
