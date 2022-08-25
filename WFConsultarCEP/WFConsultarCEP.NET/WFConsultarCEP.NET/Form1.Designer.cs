namespace WFConsultarCEP.NET
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.btnBuscarCEP = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtComplemento2 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(6, 31);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(320, 20);
            this.txtCEP.TabIndex = 1;
            // 
            // btnBuscarCEP
            // 
            this.btnBuscarCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCEP.Location = new System.Drawing.Point(346, 21);
            this.btnBuscarCEP.Name = "btnBuscarCEP";
            this.btnBuscarCEP.Size = new System.Drawing.Size(117, 38);
            this.btnBuscarCEP.TabIndex = 2;
            this.btnBuscarCEP.Text = "Buscar CEP";
            this.btnBuscarCEP.UseVisualStyleBackColor = true;
            this.btnBuscarCEP.Click += new System.EventHandler(this.btnBuscarCEP_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(9, 97);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(317, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Endereço";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(9, 159);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(317, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Complemento";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(317, 20);
            this.textBox4.TabIndex = 8;
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.AutoSize = true;
            this.txtComplemento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento2.Location = new System.Drawing.Point(3, 199);
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.Size = new System.Drawing.Size(114, 16);
            this.txtComplemento2.TabIndex = 7;
            this.txtComplemento2.Text = "Complemento 2";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(6, 295);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(320, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro.Location = new System.Drawing.Point(3, 268);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(49, 16);
            this.Bairro.TabIndex = 9;
            this.Bairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 358);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(320, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(6, 416);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(320, 20);
            this.txtEstado.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(6, 454);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(320, 32);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(494, 498);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtComplemento2);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarCEP);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Busca de CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Button btnBuscarCEP;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtComplemento2;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.TextBox textBox4;
    }
}

