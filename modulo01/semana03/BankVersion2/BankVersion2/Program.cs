using BankVersion2;

BankAccount account1 = new BankAccount("Djamille", AccountType.Saving_Account);
BankAccount account2 = new BankAccount("Christofer", AccountType.Current_Account);


account1.Deposit(685);          //chamando o metodo para deposito de $ 685

account1.Transfer(account2, 85);                //chamando o metodo para transferir de $ 85

account1.ShowBalance();                 //exibe o saldo que restou na conta após a transferencia

account2.ShowBalance();                 //exibe o saldo que acrescentou na conta após o depósito
