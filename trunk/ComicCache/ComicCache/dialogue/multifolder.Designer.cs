namespace clcii.dialogue
{
    partial class multifolder
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
            this.folderslistbox = new System.Windows.Forms.ListBox();
            this.removebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.labelExlcude = new System.Windows.Forms.Label();
            this.excludefolderslistbox = new System.Windows.Forms.ListBox();
            this.removebuttonexclude = new System.Windows.Forms.Button();
            this.addbuttonexclude = new System.Windows.Forms.Button();
            this.Includelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderslistbox
            // 
            this.folderslistbox.FormattingEnabled = true;
            this.folderslistbox.Location = new System.Drawing.Point(12, 25);
            this.folderslistbox.Name = "folderslistbox";
            this.folderslistbox.Size = new System.Drawing.Size(213, 147);
            this.folderslistbox.TabIndex = 1;
            // 
            // removebutton
            // 
            this.removebutton.Location = new System.Drawing.Point(231, 90);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(110, 23);
            this.removebutton.TabIndex = 3;
            this.removebutton.Text = "Remove";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(231, 61);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(110, 23);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(122, 355);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(103, 23);
            this.cancelbutton.TabIndex = 8;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(12, 355);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(104, 23);
            this.okbutton.TabIndex = 7;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // labelExlcude
            // 
            this.labelExlcude.AutoSize = true;
            this.labelExlcude.Location = new System.Drawing.Point(12, 186);
            this.labelExlcude.Name = "labelExlcude";
            this.labelExlcude.Size = new System.Drawing.Size(45, 13);
            this.labelExlcude.TabIndex = 8;
            this.labelExlcude.Text = "Exclude";
            // 
            // excludefolderslistbox
            // 
            this.excludefolderslistbox.FormattingEnabled = true;
            this.excludefolderslistbox.Location = new System.Drawing.Point(12, 202);
            this.excludefolderslistbox.Name = "excludefolderslistbox";
            this.excludefolderslistbox.Size = new System.Drawing.Size(213, 147);
            this.excludefolderslistbox.TabIndex = 4;
            // 
            // removebuttonexclude
            // 
            this.removebuttonexclude.Location = new System.Drawing.Point(231, 283);
            this.removebuttonexclude.Name = "removebuttonexclude";
            this.removebuttonexclude.Size = new System.Drawing.Size(110, 23);
            this.removebuttonexclude.TabIndex = 6;
            this.removebuttonexclude.Text = "Remove";
            this.removebuttonexclude.UseVisualStyleBackColor = true;
            this.removebuttonexclude.Click += new System.EventHandler(this.removebuttonexclude_Click);
            // 
            // addbuttonexclude
            // 
            this.addbuttonexclude.Location = new System.Drawing.Point(231, 254);
            this.addbuttonexclude.Name = "addbuttonexclude";
            this.addbuttonexclude.Size = new System.Drawing.Size(110, 23);
            this.addbuttonexclude.TabIndex = 5;
            this.addbuttonexclude.Text = "Add";
            this.addbuttonexclude.UseVisualStyleBackColor = true;
            this.addbuttonexclude.Click += new System.EventHandler(this.addbuttonexclude_Click);
            // 
            // Includelabel
            // 
            this.Includelabel.AutoSize = true;
            this.Includelabel.Location = new System.Drawing.Point(12, 9);
            this.Includelabel.Name = "Includelabel";
            this.Includelabel.Size = new System.Drawing.Size(42, 13);
            this.Includelabel.TabIndex = 12;
            this.Includelabel.Text = "Include";
            // 
            // multifolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 387);
            this.Controls.Add(this.folderslistbox);
            this.Controls.Add(this.Includelabel);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.excludefolderslistbox);
            this.Controls.Add(this.labelExlcude);
            this.Controls.Add(this.addbuttonexclude);
            this.Controls.Add(this.removebuttonexclude);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.cancelbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "multifolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Folders";
            this.Load += new System.EventHandler(this.multifolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox folderslistbox;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Label labelExlcude;
        private System.Windows.Forms.ListBox excludefolderslistbox;
        private System.Windows.Forms.Button removebuttonexclude;
        private System.Windows.Forms.Button addbuttonexclude;
        private System.Windows.Forms.Label Includelabel;
    }
}