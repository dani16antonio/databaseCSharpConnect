namespace databaseProject
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNomApeNumEnf = new System.Windows.Forms.Button();
            this.btnMedEdad = new System.Windows.Forms.Button();
            this.btnListEnfXPac = new System.Windows.Forms.Button();
            this.btnEdadProm = new System.Windows.Forms.Button();
            this.btnPacXMed = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnf = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnPac = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRepo = new System.Windows.Forms.Button();
            this.btnReEn = new System.Windows.Forms.Button();
            this.btnRePa = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRePa);
            this.groupBox2.Controls.Add(this.btnReEn);
            this.groupBox2.Controls.Add(this.btnRepo);
            this.groupBox2.Controls.Add(this.btnNomApeNumEnf);
            this.groupBox2.Controls.Add(this.btnMedEdad);
            this.groupBox2.Controls.Add(this.btnListEnfXPac);
            this.groupBox2.Controls.Add(this.btnEdadProm);
            this.groupBox2.Controls.Add(this.btnPacXMed);
            this.groupBox2.Location = new System.Drawing.Point(236, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 199);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas";
            // 
            // btnNomApeNumEnf
            // 
            this.btnNomApeNumEnf.Location = new System.Drawing.Point(20, 170);
            this.btnNomApeNumEnf.Name = "btnNomApeNumEnf";
            this.btnNomApeNumEnf.Size = new System.Drawing.Size(116, 23);
            this.btnNomApeNumEnf.TabIndex = 6;
            this.btnNomApeNumEnf.Text = "No. Enfermedades";
            this.btnNomApeNumEnf.UseVisualStyleBackColor = true;
            this.btnNomApeNumEnf.MouseHover += new System.EventHandler(this.btnNomApeNumEnf_MouseHover);
            // 
            // btnMedEdad
            // 
            this.btnMedEdad.Location = new System.Drawing.Point(20, 133);
            this.btnMedEdad.Name = "btnMedEdad";
            this.btnMedEdad.Size = new System.Drawing.Size(116, 23);
            this.btnMedEdad.TabIndex = 5;
            this.btnMedEdad.Text = "No. Medico por edad";
            this.btnMedEdad.UseVisualStyleBackColor = true;
            this.btnMedEdad.MouseHover += new System.EventHandler(this.btnMedEdad_MouseHover);
            // 
            // btnListEnfXPac
            // 
            this.btnListEnfXPac.Location = new System.Drawing.Point(20, 98);
            this.btnListEnfXPac.Name = "btnListEnfXPac";
            this.btnListEnfXPac.Size = new System.Drawing.Size(116, 23);
            this.btnListEnfXPac.TabIndex = 4;
            this.btnListEnfXPac.Text = "Lista de enferm.";
            this.btnListEnfXPac.UseVisualStyleBackColor = true;
            this.btnListEnfXPac.MouseHover += new System.EventHandler(this.btnListEnfXPac_MouseHover);
            // 
            // btnEdadProm
            // 
            this.btnEdadProm.Location = new System.Drawing.Point(20, 57);
            this.btnEdadProm.Name = "btnEdadProm";
            this.btnEdadProm.Size = new System.Drawing.Size(116, 23);
            this.btnEdadProm.TabIndex = 3;
            this.btnEdadProm.Text = "Edad promedio";
            this.btnEdadProm.UseVisualStyleBackColor = true;
            this.btnEdadProm.Click += new System.EventHandler(this.btnEdadProm_Click);
            this.btnEdadProm.MouseHover += new System.EventHandler(this.btnEdadProm_MouseHover);
            // 
            // btnPacXMed
            // 
            this.btnPacXMed.Location = new System.Drawing.Point(20, 19);
            this.btnPacXMed.Name = "btnPacXMed";
            this.btnPacXMed.Size = new System.Drawing.Size(116, 23);
            this.btnPacXMed.TabIndex = 2;
            this.btnPacXMed.Text = "No. Pacientes";
            this.btnPacXMed.UseVisualStyleBackColor = true;
            this.btnPacXMed.Click += new System.EventHandler(this.btnPacXMed_Click);
            this.btnPacXMed.MouseHover += new System.EventHandler(this.btnPacXMed_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEnf);
            this.groupBox3.Controls.Add(this.btnMed);
            this.groupBox3.Controls.Add(this.btnPac);
            this.groupBox3.Location = new System.Drawing.Point(12, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 156);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo";
            // 
            // btnEnf
            // 
            this.btnEnf.Location = new System.Drawing.Point(18, 115);
            this.btnEnf.Name = "btnEnf";
            this.btnEnf.Size = new System.Drawing.Size(116, 23);
            this.btnEnf.TabIndex = 2;
            this.btnEnf.Text = "Enfermedad";
            this.btnEnf.UseVisualStyleBackColor = true;
            this.btnEnf.Click += new System.EventHandler(this.btnEnf_Click);
            // 
            // btnMed
            // 
            this.btnMed.Location = new System.Drawing.Point(17, 67);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(116, 23);
            this.btnMed.TabIndex = 1;
            this.btnMed.Text = "Médico";
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnPac
            // 
            this.btnPac.Location = new System.Drawing.Point(18, 19);
            this.btnPac.Name = "btnPac";
            this.btnPac.Size = new System.Drawing.Size(116, 23);
            this.btnPac.TabIndex = 0;
            this.btnPac.Text = "Paciente";
            this.btnPac.UseVisualStyleBackColor = true;
            this.btnPac.Click += new System.EventHandler(this.btnPac_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(502, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRepo
            // 
            this.btnRepo.Location = new System.Drawing.Point(142, 19);
            this.btnRepo.Name = "btnRepo";
            this.btnRepo.Size = new System.Drawing.Size(116, 23);
            this.btnRepo.TabIndex = 7;
            this.btnRepo.Text = "Reporte medi.";
            this.btnRepo.UseVisualStyleBackColor = true;
            this.btnRepo.Click += new System.EventHandler(this.btnRepo_Click);
            this.btnRepo.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnReEn
            // 
            this.btnReEn.Location = new System.Drawing.Point(144, 98);
            this.btnReEn.Name = "btnReEn";
            this.btnReEn.Size = new System.Drawing.Size(116, 23);
            this.btnReEn.TabIndex = 8;
            this.btnReEn.Text = "Reporte enferm.";
            this.btnReEn.UseVisualStyleBackColor = true;
            this.btnReEn.Click += new System.EventHandler(this.btnReEn_Click);
            this.btnReEn.MouseHover += new System.EventHandler(this.btnReEn_MouseHover);
            // 
            // btnRePa
            // 
            this.btnRePa.Location = new System.Drawing.Point(142, 170);
            this.btnRePa.Name = "btnRePa";
            this.btnRePa.Size = new System.Drawing.Size(116, 23);
            this.btnRePa.TabIndex = 9;
            this.btnRePa.Text = "Reporte pacient.";
            this.btnRePa.UseVisualStyleBackColor = true;
            this.btnRePa.Click += new System.EventHandler(this.btnRePa_Click);
            this.btnRePa.MouseHover += new System.EventHandler(this.button1_MouseHover_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(589, 249);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNomApeNumEnf;
        private System.Windows.Forms.Button btnMedEdad;
        private System.Windows.Forms.Button btnListEnfXPac;
        private System.Windows.Forms.Button btnEdadProm;
        private System.Windows.Forms.Button btnPacXMed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEnf;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnPac;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRepo;
        private System.Windows.Forms.Button btnReEn;
        private System.Windows.Forms.Button btnRePa;
    }
}

