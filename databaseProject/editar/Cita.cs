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
        }

        private void btnRetu_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void cbCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nombreDoc = 0, nombrePac = 0, NombreEn = 0, tratamiento = 0;
            string query = "select Citas.Id_Citas[id_cita],Citas.Fecha[fecha_cita], Citas.Id_Medico[id_medico]" +
                ",Citas.Id_Paciente[id_paciente],Citas.Id_Tratamiento[tratamiento_id]," +
                "Paciente.Seguro_Social[paciente_seguro],Paciente.Nombre[paciente_nombe], " +
                "Paciente.Apellido[paciente_apellido],Medico.Nombre[medico_nombre],Medico.Apellido[medico_apellido]" +
                ",Tratamiento.Nombre[tratamiento_nombre],Enfermedad.Nombre[enfermedad_nombre] " +
                "from Citas inner join Paciente on Citas.Id_Paciente = Paciente.Seguro_Social inner join " +
                "Tratamiento on Citas.Id_Tratamiento = Tratamiento.Id_Tratamiento inner join Medico on" +
                " Citas.Id_Medico = Medico.Id_Medico inner join Enfermedad  on Citas.Id_Enfermedad=Enfermedad.Id_Enfermedad";
            id_medico = cbCita.SelectedIndex;
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = command.ExecuteReader();
            List<string> doctor = new List<string>();
            List<string> Paciente = new List<string>();
            List<string> Enfermedad = new List<string>();
            List<string> Tratamiento = new List<string>();
            List<DateTime> fecha = new List<DateTime>();

            while (rows.Read())
            {
                if (!doctor.Contains(rows["medico_nombre"].ToString() + "," + rows["medico_apellido"].ToString()))
                    doctor.Add(rows["medico_nombre"].ToString() + "," + rows["medico_apellido"].ToString());
                if (!Paciente.Contains(rows["paciente_nombe"].ToString() + "," + rows["paciente_apellido"].ToString()))
                    Paciente.Add(rows["paciente_nombe"].ToString() + "," + rows["paciente_apellido"].ToString());
                if (!Enfermedad.Contains(rows["enfermedad_nombre"].ToString()))
                    Enfermedad.Add(rows["enfermedad_nombre"].ToString());
                if (!Tratamiento.Contains(rows["tratamiento_nombre"].ToString()))
                    Tratamiento.Add(rows["tratamiento_nombre"].ToString());
                if (!fecha.Contains(DateTime.Parse(rows["fecha_cita"].ToString())))
                    fecha.Add(DateTime.Parse(rows["fecha_cita"].ToString()));
            }
            clearComboBox();
            foreach (string x in doctor)
                cbNoDo.Items.Add(x);
            foreach (string x in Paciente)
                cbNoPa.Items.Add(x);
            foreach (string x in Enfermedad)
                cbNoEn.Items.Add(x);
            foreach (string x in Tratamiento)
                cbTrat.Items.Add(x);
            sqlConnection.Close();
            string query1 = "select Citas.Id_Citas[id_cita],Citas.Fecha[fecha_cita], Citas.Id_Medico[id_medico]" +
                ",Citas.Id_Paciente[id_paciente],Citas.Id_Tratamiento[tratamiento_id], Citas.CostoTotalCita[CostoTotalCita]," +
                "Paciente.Seguro_Social[paciente_seguro],Paciente.Nombre[paciente_nombe], " +
                "Paciente.Apellido[paciente_apellido],Medico.Nombre[medico_nombre],Medico.Apellido[medico_apellido]" +
                ",Tratamiento.Nombre[tratamiento_nombre],Enfermedad.Id_Enfermedad[Id_Enfermedad],Enfermedad.Nombre[enfermedad_nombre] " +
                "from Citas inner join Paciente on Citas.Id_Paciente = Paciente.Seguro_Social inner join " +
                "Tratamiento on Citas.Id_Tratamiento = Tratamiento.Id_Tratamiento inner join Medico on" +
                " Citas.Id_Medico = Medico.Id_Medico inner join Enfermedad  on Citas.Id_Enfermedad=Enfermedad.Id_Enfermedad where Id_Citas=" + id_medico + 1;
            sqlConnection.Open();
            SqlCommand command1 = new SqlCommand(query1, sqlConnection);
            SqlDataReader rows1 = command1.ExecuteReader();
            if(rows1.Read())
            {
                dtpCita.Value = DateTime.Parse(rows1["fecha_cita"].ToString());
                cbNoDo.SelectedIndex = int.Parse(rows1["Id_medico"].ToString())-1;
                cbNoEn.SelectedIndex = int.Parse(rows1["Id_Enfermedad"].ToString()) - 1;
                cbNoPa.SelectedIndex = int.Parse(rows1["Id_Paciente"].ToString()) - 1;
                cbTrat.SelectedIndex = int.Parse(rows1["tratamiento_id"].ToString()) - 1;
                tbcosto.Text = rows1["CostoTotalCita"].ToString();
            }
            sqlConnection.Close();
           
        }

        private void clearComboBox()
        {
            cbNoDo.Items.Clear();
            cbNoEn.Items.Clear();
            cbNoPa.Items.Clear();
            cbTrat.Items.Clear();
        }

        private void makeQuery()
        {
            string query = "UPDATE Citas SET [Fecha]=" + dtpCita.Value.ToString("yyyy-mm-dd")+
                ", [Id_Medico]="+(cbNoDo.SelectedIndex+1)+
                ", [Id_Paciente]="+(cbNoPa.SelectedIndex+1)+
                ", [Id_Enfermedad]="+(cbNoEn.SelectedIndex+1)+
                ", [Id_Tratamiento]="+(cbTrat.SelectedIndex+1)+
                ", [CostoTotalCita]="+float.Parse(tbcosto.Text)+
                "WHERE Id_Citas="+id_medico+1;
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
    }
}
