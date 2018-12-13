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
    public partial class nuevaEnfermedad : Form
    {
        private Form f1;
        private SqlConnection sqlConnection;
        public nuevaEnfermedad(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.label3, "Sistema corporal afectado.");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void btnEars_Click(object sender, EventArgs e)
        {
            this.tbDesc.Text = String.Empty;
            this.tbNam.Text = String.Empty;
            this.tbSyst.Text = String.Empty;
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            if (validateBlank(tbDesc,tbNam,tbSyst))
            {
                consultar();
            }
            else
            {
                MessageBox.Show("No pueden haber datos en blanco",
                    "¡Vaya!",
                    MessageBoxButtons.OK);
            }

        }
        private Boolean validateBlank(params TextBox[] textBoxes)
        {
            foreach(TextBox textBox in textBoxes)
            {
                if (textBox.Text.Trim().Equals(string.Empty))
                {
                    return false;
                }
            }
            return true;
        }

        private void consultar()
        {
            string nombre = tbNam.Text;
            string sistema = tbSyst.Text;
            string descripcion = tbDesc.Text;

            string query = "EXEC dbo.usp_Insert_Enfermedad '" + nombre+"','"+sistema+"','"+descripcion+"'";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Se guardaron los datos correctamente.",
                "Datos guardados", 
                MessageBoxButtons.OK);

            tbNam.Text = string.Empty;
            tbDesc.Text = string.Empty;
            tbSyst.Text = string.Empty;

            sqlConnection.Close();
        }

        private void nuevaEnfermedad_Load(object sender, EventArgs e)
        {

        }

        private void tbSyst_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
