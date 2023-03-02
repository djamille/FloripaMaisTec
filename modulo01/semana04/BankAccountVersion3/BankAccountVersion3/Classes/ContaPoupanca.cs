using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountVersion3.Classes
{
    //Criação de Classe Conta Poupança solicitado no Exercicio 03 [M1S04]
    internal class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoa.Fisica)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");         //Criado exceção para que somente pessoas fisicas sejam cadastradas nesta Classe
            }
        }
    }
}
