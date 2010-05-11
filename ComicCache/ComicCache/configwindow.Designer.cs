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
        	((System.ComponentModel.ISupportInitialize)(this.updowninterval)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.updowncachesize)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// buttonsave
        	// 
        	this.buttonsave.Location = new System.Drawing.Point(12, 171);
        	this.buttonsave.Name = "buttonsave";
        	this.buttonsave.Size = new System.Drawing.Size(75, 23);
        	this.buttonsave.TabIndex = 0;
        	this.buttonsave.Text = "Save";
        	this.buttonsave.UseVisualStyleBackColor = true;
        	// 
        	// buttoncancel
        	// 
        	this.buttoncancel.Location = new System.Drawing.Point(105, 171);
        	this.buttoncancel.Name = "buttoncancel";
        	this.buttoncancel.Size = new System.Drawing.Size(75, 23);
        	this.buttoncancel.TabIndex = 1;
        	this.buttoncancel.Text = "Cancel";
        	this.buttoncancel.UseVisualStyleBackColor = true;
        	// 
        	// buttontest
        	// 
        	this.buttontest.Location = new System.Drawing.Point(196, 171);
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
        	this.combointerval.TabIndex = 5;
        	// 
        	// updowninterval
        	// 
        	this.updowninterval.Location = new System.Drawing.Point(101, 6);
        	this.updowninterval.Name = "updowninterval";
        	this.updowninterval.Size = new System.Drawing.Size(45, 20);
        	this.updowninterval.TabIndex = 17;
        	// 
        	// comicbasebutton
        	// 
        	this.comicbasebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        	this.comicbasebutton.Location = new System.Drawing.Point(215, 53);
        	this.comicbasebutton.Name = "comicbasebutton";
        	this.comicbasebutton.Size = new System.Drawing.Size(47, 23);
        	this.comicbasebutton.TabIndex = 18;
        	this.comicbasebutton.Text = "...";
        	this.comicbasebutton.UseVisualStyleBackColor = true;
        	// 
        	// comicfolder
        	// 
        	this.comicfolder.Location = new System.Drawing.Point(12, 55);
        	this.comicfolder.Name = "comicfolder";
        	this.comicfolder.Size = new System.Drawing.Size(197, 20);
        	this.comicfolder.TabIndex = 19;
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
        	this.cacheFolder.TabIndex = 22;
        	// 
        	// cachebrowsebutton
        	// 
        	this.cachebrowsebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
        	this.cachebrowsebutton.Location = new System.Drawing.Point(215, 133);
        	this.cachebrowsebutton.Name = "cachebrowsebutton";
        	this.cachebrowsebutton.Size = new System.Drawing.Size(47, 23);
        	this.cachebrowsebutton.TabIndex = 21;
        	this.cachebrowsebutton.Text = "...";
        	this.cachebrowsebutton.UseVisualStyleBackColor = true;
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
        	this.updowncachesize.TabIndex = 24;
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
        	        	        	"Seconds",
        	        	        	"Minutes",
        	        	        	"Hours",
        	        	        	"Days"});
        	this.cachetypecombo.Location = new System.Drawing.Point(161, 82);
        	this.cachetypecombo.Name = "cachetypecombo";
        	this.cachetypecombo.Size = new System.Drawing.Size(101, 21);
        	this.cachetypecombo.TabIndex = 26;
        	// 
        	// ConfigWindow
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(281, 204);
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
        	((System.ComponentModel.ISupportInitialize)(this.updowninterval)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.updowncachesize)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
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

