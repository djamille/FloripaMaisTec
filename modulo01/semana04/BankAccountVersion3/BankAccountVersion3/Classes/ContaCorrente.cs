using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountVersion3
{
    public class ContaCorrente : ContaBancaria                  //Criação de Classe Conta Corrente solicitado no EXERCICIO 03 [M1S04], tendo como super classe a Conta Bancaria
    {
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoa.Fisica)                //Igualdade, o cliente tem que ser pessoa física
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");         //Criado exceção para que somente pessoas fisicas sejam cadastradas nesta Classe
            }
        }

        public override void Saque(decimal valor)               //EXERCICIO 06 [M1S04] Metodo sobrescrito, foi acrescentado uma taxa ao saque
        {
            valor += 0.50M;
            base.Saque(valor);                  //chama o método saque da classe mãe
        }

        public override void Transferencia(ContaBancaria conta, decimal valor)               //Metodo sobrescrito, foi acrescentado uma taxa a transferenia
        {
            valor += 0.25M;
            base.Transferencia(conta, valor);           //chama o método transferencia da super classe
        }
    }
}
