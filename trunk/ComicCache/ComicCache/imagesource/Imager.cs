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
using System.Drawing.Drawing2D;

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
					
					if (Directory.Exists(subdir)){
					foreach(string sext in cis.ComicExtensions()){
						
						files.AddRange(Directory.GetFiles(subdir, "*"+sext,SearchOption.AllDirectories));
				        		}
				        }
					}
				}
			if (files.Count !=0) {
				Random rnd = new Random();
				int filenumber = rnd.Next(0,files.Count-1);
				result = cis.GetImage(files[filenumber]);
				files.RemoveAt(filenumber);
			}
			if (resize||result != null){
				Size testSize = new Size(800,600);
				result = resizeImage(result, testSize);
				//result = resizeImage(result, newsize);
			}
			return result;
			
		}
		
	private List<string> files = new List<string>();
	private string root = "";
	private clcii.comic.ComicImageSource cis;
	private bool resize = false;
	private Size newsize;
	
	public Size Newsize {
		get { return newsize; }
		set { newsize = value; }
	}
	
	public bool Resize {
		get { return resize; }
		set { resize = value; }
	}
	private static Image resizeImage(Image imgToResize, Size size)
	{
   		
		int sourceWidth = imgToResize.Width;
   		int sourceHeight = imgToResize.Height;

   		float nPercent = 0;
   		float nPercentW = 0;
   		float nPercentH = 0;

   		nPercentW = ((float)size.Width / (float)sourceWidth);
   		nPercentH = ((float)size.Height / (float)sourceHeight);

   		if (nPercentH < nPercentW)
      		nPercent = nPercentH;
   		else
      		nPercent = nPercentW;

   		int destWidth = (int)(sourceWidth * nPercent);
   		int destHeight = (int)(sourceHeight * nPercent);

   		Bitmap b = new Bitmap(destWidth, destHeight);
   		Graphics g = Graphics.FromImage((Image)b);
   		g.InterpolationMode = InterpolationMode.HighQualityBicubic;

   		g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
   		g.Dispose();

   	return (Image)b;
	}
	
	
	}
}
