using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseProject
{
    public partial class nuevaEnfermedad : Form
    {
        Form f1;
        public nuevaEnfermedad(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.label3, "Sistema corporal afectado.");
        }
    }
}
