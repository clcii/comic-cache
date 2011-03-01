using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComicCache.dialogue
{
    public partial class margin : Form
    {
        public margin()
        {
            InitializeComponent();
        }
        public margin(string originalvalues) {

            InitializeComponent();
            resultstring = originalvalues;
            setcontrols(ResultString);
        }
        private string resultstring = "";

        public string ResultString
        {
            get { return resultstring; }
            set { resultstring = value;
            setcontrols(resultstring);
            }
        }
        
        private DialogResult dialogresult = DialogResult.Cancel;

        public DialogResult Dialogresult
        {
            get { return dialogresult; }
            set { dialogresult = value; }
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            dialogresult = System.Windows.Forms.DialogResult.OK;
            resultstring = leftnumericupdown.Value + "," + topnumericupdown.Value + "," + rightnumericupdown.Value + "," +  bottomnumericupdown.Value ;
            Close();
        }
        private void setcontrols(string text)
        {
            try
            {
                leftnumericupdown.Value = Convert.ToInt16(text.Split(',')[0]);
                topnumericupdown.Value = Convert.ToInt16(text.Split(',')[1]);
                rightnumericupdown.Value = Convert.ToInt16(text.Split(',')[2]);
                bottomnumericupdown.Value = Convert.ToInt16(text.Split(',')[3]);
            }
            catch (Exception)
            {
                
                throw;
            }
    
        }
    }
}
