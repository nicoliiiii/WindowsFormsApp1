
namespace WindowsFormsApp1
{
    partial class Salas
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
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNumeroPC = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.labelNumPc = new System.Windows.Forms.Label();
            this.labelNumCadeiras = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumCadei = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.chkIsLab = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = " Salas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(73, 85);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // txtNumeroPC
            // 
            this.txtNumeroPC.BackColor = System.Drawing.Color.LightCyan;
            this.txtNumeroPC.Location = new System.Drawing.Point(76, 152);
            this.txtNumeroPC.Name = "txtNumeroPC";
            this.txtNumeroPC.Size = new System.Drawing.Size(250, 20);
            this.txtNumeroPC.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.LightCyan;
            this.txtNom.Location = new System.Drawing.Point(76, 101);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(250, 20);
            this.txtNom.TabIndex = 3;
            // 
            // labelNumPc
            // 
            this.labelNumPc.AutoSize = true;
            this.labelNumPc.Location = new System.Drawing.Point(73, 136);
            this.labelNumPc.Name = "labelNumPc";
            this.labelNumPc.Size = new System.Drawing.Size(76, 13);
            this.labelNumPc.TabIndex = 4;
            this.labelNumPc.Text = "Numero de PC";
            // 
            // labelNumCadeiras
            // 
            this.labelNumCadeiras.AutoSize = true;
            this.labelNumCadeiras.Location = new System.Drawing.Point(73, 180);
            this.labelNumCadeiras.Name = "labelNumCadeiras";
            this.labelNumCadeiras.Size = new System.Drawing.Size(103, 13);
            this.labelNumCadeiras.TabIndex = 5;
            this.labelNumCadeiras.Text = "Numero de Cadeiras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Predio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Complemento";
            // 
            // txtNumCadei
            // 
            this.txtNumCadei.BackColor = System.Drawing.Color.LightCyan;
            this.txtNumCadei.Location = new System.Drawing.Point(76, 196);
            this.txtNumCadei.Name = "txtNumCadei";
            this.txtNumCadei.Size = new System.Drawing.Size(250, 20);
            this.txtNumCadei.TabIndex = 8;
            // 
            // txtPredio
            // 
            this.txtPredio.BackColor = System.Drawing.Color.LightCyan;
            this.txtPredio.Location = new System.Drawing.Point(76, 246);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(250, 20);
            this.txtPredio.TabIndex = 9;
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.LightCyan;
            this.txtComplemento.Location = new System.Drawing.Point(76, 298);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(250, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // chkIsLab
            // 
            this.chkIsLab.AutoSize = true;
            this.chkIsLab.Location = new System.Drawing.Point(76, 340);
            this.chkIsLab.Name = "chkIsLab";
            this.chkIsLab.Size = new System.Drawing.Size(79, 17);
            this.chkIsLab.TabIndex = 11;
            this.chkIsLab.Text = "Laboratorio";
            this.chkIsLab.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCadastrar.Location = new System.Drawing.Point(101, 386);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLimpar.Location = new System.Drawing.Point(204, 386);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.chkIsLab);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtPredio);
            this.Controls.Add(this.txtNumCadei);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumCadeiras);
            this.Controls.Add(this.labelNumPc);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNumeroPC);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.Name = "Salas";
            this.Text = "Salas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNumeroPC;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label labelNumPc;
        private System.Windows.Forms.Label labelNumCadeiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumCadei;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.CheckBox chkIsLab;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}