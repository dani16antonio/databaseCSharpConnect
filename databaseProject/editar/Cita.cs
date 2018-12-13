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
    public partial class Cita : Form
    {
        SqlConnection sqlConnection;
        Form form;
        int id_medico = 0;
        public Cita(Form form)
        {
            InitializeComponent();
            this.form = form;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void Cita_Load(object sender, EventArgs e)
        {
            string query = "select c.Id_Citas,p.Nombre from Citas as c inner join Paciente as p on c.Id_Paciente=p.Seguro_Social";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = command.ExecuteReader();
            while (rows.Read())
            {
                cbCita.Items.Add(rows["Id_Citas"].ToString() + ", " + rows["Nombre"].ToString());
            }
            sqlConnection.Close();

            string queryM = "SELECT *  FROM Medico";
            string queryP = "SELECT *  FROM Paciente";
            string queryE = "SELECT *  FROM Enfermedad";
            string queryT = "SELECT *  FROM Tratamiento";
            queryMedico(queryM);
            queryPaciente(queryP);
            queryEnfermedad(queryE);
            queryTratamiento(queryT);
        }

        private void btnRetu_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void cbCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            // one time selected any meeting, we going to consult its info
            int nombreDoc = 0, nombrePac = 0, NombreEn = 0, tratamiento = 0;
            string query = "SELECT * FROM Citas WHERE Id_Citas="+(cbCita.SelectedIndex+1);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = command.ExecuteReader();
            if (rows.Read())
            {
                id_medico = int.Parse(rows["Id_Citas"].ToString());
                nombreDoc = int.Parse(rows["Id_Medico"].ToString());
                nombrePac = int.Parse(rows["Id_Paciente"].ToString());
                NombreEn = int.Parse(rows["Id_Enfermedad"].ToString());
                tratamiento= int.Parse(rows["Id_Tratamiento"].ToString());
                dtpCita.Value = DateTime.Parse(rows["Fecha"].ToString());
                tbcosto.Text = rows["CostoTotalCita"].ToString();
            }
            //clearComboBox();
            sqlConnection.Close();

            cbNoDo.SelectedIndex = nombreDoc-1;
            cbNoPa.SelectedIndex = nombrePac-1;
            cbNoEn.SelectedIndex = NombreEn-1;
            cbTrat.SelectedIndex = tratamiento-1;
        }

        private void queryMedico(string queryMedico)
        {
            sqlConnection.Open();
            SqlCommand command= new SqlCommand(queryMedico, sqlConnection);
            SqlDataReader rows= command.ExecuteReader();
            while (rows.Read())
            {
                cbNoDo.Items.Add(rows["Nombre"].ToString() + ", " + rows["Apellido"].ToString());
            }
            sqlConnection.Close();
        }
        private void queryPaciente(string queryPaciente)
        {
            sqlConnection.Open();
            SqlCommand command= new SqlCommand(queryPaciente, sqlConnection);
            SqlDataReader rows= command.ExecuteReader();
            while (rows.Read())
            {
                cbNoPa.Items.Add(rows["Nombre"].ToString() + ", " + rows["Apellido"].ToString());
            }
            sqlConnection.Close();
        }
        private void queryEnfermedad(string queryEnfermedad)
        {
            sqlConnection.Open();
            SqlCommand command= new SqlCommand(queryEnfermedad, sqlConnection);
            SqlDataReader rows= command.ExecuteReader();
            while (rows.Read())
            {
                cbNoEn.Items.Add(rows["Nombre"].ToString());
            }
            sqlConnection.Close();
        }
        private void queryTratamiento(string queryTratamiento)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(queryTratamiento, sqlConnection);
            SqlDataReader rows = command.ExecuteReader();
            while (rows.Read())
            {
                cbTrat.Items.Add(rows["Nombre"].ToString());
            }
            sqlConnection.Close();
        }

        private void makeQuery()
        {
            string query = "UPDATE Citas SET [Fecha]=" + dtpCita.Value.ToString("yyyy-mm-dd")+
                ", [Id_Medico]="+(cbNoDo.SelectedIndex+1)+
                ", [Id_Paciente]="+(cbNoPa.SelectedIndex+1)+
                ", [Id_Enfermedad]="+(cbNoEn.SelectedIndex+1)+
                ", [Id_Tratamiento]="+(cbTrat.SelectedIndex+1)+
                ", [CostoTotalCita]="+float.Parse(tbcosto.Text)+
                "WHERE Id_Citas="+(cbCita.SelectedIndex)+1;
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int com=command.ExecuteNonQuery();
            if (com == 1)
                MessageBox.Show("Ha actualizado los datos satisfactoriamente.", "Datos actulizados", MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Los datos no pudieron ser actualizados, intentelo de nuevo más tarde.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

            sqlConnection.Close();
        }

        private void btnComm_Click(object sender, EventArgs e)
        {
            makeQuery();
        }

        private void dtpCita_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
