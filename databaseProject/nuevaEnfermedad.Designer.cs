namespace databaseProject
{
    partial class nuevaEnfermedad
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
            this.components = new System.ComponentModel.Container();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSyst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnComm = new System.Windows.Forms.Button();
            this.btnEars = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // tbNam
            // 
            this.tbNam.Location = new System.Drawing.Point(115, 31);
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(100, 20);
            this.tbNam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(115, 101);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(123, 54);
            this.tbDesc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descripción";
            // 
            // tbSyst
            // 
            this.tbSyst.Location = new System.Drawing.Point(115, 69);
            this.tbSyst.Name = "tbSyst";
            this.tbSyst.PasswordChar = '*';
            this.tbSyst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSyst.Size = new System.Drawing.Size(100, 20);
            this.tbSyst.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sistema";
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(296, 101);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnComm
            // 
            this.btnComm.Location = new System.Drawing.Point(296, 26);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(75, 23);
            this.btnComm.TabIndex = 4;
            this.btnComm.Text = "Registrar";
            this.btnComm.UseVisualStyleBackColor = true;
            this.btnComm.Click += new System.EventHandler(this.btnComm_Click);
            // 
            // btnEars
            // 
            this.btnEars.Location = new System.Drawing.Point(296, 64);
            this.btnEars.Name = "btnEars";
            this.btnEars.Size = new System.Drawing.Size(75, 23);
            this.btnEars.TabIndex = 5;
            this.btnEars.Text = "Borrar todo";
            this.btnEars.UseVisualStyleBackColor = true;
            this.btnEars.Click += new System.EventHandler(this.btnEars_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nuevaEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.btnEars);
            this.Controls.Add(this.btnComm);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbSyst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label1);
            this.Name = "nuevaEnfermedad";
            this.Text = "nueva enfermedad";
            this.Load += new System.EventHandler(this.nuevaEnfermedad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSyst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnComm;
        private System.Windows.Forms.Button btnEars;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}