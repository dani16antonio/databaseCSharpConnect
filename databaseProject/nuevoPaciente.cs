using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
         SqlConnection sqlConnection;
        public nuevoPaciente(Form1 form1)
        {
            InitializeComponent();
            this.f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
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
            easerControls();
        }

        private void easerControls()
        {
            this.tbDirec.Text = String.Empty;
            this.tbLast.Text = String.Empty;
            this.tbName.Text = String.Empty;
            this.tbSoci.Text = String.Empty;
            this.dtpBorn.Value = DateTime.Today;
            this.tbNoHi.Text = string.Empty;
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            string nombre = tbName.Text;
            string apellido = tbLast.Text;
            DateTime nacimiento = dtpBorn.Value.Date;
            string direccion = this.tbDirec.Text;
            string social=this.tbSoci.Text;
            int numero = int.Parse(this.tbNoHi.Text);
            nacimiento = DateTime.Parse(nacimiento.Year.ToString() + "-" + nacimiento.Month.ToString() + "-" + nacimiento.Day.ToString());
            string query = "EXEC dbo.usp_Insert_Paciente " + social + ",'" + nombre + "','" + apellido + "','" + nacimiento + "','" + direccion + "', " + numero + "";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Se guardaron los datos correctamente.",
                "Datos guardados",
                MessageBoxButtons.OK);
            easerControls();
            sqlConnection.Close();
        }
    }
}
