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
    public partial class Login : Form
    {
        SqlConnection sqlConnection;
        public Login()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
            tbPass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario,contraseña;
            usuario = tbUser.Text;
            contraseña = tbPass.Text;
            string query = "SELECT Usuario from dbo.Usuario WHERE Contraseña='"+contraseña+"' and Usuario='"+usuario+"'";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                this.Hide();
                new Form1(this).ShowDialog();
            }
            else
            {
                MessageBox.Show("Parece que el usuario o la contraseña están incorrectos", "¡Vaya!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Presentacion(this).ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbUser.Text = "El gran usuario";
            tbPass.Text = "La pequeña";
            // TODO eraser those 2 line of code, please... do it...
        }
    }
}
