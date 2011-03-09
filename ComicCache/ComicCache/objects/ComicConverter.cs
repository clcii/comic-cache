using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
namespace ComicCache.objects{
    class ComicConverter{
        bool resize = false;
        string filter = "";
        Size resultSize = new Size();
        imagesource.Imager img;
        string comicfilepath = "";
        ResizeRatioType resizeratiotype = ResizeRatioType.Keep;
        ImageFormat resultformat = ImageFormat.Jpeg;
        Color backgroundcolor = Color.Black;
        bool cropfillforBG = false;
        int transparency = 0;
        bool greyscaleBG = false;
        Config config = new Config();
        public Color Backgroundcolor
    {
        get { return backgroundcolor; }
        set { backgroundcolor = value; }
    }
        public bool CropfillforBG
    {
        get { return cropfillforBG; }
        set { cropfillforBG = value; }
    }
        public int Transparency
    {
        get { return transparency; }
        set { transparency = value; }
    }
        public ResizeRatioType ResizeRationType
        {
            get { return resizeratiotype; }
            set { resizeratiotype = value;}
        }
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
        public ComicConverter(Config config) {
            this.config = config;
            this.Comicfilepath = config.ComicPath;
            this.Resultformat = config.ImageFormat;
            this.ResultSize = config.ImageResizeSize;
            this.Resize = config.Resize;
            this.ResizeRationType = config.SelectedResizeRatioType;
            this.backgroundcolor = config.BackGroundColor;
            this.cropfillforBG = config.CropFillForBG;
            this.transparency = config.Transparency;
            this.greyscaleBG = config.GreyScaleBG;
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
                g.Clear(this.backgroundcolor);
  
                Rectangle newimagerectangle = new Rectangle();
                decimal imageratio = (decimal)((decimal)coverimage.Width / (decimal)coverimage.Height);
                decimal resultratio = (decimal)((decimal)ResultSize.Width / (decimal)ResultSize.Height);
                
                if (cropfillforBG)
                {
                    if (imageratio > resultratio)
                    {
                        newimagerectangle.Y = 0;
                        newimagerectangle.Height = coverimage.Height;
                        newimagerectangle.Width = Convert.ToInt16((newimagerectangle.Height * ResultSize.Width) / ResultSize.Height);
                        newimagerectangle.X = Convert.ToInt16((coverimage.Width - newimagerectangle.Width) / 2);
                    }
                    else
                    {
                        newimagerectangle.X = 0;
                        newimagerectangle.Width = coverimage.Width;
                        newimagerectangle.Height = Convert.ToInt16((newimagerectangle.Width * ResultSize.Height) / ResultSize.Width);
                        newimagerectangle.Y = Convert.ToInt16((coverimage.Height - newimagerectangle.Height) / 2);

                    }

                    Bitmap newimage = new Bitmap(coverimage);
                    if (greyscaleBG) {
                        Graphics greyg = Graphics.FromImage(newimage);
                        ColorMatrix greyMatrix = new ColorMatrix();
                        float[][] greyarray =
                                new float[][] 
                                {
                                new float[] {.3f, .3f, .3f, 0, 0},
                                new float[] {.59f, .59f, .59f, 0, 0},
                                new float[] {.11f, .11f, .11f, 0, 0},
                                new float[] {0, 0, 0, 1, 0},
                                new float[] {0, 0, 0, 0, 1}
                            };
                        greyMatrix = new ColorMatrix(greyarray);
                        ImageAttributes greyAttributes = new ImageAttributes();

                        greyAttributes.SetColorMatrix(greyMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                        
                        
                        greyg.DrawImage(newimage, new Rectangle(new Point(0, 0),newimage.Size),0,0,newimage.Width,newimage.Height,GraphicsUnit.Pixel, greyAttributes);
                        greyg.Dispose();
                        }

                    
                    
                    Image BGimage  = (Image)newimage.Clone(newimagerectangle, newimage.PixelFormat);
                    float trans = ((float)(100-transparency)/(float)100);


                    ColorMatrix transparencyMatrix = new ColorMatrix();
                    


                    float[][] ptsArray ={ 
                        new float[] {1, 0, 0, 0, 0},
                        new float[] {0, 1, 0, 0, 0},
                        new float[] {0, 0, 1, 0, 0},
                        new float[] {0, 0, 0, trans, 0}, 
                        new float[] {0, 0, 0, 0, 1}}; 


                    ImageAttributes attributes = new ImageAttributes();
                    //attributes.SetColorMatrix(colorMatrix);
                    transparencyMatrix = new ColorMatrix(ptsArray);
                    

                    attributes.SetColorMatrix(transparencyMatrix,ColorMatrixFlag.Default,ColorAdjustType.Bitmap);

                    

                    g.DrawImage(BGimage, new Rectangle(new Point(0, 0), canvas.Size),0,0,BGimage.Width,BGimage.Height,GraphicsUnit.Pixel,attributes);
                    //g.DrawImage(BGimage, new Rectangle(new Point(config.leftmargin, config.topmargin), resultsize), 0, 0, BGimage.Width, BGimage.Height, GraphicsUnit.Pixel, attributes);

                    newimagerectangle = new Rectangle();
                } 

                switch (this.ResizeRationType)
                {
                    case ResizeRatioType.Crop:
                        if (imageratio > resultratio)
                        {
                            newimagerectangle.Y = 0 ;
                            newimagerectangle.Height = coverimage.Height ;
                            newimagerectangle.Width = Convert.ToInt16((newimagerectangle.Height * ResultSize.Width) / ResultSize.Height);
                            newimagerectangle.X = Convert.ToInt16((coverimage.Width - newimagerectangle.Width) / 2);
                        }
                        else
                        {
                            newimagerectangle.X = 0;
                            newimagerectangle.Width = coverimage.Width;
                            newimagerectangle.Height = Convert.ToInt16((newimagerectangle.Width * ResultSize.Height) / ResultSize.Width) - config.bottommargin;
                            newimagerectangle.Y = Convert.ToInt16((coverimage.Height - newimagerectangle.Height) / 2);

                        }
                              
                        Bitmap newimage = new Bitmap(coverimage);
                        coverimage = (Image) newimage.Clone(newimagerectangle, newimage.PixelFormat);

                            g.DrawImage(coverimage,new Rectangle(new Point(0,0),canvas.Size));
                            //g.DrawImageUnscaledAndClipped(coverimage, new Rectangle(new Point(0,0), canvas.Size));
                            g.Dispose();
                            coverimage = canvas;
                        break;
                    case ResizeRatioType.Stretch:
                        g.DrawImage(coverimage, new Rectangle(0,0,ResultSize.Width,ResultSize.Height));
                        g.Dispose();
                        coverimage = canvas;
                        break;
                    default:
                        if (imageratio > resultratio)
                            {
                                Rectangle adjustedimage = new Rectangle(config.rightmargin,config.topmargin, ResultSize.Width - config.rightmargin - config.leftmargin,coverimage.Height - config.topmargin - config.bottommargin);
                                newimagerectangle.X = adjustedimage.X;
                                newimagerectangle.Width = adjustedimage.Width;
                                newimagerectangle.Height = Convert.ToInt16((coverimage.Height * newimagerectangle.Width) / coverimage.Width);
                                newimagerectangle.Y = Convert.ToInt16((ResultSize.Height - newimagerectangle.Height) / 2);
                            }
                         else
                            {
                                Rectangle adjustedimage = new Rectangle(config.rightmargin, config.topmargin, coverimage.Width - config.rightmargin - config.leftmargin, ResultSize.Height - config.topmargin - config.bottommargin);
                                newimagerectangle.Y = adjustedimage.Y;
                                newimagerectangle.Height = adjustedimage.Height;
                                newimagerectangle.Width = Convert.ToInt16((coverimage.Width * newimagerectangle.Height) / coverimage.Height);
                                newimagerectangle.X = Convert.ToInt16((ResultSize.Width - newimagerectangle.Width) / 2);
                            }
                            g.DrawImage(coverimage, newimagerectangle);
                            g.Dispose();
                            coverimage = canvas;
                        break;
                }
            }

            coverimage.Save(destination);
        
        }
    }
}
