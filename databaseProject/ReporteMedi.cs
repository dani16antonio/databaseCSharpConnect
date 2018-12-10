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
    public partial class ReporteMedi : Form
    {
        Form f1;
        private SqlConnection sqlConnection;
        public ReporteMedi(Form form1)
        {
            InitializeComponent();
            f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void ReporteMedi_Load(object sender, EventArgs e)
        {
            var select =
                "SELECT (m.Nombre + ' ' + m.Apellido) Nombre_Doctor, m.Id_Medico Codigo, m.Direccion Direccion, t.Tipo_de_Contratacion Contrato, u.Nombre Universidad FROM dbo.Medico m INNER JOIN dbo.Universidad u ON u.Id_Universidad = m.Id_Universidad INNER JOIN dbo.TipoContratacion t ON t.Id_Tipo_Contratacion = m.Id_Tipo_Contratacion ORDER BY (m.Nombre + ' ' + m.Apellido), m.Id_Medico,  m.Direccion, t.Tipo_de_Contratacion, u.Nombre asc";
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
