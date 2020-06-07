using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_banco
{
    class Conta
    {
        private double saldo; //encapsulamento 


        public double Saldo //criação do método Saldo
        {
            get { return saldo; } //retorna a variável saldo  
            set { saldo = value; } //guarda o valor da variável
        }

        public virtual void creditar(double valor) //método "virtual" para poder fazer o polimorfismo
        {
            saldo += valor;
        }

        public virtual void debitar(double valor) //método "virtual" para poder fazer o polimorfismo
        {
            saldo -= valor;
        }


    }
}
