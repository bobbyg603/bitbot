using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bitbot.Services;

namespace bitbot
{
    public partial class Form1 : Form
    {
        INetworkService _networkService;

        public Form1()
        {
            InitializeComponent();
            _networkService = new NetworkService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_networkService.Get());
        }
    }
}
