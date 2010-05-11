using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ComicCache
{
    public partial class ConfigWindow : Form
    {
        #region Constructors
	   	public ConfigWindow()
        {
	   		InitializeComponent();
	   		LoadConfig();
        }       
        #endregion
        
        
        void ButtontestClick(object sender, EventArgs e)
        {
        	CopyConfig();
        	this.Text = "Abs Interval = " + Convert.ToString( config.Intervalabs);
        	//Program program = new Program(config);
        }
        void CopyConfig(){
        	config.Intervaltype = combointerval.Text;
        	config.Intervalnum = (int)updowninterval.Value;
        	config.ComicPath = (string)comicfolder.Text;
        	config.Covers = (int)updowncachesize.Value;
        	config.FolderPath = (string)cacheFolder.Text;
        	config.Cachetype = (string)cachetypecombo.Text;

        }
        void LoadConfig(){
        	combointerval.Text = config.Intervaltype;
        	updowninterval.Value = config.Intervalnum;
        	comicfolder.Text = config.ComicPath;
        	updowncachesize.Value = config.Covers;
        	cacheFolder.Text = config.FolderPath;
        	cachetypecombo.Text = config.Cachetype;
        }
        
        public Config config = new Config();
        
        
        void ButtonsaveClick(object sender, EventArgs e)
        {
        	CopyConfig();
        	config.Save();
        }
    }
}
