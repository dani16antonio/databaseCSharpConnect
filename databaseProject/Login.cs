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
    public partial class Login : Form
    {
        SqlConnection sqlConnection;
        public Login()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(@"Data Source=(local);
                                                            Initial Catalog=CITAS_SPACEMONKEYS;
                                                            Integrated Security=true;");
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
            sqlConnection.Close();
            if (dataReader.Read())
            {
                new Form1();
                this.Close();
            }
            else
            {
                MessageBox.Show("Parece que el usuario o la contraseña están incorrectos", "¡Vaya!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}