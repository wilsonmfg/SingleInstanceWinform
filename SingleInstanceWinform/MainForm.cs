using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingleInstanceWinform
{
    public partial class MainForm : FormSingleInstance
    {
        public MainForm()
        {
            InitializeComponent();
            LogBox.Text = "";
            CmdBox.Text = Application.ExecutablePath;
        }

        public void HandleCliArg(string arg)
        {
            LogBox.Text += "\r\n" + arg;
        }

        #region ISingleInstanceApp Members
        public override bool SignalExternalCommandLineArgs(IList<string> args)
        {
            //Method is called from a different thread so Invoke on the form's UI thread to interact with it
            this.Invoke((Action)delegate
            {
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;
                this.Activate();
                if (args.Count > 1)
                { 
                    this.HandleCliArg("First arg is: " + args[1]);
                    if(args.Count > 2)
                        this.HandleCliArg("Second arg is: " + args[2]);
                }
                else
                {
                    this.HandleCliArg("no command line args passed");
                }
            });
            return true; //have args, keep single instance
        }
        #endregion

        private void LaunchWithArg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath, ArgBox.Text);
        }

        private void LaunchNoArg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

    }
}
