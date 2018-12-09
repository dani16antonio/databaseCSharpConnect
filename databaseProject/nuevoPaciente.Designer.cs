namespace databaseProject
{
    partial class nuevoPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoci = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDirec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRetu = new System.Windows.Forms.Button();
            this.btnEras = new System.Windows.Forms.Button();
            this.btnComm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seguro";
            // 
            // tbSoci
            // 
            this.tbSoci.Location = new System.Drawing.Point(162, 33);
            this.tbSoci.Name = "tbSoci";
            this.tbSoci.Size = new System.Drawing.Size(100, 20);
            this.tbSoci.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(162, 69);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(162, 104);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(100, 20);
            this.tbLast.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // tbDirec
            // 
            this.tbDirec.Location = new System.Drawing.Point(162, 144);
            this.tbDirec.Name = "tbDirec";
            this.tbDirec.Size = new System.Drawing.Size(100, 20);
            this.tbDirec.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(162, 183);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(200, 20);
            this.dtpBorn.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de nac.";
            // 
            // btnRetu
            // 
            this.btnRetu.Location = new System.Drawing.Point(360, 110);
            this.btnRetu.Name = "btnRetu";
            this.btnRetu.Size = new System.Drawing.Size(75, 23);
            this.btnRetu.TabIndex = 8;
            this.btnRetu.Text = "Regresar";
            this.btnRetu.UseVisualStyleBackColor = true;
            this.btnRetu.Click += new System.EventHandler(this.btnRetu_Click);
            // 
            // btnEras
            // 
            this.btnEras.Location = new System.Drawing.Point(360, 72);
            this.btnEras.Name = "btnEras";
            this.btnEras.Size = new System.Drawing.Size(75, 23);
            this.btnEras.TabIndex = 7;
            this.btnEras.Text = "Borrar todo";
            this.btnEras.UseVisualStyleBackColor = true;
            this.btnEras.Click += new System.EventHandler(this.btnEras_Click);
            // 
            // btnComm
            // 
            this.btnComm.Location = new System.Drawing.Point(360, 36);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(75, 23);
            this.btnComm.TabIndex = 6;
            this.btnComm.Text = "Registrar";
            this.btnComm.UseVisualStyleBackColor = true;
            // 
            // nuevoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 250);
            this.Controls.Add(this.btnRetu);
            this.Controls.Add(this.btnEras);
            this.Controls.Add(this.btnComm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpBorn);
            this.Controls.Add(this.tbDirec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSoci);
            this.Controls.Add(this.label1);
            this.Name = "nuevoPaciente";
            this.Text = "nuevo paciente";
            this.Load += new System.EventHandler(this.nuevoPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoci;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDirec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRetu;
        private System.Windows.Forms.Button btnEras;
        private System.Windows.Forms.Button btnComm;
    }
}