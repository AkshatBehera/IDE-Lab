using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1", 9000);
            client.Events.DataReceived += DataReceived;
            client.Events.Connected += Connected;
            client.Events.Disconnected += Disconnected;
            client.Connect();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Message sent my client");
            String sendingMsg = inputTbx.Text;
            client.Send(sendingMsg);
            inputTbx.Text = "";
            displayTbx.AppendText("Client : " + sendingMsg);
            displayTbx.AppendText(Environment.NewLine);
        }

        void Connected(object sender, EventArgs e)
        {
            Console.WriteLine("Server connected");
        }

        void Disconnected(object sender, EventArgs e)
        {
            Console.WriteLine("Server disconnected");
        }

        void DataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine("[" + e.IpPort + "] from server:  " + Encoding.UTF8.GetString(e.Data));
            displayTbx.Invoke((MethodInvoker)(() =>
            {
                displayTbx.AppendText("Server :" + Encoding.UTF8.GetString(e.Data));
                displayTbx.AppendText(Environment.NewLine);
            }));
        }
    }
}
