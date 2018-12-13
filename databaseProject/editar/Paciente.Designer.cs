namespace databaseProject.editar
{
    partial class Paciente
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
            this.tbNoHi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRetu = new System.Windows.Forms.Button();
            this.btnComm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.tbDirec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPaci = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNoHi
            // 
            this.tbNoHi.Location = new System.Drawing.Point(96, 178);
            this.tbNoHi.Name = "tbNoHi";
            this.tbNoHi.Size = new System.Drawing.Size(100, 20);
            this.tbNoHi.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "No. Historial";
            // 
            // btnRetu
            // 
            this.btnRetu.Location = new System.Drawing.Point(315, 56);
            this.btnRetu.Name = "btnRetu";
            this.btnRetu.Size = new System.Drawing.Size(75, 23);
            this.btnRetu.TabIndex = 24;
            this.btnRetu.Text = "Regresar";
            this.btnRetu.UseVisualStyleBackColor = true;
            this.btnRetu.Click += new System.EventHandler(this.btnRetu_Click);
            // 
            // btnComm
            // 
            this.btnComm.Location = new System.Drawing.Point(315, 27);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(75, 23);
            this.btnComm.TabIndex = 22;
            this.btnComm.Text = "Registrar";
            this.btnComm.UseVisualStyleBackColor = true;
            this.btnComm.Click += new System.EventHandler(this.btnComm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fecha de nac.";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(96, 208);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(200, 20);
            this.dtpBorn.TabIndex = 20;
            // 
            // tbDirec
            // 
            this.tbDirec.Location = new System.Drawing.Point(96, 131);
            this.tbDirec.Multiline = true;
            this.tbDirec.Name = "tbDirec";
            this.tbDirec.Size = new System.Drawing.Size(100, 41);
            this.tbDirec.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dirección";
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(96, 105);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(96, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // cbPaci
            // 
            this.cbPaci.FormattingEnabled = true;
            this.cbPaci.Location = new System.Drawing.Point(75, 17);
            this.cbPaci.Name = "cbPaci";
            this.cbPaci.Size = new System.Drawing.Size(121, 21);
            this.cbPaci.TabIndex = 27;
            this.cbPaci.SelectedIndexChanged += new System.EventHandler(this.cbPaci_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Paciente";
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 247);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPaci);
            this.Controls.Add(this.tbNoHi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRetu);
            this.Controls.Add(this.btnComm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBorn);
            this.Controls.Add(this.tbDirec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNoHi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRetu;
        private System.Windows.Forms.Button btnComm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.TextBox tbDirec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPaci;
        private System.Windows.Forms.Label label7;
    }
}