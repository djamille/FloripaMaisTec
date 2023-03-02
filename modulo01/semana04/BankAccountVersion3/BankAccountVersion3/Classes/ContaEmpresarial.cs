using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace BankAccountVersion3
{
    public class ContaEmpresarial : ContaBancaria                 //Criação de Classe Conta Empresarial e atributos solicitados no EXERCICIO 03 [M1S04]
    {
        public decimal LimiteEmprestimo { get; private set; } 
        public decimal TaxaJuros { get; private set; }
        public decimal RendimentoMensal { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public decimal ValorUsado { get; private set; }
        public decimal CNPJ { get; private set; }
               
        
        //Criação de Construtor com os atributos base solicitado no Exercicio 03 [M1S04]
        //Inclusão de novos atributos solicitado no Exercicio 04 [M1S04]
        public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal RendimentoMensal, decimal taxaJuros, decimal cnpj) : base(numero, agencia, cliente)
        {
            LimiteEmprestimo = RendimentoMensal * 0.30M;                //aqui fiz um acrescimo de limitação para o emprestimo, sendo liberado um valor de apenas 30% da sua renda mensal,
            TaxaJuros = taxaJuros;                                      // ja que para quitar o emprestimo o valor tem que ser pago integral. Esse tipo de percentual é usado em 
            //ValorUsado = valorUsado;                                    // emprestimos consignados, e o mesmo é dividido em parcelas, o cliente nao pode exceder certo limite do 
            CNPJ = cnpj;                                                // seu salario senao não tem como horar com os demais gastos alem do emprestimo

            if (cliente.TipoPessoa != TipoPessoa.Juridica)                //Igualdade, o cliente tem que ser pessoa física
            {
                throw new ArgumentException("Cliente precisa ser do tipo jurídica!");         //Criado exceção para que somente pessoas juridica sejam cadastradas nesta Classe
            }
        }


        public void FazerEmprestimo(decimal valor)         //EXERCICIO 05[M1S04] Método para Fazer Emprestimo em conta
        {
 
            if (valor <= 0)                 //Valida se o valor é maior que zero
            {
                Console.WriteLine("Valor incorreto. Insira um valor maior que zero!");              //Indica na tela que o valor deve ser maior que zero
                return;
            }
            
            if (PossuiEmprestimo)               //Verifica se tem emprestimo (bool)
            {
                Console.WriteLine("Você já possui um empréstimo ativo!");               //Caso ja tenha emprestimo, imprime mensagem na tela
                return;                
            }

            if (valor > LimiteEmprestimo)               //verifica o valor solicitado, se o mesmo for maior que o limite de emprestimmo, nao libera
            {
                Console.WriteLine("O valor de R$ {0} ultrapassa seu limite de empréstimo disponível, que atualmente é de R$ {1}!", valor, LimiteEmprestimo);
                return;
            }

            PossuiEmprestimo = true;            //false ou true
            base.Deposito(valor);               //chama metodo deposito da classe mae
            ValorUsado = valor;
            Console.WriteLine("Empréstimo no valor de R$ {0} realizado com sucesso!", valor);           //Imprime valor 
        }

        public void PagarEmprestimo()         //EXERCICIO 05[M1S04] Método para Pagar Emprestimo em conta
        {
            decimal total = ValorUsado + (ValorUsado * TaxaJuros / 100);                //Valor pego no emprestimo ja somado os juros
            if (total > Saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar o pagamento!");                 //total tem que ser menor que o saldo
                return;
            }

            Saque(total);                   //Saca do Saldo o valor da quitação do emprestimo (valor pego +  juros)
            PossuiEmprestimo = false;               //Da baixa no emprestimo, liberando que faça um novo emprestimo
            ValorUsado = 0;                 //valor pego no emprestimoo
            Console.WriteLine("Empréstimo no valor total de R$ {0} quitado com sucesso!", total);             //imprime na tela o emprestimo quitado
        }

                
        public override void Saque(decimal valor)               //EXERCICIO 06 [M1S04] Metodo sobrescrito, foi acrescentado uma taxa ao saque
        {
            valor += 1;
            base.Saque(valor);                 //chama o método saque da  classe mãe
        }

        public override void Transferencia(ContaBancaria conta, decimal valor)               ////EXERCICIO 06 [M1S04] Metodo sobrescrito, foi acrescentado uma taxa a transferencia
        {
            valor += 0.50M;
            base.Transferencia(conta, valor);                 //chama o método saque da super classe
        }
        
    }
}

