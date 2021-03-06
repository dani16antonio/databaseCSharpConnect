﻿using System;
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
    public partial class EdadPromedio : Form
    {
        Form f1;
        private SqlConnection sqlConnection;
        public EdadPromedio(Form form1)
        {
            InitializeComponent();
            f1 = form1;
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
        }

        private void EdadPromedio_Load(object sender, EventArgs e)
        {
            var select =
                "SELECT avg(DATEDIFF(YEAR,p.Fecha_Nacimiento, GETDATE() )) Edad FROM dbo.Enfermedad_X_Paciente ep INNER JOIN dbo.Paciente p ON ep.Id_Paciente = p.Seguro_Social INNER JOIN dbo.Enfermedad e ON ep.Id_Enfermedad = e.Id_Enfermedad WHERE e.Sistema = 'Circulatorio'";
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
