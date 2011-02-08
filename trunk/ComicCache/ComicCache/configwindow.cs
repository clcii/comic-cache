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
        private ContextMenuStrip clickMenu;
        #region LocalProperties
        public Config config; //= Config.Load();

        #endregion
        #region Constructors
        public ConfigWindow(Config config)
        {
            InitializeComponent();
            this.config = config;
            LoadConfig();
        }
        #endregion

        #region Methods
        void ButtontestClick(object sender, EventArgs e)
        {

            CopyConfig();
            //this.Text = "Abs Interval = " + Convert.ToString( config.Intervalabs);
            Boolean isValid = config.IsValid();
            errorlabel.Text = config.ErrorMessage;
            errorlabel.Visible = !isValid;

            if (isValid)
            {
                Program program = new Program(config);
                program.Run();
                if (notifyicon != null)
                {
                    notifyicon.ContextMenuStrip.Visible = false;
                }
            }
            else 
            { 
                System.Media.SystemSounds.Exclamation.Play();    
            }
        }
        void refresh() {
            CopyConfig();
            Boolean isValid = config.IsValid();
            errorlabel.Text = config.ErrorMessage;
            errorlabel.Visible = !isValid;
            if (config.IsValid())
            {
                Program program = new Program(config);
                program.Run();
            }
        }
        void ButtonsaveClick(object sender, EventArgs e)
        {
            CopyConfig();
            config.Save();
            if (config.IsValid())
            {
                this.Hide();
                ShowNotify();
            }
        }
        void ComicbasebuttonClick(object sender, EventArgs e)
        {
            clcii.dialogue.multifolder basefolder = new clcii.dialogue.multifolder(comicfolder.Text);
            basefolder.ShowDialog();
            if (basefolder.Result() == DialogResult.OK)
            {
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
        void ConfigWindowFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
                ShowNotify();
            }
        }
        private void commonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.commonComboBox.Enabled = commonRadioButton.Checked; ;
        }
        private void customRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            customXnumeric.Enabled = customRadioButton.Checked;
            customYnumberic.Enabled = customRadioButton.Checked;
        }
        private void limitfilescheckbox_CheckedChanged(object sender, EventArgs e)
        {
            filelimitertextbox.Enabled = limitfilescheckbox.Checked;
        }
        private void buttoncancel_Click(object sender, EventArgs e)
        {
            LoadConfig();
            if (config.IsValid())
            {
                this.Hide();
                ShowNotify();
            }
        }
        private void validate() { 
        
        
        }
        private void notifyicon_Click(object Sender, MouseEventArgs e)
        {

            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    restore();
                }
            }
        }
        void restore()
        {
            try
            {
                this.Visible = true;
                this.Show();
                this.BringToFront();
                this.Focus();
                notifyicon.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Instance.Write(ex.Message);
            }
            finally
            {
            }

        }
        void CopyConfig()
        {
            config.Intervaltype = combointerval.Text;
            config.Intervalnum = (int)updowninterval.Value;
            config.ComicPath = (string)comicfolder.Text;
            config.Covers = (int)updowncachesize.Value;
            config.FolderPath = (string)cacheFolder.Text;
            config.Cachetype = (string)cachetypecombo.Text;
            config.Resize = (bool)resizeCheckBox.Checked;
            config.SelectedResizeStyle = CurrentResizeStyle();
            config.SelectedCommonResizeSize = commonComboBox.Text;
            config.SelectedCustomResizeX = (int)customXnumeric.Value;
            config.SelectedCustomResizeY = (int)customYnumberic.Value;
            config.Filefilter = (string)filelimitertextbox.Text;
            config.Filterenabled = (bool)limitfilescheckbox.Checked;
            if (stretchradiobutton.Checked)
                { config.SelectedResizeRatioType = ResizeRatioType.Stretch; } 
            else if (cropRadioButton.Checked) 
                { config.SelectedResizeRatioType = ResizeRatioType.Crop; } 
            else 
                { config.SelectedResizeRatioType = ResizeRatioType.Keep; }

        }
        void LoadConfig()
        {
            combointerval.Text = config.Intervaltype;
            updowninterval.Value = config.Intervalnum;
            comicfolder.Text = config.ComicPath;
            updowncachesize.Value = config.Covers;
            cacheFolder.Text = config.FolderPath;
            cachetypecombo.Text = config.Cachetype;
            resizeCheckBox.Checked = config.Resize;
            commonComboBox.Text = config.SelectedCommonResizeSize;
            customYnumberic.Value = config.SelectedCustomResizeY;
            customXnumeric.Value = config.SelectedCustomResizeX;
            limitfilescheckbox.Checked = config.Filterenabled;
            filelimitertextbox.Text = config.Filefilter;
            switch (config.SelectedResizeStyle)
            {
                case ResizeStyle.None:
                    break;
                case ResizeStyle.CurrentScreen:
                    screenSizeRadioButton.Checked = true;
                    break;
                case ResizeStyle.Common:
                    commonRadioButton.Checked = true;
                    break;
                case ResizeStyle.Custom:
                    customRadioButton.Checked = true;
                    break;
                default:
                    break;
            }
            switch (config.SelectedResizeRatioType)
            { 
                case ResizeRatioType.Crop:
                    cropRadioButton.Checked = true;
                    break;
                case ResizeRatioType.Stretch:
                    stretchradiobutton.Checked = true;
                    break;

                default:
                    keepratioradiobutton.Checked = true;
                    break;
            }

        }
        public void ShowNotify()
        {
            if (notifyicon == null)
            {
                notifyicon = new NotifyIcon();
                clickMenu = new System.Windows.Forms.ContextMenuStrip();
                notifyicon.ContextMenuStrip = clickMenu;
                PrepContextMenu();
            }
            notifyicon.Text = "Comic Cache";
            notifyicon.MouseClick += new MouseEventHandler(this.notifyicon_Click);
            //notifyicon.Click += new EventHandler(this.notifyicon_Click);
            notifyicon.Icon = new Icon("ComicCache.ico");
            notifyicon.Visible = true;

        }
        void PrepContextMenu()
        {
            ToolStripItem restorebutton = new ToolStripButton("Restore");
            restorebutton.Click += new EventHandler(restorebutton_Click);
            notifyicon.ContextMenuStrip.Items.Add(restorebutton);
            ToolStripItem refreshbutton = new ToolStripButton("Refresh");
            refreshbutton.Click += new EventHandler(ButtontestClick);
            notifyicon.ContextMenuStrip.Items.Add(refreshbutton);
            ToolStripButton exitbutton = new ToolStripButton("Exit");
            exitbutton.Click += new EventHandler(exitbutton_Click);
            notifyicon.ContextMenuStrip.Items.Add(exitbutton);
            
        }

        void restorebutton_Click(object sender, EventArgs e)
        {
            restore();
        }

        void exitbutton_Click(object sender, EventArgs e)
        {
            HideNotify();
            Application.Exit();
        }

        void clickMenu_Opening(object sender, CancelEventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void HideNotify()
        {
            notifyicon.Visible = false;
            notifyicon = null;
        }

        private void resizePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private ResizeStyle CurrentResizeStyle()
        {
            ResizeStyle result = ResizeStyle.None;
            if (resizeCheckBox.Checked)
            {
                if (screenSizeRadioButton.Checked)
                {
                    result = ResizeStyle.CurrentScreen;
                }
                else if (commonRadioButton.Checked)
                {
                    result = ResizeStyle.Common;
                }
                else if (customRadioButton.Checked)
                {
                    result = ResizeStyle.Custom;
                }
                //if (resizeCheckBox.Checked = false) { 
                //   result = ResizeStyle.None; }
            }
            return result;
        }
        private ResizeRatioType CurrentResizeRatioType() 
        {
            ResizeRatioType result = ResizeRatioType.Keep;
            if (stretchradiobutton.Checked) 
                {
                    result = ResizeRatioType.Keep;
                }
            else if (cropRadioButton.Checked) 
                {
                    result = ResizeRatioType.Crop;
                }
            return result;
        }
        #endregion
    }    
    public enum ResizeStyle { 
        None,
        CurrentScreen,
        Common,
        Custom
    }
    public enum ResizeRatioType { 
        Keep,
        Stretch,
        Crop
    }
}
