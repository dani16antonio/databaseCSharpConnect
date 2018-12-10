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
    public partial class nuevoMedico : Form
    {
        Form f1;
        public static int contrato = 0, universidad=0;
        private SqlConnection sqlConnection;
        public nuevoMedico(Form form1)
        {
            InitializeComponent();
            f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
            comboBoxItems();
        }

        private void btnEras_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void Limpiar()
        {
            this.tbDire.Text = String.Empty;
            this.tbLast.Text = String.Empty;
            this.tbNam.Text = String.Empty;
            contrato = 0;
            universidad = 0;
            this.dtpBorn.Value = DateTime.Today;
        }

        private void btnRetu_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            if (validateBlank(tbDire,tbLast,tbNam) &
                validateDate(dtpBorn))
            {
                makeQuery();
            }
            else
            {
                MessageBox.Show("No pueden haber datos en blanco",
                    "¡Vaya!",
                    MessageBoxButtons.OK);
            }
        }

        private void makeQuery()
        {
            string nombre = tbNam.Text;
            string apellido = tbLast.Text;
            string direccion = tbDire.Text;
            DateTime nacimiento = dtpBorn.Value.Date;
            nacimiento = DateTime.Parse(nacimiento.Year.ToString()+"-"+nacimiento.Month.ToString()+"-"+nacimiento.Day.ToString());
            string query = "EXEC dbo.usp_Insert_Medico '" + nombre + "','" + apellido + "','" + nacimiento + "'," +universidad+",'"+direccion+"',"+contrato+"";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Se guardaron los datos correctamente.",
                "Datos guardados",
                MessageBoxButtons.OK);
            Limpiar();
            sqlConnection.Close();
        }

        private bool validateDate(DateTimePicker dtpBorn)
        {
            if (dtpBorn.Value.Equals(DateTime.Today))
                return false;
            return true;
        }

        private bool validateBlank(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Trim().Equals(string.Empty))
                {
                    return false;
                }
            }
            return true;
        }

        private void comboBoxItems()
        {
            sqlConnection.Open();
            string query = "SELECT Tipo_de_Contratacion FROM TipoContratacion";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = sqlCommand.ExecuteReader();
            while (rows.Read())
            {
                comboBox1.Items.Add(rows["Tipo_de_Contratacion"].ToString());
            }
            sqlConnection.Close();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contrato = (comboBox1.SelectedIndex) + 1;
        }

        private void nuevoMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnUniv_Click(object sender, EventArgs e)
        {
            medico.universidad universidad = new medico.universidad(this);
            this.Hide();
            universidad.ShowDialog();
        }
    }
}
