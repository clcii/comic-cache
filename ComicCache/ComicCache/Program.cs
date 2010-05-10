using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace ComicCache
{
    class Program
    {
        [STAThread()]
        static void Main(string[] args)
        {
            try
            {

                foreach (Process process in Process.GetProcesses())
                    if (process.Id != Process.GetCurrentProcess().Id && process.ProcessName.Equals("YetAnotherPhotoScreenSaverCE"))
                        return;
                if (args.Length > 0)
                    if (args[0].ToLower().Contains("/p"))
                        return;
                    else if (args[0].ToLower().Contains("/c"))
                    {
                        Application.Run(new ConfigWindow());
                        return;
                    }

                Config config = new Config();
                Program program = new Program(config);
                program.End += (obj, e) =>
                {
                    Log.Instance.Write("Stopping screen saver");
                    program.Stop();
                    Application.Exit();
                };
                program.Run();
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
        public void Run() { }
        public void Stop() { }

        public Program(Config config)
        {
            this.config = config;
        }
        private Config config;
        public event EventHandler End;
    }
}
