namespace ComicCache.controls
{
    partial class configcontrol
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resizePanel = new System.Windows.Forms.Panel();
            this.backgroundlabel = new System.Windows.Forms.Label();
            this.backgroundpanel = new System.Windows.Forms.Panel();
            this.marginlabel = new System.Windows.Forms.Label();
            this.margintextbox = new System.Windows.Forms.TextBox();
            this.cropfillforGBcheckbox = new System.Windows.Forms.CheckBox();
            this.backgroundimagepanel = new System.Windows.Forms.Panel();
            this.greyscalecheckbox = new System.Windows.Forms.CheckBox();
            this.transparencyupdown = new System.Windows.Forms.NumericUpDown();
            this.transparencylabel = new System.Windows.Forms.Label();
            this.backgroundcolorlabel = new System.Windows.Forms.Label();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.grpResizeType = new System.Windows.Forms.GroupBox();
            this.cropRadioButton = new System.Windows.Forms.RadioButton();
            this.stretchradiobutton = new System.Windows.Forms.RadioButton();
            this.keepratioradiobutton = new System.Windows.Forms.RadioButton();
            this.screensizetextbox = new System.Windows.Forms.TextBox();
            this.commonComboBox = new System.Windows.Forms.ComboBox();
            this.screenSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.commonRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.customXnumeric = new System.Windows.Forms.NumericUpDown();
            this.customYnumberic = new System.Windows.Forms.NumericUpDown();
            this.cachetypecombo = new System.Windows.Forms.ComboBox();
            this.cachesizelabel = new System.Windows.Forms.Label();
            this.updowncachesize = new System.Windows.Forms.NumericUpDown();
            this.cachefolderlabel = new System.Windows.Forms.Label();
            this.cacheFolder = new System.Windows.Forms.TextBox();
            this.cachebrowsebutton = new System.Windows.Forms.Button();
            this.updowninterval = new System.Windows.Forms.NumericUpDown();
            this.combointerval = new System.Windows.Forms.ComboBox();
            this.intervallabel = new System.Windows.Forms.Label();
            this.comicfolder = new System.Windows.Forms.TextBox();
            this.comicsbaselabel = new System.Windows.Forms.Label();
            this.comicbasebutton = new System.Windows.Forms.Button();
            this.comicstylelabel = new System.Windows.Forms.Label();
            this.resizeCheckBox = new System.Windows.Forms.CheckBox();
            this.limitfilescheckbox = new System.Windows.Forms.CheckBox();
            this.comicstylecombobox = new System.Windows.Forms.ComboBox();
            this.filelimitertextbox = new System.Windows.Forms.TextBox();
            this.buttontest = new System.Windows.Forms.Button();
            this.resizePanel.SuspendLayout();
            this.backgroundpanel.SuspendLayout();
            this.backgroundimagepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyupdown)).BeginInit();
            this.grpResizeType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customXnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customYnumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updowncachesize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updowninterval)).BeginInit();
            this.SuspendLayout();
            // 
            // resizePanel
            // 
            this.resizePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resizePanel.Controls.Add(this.backgroundlabel);
            this.resizePanel.Controls.Add(this.backgroundpanel);
            this.resizePanel.Controls.Add(this.grpResizeType);
            this.resizePanel.Controls.Add(this.screensizetextbox);
            this.resizePanel.Controls.Add(this.commonComboBox);
            this.resizePanel.Controls.Add(this.screenSizeRadioButton);
            this.resizePanel.Controls.Add(this.commonRadioButton);
            this.resizePanel.Controls.Add(this.label3);
            this.resizePanel.Controls.Add(this.customRadioButton);
            this.resizePanel.Controls.Add(this.customXnumeric);
            this.resizePanel.Controls.Add(this.customYnumberic);
            this.resizePanel.Enabled = false;
            this.resizePanel.Location = new System.Drawing.Point(6, 240);
            this.resizePanel.Name = "resizePanel";
            this.resizePanel.Size = new System.Drawing.Size(258, 210);
            this.resizePanel.TabIndex = 67;
            // 
            // backgroundlabel
            // 
            this.backgroundlabel.AutoSize = true;
            this.backgroundlabel.Location = new System.Drawing.Point(34, 135);
            this.backgroundlabel.Name = "backgroundlabel";
            this.backgroundlabel.Size = new System.Drawing.Size(65, 13);
            this.backgroundlabel.TabIndex = 38;
            this.backgroundlabel.Text = "Background";
            // 
            // backgroundpanel
            // 
            this.backgroundpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundpanel.Controls.Add(this.marginlabel);
            this.backgroundpanel.Controls.Add(this.margintextbox);
            this.backgroundpanel.Controls.Add(this.cropfillforGBcheckbox);
            this.backgroundpanel.Controls.Add(this.backgroundimagepanel);
            this.backgroundpanel.Controls.Add(this.backgroundcolorlabel);
            this.backgroundpanel.Controls.Add(this.backgroundButton);
            this.backgroundpanel.Location = new System.Drawing.Point(3, 138);
            this.backgroundpanel.Name = "backgroundpanel";
            this.backgroundpanel.Size = new System.Drawing.Size(250, 69);
            this.backgroundpanel.TabIndex = 37;
            // 
            // marginlabel
            // 
            this.marginlabel.AutoSize = true;
            this.marginlabel.Location = new System.Drawing.Point(1, 45);
            this.marginlabel.Name = "marginlabel";
            this.marginlabel.Size = new System.Drawing.Size(44, 13);
            this.marginlabel.TabIndex = 40;
            this.marginlabel.Text = "Margins";
            // 
            // margintextbox
            // 
            this.margintextbox.Location = new System.Drawing.Point(41, 42);
            this.margintextbox.Name = "margintextbox";
            this.margintextbox.ReadOnly = true;
            this.margintextbox.Size = new System.Drawing.Size(66, 20);
            this.margintextbox.TabIndex = 24;
            this.margintextbox.TabStop = false;
            this.margintextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cropfillforGBcheckbox
            // 
            this.cropfillforGBcheckbox.AutoSize = true;
            this.cropfillforGBcheckbox.Location = new System.Drawing.Point(109, 3);
            this.cropfillforGBcheckbox.Name = "cropfillforGBcheckbox";
            this.cropfillforGBcheckbox.Size = new System.Drawing.Size(95, 17);
            this.cropfillforGBcheckbox.TabIndex = 25;
            this.cropfillforGBcheckbox.Text = "Crop Fill Image";
            this.cropfillforGBcheckbox.UseVisualStyleBackColor = true;
            // 
            // backgroundimagepanel
            // 
            this.backgroundimagepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundimagepanel.Controls.Add(this.greyscalecheckbox);
            this.backgroundimagepanel.Controls.Add(this.transparencyupdown);
            this.backgroundimagepanel.Controls.Add(this.transparencylabel);
            this.backgroundimagepanel.Enabled = false;
            this.backgroundimagepanel.Location = new System.Drawing.Point(113, 12);
            this.backgroundimagepanel.Name = "backgroundimagepanel";
            this.backgroundimagepanel.Size = new System.Drawing.Size(132, 52);
            this.backgroundimagepanel.TabIndex = 38;
            // 
            // greyscalecheckbox
            // 
            this.greyscalecheckbox.AutoSize = true;
            this.greyscalecheckbox.Location = new System.Drawing.Point(15, 11);
            this.greyscalecheckbox.Name = "greyscalecheckbox";
            this.greyscalecheckbox.Size = new System.Drawing.Size(78, 17);
            this.greyscalecheckbox.TabIndex = 26;
            this.greyscalecheckbox.Text = "Grey Scale";
            this.greyscalecheckbox.UseVisualStyleBackColor = true;
            // 
            // transparencyupdown
            // 
            this.transparencyupdown.Location = new System.Drawing.Point(12, 29);
            this.transparencyupdown.Name = "transparencyupdown";
            this.transparencyupdown.Size = new System.Drawing.Size(43, 20);
            this.transparencyupdown.TabIndex = 27;
            // 
            // transparencylabel
            // 
            this.transparencylabel.AutoSize = true;
            this.transparencylabel.Location = new System.Drawing.Point(57, 31);
            this.transparencylabel.Name = "transparencylabel";
            this.transparencylabel.Size = new System.Drawing.Size(72, 13);
            this.transparencylabel.TabIndex = 36;
            this.transparencylabel.Text = "Transparency";
            // 
            // backgroundcolorlabel
            // 
            this.backgroundcolorlabel.AutoSize = true;
            this.backgroundcolorlabel.Location = new System.Drawing.Point(38, 20);
            this.backgroundcolorlabel.Name = "backgroundcolorlabel";
            this.backgroundcolorlabel.Size = new System.Drawing.Size(31, 13);
            this.backgroundcolorlabel.TabIndex = 33;
            this.backgroundcolorlabel.Text = "Color";
            // 
            // backgroundButton
            // 
            this.backgroundButton.BackColor = System.Drawing.Color.Black;
            this.backgroundButton.Location = new System.Drawing.Point(3, 16);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(29, 23);
            this.backgroundButton.TabIndex = 23;
            this.backgroundButton.UseVisualStyleBackColor = false;
            // 
            // grpResizeType
            // 
            this.grpResizeType.Controls.Add(this.cropRadioButton);
            this.grpResizeType.Controls.Add(this.stretchradiobutton);
            this.grpResizeType.Controls.Add(this.keepratioradiobutton);
            this.grpResizeType.Location = new System.Drawing.Point(14, 3);
            this.grpResizeType.Name = "grpResizeType";
            this.grpResizeType.Padding = new System.Windows.Forms.Padding(1, 2, 3, 4);
            this.grpResizeType.Size = new System.Drawing.Size(239, 44);
            this.grpResizeType.TabIndex = 27;
            this.grpResizeType.TabStop = false;
            this.grpResizeType.Text = "Scaling Type";
            // 
            // cropRadioButton
            // 
            this.cropRadioButton.AutoSize = true;
            this.cropRadioButton.Location = new System.Drawing.Point(182, 18);
            this.cropRadioButton.Name = "cropRadioButton";
            this.cropRadioButton.Size = new System.Drawing.Size(47, 17);
            this.cropRadioButton.TabIndex = 15;
            this.cropRadioButton.TabStop = true;
            this.cropRadioButton.Text = "Crop";
            this.cropRadioButton.UseVisualStyleBackColor = true;
            // 
            // stretchradiobutton
            // 
            this.stretchradiobutton.AutoSize = true;
            this.stretchradiobutton.Location = new System.Drawing.Point(108, 18);
            this.stretchradiobutton.Name = "stretchradiobutton";
            this.stretchradiobutton.Size = new System.Drawing.Size(59, 17);
            this.stretchradiobutton.TabIndex = 14;
            this.stretchradiobutton.TabStop = true;
            this.stretchradiobutton.Text = "Stretch";
            this.stretchradiobutton.UseVisualStyleBackColor = true;
            // 
            // keepratioradiobutton
            // 
            this.keepratioradiobutton.AutoSize = true;
            this.keepratioradiobutton.Location = new System.Drawing.Point(15, 18);
            this.keepratioradiobutton.Name = "keepratioradiobutton";
            this.keepratioradiobutton.Size = new System.Drawing.Size(78, 17);
            this.keepratioradiobutton.TabIndex = 13;
            this.keepratioradiobutton.TabStop = true;
            this.keepratioradiobutton.Text = "Keep Ratio";
            this.keepratioradiobutton.UseVisualStyleBackColor = true;
            // 
            // screensizetextbox
            // 
            this.screensizetextbox.Enabled = false;
            this.screensizetextbox.Location = new System.Drawing.Point(101, 53);
            this.screensizetextbox.Name = "screensizetextbox";
            this.screensizetextbox.Size = new System.Drawing.Size(144, 20);
            this.screensizetextbox.TabIndex = 17;
            // 
            // commonComboBox
            // 
            this.commonComboBox.Enabled = false;
            this.commonComboBox.FormattingEnabled = true;
            this.commonComboBox.Items.AddRange(new object[] {
            "720x480",
            "800x600",
            "1024x768",
            "1280x720"});
            this.commonComboBox.Location = new System.Drawing.Point(101, 78);
            this.commonComboBox.Name = "commonComboBox";
            this.commonComboBox.Size = new System.Drawing.Size(144, 21);
            this.commonComboBox.TabIndex = 19;
            // 
            // screenSizeRadioButton
            // 
            this.screenSizeRadioButton.Location = new System.Drawing.Point(16, 50);
            this.screenSizeRadioButton.Name = "screenSizeRadioButton";
            this.screenSizeRadioButton.Size = new System.Drawing.Size(92, 24);
            this.screenSizeRadioButton.TabIndex = 16;
            this.screenSizeRadioButton.TabStop = true;
            this.screenSizeRadioButton.Text = "Screen Size";
            this.screenSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // commonRadioButton
            // 
            this.commonRadioButton.Location = new System.Drawing.Point(16, 78);
            this.commonRadioButton.Name = "commonRadioButton";
            this.commonRadioButton.Size = new System.Drawing.Size(71, 24);
            this.commonRadioButton.TabIndex = 18;
            this.commonRadioButton.TabStop = true;
            this.commonRadioButton.Text = "Common";
            this.commonRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(168, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "x";
            // 
            // customRadioButton
            // 
            this.customRadioButton.Location = new System.Drawing.Point(16, 108);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(71, 24);
            this.customRadioButton.TabIndex = 20;
            this.customRadioButton.TabStop = true;
            this.customRadioButton.Text = "Custom";
            this.customRadioButton.UseVisualStyleBackColor = true;
            // 
            // customXnumeric
            // 
            this.customXnumeric.Enabled = false;
            this.customXnumeric.Location = new System.Drawing.Point(101, 109);
            this.customXnumeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.customXnumeric.Name = "customXnumeric";
            this.customXnumeric.Size = new System.Drawing.Size(62, 20);
            this.customXnumeric.TabIndex = 21;
            // 
            // customYnumberic
            // 
            this.customYnumberic.Enabled = false;
            this.customYnumberic.Location = new System.Drawing.Point(190, 109);
            this.customYnumberic.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.customYnumberic.Name = "customYnumberic";
            this.customYnumberic.Size = new System.Drawing.Size(57, 20);
            this.customYnumberic.TabIndex = 22;
            // 
            // cachetypecombo
            // 
            this.cachetypecombo.FormattingEnabled = true;
            this.cachetypecombo.Items.AddRange(new object[] {
            "jpg",
            "png",
            "bmp"});
            this.cachetypecombo.Location = new System.Drawing.Point(163, 84);
            this.cachetypecombo.Name = "cachetypecombo";
            this.cachetypecombo.Size = new System.Drawing.Size(101, 21);
            this.cachetypecombo.TabIndex = 61;
            // 
            // cachesizelabel
            // 
            this.cachesizelabel.Location = new System.Drawing.Point(14, 85);
            this.cachesizelabel.Name = "cachesizelabel";
            this.cachesizelabel.Size = new System.Drawing.Size(91, 20);
            this.cachesizelabel.TabIndex = 71;
            this.cachesizelabel.Text = "Cache Size/Type";
            // 
            // updowncachesize
            // 
            this.updowncachesize.Location = new System.Drawing.Point(120, 83);
            this.updowncachesize.Name = "updowncachesize";
            this.updowncachesize.Size = new System.Drawing.Size(37, 20);
            this.updowncachesize.TabIndex = 60;
            // 
            // cachefolderlabel
            // 
            this.cachefolderlabel.Location = new System.Drawing.Point(14, 111);
            this.cachefolderlabel.Name = "cachefolderlabel";
            this.cachefolderlabel.Size = new System.Drawing.Size(80, 23);
            this.cachefolderlabel.TabIndex = 70;
            this.cachefolderlabel.Text = "Cache Folder";
            // 
            // cacheFolder
            // 
            this.cacheFolder.Location = new System.Drawing.Point(14, 137);
            this.cacheFolder.Name = "cacheFolder";
            this.cacheFolder.Size = new System.Drawing.Size(197, 20);
            this.cacheFolder.TabIndex = 63;
            // 
            // cachebrowsebutton
            // 
            this.cachebrowsebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cachebrowsebutton.Location = new System.Drawing.Point(217, 135);
            this.cachebrowsebutton.Name = "cachebrowsebutton";
            this.cachebrowsebutton.Size = new System.Drawing.Size(47, 23);
            this.cachebrowsebutton.TabIndex = 64;
            this.cachebrowsebutton.Text = "...";
            this.cachebrowsebutton.UseVisualStyleBackColor = true;
            // 
            // updowninterval
            // 
            this.updowninterval.Location = new System.Drawing.Point(103, 8);
            this.updowninterval.Name = "updowninterval";
            this.updowninterval.Size = new System.Drawing.Size(45, 20);
            this.updowninterval.TabIndex = 55;
            // 
            // combointerval
            // 
            this.combointerval.FormattingEnabled = true;
            this.combointerval.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days"});
            this.combointerval.Location = new System.Drawing.Point(154, 7);
            this.combointerval.Name = "combointerval";
            this.combointerval.Size = new System.Drawing.Size(110, 21);
            this.combointerval.TabIndex = 56;
            // 
            // intervallabel
            // 
            this.intervallabel.Location = new System.Drawing.Point(14, 11);
            this.intervallabel.Name = "intervallabel";
            this.intervallabel.Size = new System.Drawing.Size(67, 20);
            this.intervallabel.TabIndex = 59;
            this.intervallabel.Text = "Interval";
            // 
            // comicfolder
            // 
            this.comicfolder.Location = new System.Drawing.Point(14, 57);
            this.comicfolder.Name = "comicfolder";
            this.comicfolder.Size = new System.Drawing.Size(197, 20);
            this.comicfolder.TabIndex = 57;
            // 
            // comicsbaselabel
            // 
            this.comicsbaselabel.Location = new System.Drawing.Point(14, 31);
            this.comicsbaselabel.Name = "comicsbaselabel";
            this.comicsbaselabel.Size = new System.Drawing.Size(134, 23);
            this.comicsbaselabel.TabIndex = 69;
            this.comicsbaselabel.Text = "Comics Base Folder(s)";
            // 
            // comicbasebutton
            // 
            this.comicbasebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comicbasebutton.Location = new System.Drawing.Point(217, 55);
            this.comicbasebutton.Name = "comicbasebutton";
            this.comicbasebutton.Size = new System.Drawing.Size(47, 23);
            this.comicbasebutton.TabIndex = 58;
            this.comicbasebutton.Text = "...";
            this.comicbasebutton.UseVisualStyleBackColor = true;
            // 
            // comicstylelabel
            // 
            this.comicstylelabel.AutoSize = true;
            this.comicstylelabel.Location = new System.Drawing.Point(113, 113);
            this.comicstylelabel.Name = "comicstylelabel";
            this.comicstylelabel.Size = new System.Drawing.Size(30, 13);
            this.comicstylelabel.TabIndex = 73;
            this.comicstylelabel.Text = "Style";
            // 
            // resizeCheckBox
            // 
            this.resizeCheckBox.Location = new System.Drawing.Point(13, 210);
            this.resizeCheckBox.Name = "resizeCheckBox";
            this.resizeCheckBox.Size = new System.Drawing.Size(67, 24);
            this.resizeCheckBox.TabIndex = 68;
            this.resizeCheckBox.Text = "Resize";
            this.resizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // limitfilescheckbox
            // 
            this.limitfilescheckbox.AutoSize = true;
            this.limitfilescheckbox.Location = new System.Drawing.Point(14, 163);
            this.limitfilescheckbox.Name = "limitfilescheckbox";
            this.limitfilescheckbox.Size = new System.Drawing.Size(194, 17);
            this.limitfilescheckbox.TabIndex = 65;
            this.limitfilescheckbox.Text = "Limit to Files with Names Containing";
            this.limitfilescheckbox.UseVisualStyleBackColor = true;
            // 
            // comicstylecombobox
            // 
            this.comicstylecombobox.FormattingEnabled = true;
            this.comicstylecombobox.Items.AddRange(new object[] {
            "Covers Only",
            "Entire Comic",
            "Any Page"});
            this.comicstylecombobox.Location = new System.Drawing.Point(163, 110);
            this.comicstylecombobox.Name = "comicstylecombobox";
            this.comicstylecombobox.Size = new System.Drawing.Size(98, 21);
            this.comicstylecombobox.TabIndex = 62;
            // 
            // filelimitertextbox
            // 
            this.filelimitertextbox.Enabled = false;
            this.filelimitertextbox.Location = new System.Drawing.Point(13, 186);
            this.filelimitertextbox.Name = "filelimitertextbox";
            this.filelimitertextbox.Size = new System.Drawing.Size(250, 20);
            this.filelimitertextbox.TabIndex = 66;
            // 
            // buttontest
            // 
            this.buttontest.Location = new System.Drawing.Point(95, 454);
            this.buttontest.Name = "buttontest";
            this.buttontest.Size = new System.Drawing.Size(75, 23);
            this.buttontest.TabIndex = 72;
            this.buttontest.Text = "Test";
            this.buttontest.UseVisualStyleBackColor = true;
            // 
            // configcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resizePanel);
            this.Controls.Add(this.cachetypecombo);
            this.Controls.Add(this.cachesizelabel);
            this.Controls.Add(this.updowncachesize);
            this.Controls.Add(this.cachefolderlabel);
            this.Controls.Add(this.cacheFolder);
            this.Controls.Add(this.cachebrowsebutton);
            this.Controls.Add(this.updowninterval);
            this.Controls.Add(this.combointerval);
            this.Controls.Add(this.intervallabel);
            this.Controls.Add(this.comicfolder);
            this.Controls.Add(this.comicsbaselabel);
            this.Controls.Add(this.comicbasebutton);
            this.Controls.Add(this.comicstylelabel);
            this.Controls.Add(this.resizeCheckBox);
            this.Controls.Add(this.limitfilescheckbox);
            this.Controls.Add(this.comicstylecombobox);
            this.Controls.Add(this.filelimitertextbox);
            this.Controls.Add(this.buttontest);
            this.Name = "configcontrol";
            this.Size = new System.Drawing.Size(278, 482);
            this.Load += new System.EventHandler(this.configcontrol_Load);
            this.resizePanel.ResumeLayout(false);
            this.resizePanel.PerformLayout();
            this.backgroundpanel.ResumeLayout(false);
            this.backgroundpanel.PerformLayout();
            this.backgroundimagepanel.ResumeLayout(false);
            this.backgroundimagepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyupdown)).EndInit();
            this.grpResizeType.ResumeLayout(false);
            this.grpResizeType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customXnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customYnumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updowncachesize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updowninterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel resizePanel;
        private System.Windows.Forms.Label backgroundlabel;
        private System.Windows.Forms.Panel backgroundpanel;
        private System.Windows.Forms.Label marginlabel;
        private System.Windows.Forms.TextBox margintextbox;
        private System.Windows.Forms.CheckBox cropfillforGBcheckbox;
        private System.Windows.Forms.Panel backgroundimagepanel;
        private System.Windows.Forms.CheckBox greyscalecheckbox;
        private System.Windows.Forms.NumericUpDown transparencyupdown;
        private System.Windows.Forms.Label transparencylabel;
        private System.Windows.Forms.Label backgroundcolorlabel;
        private System.Windows.Forms.Button backgroundButton;
        private System.Windows.Forms.GroupBox grpResizeType;
        private System.Windows.Forms.RadioButton cropRadioButton;
        private System.Windows.Forms.RadioButton stretchradiobutton;
        private System.Windows.Forms.RadioButton keepratioradiobutton;
        private System.Windows.Forms.TextBox screensizetextbox;
        private System.Windows.Forms.ComboBox commonComboBox;
        private System.Windows.Forms.RadioButton screenSizeRadioButton;
        private System.Windows.Forms.RadioButton commonRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.NumericUpDown customXnumeric;
        private System.Windows.Forms.NumericUpDown customYnumberic;
        private System.Windows.Forms.ComboBox cachetypecombo;
        private System.Windows.Forms.Label cachesizelabel;
        private System.Windows.Forms.NumericUpDown updowncachesize;
        private System.Windows.Forms.Label cachefolderlabel;
        private System.Windows.Forms.TextBox cacheFolder;
        private System.Windows.Forms.Button cachebrowsebutton;
        private System.Windows.Forms.NumericUpDown updowninterval;
        private System.Windows.Forms.ComboBox combointerval;
        private System.Windows.Forms.Label intervallabel;
        private System.Windows.Forms.TextBox comicfolder;
        private System.Windows.Forms.Label comicsbaselabel;
        private System.Windows.Forms.Button comicbasebutton;
        private System.Windows.Forms.Label comicstylelabel;
        private System.Windows.Forms.CheckBox resizeCheckBox;
        private System.Windows.Forms.CheckBox limitfilescheckbox;
        private System.Windows.Forms.ComboBox comicstylecombobox;
        private System.Windows.Forms.TextBox filelimitertextbox;
        private System.Windows.Forms.Button buttontest;
    }
}
