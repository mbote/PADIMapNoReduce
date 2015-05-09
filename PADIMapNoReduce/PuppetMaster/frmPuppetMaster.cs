using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuppetMaster
{
    public partial class FrmPuppetMaster : Form
    {
        public FrmPuppetMaster()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {

        }

        private void FrmPuppetMaster_Load(object sender, EventArgs e)
        {

        }

        private void btStartClient_Click(object sender, EventArgs e)
        {
            //TODO: ISTO NAO E PARA FICAR AQUI
            Program.Connection("20001");
        }
    }
}
