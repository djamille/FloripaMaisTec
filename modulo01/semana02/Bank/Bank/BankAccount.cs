using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Bank
{
    internal class BankAccount          //Classe criada
    {
        public int Number;           //Atríbutos
        public int Agency;           //Atríbutos
        public string Name = null;           //Atríbutos
        public double Balance = 0;           //Atríbutos
        public Types AccountType;           //Criado tipo Types para os tipos de contas
        
        public enum Types { Current_Account, Savings_Account };         //Criando dois tipos de conta: conta corrente e conta poupança
        
        
        public Boolean Deposit(double depositAmount)            //Método deposito criado
        {
            if (depositAmount > 0.0)            //Valor de depósito deve ser maior que zero
            {
                Balance = Balance + depositAmount;          //Somando o valor do saldo ao valor do deposito
                return true;
                Console.WriteLine(Balance);
            }   
            
            return false;

        }

       
        public Boolean Withdrawal(double withdrawalAmount)          //Método saque criado
        {
            if (withdrawalAmount > 0 & withdrawalAmount <= Balance)         //Valor de saque deve ser maior que zero e menor ou igual ao saldo.
            {   
                Balance = Balance - withdrawalAmount;           //Diminuindo o valor do saque do valor do saldo
                return true;
            }

            return false;

        }

        public void ShowBalance()           //Método saldo atualizado criado
        { 
            Console.WriteLine("Your current balance is: " + (Balance.ToString("F2", CultureInfo.InvariantCulture)));        //Saida de dados + valor do saldo atual
        }

    }
}
