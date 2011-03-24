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
            this.errorlabel = new System.Windows.Forms.Label();
            this.homelink = new System.Windows.Forms.LinkLabel();
            this.infotextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.configtabs = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(62, 56);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 28;
            this.buttonsave.Text = "Save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.ButtonsaveClick);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(143, 56);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 23);
            this.buttoncancel.TabIndex = 29;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(72, 40);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(126, 13);
            this.errorlabel.TabIndex = 26;
            this.errorlabel.Text = "Error in configuration";
            this.errorlabel.Visible = false;
            // 
            // homelink
            // 
            this.homelink.AutoSize = true;
            this.homelink.Location = new System.Drawing.Point(50, 80);
            this.homelink.Name = "homelink";
            this.homelink.Size = new System.Drawing.Size(202, 13);
            this.homelink.TabIndex = 31;
            this.homelink.TabStop = true;
            this.homelink.Text = "http://code.google.com/p/comic-cache/";
            this.homelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homelink_LinkClicked);
            // 
            // infotextbox
            // 
            this.infotextbox.BackColor = System.Drawing.SystemColors.Info;
            this.infotextbox.Enabled = false;
            this.infotextbox.Location = new System.Drawing.Point(17, 96);
            this.infotextbox.Name = "infotextbox";
            this.infotextbox.Size = new System.Drawing.Size(263, 20);
            this.infotextbox.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.errorlabel);
            this.panel1.Controls.Add(this.infotextbox);
            this.panel1.Controls.Add(this.buttonsave);
            this.panel1.Controls.Add(this.homelink);
            this.panel1.Controls.Add(this.buttoncancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 123);
            this.panel1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // configtabs
            // 
            this.configtabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configtabs.Location = new System.Drawing.Point(0, 0);
            this.configtabs.Name = "configtabs";
            this.configtabs.SelectedIndex = 0;
            this.configtabs.Size = new System.Drawing.Size(313, 461);
            this.configtabs.TabIndex = 33;
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 584);
            this.Controls.Add(this.configtabs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigWindow";
            this.Text = "Comic Cache";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigWindowFormClosing);
            this.Load += new System.EventHandler(this.ConfigWindowLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttoncancel;

        #endregion

        public Label errorlabel;
        private LinkLabel homelink;
        private TextBox infotextbox;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private TabControl configtabs;
    }
}

