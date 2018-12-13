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

namespace databaseProject.editar
{
    public partial class Paciente : Form
    {
        Form form;
        SqlConnection sqlConnection;
        public Paciente(Form form)
        {
            InitializeComponent();
            this.form = form;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
            queryPati();
        }

        private void queryPati()
        {
            string query="SELECT * FROM Paciente";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader row = command.ExecuteReader();
            while (row.Read())
            {
                cbPaci.Items.Add(row["Seguro_Social"].ToString() + ", " + row["Nombre"].ToString() + " " + row["Apellido"].ToString());
            }
            sqlConnection.Close();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        private void btnRetu_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void cbPaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            makeQuery();
        }

        private void makeQuery()
        {
            string query = "SELECT * FRoM Paciente WHERE Seguro_Social="+(cbPaci.SelectedIndex+1);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader row = command.ExecuteReader();
            if (row.Read())
            {
                tbName.Text = row["Nombre"].ToString();
                tbLast.Text = row["Apellido"].ToString();
                dtpBorn.Value = DateTime.Parse(row["Fecha_Nacimiento"].ToString());
                tbDirec.Text = row["Direccion"].ToString();
                tbNoHi.Text = row["Numero_Historial"].ToString();
            }
            sqlConnection.Close();
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            if (!validateBlankFields())
                updateQuery();
            else
                MessageBox.Show("Verifique que todos los campos tengan informaición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validateBlankFields()
        {
            if (tbName.Text.Trim() == string.Empty | tbLast.Text.Trim() == string.Empty
                | tbDirec.Text.Trim() == string.Empty | tbNoHi.Text.Trim() == string.Empty)
                return true;
            return false;
        }

        private void updateQuery()
        {
            string query = "UPDATE [Paciente] SET "+
                "[Nombre]='" + tbName.Text + "',[Apellido]='" + tbLast.Text + "',[Fecha_Nacimiento]=" + dtpBorn.Value.ToString("yyyy-mm-dd") +
                ", [Direccion]='" + tbDirec.Text + "', [Numero_Historial]=" + int.Parse(tbNoHi.Text) + " WHERE Seguro_Social="+(cbPaci.SelectedIndex+1);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int quer=command.ExecuteNonQuery();
            if (quer==1)
            {
                MessageBox.Show("Se actualizaron los datos satisfactoriamente", "Datos actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudieron actualizar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sqlConnection.Close();
        }
    }
}
