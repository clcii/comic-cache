using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace clcii.dialogue
{
    public partial class multifolder : Form
    {
        public multifolder()
        {
            InitializeComponent();
        }

        public multifolder(string foldersString)
        {
            InitializeComponent();
            List<string> allfolders = new List<string>();
            List<string> includefolders = new List<string>();
            List<string> excludefolders = new List<string>();
            
            allfolders.AddRange(foldersString.Split(';'));
            excludefolders.AddRange
                (
                    allfolders.FindAll
                    (
                        delegate(string exclude)
                        {
                            return exclude.StartsWith("!");
                        }
                    )
                );
            includefolders.AddRange
                (
                    allfolders.FindAll
                    (
                        delegate(string include)
                        {
                            return !excludefolders.Contains(include);
                        }
                    )
                );
            foreach (string excludeitm in excludefolders)
            {
                excludefolderslistbox.Items.Add(excludeitm.TrimStart('!'));
            }

            folderslistbox.Items.AddRange(includefolders.ToArray());


        }

        private void multifolder_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Directory.Exists(fbd.SelectedPath))
                {
                    if (folderslistbox.Items.Count == 1) 
                    {
                        if (folderslistbox.Items[0].ToString() == string.Empty)
                        {
                            folderslistbox.Items[0] = fbd.SelectedPath;
                        }
                        else
                        {
                            folderslistbox.Items.Add(fbd.SelectedPath);
                        }
                    }
                    else{
                        folderslistbox.Items.Add(fbd.SelectedPath);
                    }
                }

            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            if (folderslistbox.SelectedItem != null)
            {
                folderslistbox.Items.Remove(folderslistbox.SelectedItem);
            }
        }
        public DialogResult Result ()
        { 
            return result;
        }
        public string FileImageSourcePath()
        {
            List<string> values = new List<string>();
            string[] dump;
            dump = new string[folderslistbox.Items.Count];
            folderslistbox.Items.CopyTo(dump,0);
            values.AddRange(dump);
            foreach (string itm in excludefolderslistbox.Items)
            {
                values.Add("!" + itm);
            }
            
            return string.Join(";", values);
        
        }
        DialogResult result = DialogResult.Cancel;

        private void okbutton_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            this.Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            this.Close();
        }

        private void addbuttonexclude_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.Directory.Exists(fbd.SelectedPath))
                {
                    if (excludefolderslistbox.Items.Count == 1)
                    {
                        if (excludefolderslistbox.Items[0].ToString() == string.Empty)
                        {
                            excludefolderslistbox.Items[0] = fbd.SelectedPath;
                        }
                        else
                        {
                            excludefolderslistbox.Items.Add(fbd.SelectedPath);
                        }
                    }
                    else
                    {
                        excludefolderslistbox.Items.Add(fbd.SelectedPath);
                    }
                }

            }

        }

        private void removebuttonexclude_Click(object sender, EventArgs e)
        {
            if (excludefolderslistbox.SelectedItem != null)
            {
                excludefolderslistbox.Items.Remove(excludefolderslistbox.SelectedItem);
            }
        }
    }

}
