﻿namespace databaseProject
{
    partial class NombreDirec
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
            this.btn_retu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_retu
            // 
            this.btn_retu.Location = new System.Drawing.Point(555, 245);
            this.btn_retu.Name = "btn_retu";
            this.btn_retu.Size = new System.Drawing.Size(75, 23);
            this.btn_retu.TabIndex = 0;
            this.btn_retu.Text = "Regresar";
            this.btn_retu.UseVisualStyleBackColor = true;
            this.btn_retu.Click += new System.EventHandler(this.btn_retu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // NombreDirec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 280);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_retu);
            this.Name = "NombreDirec";
            this.Text = "NombreDirec";
            this.Load += new System.EventHandler(this.NombreDirec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_retu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}