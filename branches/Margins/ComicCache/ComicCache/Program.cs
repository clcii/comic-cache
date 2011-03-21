﻿using System;
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
                if (config.IsValid() == false) {
                    Application.Run(new ConfigWindow(config));
                    return; 
                }
                if (args.Length > 0)
                    if (args[0].ToLower().Contains("/p"))
                        return;
                    else if (args[0].ToLower().Contains("/c"))
                    {
                        Application.Run(new ConfigWindow(config));
                        return;
                    }
                Program program = new Program(config);
                program.End += (obj, e) =>
                {
                   	Log.Instance.Write("Stopping Cacher");
                    program.Stop();
                    Application.Exit();
                };
                program.ShowTrayIcon();
                program.Run();
                Application.Run();
            }
            catch (Exception ex)
            {
                Log.Instance.Write("Unhandled exception on main thread", ex);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // just in case of abnormal termination
            }
        }
		#region Methods
            public void Run() { 
		    // start the thread
            MainThread = new Thread(ThreadProc);
            MainThread.IsBackground = true;
            MainThread.Start();
		}
            public void Stop() {
            configwindow.HideNotify();
		}
		    public void ThreadStop() {
			MainThread.Abort();
		}
            public void ThreadProc(){
                Log.Instance.Write("Refreshing");
                Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
                Config myconfig = config;
                while (cancel.Equals(false)&&myconfig.IsValid()) {
            	    List<string> cacheitems = new List<string>();
            	    cacheitems.AddRange(Directory.GetFiles(config.FolderPath));
            	    foreach(string file in cacheitems)
                    {
            		    try 
                        {
            			    File.Delete(file);
            		    } catch (Exception) {
            		}
            	}
				int inum = 0;
				string newfilename = "";
                ComicCache.objects.ComicConverter cc = new objects.ComicConverter(config);
            	while (Directory.GetFiles(config.FolderPath).Length < config.Covers) 
                {
            		newfilename = Path.Combine(config.FolderPath, "ComicPic" + Convert.ToString(inum) +"." + config.Cachetype);
            		while (File.Exists(newfilename)) {
            			inum++;
            			newfilename = Path.Combine(config.FolderPath, "ComicPic" + Convert.ToString(inum) +"." + config.Cachetype);
            		}
					try {
                            
					        cc.Save(newfilename, config.Filterenabled ? config.Filefilter : "");
						} catch (Exception ex) {
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
                        Log.Instance.Write("Waiting till " + System.DateTime.Now.AddMilliseconds((int)myconfig.Intervalabs) );
				        Thread.Sleep((int)myconfig.Intervalabs);
                    }
            }
            
        
        }
            private void ShowTrayIcon(){
			configwindow = new ConfigWindow(config);
			configwindow.ShowNotify();
        }
            public void RestartMainTreade(Config config) {
                ThreadStop();
                this.config = config;
                Run();
            }

    		private void Application_ApplicationExit(object sender, EventArgs e)
        {
            Log.Instance.Write("ApplicationExit");
        }
		#endregion
		#region Constructors
            public Program(Config config, bool testrun)
                {
                    this.config = config;
                    this.testrun = testrun;
                }
            public Program(Config config) {
                this.config = config;
            }
		#endregion
		#region Properties
	    private Config config;
		private Thread MainThread;
      	public event EventHandler End;
      	public bool cancel = false;
      	public ConfigWindow configwindow;
        private bool testrun = false;
		#endregion
    }
}