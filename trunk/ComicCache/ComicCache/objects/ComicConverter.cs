using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
namespace ComicCache.objects
{
    class ComicConverter
    {
        string comicfilepath = "";

        public string Comicfilepath
        {
            get { return comicfilepath; }
            set { comicfilepath = value; }
        }
        imagesource.Imager img;
        ImageFormat resultformat = ImageFormat.Jpeg;
        public ImageFormat Resultformat
        {
            get { return resultformat; }
            set { resultformat = value; }
        }
        Size resultSize = new Size();
        public Size ResultSize
        {
            get { return resultSize; }
            set { resultSize = value; }
        }
        public ComicConverter() { }
        public ComicConverter(string ComicFilePath, ImageFormat format) {
            this.Comicfilepath = ComicFilePath;
            this.Resultformat = format;

        }
        public ComicConverter(string ComicFilePath, ImageFormat format, Size newsize) {
            this.Comicfilepath = ComicFilePath;
            this.Resultformat = format;
            this.ResultSize = newsize;            
        }
        public void Save(string destination) {
            if (img == null){ 
               img = new ComicCache.imagesource.Imager(Comicfilepath);
            }
            Image coverimage = img.GetImage();
            if (this.ResultSize != new Size())
            {
                Image canvas = new Bitmap(this.ResultSize.Width, this.ResultSize.Height);
                Graphics g = Graphics.FromImage(canvas);
                g.Clear(Color.Black);
                Rectangle newimagerectangle = new Rectangle();
                
                if (coverimage.Width >= coverimage.Height) {
                    newimagerectangle.X = 0;
                    newimagerectangle.Width = ResultSize.Width;
                    newimagerectangle.Height = Convert.ToInt16( (coverimage.Height * newimagerectangle.Width) / coverimage.Width);
                    newimagerectangle.Y = Convert.ToInt16( (ResultSize.Height - newimagerectangle.Height) / 2);
                }
                else
                {
                    newimagerectangle.Y = 0;
                    newimagerectangle.Height = ResultSize.Height;
                    newimagerectangle.Width = Convert.ToInt16((coverimage.Width * newimagerectangle.Height) / coverimage.Height);
                    newimagerectangle.X = Convert.ToInt16((ResultSize.Width - newimagerectangle.Width) / 2);
                }
                g.DrawImage(coverimage, newimagerectangle);
            }

            coverimage.Save(destination);
        
        }

    }
}
