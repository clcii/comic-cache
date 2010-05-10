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
        	this.labelInterval = new System.Windows.Forms.Label();
        	this.combointerval = new System.Windows.Forms.ComboBox();
        	this.updowninterval = new System.Windows.Forms.NumericUpDown();
        	((System.ComponentModel.ISupportInitialize)(this.updowninterval)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// buttonsave
        	// 
        	this.buttonsave.Location = new System.Drawing.Point(5, 343);
        	this.buttonsave.Name = "buttonsave";
        	this.buttonsave.Size = new System.Drawing.Size(75, 23);
        	this.buttonsave.TabIndex = 0;
        	this.buttonsave.Text = "Save";
        	this.buttonsave.UseVisualStyleBackColor = true;
        	this.buttonsave.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// buttoncancel
        	// 
        	this.buttoncancel.Location = new System.Drawing.Point(98, 343);
        	this.buttoncancel.Name = "buttoncancel";
        	this.buttoncancel.Size = new System.Drawing.Size(75, 23);
        	this.buttoncancel.TabIndex = 1;
        	this.buttoncancel.Text = "Cancel";
        	this.buttoncancel.UseVisualStyleBackColor = true;
        	// 
        	// buttontest
        	// 
        	this.buttontest.Location = new System.Drawing.Point(189, 343);
        	this.buttontest.Name = "buttontest";
        	this.buttontest.Size = new System.Drawing.Size(75, 23);
        	this.buttontest.TabIndex = 2;
        	this.buttontest.Text = "Test";
        	this.buttontest.UseVisualStyleBackColor = true;
        	this.buttontest.Click += new System.EventHandler(this.ButtontestClick);
        	// 
        	// labelInterval
        	// 
        	this.labelInterval.Location = new System.Drawing.Point(13, 8);
        	this.labelInterval.Name = "labelInterval";
        	this.labelInterval.Size = new System.Drawing.Size(67, 20);
        	this.labelInterval.TabIndex = 4;
        	this.labelInterval.Text = "Interval";
        	// 
        	// combointerval
        	// 
        	this.combointerval.FormattingEnabled = true;
        	this.combointerval.Items.AddRange(new object[] {
        	        	        	"Seconds",
        	        	        	"Minutes",
        	        	        	"Hours",
        	        	        	"Days"});
        	this.combointerval.Location = new System.Drawing.Point(153, 4);
        	this.combointerval.Name = "combointerval";
        	this.combointerval.Size = new System.Drawing.Size(110, 21);
        	this.combointerval.TabIndex = 5;
        	// 
        	// updowninterval
        	// 
        	this.updowninterval.Location = new System.Drawing.Point(102, 5);
        	this.updowninterval.Name = "updowninterval";
        	this.updowninterval.Size = new System.Drawing.Size(45, 20);
        	this.updowninterval.TabIndex = 17;
        	// 
        	// ConfigWindow
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(307, 388);
        	this.Controls.Add(this.updowninterval);
        	this.Controls.Add(this.combointerval);
        	this.Controls.Add(this.labelInterval);
        	this.Controls.Add(this.buttontest);
        	this.Controls.Add(this.buttoncancel);
        	this.Controls.Add(this.buttonsave);
        	this.Name = "ConfigWindow";
        	this.Text = "Form1";
        	((System.ComponentModel.ISupportInitialize)(this.updowninterval)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.ComboBox combointerval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown updowninterval;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttontest;
        private System.Windows.Forms.Button buttoncancel;

        #endregion
    }
}

