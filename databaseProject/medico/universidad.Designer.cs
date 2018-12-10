namespace databaseProject.medico
{
    partial class universidad
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbUniv = new System.Windows.Forms.TextBox();
            this.btnUniv = new System.Windows.Forms.Button();
            this.btnRetu = new System.Windows.Forms.Button();
            this.lbUniv = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione su universidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese una nueva universidad";
            // 
            // tbUniv
            // 
            this.tbUniv.Location = new System.Drawing.Point(238, 38);
            this.tbUniv.Name = "tbUniv";
            this.tbUniv.Size = new System.Drawing.Size(100, 20);
            this.tbUniv.TabIndex = 3;
            // 
            // btnUniv
            // 
            this.btnUniv.Location = new System.Drawing.Point(238, 73);
            this.btnUniv.Name = "btnUniv";
            this.btnUniv.Size = new System.Drawing.Size(75, 23);
            this.btnUniv.TabIndex = 4;
            this.btnUniv.Text = "ingresar";
            this.btnUniv.UseVisualStyleBackColor = true;
            this.btnUniv.Click += new System.EventHandler(this.btnUniv_Click);
            // 
            // btnRetu
            // 
            this.btnRetu.Location = new System.Drawing.Point(299, 155);
            this.btnRetu.Name = "btnRetu";
            this.btnRetu.Size = new System.Drawing.Size(75, 23);
            this.btnRetu.TabIndex = 5;
            this.btnRetu.Text = "Regresar";
            this.btnRetu.UseVisualStyleBackColor = true;
            this.btnRetu.Click += new System.EventHandler(this.btnRetu_Click);
            // 
            // lbUniv
            // 
            this.lbUniv.FormattingEnabled = true;
            this.lbUniv.Location = new System.Drawing.Point(12, 38);
            this.lbUniv.Name = "lbUniv";
            this.lbUniv.Size = new System.Drawing.Size(120, 95);
            this.lbUniv.TabIndex = 6;
            this.lbUniv.SelectedIndexChanged += new System.EventHandler(this.lbUniv_SelectedIndexChanged);
            // 
            // universidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 200);
            this.Controls.Add(this.lbUniv);
            this.Controls.Add(this.btnRetu);
            this.Controls.Add(this.btnUniv);
            this.Controls.Add(this.tbUniv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "universidad";
            this.Text = "universidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUniv;
        private System.Windows.Forms.Button btnUniv;
        private System.Windows.Forms.Button btnRetu;
        private System.Windows.Forms.ListBox lbUniv;
    }
}