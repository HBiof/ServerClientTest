using Eneter.Messaging.EndPoints.TypedMessages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        DuplexPersonSender duplex = new DuplexPersonSender();
        public Form1()
        {
            InitializeComponent();
            duplex.OnResponseMessage += Duplex_OnResponseMessage;
        }

        private void Duplex_OnResponseMessage(object sender, string message)
        {
            lblResponse.Invoke((MethodInvoker)(() => lblResponse.Text = message));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                duplex.Openconnection();
                if (duplex.isConnect())
                {
                    lbltrangthai.Text = "Connected";
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStartSend_Click(object sender, EventArgs e)
        {
            duplex.SendPersonalInfo(txbUserName.Text, int.Parse(txbItems.Text));
        }
    }
}
