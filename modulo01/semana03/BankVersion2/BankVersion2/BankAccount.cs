using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace BankVersion2
{
    public class BankAccount            //Criação de classe Conta Bancaria
    {
        private string _cardholderName;          // Aributos criados de inicio como "public" para o exercício 2 [M1S03] 
        private int _agency;            //Alteração de visibilidade de todos os atributos para "private" como solicitado no exercício 3  [M1S03]
        private int _number;
        private AccountType _accountType;            //Chamando o Enum para dentro da classe 
        private double _balance;

        public BankAccount (string cardholderName, int agency, int number, AccountType accountType)          //Construtor solicitado no exercicio 2 [M1S03]
        {
            _cardholderName = cardholderName;
            _agency = agency;
            _number = number;
            _accountType = accountType;
        }
        
        public BankAccount (string cardholderName, AccountType accountType)                //Segundo construtor solicitado no exercicio 4 [M1S03]
        {
            _cardholderName = cardholderName;
            _accountType = accountType;
            Random agencyRnd= new Random();             //numero aleatorio solicitado no exercicio 4 [M1S03]
            _agency = agencyRnd.Next(0000, 9999);
            Random numberRnd = new Random();             //numero aleatorio solicitado no exercicio 4 [M1S03]
            _number = numberRnd.Next(0000, 9999);
        }

        public void Deposit(double value)         //Método para deposito em conta
        {
            if (value <= 0)
            {
                Console.WriteLine("Incorrect value. Enter a value above 0!");           //Valida se o valor é maior que zero
            }
            else
            {
                _balance = _balance + value;            //Se for maior que zero, soma ao valor do saldo
            }
        }

        public void Transfer(BankAccount account, double value)         //Método para transferencia entre contas
        {
            if (value <= 0)
            {
                Console.WriteLine("Incorrect value. Enter a value above 0!");           //Só aceitará o valor se for maior que zero
            }

            if (value > _balance)           //Só aceitará o valor a ser transferido se o mesmo for menor que o valor total da conta.
            {
                Console.WriteLine("There is not enough balance for this transaction!");
            }

            _balance -= value;
            account.Deposit(value);

            Console.WriteLine("Transfer in the amount of $ {0} successfully completed!", value);
        }

        public void ShowBalance()
        {
            Console.WriteLine("Your current account balance is $ {0}", _balance);
        }
    }
}
