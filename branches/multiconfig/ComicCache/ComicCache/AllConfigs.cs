using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Drawing;
using System.ComponentModel;
using Microsoft.Win32;


namespace ComicCache
{
    
    class AllConfigs
    {
        List<Config> configs = new List<Config>();
        public static string settingsFolder
        {
            get
            {
                return Path.GetDirectoryName(Application.ExecutablePath);
            }

        }
        public static string settingsFile
        {
            get { return Path.Combine(settingsFolder, Application.ProductName + ".xml"); }

        }
        public List<Config> Configs
        {
            get { return configs; }
            set { configs = value; }
        }
        public string SettingsFile
        {
            get { return settingsFile; }
        }
        public static AllConfigs Load()
        {
            try
            {
                if (File.Exists(settingsFile))
                {
                    Stream stream = File.Open(settingsFile, FileMode.Open);
                    XmlSerializer xs = new XmlSerializer(typeof(Config));
                    AllConfigs cpycfg;
                    try
                    {
                        cpycfg = (AllConfigs)xs.Deserialize(stream);
                    }
                    catch (Exception ex)
                    {
                        Log.Instance.Write(ex.Message);
                        Log.Instance.Write("Loading default");
                        cpycfg = new AllConfigs();
                    }

                    stream.Close();
                    return cpycfg;
                }
                else
                {
                    return new AllConfigs();
                }
            }
            catch (Exception ex)
            {
                Log.Instance.Write(ex.Message);
                return null;
            }
            finally
            {

            }

        }
        public void Save()
        {
            try
            {
                if (Directory.Exists(settingsFolder) == false)
                {
                    Directory.CreateDirectory(settingsFolder);
                }
                XmlSerializer xs = new XmlSerializer(typeof(Config));
                TextWriter tw = new StreamWriter(settingsFile);
                xs.Serialize(tw, this);
                tw.Close();

            }
            catch (Exception ex)
            {
                Log.Instance.Write(ex.Message);
            }
            finally
            {

            }
        }
    }
   
}
