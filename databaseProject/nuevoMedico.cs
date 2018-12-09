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
    public partial class nuevoMedico : Form
    {
        Form f1;
        public nuevoMedico(Form form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        private void btnEras_Click(object sender, EventArgs e)
        {
            this.tbCod.Text = String.Empty;
            this.tbContr.Text = String.Empty;
            this.tbDire.Text = String.Empty;
            this.tbLast.Text = String.Empty;
            this.tbNam.Text = String.Empty;
            this.tbUniv.Text = String.Empty;
            this.dtpBorn.Value = DateTime.Today;
        }

        private void btnRetu_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }
    }
}
