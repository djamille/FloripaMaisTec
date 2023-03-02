using BankAccountVersion3;
using BankAccountVersion3.Classes;

Cliente pj = new Cliente("Djamille Vieira", DateTime.Parse("1984-12-13"), "Desenvolvedora", EstadoCivil.Casado, TipoPessoa.Juridica);

ContaEmpresarial contaEmpresa = new ContaEmpresarial(1253, 29, pj, 8000, 9,  12546789000117);
contaEmpresa.FazerEmprestimo(2500.00M);             //teste para o limite de 30%
contaEmpresa.FazerEmprestimo(2000.00M);
contaEmpresa.Deposito(3000.00M);
contaEmpresa.ExibirSaldo();
contaEmpresa.PagarEmprestimo();
contaEmpresa.ExibirSaldo();


Cliente pf = new Cliente("Djamille Vieira", DateTime.Parse("1984-12-13"), "Desenvolvedora", EstadoCivil.Casado, TipoPessoa.Fisica);

ContaCorrente contaCorrente = new ContaCorrente(1234, 25, pf);
contaCorrente.Deposito(350.00M);
contaCorrente.Saque(100.00M);
contaCorrente.ExibirSaldo();

ContaPoupanca contaPoupanca = new ContaPoupanca(1234, 25, pf);
contaPoupanca.Deposito(100.00M);
contaPoupanca.Transferencia(contaCorrente, 80.00M);
contaPoupanca.ExibirSaldo();
