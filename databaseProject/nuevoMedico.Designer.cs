namespace databaseProject
{
    partial class nuevoMedico
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbDire = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnComm = new System.Windows.Forms.Button();
            this.btnEras = new System.Windows.Forms.Button();
            this.btnRetu = new System.Windows.Forms.Button();
            this.btnUniv = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Universidad";
            // 
            // tbDire
            // 
            this.tbDire.Location = new System.Drawing.Point(146, 104);
            this.tbDire.Name = "tbDire";
            this.tbDire.Size = new System.Drawing.Size(100, 20);
            this.tbDire.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dirección";
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(146, 64);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido";
            // 
            // tbNam
            // 
            this.tbNam.Location = new System.Drawing.Point(146, 29);
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(100, 20);
            this.tbNam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha de nac";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(143, 175);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(200, 20);
            this.dtpBorn.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Contrato";
            // 
            // btnComm
            // 
            this.btnComm.Location = new System.Drawing.Point(414, 24);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(75, 23);
            this.btnComm.TabIndex = 8;
            this.btnComm.Text = "Registrar";
            this.btnComm.UseVisualStyleBackColor = true;
            this.btnComm.Click += new System.EventHandler(this.btnComm_Click);
            // 
            // btnEras
            // 
            this.btnEras.Location = new System.Drawing.Point(414, 60);
            this.btnEras.Name = "btnEras";
            this.btnEras.Size = new System.Drawing.Size(75, 23);
            this.btnEras.TabIndex = 9;
            this.btnEras.Text = "Borrar todo";
            this.btnEras.UseVisualStyleBackColor = true;
            this.btnEras.Click += new System.EventHandler(this.btnEras_Click);
            // 
            // btnRetu
            // 
            this.btnRetu.Location = new System.Drawing.Point(414, 98);
            this.btnRetu.Name = "btnRetu";
            this.btnRetu.Size = new System.Drawing.Size(75, 23);
            this.btnRetu.TabIndex = 10;
            this.btnRetu.Text = "Regresar";
            this.btnRetu.UseVisualStyleBackColor = true;
            this.btnRetu.Click += new System.EventHandler(this.btnRetu_Click);
            // 
            // btnUniv
            // 
            this.btnUniv.Location = new System.Drawing.Point(146, 135);
            this.btnUniv.Name = "btnUniv";
            this.btnUniv.Size = new System.Drawing.Size(75, 23);
            this.btnUniv.TabIndex = 24;
            this.btnUniv.Text = "Seleccionar";
            this.btnUniv.UseVisualStyleBackColor = true;
            this.btnUniv.Click += new System.EventHandler(this.btnUniv_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(143, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nuevoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 289);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUniv);
            this.Controls.Add(this.btnRetu);
            this.Controls.Add(this.btnEras);
            this.Controls.Add(this.btnComm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpBorn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNam);
            this.Controls.Add(this.label2);
            this.Name = "nuevoMedico";
            this.Text = "nuevo medico";
            this.Load += new System.EventHandler(this.nuevoMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnComm;
        private System.Windows.Forms.Button btnEras;
        private System.Windows.Forms.Button btnRetu;
        private System.Windows.Forms.Button btnUniv;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}