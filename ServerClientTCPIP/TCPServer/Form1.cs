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

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        static string connectedClientAddress = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer("127.0.0.1", 9000);
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
            server.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sendingMsg = inputTbx.Text;
            String address = $"{connectedClientAddress}";
            server.Send(address, sendingMsg);
            inputTbx.Text = "";
            //Console.WriteLine("Message sent by server" + address);
            displayTbx.AppendText("Server : " + sendingMsg);
            displayTbx.AppendText(Environment.NewLine);
        }



        void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            connectedClientAddress = e.IpPort;
            Console.WriteLine("[" + e.IpPort + "] client connected");
        }

        void DataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine("[" + e.IpPort + "]: from client: " + Encoding.UTF8.GetString(e.Data));
            displayTbx.Invoke((MethodInvoker)(() =>
            {
                displayTbx.AppendText("Client :" + Encoding.UTF8.GetString(e.Data));
                displayTbx.AppendText(Environment.NewLine);
            }));

        }

        void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            Console.WriteLine("[" + e.IpPort + "] client disconnected: " + e.Reason.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
