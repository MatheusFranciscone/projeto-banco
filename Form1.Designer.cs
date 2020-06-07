namespace projeto_banco
{
    partial class frm_Conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Conta));
            this.rdb_Especial = new System.Windows.Forms.RadioButton();
            this.rdb_Poupanca = new System.Windows.Forms.RadioButton();
            this.btn_Sacar = new System.Windows.Forms.Button();
            this.btn_Depositar = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_SaldoCE = new System.Windows.Forms.Label();
            this.lbl_SaldoCP = new System.Windows.Forms.Label();
            this.txt_SaldoCE = new System.Windows.Forms.TextBox();
            this.txt_SaldoCP = new System.Windows.Forms.TextBox();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_Especial
            // 
            this.rdb_Especial.AutoSize = true;
            this.rdb_Especial.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rdb_Especial.Location = new System.Drawing.Point(14, 73);
            this.rdb_Especial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_Especial.Name = "rdb_Especial";
            this.rdb_Especial.Size = new System.Drawing.Size(113, 20);
            this.rdb_Especial.TabIndex = 0;
            this.rdb_Especial.Text = "Conta Especial";
            this.rdb_Especial.UseVisualStyleBackColor = true;
            // 
            // rdb_Poupanca
            // 
            this.rdb_Poupanca.AutoSize = true;
            this.rdb_Poupanca.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.rdb_Poupanca.Location = new System.Drawing.Point(164, 73);
            this.rdb_Poupanca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_Poupanca.Name = "rdb_Poupanca";
            this.rdb_Poupanca.Size = new System.Drawing.Size(121, 20);
            this.rdb_Poupanca.TabIndex = 1;
            this.rdb_Poupanca.Text = "Conta Poupança";
            this.rdb_Poupanca.UseVisualStyleBackColor = true;
            // 
            // btn_Sacar
            // 
            this.btn_Sacar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Sacar.ForeColor = System.Drawing.Color.White;
            this.btn_Sacar.Location = new System.Drawing.Point(14, 169);
            this.btn_Sacar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sacar.Name = "btn_Sacar";
            this.btn_Sacar.Size = new System.Drawing.Size(87, 28);
            this.btn_Sacar.TabIndex = 3;
            this.btn_Sacar.Text = "Sacar";
            this.btn_Sacar.UseVisualStyleBackColor = false;
            this.btn_Sacar.Click += new System.EventHandler(this.btn_Sacar_Click);
            // 
            // btn_Depositar
            // 
            this.btn_Depositar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Depositar.ForeColor = System.Drawing.Color.White;
            this.btn_Depositar.Location = new System.Drawing.Point(189, 169);
            this.btn_Depositar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Depositar.Name = "btn_Depositar";
            this.btn_Depositar.Size = new System.Drawing.Size(87, 28);
            this.btn_Depositar.TabIndex = 4;
            this.btn_Depositar.Text = "Depositar";
            this.btn_Depositar.UseVisualStyleBackColor = false;
            this.btn_Depositar.Click += new System.EventHandler(this.btn_Depositar_Click);
            // 
            // txt_Valor
            // 
            this.txt_Valor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_Valor.Location = new System.Drawing.Point(107, 119);
            this.txt_Valor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(116, 23);
            this.txt_Valor.TabIndex = 2;
            this.txt_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Valor_KeyPress);
            // 
            // lbl_SaldoCE
            // 
            this.lbl_SaldoCE.AutoSize = true;
            this.lbl_SaldoCE.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_SaldoCE.Location = new System.Drawing.Point(10, 238);
            this.lbl_SaldoCE.Name = "lbl_SaldoCE";
            this.lbl_SaldoCE.Size = new System.Drawing.Size(65, 16);
            this.lbl_SaldoCE.TabIndex = 5;
            this.lbl_SaldoCE.Text = "Saldo CE:";
            // 
            // lbl_SaldoCP
            // 
            this.lbl_SaldoCP.AutoSize = true;
            this.lbl_SaldoCP.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_SaldoCP.Location = new System.Drawing.Point(161, 238);
            this.lbl_SaldoCP.Name = "lbl_SaldoCP";
            this.lbl_SaldoCP.Size = new System.Drawing.Size(64, 16);
            this.lbl_SaldoCP.TabIndex = 6;
            this.lbl_SaldoCP.Text = "Saldo CP:";
            // 
            // txt_SaldoCE
            // 
            this.txt_SaldoCE.Enabled = false;
            this.txt_SaldoCE.Location = new System.Drawing.Point(14, 257);
            this.txt_SaldoCE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SaldoCE.Name = "txt_SaldoCE";
            this.txt_SaldoCE.Size = new System.Drawing.Size(116, 23);
            this.txt_SaldoCE.TabIndex = 7;
            this.txt_SaldoCE.Text = "0";
            this.txt_SaldoCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SaldoCP
            // 
            this.txt_SaldoCP.Enabled = false;
            this.txt_SaldoCP.Location = new System.Drawing.Point(164, 257);
            this.txt_SaldoCP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SaldoCP.Name = "txt_SaldoCP";
            this.txt_SaldoCP.Size = new System.Drawing.Size(116, 23);
            this.txt_SaldoCP.TabIndex = 8;
            this.txt_SaldoCP.Text = "0";
            this.txt_SaldoCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_Texto.Location = new System.Drawing.Point(12, 20);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(270, 19);
            this.lbl_Texto.TabIndex = 9;
            this.lbl_Texto.Text = "Digite o valor e clique na operação!";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_Valor.Location = new System.Drawing.Point(48, 123);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(43, 16);
            this.lbl_Valor.TabIndex = 10;
            this.lbl_Valor.Text = "Valor:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(14, 290);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(112, 28);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "Limpar Dados";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(164, 290);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(117, 28);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 334);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.txt_SaldoCP);
            this.Controls.Add(this.txt_SaldoCE);
            this.Controls.Add(this.lbl_SaldoCP);
            this.Controls.Add(this.lbl_SaldoCE);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.btn_Depositar);
            this.Controls.Add(this.btn_Sacar);
            this.Controls.Add(this.rdb_Poupanca);
            this.Controls.Add(this.rdb_Especial);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Conta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Especial;
        private System.Windows.Forms.RadioButton rdb_Poupanca;
        private System.Windows.Forms.Button btn_Sacar;
        private System.Windows.Forms.Button btn_Depositar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_SaldoCE;
        private System.Windows.Forms.Label lbl_SaldoCP;
        private System.Windows.Forms.TextBox txt_SaldoCE;
        private System.Windows.Forms.TextBox txt_SaldoCP;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
    }
}

