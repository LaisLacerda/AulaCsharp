
namespace CopiaNome
{
    partial class frmCopiar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblCopiar = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Insira seu nome:";
            // 
            // lblCopiar
            // 
            this.lblCopiar.AutoSize = true;
            this.lblCopiar.Location = new System.Drawing.Point(46, 219);
            this.lblCopiar.Name = "lblCopiar";
            this.lblCopiar.Size = new System.Drawing.Size(24, 20);
            this.lblCopiar.TabIndex = 1;
            this.lblCopiar.Text = "---";
            this.lblCopiar.Visible = false;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(26, 126);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(194, 33);
            this.btnCopiar.TabIndex = 2;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(194, 26);
            this.txtNome.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(173, 75);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(194, 26);
            this.txtSobrenome.TabIndex = 4;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(-2, 78);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(169, 20);
            this.lblSobrenome.TabIndex = 5;
            this.lblSobrenome.Text = "Insira seu Sobrenome:";
            this.lblSobrenome.Click += new System.EventHandler(this.lblSobrenome_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(274, 125);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 34);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCopiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 257);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.lblCopiar);
            this.Controls.Add(this.lblName);
            this.Name = "frmCopiar";
            this.Text = "Copiando Nome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCopiar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Button btnLimpar;
    }
}

