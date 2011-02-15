﻿using System;
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

            setuptooltips();

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
            config.CropfFllForBG = (bool)cropfillforGBcheckbox.Checked;
            if (stretchradiobutton.Checked)
                { config.SelectedResizeRatioType = ResizeRatioType.Stretch; } 
            else if (cropRadioButton.Checked) 
                { config.SelectedResizeRatioType = ResizeRatioType.Crop; } 
            else 
                { config.SelectedResizeRatioType = ResizeRatioType.Keep; }

            config.BackGroundColor = backgroundButton.BackColor;
            config.Transparency = (int) transparencyupdown.Value;

        }
        void LoadConfig()
        {
            try
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
                backgroundButton.BackColor = config.BackGroundColor;
                cropfillforGBcheckbox.Checked = config.CropfFllForBG;
                transparencyupdown.Value = (decimal)config.Transparency;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
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

        #region Procedures

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            colorpicker.AllowFullOpen = true;
            colorpicker.Color = config.BackGroundColor;
            colorpicker.ShowDialog();
            if (colorpicker.Color != null) {
                backgroundButton.BackColor = colorpicker.Color;
            }
            

        }

        private void homelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(homelink.Text);
        }

        private void setuptooltips() {
            ToolTip forButton = new ToolTip();
            forButton.SetToolTip(comicbasebutton, "Select base or bases for comic files.  You can type in seperating with ';'s.");
            forButton.SetToolTip(cachebrowsebutton, "Select where you want the covers to be exported to.  Only one folder allowed");
            forButton.SetToolTip(updowninterval, "Select number of intervals to wait between refreshes.");
            forButton.SetToolTip(updowncachesize, "Select number of cover images to export every refresh");
            forButton.SetToolTip(cachetypecombo, "Select type of images you wish to export.");
            forButton.SetToolTip(combointerval, "Select type of time intervals to wait between intervals");
            forButton.SetToolTip(limitfilescheckbox, "Check to limit the images to a certain keyword.  Seperate multiple keywords with ';'");
            forButton.SetToolTip(keepratioradiobutton, "Do not change page ratio.  All available space will be filled with Background color.  Be sure and choose a SIZE.");
            forButton.SetToolTip(stretchradiobutton, "Stretch image to fill Scale size. Be sure and choose a SIZE.");
            forButton.SetToolTip(cropRadioButton, "Crop image in the middle to fill Scale Size. Be sure and choose a SIZE.");
            forButton.SetToolTip(screenSizeRadioButton, "Size of current screen.");
            forButton.SetToolTip(commonComboBox, "Common image sizes");
            forButton.SetToolTip(customRadioButton, "Make your own scale size to fit gadgets, widgets, and doodads");
            forButton.SetToolTip(backgroundButton, "Click here to select a color to fill back ground for Keep Ratio size.  All others will not show the background color");
            forButton.SetToolTip(cropfillforGBcheckbox, "Will place a centered cropped transparent copy of the image on top of the background color");
            forButton.SetToolTip(buttonsave, "Save settings and minimize to tray");
            forButton.SetToolTip(buttoncancel, "Do not save settings.");
            forButton.SetToolTip(buttontest, "Run a set of images based off current settings.  The settings will not be saved.");
            forButton.SetToolTip(resizeCheckBox, "Resize image to resolution.  If not checked, images will be the same resolution as scanned which often varies greatley from source to source");
            forButton.SetToolTip(transparencyupdown, "Set how transparent the cropped image overlay is to the background color.");

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
