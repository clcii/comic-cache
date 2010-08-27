using System.Windows.Forms;

namespace ComicCache
{
    public partial class ConfigWindow : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigWindow));
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttontest = new System.Windows.Forms.Button();
            this.intervallabel = new System.Windows.Forms.Label();
            this.combointerval = new System.Windows.Forms.ComboBox();
            this.updowninterval = new System.Windows.Forms.NumericUpDown();
            this.comicbasebutton = new System.Windows.Forms.Button();
            this.comicfolder = new System.Windows.Forms.TextBox();
            this.comicsbaselabel = new System.Windows.Forms.Label();
            this.cacheFolder = new System.Windows.Forms.TextBox();
            this.cachebrowsebutton = new System.Windows.Forms.Button();
            this.cachefolderlabel = new System.Windows.Forms.Label();
            this.updowncachesize = new System.Windows.Forms.NumericUpDown();
            this.cachesizelabel = new System.Windows.Forms.Label();
            this.cachetypecombo = new System.Windows.Forms.ComboBox();
            this.customXnumeric = new System.Windows.Forms.NumericUpDown();
            this.customYnumberic = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.resizePanel = new System.Windows.Forms.Panel();
            this.screensizetextbox = new System.Windows.Forms.TextBox();
            this.commonComboBox = new System.Windows.Forms.ComboBox();
            this.screenSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.commonRadioButton = new System.Windows.Forms.RadioButton();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.resizeCheckBox = new System.Windows.Forms.CheckBox();
            this.filelimitertextbox = new System.Windows.Forms.TextBox();
            this.limitfilescheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.updowninterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updowncachesize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customXnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customYnumberic)).BeginInit();
            this.resizePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(23, 344);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 19;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.ButtonsaveClick);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(104, 344);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 20;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // buttontest
            // 
            this.buttontest.Location = new System.Drawing.Point(186, 344);
            this.buttontest.Name = "buttontest";
            this.buttontest.Size = new System.Drawing.Size(75, 23);
            this.buttontest.TabIndex = 21;
            this.buttontest.Text = "Test";
            this.buttontest.UseVisualStyleBackColor = true;
            this.buttontest.Click += new System.EventHandler(this.ButtontestClick);
            // 
            // intervallabel
            // 
            this.intervallabel.Location = new System.Drawing.Point(12, 9);
            this.intervallabel.Name = "intervallabel";
            this.intervallabel.Size = new System.Drawing.Size(67, 20);
            this.intervallabel.TabIndex = 4;
            this.intervallabel.Text = "Interval";
            // 
            // combointerval
            // 
            this.combointerval.FormattingEnabled = true;
            this.combointerval.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days"});
            this.combointerval.Location = new System.Drawing.Point(152, 5);
            this.combointerval.Name = "combointerval";
            this.combointerval.Size = new System.Drawing.Size(110, 21);
            this.combointerval.TabIndex = 2;
            // 
            // updowninterval
            // 
            this.updowninterval.Location = new System.Drawing.Point(101, 6);
            this.updowninterval.Name = "updowninterval";
            this.updowninterval.Size = new System.Drawing.Size(45, 20);
            this.updowninterval.TabIndex = 1;
            // 
            // comicbasebutton
            // 
            this.comicbasebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comicbasebutton.Location = new System.Drawing.Point(215, 53);
            this.comicbasebutton.Name = "comicbasebutton";
            this.comicbasebutton.Size = new System.Drawing.Size(47, 23);
            this.comicbasebutton.TabIndex = 4;
            this.comicbasebutton.Text = "...";
            this.comicbasebutton.UseVisualStyleBackColor = true;
            this.comicbasebutton.Click += new System.EventHandler(this.ComicbasebuttonClick);
            // 
            // comicfolder
            // 
            this.comicfolder.Location = new System.Drawing.Point(12, 55);
            this.comicfolder.Name = "comicfolder";
            this.comicfolder.Size = new System.Drawing.Size(197, 20);
            this.comicfolder.TabIndex = 3;
            // 
            // comicsbaselabel
            // 
            this.comicsbaselabel.Location = new System.Drawing.Point(12, 29);
            this.comicsbaselabel.Name = "comicsbaselabel";
            this.comicsbaselabel.Size = new System.Drawing.Size(134, 23);
            this.comicsbaselabel.TabIndex = 20;
            this.comicsbaselabel.Text = "Comics Base Folder(s)";
            // 
            // cacheFolder
            // 
            this.cacheFolder.Location = new System.Drawing.Point(12, 135);
            this.cacheFolder.Name = "cacheFolder";
            this.cacheFolder.Size = new System.Drawing.Size(197, 20);
            this.cacheFolder.TabIndex = 7;
            // 
            // cachebrowsebutton
            // 
            this.cachebrowsebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cachebrowsebutton.Location = new System.Drawing.Point(215, 133);
            this.cachebrowsebutton.Name = "cachebrowsebutton";
            this.cachebrowsebutton.Size = new System.Drawing.Size(47, 23);
            this.cachebrowsebutton.TabIndex = 8;
            this.cachebrowsebutton.Text = "...";
            this.cachebrowsebutton.UseVisualStyleBackColor = true;
            this.cachebrowsebutton.Click += new System.EventHandler(this.CachebrowsebuttonClick);
            // 
            // cachefolderlabel
            // 
            this.cachefolderlabel.Location = new System.Drawing.Point(12, 109);
            this.cachefolderlabel.Name = "cachefolderlabel";
            this.cachefolderlabel.Size = new System.Drawing.Size(112, 23);
            this.cachefolderlabel.TabIndex = 23;
            this.cachefolderlabel.Text = "Cache Folder";
            // 
            // updowncachesize
            // 
            this.updowncachesize.Location = new System.Drawing.Point(118, 81);
            this.updowncachesize.Name = "updowncachesize";
            this.updowncachesize.Size = new System.Drawing.Size(37, 20);
            this.updowncachesize.TabIndex = 5;
            // 
            // cachesizelabel
            // 
            this.cachesizelabel.Location = new System.Drawing.Point(12, 83);
            this.cachesizelabel.Name = "cachesizelabel";
            this.cachesizelabel.Size = new System.Drawing.Size(91, 20);
            this.cachesizelabel.TabIndex = 25;
            this.cachesizelabel.Text = "Cache Size/Type";
            // 
            // cachetypecombo
            // 
            this.cachetypecombo.FormattingEnabled = true;
            this.cachetypecombo.Items.AddRange(new object[] {
            "jpg",
            "png",
            "bmp"});
            this.cachetypecombo.Location = new System.Drawing.Point(161, 82);
            this.cachetypecombo.Name = "cachetypecombo";
            this.cachetypecombo.Size = new System.Drawing.Size(101, 21);
            this.cachetypecombo.TabIndex = 6;
            // 
            // customXnumeric
            // 
            this.customXnumeric.Enabled = false;
            this.customXnumeric.Location = new System.Drawing.Point(105, 62);
            this.customXnumeric.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.customXnumeric.Name = "customXnumeric";
            this.customXnumeric.Size = new System.Drawing.Size(62, 20);
            this.customXnumeric.TabIndex = 17;
            // 
            // customYnumberic
            // 
            this.customYnumberic.Enabled = false;
            this.customYnumberic.Location = new System.Drawing.Point(194, 62);
            this.customYnumberic.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.customYnumberic.Name = "customYnumberic";
            this.customYnumberic.Size = new System.Drawing.Size(57, 20);
            this.customYnumberic.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(172, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "x";
            // 
            // resizePanel
            // 
            this.resizePanel.Controls.Add(this.screensizetextbox);
            this.resizePanel.Controls.Add(this.commonComboBox);
            this.resizePanel.Controls.Add(this.screenSizeRadioButton);
            this.resizePanel.Controls.Add(this.commonRadioButton);
            this.resizePanel.Controls.Add(this.label3);
            this.resizePanel.Controls.Add(this.customRadioButton);
            this.resizePanel.Controls.Add(this.customXnumeric);
            this.resizePanel.Controls.Add(this.customYnumberic);
            this.resizePanel.Enabled = false;
            this.resizePanel.Location = new System.Drawing.Point(12, 237);
            this.resizePanel.Name = "resizePanel";
            this.resizePanel.Size = new System.Drawing.Size(262, 101);
            this.resizePanel.TabIndex = 12;
            this.resizePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.resizePanel_Paint);
            // 
            // screensizetextbox
            // 
            this.screensizetextbox.Enabled = false;
            this.screensizetextbox.Location = new System.Drawing.Point(105, 6);
            this.screensizetextbox.Name = "screensizetextbox";
            this.screensizetextbox.Size = new System.Drawing.Size(144, 20);
            this.screensizetextbox.TabIndex = 13;
            // 
            // commonComboBox
            // 
            this.commonComboBox.Enabled = false;
            this.commonComboBox.FormattingEnabled = true;
            this.commonComboBox.Items.AddRange(new object[] {
            "800x600",
            "720x480",
            "1024x768",
            "1280x720"});
            this.commonComboBox.Location = new System.Drawing.Point(105, 31);
            this.commonComboBox.Name = "commonComboBox";
            this.commonComboBox.Size = new System.Drawing.Size(144, 21);
            this.commonComboBox.TabIndex = 15;
            // 
            // screenSizeRadioButton
            // 
            this.screenSizeRadioButton.Location = new System.Drawing.Point(3, 3);
            this.screenSizeRadioButton.Name = "screenSizeRadioButton";
            this.screenSizeRadioButton.Size = new System.Drawing.Size(92, 24);
            this.screenSizeRadioButton.TabIndex = 12;
            this.screenSizeRadioButton.TabStop = true;
            this.screenSizeRadioButton.Text = "Screen Size";
            this.screenSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // commonRadioButton
            // 
            this.commonRadioButton.Location = new System.Drawing.Point(3, 31);
            this.commonRadioButton.Name = "commonRadioButton";
            this.commonRadioButton.Size = new System.Drawing.Size(71, 24);
            this.commonRadioButton.TabIndex = 14;
            this.commonRadioButton.TabStop = true;
            this.commonRadioButton.Text = "Common";
            this.commonRadioButton.UseVisualStyleBackColor = true;
            this.commonRadioButton.CheckedChanged += new System.EventHandler(this.commonRadioButton_CheckedChanged);
            // 
            // customRadioButton
            // 
            this.customRadioButton.Location = new System.Drawing.Point(3, 61);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(71, 24);
            this.customRadioButton.TabIndex = 16;
            this.customRadioButton.TabStop = true;
            this.customRadioButton.Text = "Custom";
            this.customRadioButton.UseVisualStyleBackColor = true;
            this.customRadioButton.CheckedChanged += new System.EventHandler(this.customRadioButton_CheckedChanged);
            // 
            // resizeCheckBox
            // 
            this.resizeCheckBox.Location = new System.Drawing.Point(15, 210);
            this.resizeCheckBox.Name = "resizeCheckBox";
            this.resizeCheckBox.Size = new System.Drawing.Size(67, 24);
            this.resizeCheckBox.TabIndex = 11;
            this.resizeCheckBox.Text = "Resize";
            this.resizeCheckBox.UseVisualStyleBackColor = true;
            this.resizeCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
            // 
            // filelimitertextbox
            // 
            this.filelimitertextbox.Enabled = false;
            this.filelimitertextbox.Location = new System.Drawing.Point(11, 184);
            this.filelimitertextbox.Name = "filelimitertextbox";
            this.filelimitertextbox.Size = new System.Drawing.Size(250, 20);
            this.filelimitertextbox.TabIndex = 10;
            this.filelimitertextbox.TextChanged += new System.EventHandler(this.filelimitertextbox_TextChanged);
            // 
            // limitfilescheckbox
            // 
            this.limitfilescheckbox.AutoSize = true;
            this.limitfilescheckbox.Location = new System.Drawing.Point(12, 161);
            this.limitfilescheckbox.Name = "limitfilescheckbox";
            this.limitfilescheckbox.Size = new System.Drawing.Size(194, 17);
            this.limitfilescheckbox.TabIndex = 9;
            this.limitfilescheckbox.Text = "Limit to Files with Names Containing";
            this.limitfilescheckbox.UseVisualStyleBackColor = true;
            this.limitfilescheckbox.CheckedChanged += new System.EventHandler(this.limitfilescheckbox_CheckedChanged);
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 377);
            this.Controls.Add(this.limitfilescheckbox);
            this.Controls.Add(this.filelimitertextbox);
            this.Controls.Add(this.resizeCheckBox);
            this.Controls.Add(this.resizePanel);
            this.Controls.Add(this.cachetypecombo);
            this.Controls.Add(this.cachesizelabel);
            this.Controls.Add(this.updowncachesize);
            this.Controls.Add(this.cachefolderlabel);
            this.Controls.Add(this.cacheFolder);
            this.Controls.Add(this.cachebrowsebutton);
            this.Controls.Add(this.comicsbaselabel);
            this.Controls.Add(this.comicfolder);
            this.Controls.Add(this.comicbasebutton);
            this.Controls.Add(this.updowninterval);
            this.Controls.Add(this.combointerval);
            this.Controls.Add(this.intervallabel);
            this.Controls.Add(this.buttontest);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonsave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigWindow";
            this.Text = "Comic Cache";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigWindowFormClosing);
            this.Load += new System.EventHandler(this.ConfigWindowLoad);
            ((System.ComponentModel.ISupportInitialize)(this.updowninterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updowncachesize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customXnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customYnumberic)).EndInit();
            this.resizePanel.ResumeLayout(false);
            this.resizePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.NumericUpDown customXnumeric;
        private System.Windows.Forms.NumericUpDown customYnumberic;
        private System.Windows.Forms.RadioButton screenSizeRadioButton;
        private System.Windows.Forms.RadioButton commonRadioButton;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.ComboBox commonComboBox;
        private System.Windows.Forms.TextBox screensizetextbox;
        private System.Windows.Forms.Panel resizePanel;
        private System.Windows.Forms.CheckBox resizeCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label intervallabel;
        private System.Windows.Forms.TextBox comicfolder;
        private System.Windows.Forms.Label comicsbaselabel;
        private System.Windows.Forms.TextBox cacheFolder;
        private System.Windows.Forms.Button cachebrowsebutton;
        private System.Windows.Forms.Label cachefolderlabel;
        private System.Windows.Forms.NumericUpDown updowncachesize;
        private System.Windows.Forms.Label cachesizelabel;
        private System.Windows.Forms.ComboBox cachetypecombo;
        private System.Windows.Forms.Button comicbasebutton;
        private System.Windows.Forms.ComboBox combointerval;
        private System.Windows.Forms.NumericUpDown updowninterval;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttontest;
        private System.Windows.Forms.Button buttoncancel;

        #endregion
        private TextBox filelimitertextbox;
        private CheckBox limitfilescheckbox;
    }
}

