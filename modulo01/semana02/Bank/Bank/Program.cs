using System;
using Bank;
using static Bank.BankAccount;

namespace FloripaMaisTec
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();            //Instanciando a classe
            account.Number = 123;           //Número da conta - atribuindo valor
            account.Agency = 10;            //Número da agência - atribuindo valor
            account.Name = "Brian Conor";           //Nome do cliente - atribuindo valor
            account.AccountType = Types.Current_Account;            //Escolhido o tipo de conta
            

            Console.WriteLine("Bank manager: -'Good morning Mr {0}! I create your {1} and here are the details: number {2}, agency {3}.'", account.Name, account.AccountType, account.Number, account.Agency);              //Saída de dados, com valores dos atributos 
            Console.WriteLine("Bank manager: -'Your current balance is:  {0:F2}. Would you like to make a deposit?'", account.Balance);         //Saída de dados com valor do atributo
            Console.WriteLine("Mr Brian: -'Good morning! Yes, I would like to deposit.'");
            Console.WriteLine("Bank manager: '-Enter the deposit amount: ");
            
            double depositAmount = double.Parse(Console.ReadLine());            //Entrada de dados, valor de depósito

            account.Deposit(depositAmount);         //Chamando o método dépósito
            
            account.ShowBalance();          //Chamando o método de saldo atual

            Console.WriteLine("Mr Brian: -'Sorry, I deposited all my money. Could I withdraw some value?'");
            Console.WriteLine("Bank manager: 'For sure! Enter the withdrawal amount: '");

            double withdrawaAccount = double.Parse(Console.ReadLine());            //Entrada de dados, valor de saque

            account.Withdrawal(withdrawaAccount);          //Chamando o método de saque

            account.ShowBalance();          //Chamando o método de saldo atual

            Console.WriteLine("Mr Brian: -'Thanks! That would be it for now! Goodbye'");
            Console.WriteLine("Bank manager: -'Thank you! Goodbye!'");
        }
    }
}