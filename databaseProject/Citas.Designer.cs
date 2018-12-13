namespace databaseProject
{
    partial class Citas
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
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.comboBoxE = new System.Windows.Forms.ComboBox();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.btnback = new System.Windows.Forms.Button();
            this.tbcosto = new System.Windows.Forms.TextBox();
            this.btnregistrarcita = new System.Windows.Forms.Button();
            this.comboBoxT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Location = new System.Drawing.Point(164, 24);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxM.TabIndex = 0;
            this.comboBoxM.SelectedIndexChanged += new System.EventHandler(this.comboBoxM_SelectedIndexChanged);
            // 
            // comboBoxP
            // 
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Location = new System.Drawing.Point(164, 67);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxP.TabIndex = 1;
            this.comboBoxP.SelectedIndexChanged += new System.EventHandler(this.comboBoxP_SelectedIndexChanged);
            // 
            // comboBoxE
            // 
            this.comboBoxE.FormattingEnabled = true;
            this.comboBoxE.Location = new System.Drawing.Point(164, 104);
            this.comboBoxE.Name = "comboBoxE";
            this.comboBoxE.Size = new System.Drawing.Size(121, 21);
            this.comboBoxE.TabIndex = 2;
            this.comboBoxE.SelectedIndexChanged += new System.EventHandler(this.comboBoxE_SelectedIndexChanged);
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(164, 148);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(200, 20);
            this.dtpBorn.TabIndex = 7;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(383, 41);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbcosto
            // 
            this.tbcosto.Location = new System.Drawing.Point(164, 227);
            this.tbcosto.Name = "tbcosto";
            this.tbcosto.Size = new System.Drawing.Size(121, 20);
            this.tbcosto.TabIndex = 11;
            // 
            // btnregistrarcita
            // 
            this.btnregistrarcita.Location = new System.Drawing.Point(383, 12);
            this.btnregistrarcita.Name = "btnregistrarcita";
            this.btnregistrarcita.Size = new System.Drawing.Size(75, 23);
            this.btnregistrarcita.TabIndex = 12;
            this.btnregistrarcita.Text = "Registrar";
            this.btnregistrarcita.UseVisualStyleBackColor = true;
            this.btnregistrarcita.Click += new System.EventHandler(this.btnregistrarcita_Click);
            // 
            // comboBoxT
            // 
            this.comboBoxT.FormattingEnabled = true;
            this.comboBoxT.Location = new System.Drawing.Point(164, 191);
            this.comboBoxT.Name = "comboBoxT";
            this.comboBoxT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxT.TabIndex = 13;
            this.comboBoxT.SelectedIndexChanged += new System.EventHandler(this.comboBoxT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre del doctor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre del paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre del la enfermedad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha para la cita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tratamiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio";
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 283);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxT);
            this.Controls.Add(this.btnregistrarcita);
            this.Controls.Add(this.tbcosto);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dtpBorn);
            this.Controls.Add(this.comboBoxE);
            this.Controls.Add(this.comboBoxP);
            this.Controls.Add(this.comboBoxM);
            this.Name = "Citas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.ComboBox comboBoxE;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox tbcosto;
        private System.Windows.Forms.Button btnregistrarcita;
        private System.Windows.Forms.ComboBox comboBoxT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}