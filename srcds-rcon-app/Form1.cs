using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace srcds_rcon_app
{
    public partial class connectWindow : Form
    {
        public connectWindow()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnConnect.Text = "Connecting";
            string srvAddr = txtBoxAddr.Text;
            string rconPass = txtBoxPass.Text;

            if (string.IsNullOrEmpty(srvAddr) || string.IsNullOrEmpty(rconPass))
            {
                MessageBox.Show("You must enter a server address and RCON password.");
                btnConnect.Text = "Connect";
                btnConnect.Enabled = true;
            }

            //TODO: Connect and then open a management window.
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
