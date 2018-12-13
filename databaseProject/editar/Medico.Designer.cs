namespace databaseProject.editar
{
    partial class Medico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRetu = new System.Windows.Forms.Button();
            this.btnEras = new System.Windows.Forms.Button();
            this.btnComm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUniv = new System.Windows.Forms.ComboBox();
            this.cbCont = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMedi = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetu
            // 
            this.btnRetu.Location = new System.Drawing.Point(428, 86);
            this.btnRetu.Name = "btnRetu";
            this.btnRetu.Size = new System.Drawing.Size(75, 23);
            this.btnRetu.TabIndex = 32;
            this.btnRetu.Text = "Regresar";
            this.btnRetu.UseVisualStyleBackColor = true;
            this.btnRetu.Click += new System.EventHandler(this.btnRetu_Click);
            // 
            // btnEras
            // 
            this.btnEras.Location = new System.Drawing.Point(428, 48);
            this.btnEras.Name = "btnEras";
            this.btnEras.Size = new System.Drawing.Size(75, 23);
            this.btnEras.TabIndex = 31;
            this.btnEras.Text = "Borrar todo";
            this.btnEras.UseVisualStyleBackColor = true;
            this.btnEras.Click += new System.EventHandler(this.btnEras_Click);
            // 
            // btnComm
            // 
            this.btnComm.Location = new System.Drawing.Point(428, 12);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(75, 23);
            this.btnComm.TabIndex = 30;
            this.btnComm.Text = "Registrar";
            this.btnComm.UseVisualStyleBackColor = true;
            this.btnComm.Click += new System.EventHandler(this.btnComm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUniv);
            this.groupBox1.Controls.Add(this.cbCont);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpBorn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbDire);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbLast);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 233);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médico";
            // 
            // cbUniv
            // 
            this.cbUniv.FormattingEnabled = true;
            this.cbUniv.Location = new System.Drawing.Point(144, 136);
            this.cbUniv.Name = "cbUniv";
            this.cbUniv.Size = new System.Drawing.Size(121, 21);
            this.cbUniv.TabIndex = 51;
            // 
            // cbCont
            // 
            this.cbCont.Location = new System.Drawing.Point(144, 203);
            this.cbCont.Name = "cbCont";
            this.cbCont.Size = new System.Drawing.Size(121, 21);
            this.cbCont.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Contrato";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(144, 174);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(200, 20);
            this.dtpBorn.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Fecha de nac";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Universidad";
            // 
            // tbDire
            // 
            this.tbDire.Location = new System.Drawing.Point(147, 103);
            this.tbDire.Name = "tbDire";
            this.tbDire.Size = new System.Drawing.Size(100, 20);
            this.tbDire.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Dirección";
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(147, 63);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Apellido";
            // 
            // tbNam
            // 
            this.tbNam.Location = new System.Drawing.Point(147, 28);
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(100, 20);
            this.tbNam.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Médico";
            // 
            // cbMedi
            // 
            this.cbMedi.FormattingEnabled = true;
            this.cbMedi.Location = new System.Drawing.Point(60, 19);
            this.cbMedi.Name = "cbMedi";
            this.cbMedi.Size = new System.Drawing.Size(121, 21);
            this.cbMedi.TabIndex = 35;
            this.cbMedi.SelectedIndexChanged += new System.EventHandler(this.cbMedi_SelectedIndexChanged);
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 326);
            this.Controls.Add(this.cbMedi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRetu);
            this.Controls.Add(this.btnEras);
            this.Controls.Add(this.btnComm);
            this.Name = "Medico";
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.Medico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRetu;
        private System.Windows.Forms.Button btnEras;
        private System.Windows.Forms.Button btnComm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCont;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMedi;
        private System.Windows.Forms.ComboBox cbUniv;
    }
}