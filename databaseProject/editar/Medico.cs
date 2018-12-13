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
    public partial class Medico : Form
    {
        public static int contrato = 0, universidad = 0;
        private SqlConnection sqlConnection;
        private int id_medico;
        Form form;
        public Medico(Form form)
        {
            InitializeComponent();
            this.form = form;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [dbo].[Medico] SET Nombre='" + tbNam.Text + "' ,Apellido='" + tbLast.Text + "'" +
                ",Fecha_Nacimiento=" + dtpBorn.Value.ToString("yyyy-mm-dd") + ",Id_Universidad=" + (cbUniv.SelectedIndex + 1) + 
                ",Direccion='" + tbDire.Text + "',Id_Tipo_Contratacion="+(cbCont.SelectedIndex+1)+" WHERE Id_Medico="+id_medico;
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int consulta=command.ExecuteNonQuery();
            if(consulta==1)
            {
                MessageBox.Show("Datos guardados", "Se actualizaron los datos exitosamente", MessageBoxButtons.OK);
                Limpiar();
            }
            sqlConnection.Close();
        }

        private void btnEras_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void Medico_Load(object sender, EventArgs e)
        {
            string query = "SELECT Id_Medico,Nombre FROM Medico";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query,sqlConnection);
            SqlDataReader rows = command.ExecuteReader();
            while (rows.Read())
            {
                cbMedi.Items.Add(rows["Id_Medico"].ToString()+", "+ rows["Nombre"].ToString());
            }
            sqlConnection.Close();
        }

        private void cbMedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int contrato=0, universidad=0;
            string query = "SELECT * FROM Medico WHERE Id_Medico="+
                (cbMedi.SelectedIndex+1);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = command.ExecuteReader();

            if (rows.Read())
            {
                tbNam.Text = rows["Nombre"].ToString();
                tbLast.Text = rows["Apellido"].ToString();
                tbDire.Text = rows["Direccion"].ToString();
                dtpBorn.Value=DateTime.Parse(rows["Fecha_Nacimiento"].ToString());
                contrato=int.Parse(rows["Id_Tipo_Contratacion"].ToString());
                universidad = int.Parse(rows["Id_Universidad"].ToString());
                contrato--;
                universidad--;
                id_medico = int.Parse(rows["Id_Medico"].ToString());
            }
            sqlConnection.Close();
            sqlConnection.Open();
            string queryUniversidad = "SELECT * FROM Universidad";
            SqlCommand commandU = new SqlCommand(queryUniversidad, sqlConnection);
            SqlDataReader rowsU = commandU.ExecuteReader();
            while (rowsU.Read())
            {
                cbUniv.Items.Add(rowsU["Nombre"].ToString());
            }
            cbUniv.SelectedIndex = universidad;
            sqlConnection.Close();

            sqlConnection.Open();
            string queryContrato = "SELECT * FROM TipoContratacion";
            SqlCommand commandC = new SqlCommand(queryContrato, sqlConnection);
            SqlDataReader rowsC = commandC.ExecuteReader();
            while (rowsC.Read())
            {
                cbCont.Items.Add(rowsC["Tipo_de_Contratacion"].ToString());
            }
            cbCont.SelectedIndex = contrato;
            sqlConnection.Close();
        }

        private void btnRetu_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void Limpiar()
        {
            this.tbDire.Text = String.Empty;
            this.tbLast.Text = String.Empty;
            this.tbNam.Text = String.Empty;
            contrato = 0;
            universidad = 0;
            this.cbCont.SelectedIndex = 0;
            this.cbUniv.SelectedIndex = 0;
            this.cbMedi.SelectedIndex = 0;
            this.dtpBorn.Value = DateTime.Today;
        }
    }
}
