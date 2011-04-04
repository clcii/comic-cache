using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;


namespace ComicCache
{
    
    class cacher
    {
        cacher(Config config) 
        {
            this.config = config;
        }
        public static void run(Boolean testrun){
            ParameterizedThreadStart ps = new ParameterizedThreadStart(oCaching);
            Thread MainThread = new Thread(ps);
            MainThread.IsBackground = true;
            MainThread.Start(testrun);
        }
        static void oCaching(object testrun) 
        {
            Log.Instance.Write("Refreshing");

            //Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Config myconfig = config;
            while (cancel.Equals(false) && myconfig.IsValid())
            {
                List<string> cacheitems = new List<string>();
                cacheitems.AddRange(Directory.GetFiles(config.FolderPath));
                foreach (string file in cacheitems)
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (Exception)
                    {
                    }
                }
                int inum = 0;
                string newfilename = "";
                ComicCache.objects.ComicConverter cc = new objects.ComicConverter(config);

                while (Directory.GetFiles(config.FolderPath).Length < config.Covers)
                {
                    newfilename = Path.Combine(config.FolderPath, "ComicPic" + Convert.ToString(inum) + "." + config.Cachetype);
                    while (File.Exists(newfilename))
                    {
                        inum++;
                        newfilename = Path.Combine(config.FolderPath, "ComicPic" + Convert.ToString(inum) + "." + config.Cachetype);
                    }
                    try
                    {

                        cc.Save(newfilename, config.Filterenabled ? config.Filefilter : "");
                    }
                    catch (Exception ex)
                    {
                        Log.Instance.Write(ex.Message);
                    }
                }
                if (testrun)
                {
                    Log.Instance.Write("Exiting Test Run");
                    cancel = true;
                }
                else
                {
                    Log.Instance.Write("Waiting till " + System.DateTime.Now.AddMilliseconds((int)myconfig.Intervalabs));
                    Thread.Sleep((int)myconfig.Intervalabs);
                }
            }
        
        }
        private void Cancel() {
            try 
	        {	        
	            cancel = true;
                MainThread.Abort();	
	        }
	            catch (Exception ex)
	        {
		
		        Log.Instance.Write(ex.Message);
	        }

        }
        
        private Config config = null;
        private Thread MainThread = null;
        private bool cancel = false;
    }
}
