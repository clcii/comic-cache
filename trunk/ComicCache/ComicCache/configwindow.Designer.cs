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
        	this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        	this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.radioButton3 = new System.Windows.Forms.RadioButton();
        	this.radioButton2 = new System.Windows.Forms.RadioButton();
        	this.radioButton1 = new System.Windows.Forms.RadioButton();
        	this.resizepanel = new System.Windows.Forms.CheckBox();
        	((System.ComponentModel.ISupportInitialize)(this.updowninterval)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.updowncachesize)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
        	this.panel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// buttonsave
        	// 
        	this.buttonsave.Location = new System.Drawing.Point(12, 362);
        	this.buttonsave.Name = "buttonsave";
        	this.buttonsave.Size = new System.Drawing.Size(75, 23);
        	this.buttonsave.TabIndex = 0;
        	this.buttonsave.Text = "Save";
        	this.buttonsave.UseVisualStyleBackColor = true;
        	this.buttonsave.Click += new System.EventHandler(this.ButtonsaveClick);
        	// 
        	// buttoncancel
        	// 
        	this.buttoncancel.Location = new System.Drawing.Point(93, 362);
        	this.buttoncancel.Name = "buttoncancel";
        	this.buttoncancel.Size = new System.Drawing.Size(75, 23);
        	this.buttoncancel.TabIndex = 1;
        	this.buttoncancel.Text = "Cancel";
        	this.buttoncancel.UseVisualStyleBackColor = true;
        	// 
        	// buttontest
        	// 
        	this.buttontest.Location = new System.Drawing.Point(175, 362);
        	this.buttontest.Name = "buttontest";
        	this.buttontest.Size = new System.Drawing.Size(75, 23);
        	this.buttontest.TabIndex = 2;
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
        	// numericUpDown1
        	// 
        	this.numericUpDown1.Location = new System.Drawing.Point(105, 62);
        	this.numericUpDown1.Name = "numericUpDown1";
        	this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
        	this.numericUpDown1.TabIndex = 9;
        	// 
        	// numericUpDown2
        	// 
        	this.numericUpDown2.Location = new System.Drawing.Point(194, 62);
        	this.numericUpDown2.Name = "numericUpDown2";
        	this.numericUpDown2.Size = new System.Drawing.Size(57, 20);
        	this.numericUpDown2.TabIndex = 10;
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(118, 190);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(62, 20);
        	this.label1.TabIndex = 29;
        	this.label1.Text = "Width";
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(204, 190);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(58, 20);
        	this.label2.TabIndex = 30;
        	this.label2.Text = "Height";
        	// 
        	// label3
        	// 
        	this.label3.Location = new System.Drawing.Point(172, 64);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(16, 20);
        	this.label3.TabIndex = 31;
        	this.label3.Text = "x";
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.textBox1);
        	this.panel1.Controls.Add(this.comboBox1);
        	this.panel1.Controls.Add(this.radioButton3);
        	this.panel1.Controls.Add(this.radioButton2);
        	this.panel1.Controls.Add(this.label3);
        	this.panel1.Controls.Add(this.radioButton1);
        	this.panel1.Controls.Add(this.numericUpDown1);
        	this.panel1.Controls.Add(this.numericUpDown2);
        	this.panel1.Location = new System.Drawing.Point(13, 213);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(262, 101);
        	this.panel1.TabIndex = 33;
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(105, 6);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(144, 20);
        	this.textBox1.TabIndex = 33;
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Location = new System.Drawing.Point(105, 31);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(144, 21);
        	this.comboBox1.TabIndex = 32;
        	// 
        	// radioButton3
        	// 
        	this.radioButton3.Location = new System.Drawing.Point(3, 3);
        	this.radioButton3.Name = "radioButton3";
        	this.radioButton3.Size = new System.Drawing.Size(92, 24);
        	this.radioButton3.TabIndex = 2;
        	this.radioButton3.TabStop = true;
        	this.radioButton3.Text = "Screen Size";
        	this.radioButton3.UseVisualStyleBackColor = true;
        	// 
        	// radioButton2
        	// 
        	this.radioButton2.Location = new System.Drawing.Point(3, 31);
        	this.radioButton2.Name = "radioButton2";
        	this.radioButton2.Size = new System.Drawing.Size(71, 24);
        	this.radioButton2.TabIndex = 1;
        	this.radioButton2.TabStop = true;
        	this.radioButton2.Text = "Common";
        	this.radioButton2.UseVisualStyleBackColor = true;
        	// 
        	// radioButton1
        	// 
        	this.radioButton1.Location = new System.Drawing.Point(3, 61);
        	this.radioButton1.Name = "radioButton1";
        	this.radioButton1.Size = new System.Drawing.Size(71, 24);
        	this.radioButton1.TabIndex = 0;
        	this.radioButton1.TabStop = true;
        	this.radioButton1.Text = "Custom";
        	this.radioButton1.UseVisualStyleBackColor = true;
        	// 
        	// resizepanel
        	// 
        	this.resizepanel.Location = new System.Drawing.Point(12, 183);
        	this.resizepanel.Name = "resizepanel";
        	this.resizepanel.Size = new System.Drawing.Size(67, 24);
        	this.resizepanel.TabIndex = 34;
        	this.resizepanel.Text = "Resize";
        	this.resizepanel.UseVisualStyleBackColor = true;
        	this.resizepanel.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
        	// 
        	// ConfigWindow
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(280, 397);
        	this.Controls.Add(this.resizepanel);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
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
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "ConfigWindow";
        	this.Text = "Comic Cache";
        	this.Load += new System.EventHandler(this.ConfigWindowLoad);
        	((System.ComponentModel.ISupportInitialize)(this.updowninterval)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.updowncachesize)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.CheckBox resizepanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
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
    }
}

