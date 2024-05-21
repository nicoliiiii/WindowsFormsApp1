
namespace WindowsFormsApp1
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
            this.btnCad_Salas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCad_Salas
            // 
            this.btnCad_Salas.Location = new System.Drawing.Point(188, 160);
            this.btnCad_Salas.Name = "btnCad_Salas";
            this.btnCad_Salas.Size = new System.Drawing.Size(105, 23);
            this.btnCad_Salas.TabIndex = 0;
            this.btnCad_Salas.Text = "Cadastro de Salas";
            this.btnCad_Salas.UseVisualStyleBackColor = true;
            this.btnCad_Salas.Click += new System.EventHandler(this.btnCad_Salas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCad_Salas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCad_Salas;
    }
}

