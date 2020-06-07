using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_banco
{
    class contaEspecial: Conta //herança da classe base
    {
        public override void debitar(double valor)//metodo criado para subscrever os atributos da metodo debitar da classe conta
        {
            if (Saldo <= 0)
            {
                Saldo -= (0.01 * valor) + valor;
            } else
            {
                Saldo -= valor;
            }
        }
    }
}
