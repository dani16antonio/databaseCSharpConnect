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
    public partial class Citas : Form
    {
        Form f1;
        private SqlConnection sqlConnection;
        public Citas(Form form1)
        {            
            InitializeComponent();
            f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
            comboBoxMItems();
            comboBoxPItems();
            comboBoxEItems();
            comboBoxTItems();
        }

        private void Citas_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMItems()
        {
            sqlConnection.Open();
            string query = "SELECT Apellido FROM dbo.Medico";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = sqlCommand.ExecuteReader();
            while (rows.Read())
            {
                comboBoxM.Items.Add(rows["Apellido"].ToString());
            }
            sqlConnection.Close();
            comboBoxM.SelectedIndex = 0;
        }

        private void comboBoxPItems()
        {
            sqlConnection.Open();
            string query = "SELECT Apellido FROM dbo.Paciente";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = sqlCommand.ExecuteReader();
            while (rows.Read())
            {
                comboBoxP.Items.Add(rows["Apellido"].ToString());
            }
            sqlConnection.Close();
            comboBoxP.SelectedIndex = 0;
        }

        private void comboBoxEItems()
        {
            sqlConnection.Open();
            string query = "SELECT Nombre FROM dbo.Enfermedad";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = sqlCommand.ExecuteReader();
            while (rows.Read())
            {
                comboBoxE.Items.Add(rows["Nombre"].ToString());
            }
            sqlConnection.Close();
            //comboBoxE.SelectedIndex = 0;
        }

        private void comboBoxTItems()
        {
            sqlConnection.Open();
            string query = "SELECT Nombre FROM dbo.Tratamiento";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = sqlCommand.ExecuteReader();
            while (rows.Read())
            {
                comboBoxT.Items.Add(rows["Nombre"].ToString());
            }
            sqlConnection.Close();
            //comboBoxT.SelectedIndex = 0;
        }

        private void Limpiar()
        {
            this.tbcosto.Text = String.Empty;
            this.dtpBorn.Value = DateTime.Today;
        }

        
        private void makeQuery()
        {
            decimal costo = decimal.Parse(tbcosto.Text);
            DateTime nacimiento = dtpBorn.Value.Date;
            nacimiento = DateTime.Parse(nacimiento.Year.ToString() + "-" + nacimiento.Month.ToString() + "-" + nacimiento.Day.ToString());
            string query = "EXEC dbo.usp_Insert_Citas '" + nacimiento + "'," + (comboBoxM.SelectedIndex + 1) + "," + (comboBoxP.SelectedIndex + 1) + "," + (comboBoxE.SelectedIndex + 1) + "," + (comboBoxT.SelectedIndex + 1) + "," + costo + "";
            string query1 = "EXEC dbo.usp_Insert_Paciente_X_Medico " + (comboBoxM.SelectedIndex + 1) + "," + (comboBoxP.SelectedIndex + 1) + "";
            string query2 = "EXEC dbo.usp_Insert_Enfermedad_X_Paciente " + (comboBoxP.SelectedIndex + 1) + "," + (comboBoxE.SelectedIndex + 1) + "";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Se guardaron los datos correctamente.",
                "Datos guardados",
                MessageBoxButtons.OK);
            Limpiar();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand(query1, sqlConnection);
            sqlCommand1.ExecuteNonQuery();
            MessageBox.Show("Se guardaron los datos correctamente.",
                "Datos guardados",
                MessageBoxButtons.OK);
            Limpiar();
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand(query2, sqlConnection);
            sqlCommand2.ExecuteNonQuery();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void btnregistrarcita_Click(object sender, EventArgs e)
        {
            if (validateBlank(tbcosto) &
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

        private void comboBoxT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
