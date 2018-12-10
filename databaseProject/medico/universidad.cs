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

namespace databaseProject.medico
{
    public partial class universidad : Form
    {
        Form f1;
        private SqlConnection sqlConnection;
        public universidad(Form form1)
        {
            InitializeComponent();
            f1 = form1;
            updateListBox();
        }

        private void updateListBox()
        {
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
            sqlConnection.Open();
            string query = "SELECT Nombre FROM Universidad";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader rows = sqlCommand.ExecuteReader();
            ListViewItem item = new ListViewItem();
            while (rows.Read())
            {
                lbUniv.Items.Add(rows["Nombre"]);
            }
            sqlConnection.Close();
        }

        private void btnUniv_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRetu_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
        }

        private void lbUniv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index =lbUniv.SelectedIndex;
        }
    }
}
