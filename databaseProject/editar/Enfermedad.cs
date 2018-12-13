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
    public partial class Enfermedad : Form
    {
        Form form;
        SqlConnection sqlConnection;
        public Enfermedad(Form form)
        {
            InitializeComponent();
            this.form = form;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void Enfermedad_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Enfermedad";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = command.ExecuteReader();
            while (rows.Read())
            {
                cbName.Items.Add(rows["Nombre"].ToString());
            }
            sqlConnection.Close();
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Enfermedad WHERE Id_Enfermedad=" + (cbName.SelectedIndex + 1);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader row = command.ExecuteReader();
            if (row.Read())
            {
                tbSyst.Text = row["Sistema"].ToString();
                tbDesc.Text = row["Descripcion"].ToString();
            }
            sqlConnection.Close();
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            string query="UPDATE Enfermedad SET Sistema='"+tbSyst.Text+"', Descripcion='"+tbDesc.Text+"' WHERE " +
                "Id_Enfermedad="+(cbName.SelectedIndex+1);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int quer = command.ExecuteNonQuery();
            if (quer == 1)
                MessageBox.Show("Ha actualizado los datos satisfactoriamente.", "Datos actulizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Los datos no pudieron ser actualizados, intentelo de nuevo más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sqlConnection.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.form.Show();
        }
    }
}
