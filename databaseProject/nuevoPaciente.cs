using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseProject
{
    public partial class nuevoPaciente : Form
    {
        private Form f1;
        public nuevoPaciente(Form1 form1)
        {
            InitializeComponent();
            this.f1 = form1;
        }

        private void nuevoPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnRetu_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void btnEras_Click(object sender, EventArgs e)
        {
            this.tbDirec.Text = String.Empty;
            this.tbLast.Text = String.Empty;
            this.tbName.Text = String.Empty;
            this.tbSoci.Text = String.Empty;
            this.dtpBorn.Value = DateTime.Today;
        }
    }
}
