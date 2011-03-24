using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace ComicCache
{
    class Log
    {
		#region Methods
	        public void Write(String message)
        {
            Write(message, null);
        }

        	public void Write(String message, Exception ex)
        {
            if (enabled)
            {
                lock (this)
                {
                    StreamWriter writer = null;
                    try
                    {
                        ConfigWindow configwindow=null;
                        try
                        {
                           configwindow = (ConfigWindow)Application.OpenForms["configwindow"];
                        }
                        catch (Exception)
                        {
                        }

                        if (configwindow != null)
                        {
                            configwindow.SetStatus(message);
                        }

                        writer = File.AppendText(logFilePath);
                        writer.Write(DateTime.Now.ToString());
                        writer.Write(" ");
                        if (System.Diagnostics.Debugger.IsAttached) { System.Diagnostics.Debug.Print(message); }
                        writer.WriteLine(message);

                        if (ex != null)
                        {
                            writer.WriteLine(ex.ToString());
                        }
                        writer.Flush();
                    }
                    catch
                    {
                        // ignore
                    }
                    finally
                    {
                        if (writer != null)
                        {
                            writer.Dispose();
                        }
                    }
                }

            }
        }	
        	
		#endregion
		#region Properties
        private static Log instance = new Log();
        private bool enabled = false;
        private string logFilePath = Path.Combine(
                                Path.Combine(
                                System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "ComicCache\\"),
                               "cc.log");	
         public bool IsEnabled
        {
            get { return enabled; }
            set { enabled = value; }
        }       
         public string LogFilePath
        {
            get { return logFilePath; }
        }
		#endregion
		#region Constructors
    	public Log()
        {
            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));
        }		
        public static Log Instance
        {
            get { return instance; }
        }   	
		#endregion
    }
}
