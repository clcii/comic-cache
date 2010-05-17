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
        	//this.Text = "Abs Interval = " + Convert.ToString( config.Intervalabs);
        	Program program = new Program(config);
        	program.Run();
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
        	this.Close();
        }
        
        void ComicbasebuttonClick(object sender, EventArgs e)
        {
        	clcii.dialogue.multifolder basefolder = new clcii.dialogue.multifolder(comicfolder.Text);
        	basefolder.ShowDialog();
        	if (basefolder.Result() == DialogResult.OK) {
        		comicfolder.Text = basefolder.FileImageSourcePath();
        	}
        }
        
        void CachebrowsebuttonClick(object sender, EventArgs e)
        {
        	FolderBrowserDialog fbd = new FolderBrowserDialog();
        	fbd.SelectedPath = cacheFolder.Text;
        	if (fbd.ShowDialog() == DialogResult.OK)
        	{
        		cacheFolder.Text = fbd.SelectedPath;
        	}
        	
        }
    }
}
