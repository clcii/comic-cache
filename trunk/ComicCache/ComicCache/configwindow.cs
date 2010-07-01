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
	private NotifyIcon notifyicon;
    	#region Constructors
	   	public ConfigWindow(Config config)
        {
	   		InitializeComponent();
	   		this.config = config;
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
        	config.Resize = (bool)resizeCheckBox.Checked;

        }
        void LoadConfig(){
        	combointerval.Text = config.Intervaltype;
        	updowninterval.Value = config.Intervalnum;
        	comicfolder.Text = config.ComicPath;
        	updowncachesize.Value = config.Covers;
        	cacheFolder.Text = config.FolderPath;
        	cachetypecombo.Text = config.Cachetype;
        	resizeCheckBox.Checked = config.Resize;
        	
        }
        
        public Config config; //= Config.Load();
        void ButtonsaveClick(object sender, EventArgs e)
        {
        	CopyConfig();
        	config.Save();
        	this.Hide();
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
        void CheckBox1CheckedChanged(object sender, EventArgs e)
        {
        	resizePanel.Enabled = resizeCheckBox.Checked;
        }
        
        void ConfigWindowLoad(object sender, EventArgs e)
        {
        	screensizetextbox.Text = Convert.ToString(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) + "x" + Convert.ToString(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
        	
        }
        
        public void ShowNotify(){
           if (notifyicon == null){
        		notifyicon = new NotifyIcon();
        	}
        	notifyicon.Text = "Comic Cache";
        	notifyicon.Click += new EventHandler(this.notifyicon_Click);
        	//notifyicon.DoubleClick += new EventHandler(this.notifyicon_Doubleclick);
        	notifyicon.Icon = new Icon("test.ico");
        	notifyicon.Visible = true;	
        }
        
        private void notifyicon_Click(object Sender, EventArgs e){
        	try{
        		Show();
        		BringToFront();
        		Focus();
			} catch (Exception ex) {
				Log.Instance.Write(ex.Message);
			} finally {
			}
        }

        
        void ConfigWindowFormClosing(object sender, FormClosingEventArgs e)
        {
        	if (e.CloseReason == CloseReason.UserClosing){
        		this.Hide();
        		e.Cancel = true;
        		}
        }
    }
}
