using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_banco
{
    public partial class frm_Conta : Form
    {
        //chamada das classes
        contaEspecial ce = new contaEspecial(); 
        contaPoupanca cp = new contaPoupanca();

        public frm_Conta()
        {
            InitializeComponent();
        }

        private void btn_Depositar_Click(object sender, EventArgs e)
        {
            if (txt_Valor.Text == "")
            {
                MessageBox.Show("Digite um valor!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Valor.Focus();
            }
            else if (rdb_Especial.Checked == false && rdb_Poupanca.Checked == false)
            {
                MessageBox.Show("Escolha um tipo de conta!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else 
            {
                if (rdb_Especial.Checked)
                {
                    ce.creditar(Convert.ToDouble(txt_Valor.Text));
                    txt_SaldoCE.Text = Convert.ToString(ce.Saldo);
                }
                else
                {
                    cp.creditar(Convert.ToDouble(txt_Valor.Text));
                    txt_SaldoCP.Text = Convert.ToString(cp.Saldo);
                }
            }          
        }

        private void btn_Sacar_Click(object sender, EventArgs e)
        {
            if (txt_Valor.Text == "")
            {
                MessageBox.Show("Digite um valor!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Valor.Focus();
            } 
            else if (rdb_Especial.Checked == false && rdb_Poupanca.Checked == false)
            {
                MessageBox.Show("Escolha um tipo de conta!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
                else
                {
                    if (rdb_Especial.Checked)
                    {
                        ce.debitar(Convert.ToDouble(txt_Valor.Text));
                        txt_SaldoCE.Text = Convert.ToString(ce.Saldo);
                    }
                    else
                    {
                        cp.debitar(Convert.ToDouble(txt_Valor.Text));
                        txt_SaldoCP.Text = Convert.ToString(cp.Saldo);
                    }
                }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            rdb_Especial.Checked = false;
            rdb_Poupanca.Checked = false;
            txt_Valor.Clear();
            txt_SaldoCE.Text = "0";
            txt_SaldoCP.Text = "0";
            cp.Saldo = 0;
            ce.Saldo = 0;
            txt_Valor.Focus();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
