using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountVersion3
{
    public class ContaBancaria              //Criação de Classe base solicitado no EXERCICIO 02 [M1S04]
    {
        public int Numero { get; protected set; }           //Atributos solicitados pelo exercicio 
        public int Agencia { get;protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; } = 0;

        
        public ContaBancaria(int numero, int agencia, Cliente cliente)          //Criação de Construtor (sem inclusão do atributo saldo) conforme solicitado no EXERCICIO 02 [M1S04]
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
        }


        //Criação de métodos TRANSFERENCIA, DEPÓSITO, SAQUE e EXIBIR SALDO   solicitado no EXERCICIO 02 [M1S04]

        public virtual void Transferencia(ContaBancaria contaBancaria, decimal valor)         //Método para transferencia de conta, utilizou-se o "virtual" para 'deixar' que este método da super classe seja sobreposto em classes filhas
        {
            if (valor <= 0)                 //Só aceitará o valor, se o mesmo for maior que zero
            {
                Console.WriteLine("Valor incorreto. Insira um valor maior que zero!");           //Indica na tela que o valor deve ser maior que zero
                return;
            }

            if (valor > Saldo)           //Só aceitará o valor a ser transferido se o mesmo for menor que o valor total da conta.
            {
                Console.WriteLine("Não há saldo suficiente para esta transação!");           //Imprime na tela que não ha saldo suficiente
                return;
            }

            Saldo = Saldo - valor;                  //Diminui do saldo o valor transferido
            contaBancaria.Deposito(valor);

            Console.WriteLine("Transferência no valor de $ {0} concluída com sucesso!", valor);             //Imprime na tela a mensagem com o valor transferido
        }

        public virtual void Deposito(decimal valor)         //Método para deposito em conta, utilizou-se o "virtual" para 'deixar' que este método da super classe seja sobreposto em classes filhas
        {
            if (valor <= 0)                  //Valida se o valor é maior que zero
            {
                Console.WriteLine("Valor incorreto. Insira um valor maior que zero!");           //Indica na tela que o valor deve ser maior que zero
                return;
            }
            else
            {
                Saldo = Saldo + valor;            //Se for maior que zero, soma ao valor do saldo
            }

            Console.WriteLine("Valor de $ {0} depositado com sucesso!", valor);                    //Imprime na tela o valor depositado
        }

                
        public virtual void Saque(decimal valor)         //Método para saque em conta, utilizou-se o "virtual" para 'deixar' que este método da super classe seja sobreposto em classes filhas
        {
            if (valor <= 0)                  //Só aceitará o valor se for maior que zero
            {
                Console.WriteLine("Valor incorreto. Insira um valor maior que zero!");           //Indica na tela que o valor deve ser maior que zero
                return;
            }

            else if (valor > Saldo)           //Só aceitará o valor a ser transferido se o mesmo for menor que o valor total da conta.
            {
                Console.WriteLine("Não há saldo suficiente para esta transação!");           //Imprime na tela que não ha saldo suficiente
                return;
            }
            
            else
            {
                Saldo = Saldo - valor;                  //Sendo o valor menor que o saldo, o saque é realizado e diminuido do saldo
            }
                        
            Console.WriteLine("Saque no valor de $ {0} concluído com sucesso!", valor);                 //Imprime que o saque foi um sucesso´e informa o valor sacado
        }


        public virtual void ExibirSaldo()         //Método para exibir saldo da conta, utilizou-se o "virtual" para 'deixar' que este método da super classe seja sobreposto em classes filhas
        {
            Console.WriteLine("O saldo atual da sua conta é $ {0}", Saldo);             //Imprime na tela o saldo
        }
    }
}
