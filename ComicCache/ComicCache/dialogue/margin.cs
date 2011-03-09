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
        #region Constructors
            public margin()
        {
            InitializeComponent();
        }
            public margin(string originalvalues)
        {

            InitializeComponent();
            resultstring = originalvalues;
            setcontrols(ResultString);

        }
            public margin(string originalvalues, int maxXvalues, int maxYvalues)
        {
            InitializeComponent();
            resultstring = originalvalues;
            setmaxmargins(maxXvalues, maxYvalues);
            setcontrols(ResultString);


        }
        #endregion

        private string resultstring = "";
        private DialogResult dialogresult = DialogResult.Cancel;
        private int maxymargin = 100;
        private int maxxmargin = 100;

        public string ResultString
        {
            get { return resultstring; }
            set
            {
                resultstring = value;
                setcontrols(resultstring);
            }
        }
        public int MaxXMargin
        {
            get { return maxxmargin; }
            set { maxxmargin = value; }
        }
        public int MaxYMargin
        {
            get { return maxymargin; }
            set { maxymargin = value; }
        }
        public DialogResult Dialogresult
        {
            get { return dialogresult; }
            set { dialogresult = value; }
        }
        private void setmaxmargins(int maxX, int maxY)
        {

            topnumericupdown.Maximum = maxY;
            bottomnumericupdown.Maximum = maxY;
            leftnumericupdown.Maximum = maxX;
            rightnumericupdown.Maximum = maxX;
        }
        private void okbutton_Click(object sender, EventArgs e)
        {
            dialogresult = System.Windows.Forms.DialogResult.OK;
            resultstring = leftnumericupdown.Value + "," + topnumericupdown.Value + "," + rightnumericupdown.Value + "," + bottomnumericupdown.Value;
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
            catch (Exception ex)
            {
                Log.Instance.Write(ex.Message);
            }

        }
    }
}
