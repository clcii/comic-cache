namespace ComicCache.dialogue
{
    partial class margin
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
            this.okbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rightnumericupdown = new System.Windows.Forms.NumericUpDown();
            this.leftnumericupdown = new System.Windows.Forms.NumericUpDown();
            this.topnumericupdown = new System.Windows.Forms.NumericUpDown();
            this.bottomnumericupdown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rightnumericupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftnumericupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topnumericupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomnumericupdown)).BeginInit();
            this.SuspendLayout();
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(12, 122);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(61, 23);
            this.okbutton.TabIndex = 4;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Location = new System.Drawing.Point(79, 122);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(61, 23);
            this.cancelbutton.TabIndex = 5;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(161, 157);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(17, 15);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(122, 89);
            // 
            // rightnumericupdown
            // 
            this.rightnumericupdown.Location = new System.Drawing.Point(110, 45);
            this.rightnumericupdown.Name = "rightnumericupdown";
            this.rightnumericupdown.Size = new System.Drawing.Size(39, 20);
            this.rightnumericupdown.TabIndex = 2;
            // 
            // leftnumericupdown
            // 
            this.leftnumericupdown.Location = new System.Drawing.Point(3, 45);
            this.leftnumericupdown.Name = "leftnumericupdown";
            this.leftnumericupdown.Size = new System.Drawing.Size(39, 20);
            this.leftnumericupdown.TabIndex = 1;
            // 
            // topnumericupdown
            // 
            this.topnumericupdown.Location = new System.Drawing.Point(55, 3);
            this.topnumericupdown.Name = "topnumericupdown";
            this.topnumericupdown.Size = new System.Drawing.Size(39, 20);
            this.topnumericupdown.TabIndex = 0;
            // 
            // bottomnumericupdown
            // 
            this.bottomnumericupdown.Location = new System.Drawing.Point(55, 96);
            this.bottomnumericupdown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.bottomnumericupdown.Name = "bottomnumericupdown";
            this.bottomnumericupdown.Size = new System.Drawing.Size(39, 20);
            this.bottomnumericupdown.TabIndex = 3;
            // 
            // margin
            // 
            this.AcceptButton = this.okbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelbutton;
            this.ClientSize = new System.Drawing.Size(161, 157);
            this.Controls.Add(this.bottomnumericupdown);
            this.Controls.Add(this.topnumericupdown);
            this.Controls.Add(this.leftnumericupdown);
            this.Controls.Add(this.rightnumericupdown);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "margin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "margin";
            ((System.ComponentModel.ISupportInitialize)(this.rightnumericupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftnumericupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topnumericupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomnumericupdown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button cancelbutton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.NumericUpDown rightnumericupdown;
        private System.Windows.Forms.NumericUpDown leftnumericupdown;
        private System.Windows.Forms.NumericUpDown topnumericupdown;
        private System.Windows.Forms.NumericUpDown bottomnumericupdown;
    }
}