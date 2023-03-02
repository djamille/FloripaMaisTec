using ClassesEConstrutores;

Produto produto1 = new Produto();
produto1.nome = "Calculadora";
produto1.VerificarEstoque();

Console.WriteLine("O nome do produto é {0}", produto1.nome);

ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();
classeFilha.nome = "Produto Financeiro";
classeFilha.VerificarEstoque();
classeFilha.Acesso();