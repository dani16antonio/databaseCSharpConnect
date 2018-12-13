namespace databaseProject.editar
{
    partial class Enfermedad
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
            this.tbSyst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComm = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbSyst
            // 
            this.tbSyst.Location = new System.Drawing.Point(109, 84);
            this.tbSyst.Name = "tbSyst";
            this.tbSyst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSyst.Size = new System.Drawing.Size(100, 20);
            this.tbSyst.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(109, 116);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(123, 54);
            this.tbDesc.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Descripción";
            // 
            // btnComm
            // 
            this.btnComm.Location = new System.Drawing.Point(379, 36);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(75, 23);
            this.btnComm.TabIndex = 26;
            this.btnComm.Text = "Registrar";
            this.btnComm.UseVisualStyleBackColor = true;
            this.btnComm.Click += new System.EventHandler(this.btnComm_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(379, 84);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(109, 38);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 28;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // Enfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 203);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.btnComm);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbSyst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label1);
            this.Name = "Enfermedad";
            this.Text = "Enfermedad";
            this.Load += new System.EventHandler(this.Enfermedad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSyst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComm;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cbName;
    }
}