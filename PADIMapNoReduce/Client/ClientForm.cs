using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {

        Client client;

        public ClientForm()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new ClientForm());
        }

        private void InitializeButton_Click(object sender, EventArgs e)
        {
            client = new Client();
            client.init(WorkerURL.Text);
        }
    }
}
