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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPacXMed_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnPacXMed, "Mostrar número de pacientes por cada médico.");
        }

        private void btnEdadProm_Click(object sender, EventArgs e)
        {

        }

        private void btnEdadProm_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnEdadProm, "Mostrar edad promedio de pacientes con enfermedades que afectan un " +
                "sistema del cuerpo.");
        }

        private void btnListEnfXPac_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnListEnfXPac, "Mostrar una lista de enfermedades por paciente.");
        }

        private void btnMedEdad_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnMedEdad, "Mostrar una lista de médicos con una edad menor a la ingresada.");
        }

        private void btnNomApeNumEnf_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnNomApeNumEnf, "Mostrar una lista de cada paciente con el número de enfermedades" +
                "que tiene.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
