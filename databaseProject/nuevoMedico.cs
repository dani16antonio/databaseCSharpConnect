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
        private int contrato = -1, universidad=-1;
        private SqlConnection sqlConnection;
        public nuevoMedico(Form form1)
        {
            InitializeComponent();
            f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void btnEras_Click(object sender, EventArgs e)
        {
            
            this.tbDire.Text = String.Empty;
            this.tbLast.Text = String.Empty;
            this.tbNam.Text = String.Empty;
            this.contrato = -1;
            this.universidad = -1;
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
                validateDate(dtpBorn)& validateNumber())
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

        private bool validateNumber()
        {
            if (this.contrato > 0 & this.universidad > 0)
                return false;
            return true;
        }

        private void makeQuery()
        {
            sqlConnection.Open();
            string nombre = tbNam.Text;
            string apellido = tbLast.Text;
            //string universidad = tbUniv.Text; //Todo change this field
            string direccion = tbDire.Text;
            //string contrato = tbContr.Text; // TODO: change this field
            DateTime nacimiento = dtpBorn.Value; 

            string query = "INSERT INTO Medico(Nombre,Apellido,Fecha_Nacimiento,Id_Universidad," +
                "Direccion,Id_Tipo_Contratacion)" +
                "values(2,'" + nombre + "','" + apellido + "','" + nacimiento + "'," +
                "'"+1+"')";
//todo: mejorar query
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Se guardaron los datos correctamente.",
                "Datos guardados",
                MessageBoxButtons.OK);

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

        private void btnUniv_Click(object sender, EventArgs e)
        {
            medico.universidad universidad = new medico.universidad(this);
            this.Hide();
            universidad.ShowDialog();
        }
    }
}
