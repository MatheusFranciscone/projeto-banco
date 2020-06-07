using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_banco
{
    class contaPoupanca: Conta //herança
    {
        public override void creditar(double valor) //metodo criado para subscrever os atributos da metodo creditar da classe conta
        {
            Saldo += (0.05 * valor) + valor;
        }

        public override void debitar(double valor) //metodo criado para subscrever os atributos da metodo debitar da classe conta
        {
            if (Saldo < valor) /*se o saldo não for
                suficiente informar ao usuário que não será possível a retirada do valor acima do saldo*/
            {
                System.Windows.Forms.MessageBox.Show("Não é possível retirar um valor acima de seu saldo!", "Atenção", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }

    }
}
