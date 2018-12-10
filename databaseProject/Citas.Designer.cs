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
            this.SuspendLayout();
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Location = new System.Drawing.Point(57, 36);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxM.TabIndex = 0;
            this.comboBoxM.SelectedIndexChanged += new System.EventHandler(this.comboBoxM_SelectedIndexChanged);
            // 
            // comboBoxP
            // 
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Location = new System.Drawing.Point(57, 79);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxP.TabIndex = 1;
            this.comboBoxP.SelectedIndexChanged += new System.EventHandler(this.comboBoxP_SelectedIndexChanged);
            // 
            // comboBoxE
            // 
            this.comboBoxE.FormattingEnabled = true;
            this.comboBoxE.Location = new System.Drawing.Point(57, 116);
            this.comboBoxE.Name = "comboBoxE";
            this.comboBoxE.Size = new System.Drawing.Size(121, 21);
            this.comboBoxE.TabIndex = 2;
            this.comboBoxE.SelectedIndexChanged += new System.EventHandler(this.comboBoxE_SelectedIndexChanged);
            // 
            // dtpBorn
            // 
            this.dtpBorn.Location = new System.Drawing.Point(57, 160);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(200, 20);
            this.dtpBorn.TabIndex = 7;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(532, 248);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Regresar";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbcosto
            // 
            this.tbcosto.Location = new System.Drawing.Point(57, 239);
            this.tbcosto.Name = "tbcosto";
            this.tbcosto.Size = new System.Drawing.Size(121, 20);
            this.tbcosto.TabIndex = 11;
            // 
            // btnregistrarcita
            // 
            this.btnregistrarcita.Location = new System.Drawing.Point(532, 12);
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
            this.comboBoxT.Location = new System.Drawing.Point(57, 203);
            this.comboBoxT.Name = "comboBoxT";
            this.comboBoxT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxT.TabIndex = 13;
            this.comboBoxT.SelectedIndexChanged += new System.EventHandler(this.comboBoxT_SelectedIndexChanged);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 283);
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
    }
}