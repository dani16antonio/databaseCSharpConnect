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
    public partial class ReportePacient : Form
    {
        Form f1;
        private SqlConnection sqlConnection;
        public ReportePacient(Form form1)
        {
            InitializeComponent();
            f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void ReportePacient_Load(object sender, EventArgs e)
        {
            var select =
                "SELECT (m.Apellido + ' ' + m.Nombre) Nombre_Doctor, m.Id_Medico Codigo, m.Direccion Direccion, (p.Apellido + ' ' + p.Nombre) Nombre_Paciente, p.Numero_Historial Numero_de_Historial FROM dbo.Paciente_X_Medico pm INNER JOIN dbo.Medico m ON pm.Id_Medico = m.Id_Medico INNER JOIN dbo.Paciente p ON pm.Id_Paciente = p.Seguro_Social GROUP BY  pm.Id_Medico, (m.Apellido + ' ' + m.Nombre), m.Id_Medico, m.Direccion, (p.Apellido + ' ' + p.Nombre), p.Numero_Historial";
            var dataAdapter = new SqlDataAdapter(select, sqlConnection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

            var select1 =
                "SELECT e.Nombre Nombre_Enfermedad, (p.Apellido + ' ' + p.Nombre) Nombre_Paciente, p.Numero_Historial Numero_de_Historial FROM dbo.Enfermedad_X_Paciente ep INNER JOIN dbo.Enfermedad e  ON ep.Id_Enfermedad = e.Id_Enfermedad INNER JOIN dbo.Paciente p ON ep.Id_Paciente = p.Seguro_Social	GROUP BY  ep.Id_Enfermedad, e.Nombre, (p.Apellido + ' ' + p.Nombre), p.Numero_Historial";
            var dataAdapter1 = new SqlDataAdapter(select1, sqlConnection);

            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = ds1.Tables[0];
        }

        private void btn_retu_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }
    }
}
