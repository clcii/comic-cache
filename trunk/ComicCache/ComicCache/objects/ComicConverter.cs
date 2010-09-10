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
    bool resize = false;
    string filter = "";
    Size resultSize = new Size();
    imagesource.Imager img;
    string comicfilepath = "";
    ImageFormat resultformat = ImageFormat.Jpeg;

        public string Filter
        {
            get { return filter; }
            set { filter = value; }
        }
        public bool Resize
        {
            get { return resize; }
            set { resize = value; }
        }
        public string Comicfilepath
        {
            get { return comicfilepath; }
            set { comicfilepath = value; }
        }
        public ImageFormat Resultformat
        {
            get { return resultformat; }
            set { resultformat = value; }
        }
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
        public ComicConverter(string ComicFilePath, ImageFormat format, bool resize, Size newsize) {
            this.Comicfilepath = ComicFilePath;
            this.Resultformat = format;
            this.ResultSize = newsize;
            this.Resize = resize;
        }
        public void Save(string destination, string filter) {

            if (img == null|this.filter != filter){
                this.filter = filter;
               img = new ComicCache.imagesource.Imager(Comicfilepath, filter);
            }
            Image coverimage = img.GetImage();
            if (this.Resize)
            {
                Image canvas = new Bitmap(this.ResultSize.Width, this.ResultSize.Height);
                Graphics g = Graphics.FromImage(canvas);
                g.Clear(Color.Black);
                Rectangle newimagerectangle = new Rectangle();
                decimal imageratio = (decimal)((decimal)coverimage.Width / (decimal)coverimage.Height);
                decimal resultratio = (decimal)((decimal)ResultSize.Width / (decimal)ResultSize.Height);
                
                if (imageratio>resultratio) {
                    newimagerectangle.X = 0;
                    newimagerectangle.Width = ResultSize.Width;
                    //newimagerectangle.Height = Convert.ToInt16( (coverimage.Height * newimagerectangle.Width) / coverimage.Width);
                    //decimal ratio = (decimal)Convert.ToDecimal((decimal)coverimage.Height / (decimal)coverimage.Width);
                    newimagerectangle.Height = (int)Convert.ToInt16(ResultSize.Width * (imageratio));
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
                g.Dispose();
                coverimage = canvas;

            }

            coverimage.Save(destination);
        
        }

    }
}
