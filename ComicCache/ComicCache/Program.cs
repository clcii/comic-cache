using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;


namespace ComicCache{
    class Program{
        [STAThread()]
        static void Main(string[] args)
        {
            try
            {
				Log.Instance.IsEnabled = true;
                Application.EnableVisualStyles();
                
				foreach (Process process in Process.GetProcesses())
                    if (process.Id != Process.GetCurrentProcess().Id && process.ProcessName.Equals("ComicCache"))
                        return;
				Config config = Config.Load();
                if (args.Length > 0)
                    if (args[0].ToLower().Contains("/p"))
                        return;
                    else if (args[0].ToLower().Contains("/c"))
                    {
                        Application.Run(new ConfigWindow(config));
                        return;
                    }


                    //Log.Instance.Write(config.Cachetype);
                    
                	Program program = new Program(config);
                	program.End += (obj, e) =>
                	{
                    	Log.Instance.Write("Stopping Cacher");
                    	program.Stop();
                    	Application.Exit();
                	};
                program.ShowTrayIcon();
                //program.Run();
                Application.Run();
            }
            catch (Exception ex)
            {
                Log.Instance.Write("Unhandled exception on main thread", ex);
            }
            finally
            {
                // just in case of abnormal termination
            }
        }
		#region Methods
        public void Run() { 
		    // start the thread
            thread = new Thread(ThreadProc);
            thread.IsBackground = true;
            thread.Start();
		}
        public void Stop() {
		}
		public void ThreadStop() {
			thread.Abort();
		}
        public void ThreadProc(){
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Config myconfig = config;
            imagesource.Imager img = new ComicCache.imagesource.Imager(config.ComicPath);
            while (cancel.Equals(false)) {
            	List<string> cacheitems = new List<string>();
            	cacheitems.AddRange(Directory.GetFiles(config.FolderPath));
            	foreach(string file in cacheitems){
            		try {
            			File.Delete(file);
            		} catch (Exception) {
            		}
            	}
				int inum = 0;
				string newfilename = "";
				Image newImage = null;
            	while (Directory.GetFiles(config.FolderPath).Length < config.Covers) {
					newImage = null;
					while (newImage==null) {
						try {
							newImage = img.GetImage();
						} catch (Exception) {
							
						}
					}
            		
            		
            		
            		newfilename = Path.Combine(config.FolderPath, "ComicPic" + Convert.ToString(inum) +"." + config.Cachetype);
            		while (File.Exists(newfilename)) {
            			inum++;
            			newfilename = Path.Combine(config.FolderPath, "ComicPic" + Convert.ToString(inum) +"." + config.Cachetype);
            		} 
            		
            		newImage.Save(newfilename, config.ImageFormat);
            	}
				Thread.Sleep((int)myconfig.Intervalabs);
            }
            
        
        }
        private void ShowTrayIcon(){
			configwindow = new ConfigWindow(config);
			configwindow.ShowNotify();
        }

		static void Application_ApplicationExit(object sender, EventArgs e)
        {
            
        }
		#endregion
		#region Constructors
        public Program(Config config)
        {
            this.config = config;
        }		
		#endregion
		#region Properties
	    private Config config;
		private Thread thread;
      	public event EventHandler End;
      	public bool cancel = false;
      	public ConfigWindow configwindow;
		#endregion
    }
}
