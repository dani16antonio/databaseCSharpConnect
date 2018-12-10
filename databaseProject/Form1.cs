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
            this.Hide();
            EdadPromedio EdadPromedio = new EdadPromedio(this);
            EdadPromedio.ShowDialog();

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

        private void btnPac_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevoPaciente nuevoPaciente = new nuevoPaciente(this);
            nuevoPaciente.ShowDialog();
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevoMedico nuevoMedico = new nuevoMedico(this);
            nuevoMedico.ShowDialog();
        }

        private void btnEnf_Click(object sender, EventArgs e)
        {
            this.Hide();
            nuevaEnfermedad nuevaEnfermedad = new nuevaEnfermedad(this);
            nuevaEnfermedad.ShowDialog();
        }

        private void btnPacXMed_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoPacientes NoPacientes = new NoPacientes(this);
            NoPacientes.ShowDialog();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnRepo, "Reporte de información de los médicos.");
        }

        private void btnReEn_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnReEn, "Reporte de información de los médicos y enfermedades de pacientes que " +
                "atendió.");
        }

        private void btnRepo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteMedi ReporteMedi = new ReporteMedi(this);
            ReporteMedi.ShowDialog();
        }

        private void btnReEn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteEnferm ReporteEnferm = new ReporteEnferm(this);
            ReporteEnferm.ShowDialog();
        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btnRePa, "Reporte de información de los pacientes y sus enfermedades.");
        }

        private void btnRePa_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportePacient ReportePacient = new ReportePacient(this);
            ReportePacient.ShowDialog();
        }

        private void btnListEnfXPac_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaDeEnferm ListaDeEnferm = new ListaDeEnferm(this);
            ListaDeEnferm.ShowDialog();
        }

        private void btnMedEdad_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoMedicoPorEdad NoMedicoPorEdad = new NoMedicoPorEdad(this);
            NoMedicoPorEdad.ShowDialog();
        }

        private void btnNomApeNumEnf_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoEnfermedad NoEnfermedad = new NoEnfermedad(this);
            NoEnfermedad.ShowDialog();
        }

        private void btn_NoDicPa_Click(object sender, EventArgs e)
        {
            this.Hide();
            NombreDirec NombreDirec = new NombreDirec(this);
            NombreDirec.ShowDialog();
        }

        private void btncitas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Citas Citas = new Citas(this);
            Citas.ShowDialog();
        }
    }
}
