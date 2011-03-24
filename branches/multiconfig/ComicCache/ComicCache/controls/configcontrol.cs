﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComicCache.controls
{
    public partial class configcontrol : UserControl
    {
        public configcontrol(Config config)
        {
            InitializeComponent();
            setuptooltips();
            this.config = config;
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
        private void CopyConfig()
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
            config.CropFillForBG = (bool)cropfillforGBcheckbox.Checked;
            config.GreyScaleBG = (bool)greyscalecheckbox.Checked;
            config.Margins = (string)margintextbox.Text;
            if (stretchradiobutton.Checked)
            { config.SelectedResizeRatioType = ResizeRatioType.Stretch; }
            else if (cropRadioButton.Checked)
            { config.SelectedResizeRatioType = ResizeRatioType.Crop; }
            else
            { config.SelectedResizeRatioType = ResizeRatioType.Keep; }

            config.BackGroundColor = backgroundButton.BackColor;
            config.Transparency = (int)transparencyupdown.Value;
            switch (comicstylecombobox.Text)
            {

                case "Covers only":
                    config.Comicstyle = Comicstyle.CoversOnly;
                    break;
                case "Any Page":
                    config.Comicstyle = Comicstyle.AnyPage;
                    break;
                case "Entire Comic":
                    config.Comicstyle = Comicstyle.Entire;
                    break;
                default:
                    config.Comicstyle = Comicstyle.CoversOnly;
                    break;
            }

        }
        private void LoadConfig()
        {
            try
            {
                switch (config.Comicstyle)
                {

                    case Comicstyle.CoversOnly:
                        comicstylecombobox.Text = "Covers Only";
                        break;
                    case Comicstyle.AnyPage:
                        comicstylecombobox.Text = "Any Page";
                        break;
                    case Comicstyle.Entire:
                        comicstylecombobox.Text = "Entire Comic";
                        break;
                    default:
                        comicstylecombobox.Text = "Covers Only";
                        break;
                }
                backgroundButton.BackColor = resizeCheckBox.Checked ? tempoldcolor : Color.Gray;
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
                cropfillforGBcheckbox.Checked = config.CropFillForBG;
                transparencyupdown.Value = (decimal)config.Transparency;
                greyscalecheckbox.Checked = config.GreyScaleBG;
                margintextbox.Text = config.Margins;
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
        private void setuptooltips()
        {
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
            forButton.SetToolTip(buttontest, "Run a set of images based off current settings.  The settings will not be saved.");
            forButton.SetToolTip(resizeCheckBox, "Resize image to resolution.  If not checked, images will be the same resolution as scanned which often varies greatley from source to source");
            forButton.SetToolTip(transparencyupdown, "Set how transparent the cropped image overlay is to the background color. Larger numbers are more transparent.");
            forButton.SetToolTip(greyscalecheckbox, "Remove color from original image before setting as overlay");

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
        private Config config;
        private Color tempoldcolor;
        private void configcontrol_Load(object sender, EventArgs e)
        {
            screensizetextbox.Text = Convert.ToString(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) + "x" + Convert.ToString(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height);
        }
        void ButtontestClick(object sender, EventArgs e)
        {
            CopyConfig();
            Boolean isValid = config.IsValid();
            Log.Instance.Write(config.ErrorMessage);
            //errorlabel.Text = config.ErrorMessage;
            //errorlabel.Visible = !isValid;
            if (isValid)
            {
                Program program = new Program(config, true);
                program.Run();
                //if (notifyicon != null)
                //{
                    //notifyicon.ContextMenuStrip.Visible = false;
                //}
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play();
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
            if (!resizeCheckBox.Checked)
                tempoldcolor = backgroundButton.BackColor;
            backgroundButton.BackColor = resizeCheckBox.Checked ? tempoldcolor : Color.Gray;
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
        private void backgroundButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorpicker = new ColorDialog();
            colorpicker.AllowFullOpen = true;
            colorpicker.Color = config.BackGroundColor;
            if (colorpicker.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                backgroundButton.BackColor = colorpicker.Color;
            }
        }
        private void cropfillforGBcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            backgroundimagepanel.Enabled = cropfillforGBcheckbox.Checked;

        }
        private void keepratioradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            backgroundpanel.Enabled = keepratioradiobutton.Checked;
        }
        private void margintextbox_Click(object sender, EventArgs e)
        {
            dialogue.margin margindialogue = new dialogue.margin(margintextbox.Text, 360, 360);
            margindialogue.ShowDialog();
            if (margindialogue.Dialogresult == System.Windows.Forms.DialogResult.OK)
            {
                margintextbox.Text = margindialogue.ResultString;
            }



        }
    }
}