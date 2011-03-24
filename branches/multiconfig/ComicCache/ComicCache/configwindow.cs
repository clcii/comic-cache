using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.IO;

namespace ComicCache
{
    public partial class ConfigWindow : Form
    {
        #region LocalProperties
            delegate void setStatusInfo(string text);
            private NotifyIcon notifyicon;
            private ContextMenuStrip clickMenu;
            private AllConfigs allconfigs;

        #endregion


        #region Constructors
            public ConfigWindow(AllConfigs allconfig)
            {
                InitializeComponent();
                this.allconfigs = allconfig;
                setuptooltips();
                foreach (Config conf in allconfig.Configs)
                {
                    configtabs.TabPages.Add("Config");
                    TabPage tab = configtabs.TabPages[configtabs.TabIndex - 1];
                    tab.Controls.Add(new controls.configcontrol(conf));
                    //LoadConfig();
                }
            }
        #endregion


        #region Procedures
            private void setuptooltips()
            {
                ToolTip forButton = new ToolTip();
                forButton.SetToolTip(buttonsave, "Save settings and minimize to tray");
                forButton.SetToolTip(buttoncancel, "Do not save settings.");

            }

            private void refresh() {
            foreach (Config conf in allconfigs.Configs)
            {
               //CopyConfig();
                //Boolean isValid = allconfig.IsValid();
                //errorlabel.Text = allconfig.ErrorMessage;
                //errorlabel.Visible = !isValid;
                //if (allconfig.IsValid())
                //{
                //    Program program = new Program(allconfig);
                //    program.Run();
                //}
            }
        }
            private void PrepContextMenu()
        {
            ToolStripItem restorebutton = new ToolStripButton("Restore");
            restorebutton.Click += new EventHandler(restorebutton_Click);
            notifyicon.ContextMenuStrip.Items.Add(restorebutton);
            //ToolStripItem refreshbutton = new ToolStripButton("Refresh");
            //refreshbutton.Click += new EventHandler(ButtontestClick);
            //notifyicon.ContextMenuStrip.Items.Add(refreshbutton);
            ToolStripButton exitbutton = new ToolStripButton("Exit");
            exitbutton.Click += new EventHandler(exitbutton_Click);
            notifyicon.ContextMenuStrip.Items.Add(exitbutton);
            
        }


            private void restore()
        {
            try
            {
                this.Visible = true;
                this.Show();
                this.BringToFront();
                this.Focus();
                notifyicon.Visible = false;
            }
            catch (Exception ex)
            {
                Log.Instance.Write(ex.Message);
            }
            finally
            {
            }

        }

            public void ShowNotify()
        {
            if (notifyicon == null)
            {
                
                notifyicon = new NotifyIcon();
                clickMenu = new System.Windows.Forms.ContextMenuStrip();
                notifyicon.ContextMenuStrip = clickMenu;
                PrepContextMenu();

            }
            notifyicon.Text = "Comic Cache";
            notifyicon.MouseClick += new MouseEventHandler(this.notifyicon_Click);
            //notifyicon.Click += new EventHandler(this.notifyicon_Click);
            notifyicon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
                //new Icon("ComicCache.ico");
            notifyicon.Visible = true;
             

        }
            public void HideNotify()
        {
            notifyicon.Visible = false;
            notifyicon = null;
        }
            public void SetStatus(string text) {
                if (this.infotextbox.InvokeRequired)
                {
                    setStatusInfo d = new setStatusInfo(SetStatus);
                    this.Invoke(d, new object[] { text });
                    this.Refresh();
                }
                else
                {
                    this.infotextbox.Text = text;
                    if (notifyicon != null) {
                        notifyicon.BalloonTipText = text;
                        notifyicon.ShowBalloonTip(100);
                    }
                
                }
            }
        #endregion


        #region Events
            #region FormEvents
            void ConfigWindowLoad(object sender, EventArgs e)
            {

            }
            void ConfigWindowFormClosing(object sender, FormClosingEventArgs e)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    this.Hide();
                    e.Cancel = true;
                    ShowNotify();
                }
            }
            protected override void WndProc(ref Message message)
            {
                if (message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
                {
                    ShowWindow();
                }
                base.WndProc(ref message);
            }
            public void ShowWindow()
            {
                //WinApi.ShowToFront(this.Handle);
                restore();
            }
            #endregion
            #region ControlEvents
                void restorebutton_Click(object sender, EventArgs e)
                    {
                        restore();
                    }
                void ButtonsaveClick(object sender, EventArgs e)
                    {
                        //CopyConfig();
                        allconfigs.Save();
                        //if (allconfig.IsValid())
                        //{
                          //allconfig.Save();
                            //this.Hide();
                            //ShowNotify();
                        //}
                          
                    }


                void exitbutton_Click(object sender, EventArgs e)
                {
                    HideNotify();
                    Application.Exit();
                }            



                private void buttoncancel_Click(object sender, EventArgs e)
                    {
                        //LoadConfig();
                        //if (allconfig.IsValid())
                        //{
                        //    this.Hide();
                            //ShowNotify();
                        //}
                    }
                private void notifyicon_Click(object Sender, MouseEventArgs e)
                {

                    {
                        if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            restore();
                        }
                    }
                }

                private void homelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                    System.Diagnostics.Process.Start(homelink.Text);
                }

                }
            #endregion
        # endregion

    }    
    public enum ResizeStyle { 
        None,
        CurrentScreen,
        Common,
        Custom
    }
    public enum ResizeRatioType { 
        Keep,
        Stretch,
        Crop
    }

