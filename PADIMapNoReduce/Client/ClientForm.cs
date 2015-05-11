using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void ChooseClass_Click(object sender, EventArgs e)
        {
            DialogResult result = openMapClass.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = openMapClass.FileName;
                MapFunction.Text = path;
            }
        }

        private void SelectInput_Click(object sender, EventArgs e)
        {
            DialogResult result = openInputFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = openInputFile.FileName;
                InputFile.Text = path;
            }
        }

        private void SelectOutput_Click(object sender, EventArgs e)
        {
            DialogResult result = openOutputFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = openOutputFolder.SelectedPath;
                OutputFolder.Text = path;
            }
        }

        private void InputFile_TextChanged(object sender, EventArgs e)
        {
            InputFile.BackColor = Color.White;
        }

        private void OutputFolder_TextChanged(object sender, EventArgs e)
        {
            OutputFolder.BackColor = Color.White;
        }

        private void MapFunction_TextChanged(object sender, EventArgs e)
        {
            MapFunction.BackColor = Color.White;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            int n;
            if (File.Exists(InputFile.Text) && File.Exists(MapFunction.Text) && Directory.Exists(OutputFolder.Text) && int.TryParse(SplitsNr.Text, out n))
            {
                client.submit(InputFile.Text, n, OutputFolder.Text, MapperClassName.Text, MapFunction.Text);
                Console.WriteLine("YEY");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please, correctly fill the client form");
                Console.ReadLine();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
