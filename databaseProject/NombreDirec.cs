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
    public partial class NombreDirec : Form
    {
        Form f1;
        private SqlConnection sqlConnection;
        public NombreDirec(Form form1)
        {
            InitializeComponent();
            f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void NombreDirec_Load(object sender, EventArgs e)
        {
            var select =
                "SELECT (m.Nombre + ' ' + m.Apellido) Nombre_Doctor, (pa.Nombre + ' ' + pa.Apellido) Nombre_Paciente, pa.Direccion FROM dbo.Paciente_X_Medico p INNER JOIN dbo.Medico m ON p.Id_Medico = m.Id_Medico INNER JOIN dbo.Paciente pa ON p.Id_Paciente = pa.Seguro_Social GROUP BY p.Id_Medico, (m.Nombre + ' ' + m.Apellido), (pa.Nombre + ' ' + pa.Apellido), pa.Direccion";
            var dataAdapter = new SqlDataAdapter(select, sqlConnection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_retu_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }
    }
}
