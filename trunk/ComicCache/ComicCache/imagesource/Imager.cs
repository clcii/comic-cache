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
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

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
		
		public Image GetImage(){
			Image result = null;
			if (files.Count == 0) {
				foreach(string subdir in root.Split(';')){
					foreach(string sext in cis.ComicExtensions()){
						files.AddRange(Directory.GetFiles(subdir, "*"+sext,SearchOption.AllDirectories));
				        		}
				        }
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
	}
}
