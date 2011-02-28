/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 5/13/2010
 * Time: 11:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace ComicCache.imagesource
{
	/// <summary>
	/// Description of Imager.
	/// </summary>
	public class Imager
	{
		public Imager(string root)
		{
			this.root = root;
			cis = new clcii.comic.ComicImageSource(Comicstyle.CoversOnly);
		}
        public Imager(string root, string filter)
        {
            this.root = root;
            this.Filter = filter;
            cis = new clcii.comic.ComicImageSource(Comicstyle.CoversOnly);
        }
		
		public Image GetImage(){
			Image result = null;
			if (files.Count == 0) 
            {
                foreach(string maindir in root.Split(';')){
					if (Directory.Exists(maindir))
                    {
                        foreach (string sext in cis.ComicExtensions())
                        {
                            string searchparm = "*" + sext;
                            try
                            {
                                files.AddRange(Directory.GetFiles(maindir, searchparm,SearchOption.TopDirectoryOnly));
                            }
                            catch (Exception)
                            {
                            }
                            foreach (string subdir in Directory.GetDirectories(maindir))
                            {
                                try
                                {
                                    files.AddRange(Directory.GetFiles(subdir, searchparm, SearchOption.AllDirectories));
                                }
                                catch
                                {
                                }
                            }
                        }
				    }
			    }
		    }
            
            if (filter != "*")
            {
                List<string> resultlist = new List<string>();
                foreach (string filteritem in Filter.Split(';'))
	                {
		                resultlist.AddRange (
                            files.FindAll(
                                delegate(string file)
                                {
                                    return file.ToUpper().Contains(filteritem.ToUpper());
                                }
                              )
                          );
                            
                    ;
	                }
                files = resultlist;
            }
			if (files.Count !=0) {
				Random rnd = new Random();
				int filenumber = rnd.Next(0,files.Count-1);
				result = cis.GetImage(files[filenumber]);
				files.RemoveAt(filenumber);
			}

			return result;
			
		}

	
	private List<string> files = new List<string>();
	private string root = "";
	private clcii.comic.ComicImageSource cis;
    private string filter = "";

    public string Filter
    {
        get { return filter; }
        set {
            if (value != this.filter) { files.Clear(); }
            
            
            filter = value; }
    }
    private bool ContainsFilter(string s)
    {
        return s.Contains(Filter);
    }
	}
}
