using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEConstrutores
{
    internal class ProdutoFinanceiro : Produto
    {
        public void Acesso()
        {
            ProdutoFinanceiro PF1 = new ProdutoFinanceiro();

            PF1.nome = "Produto dentro classe produto financeiro";
            PF1.cor = "verde";

            Console.WriteLine("Nome: {0}\nCor: {1}",PF1.nome, PF1.cor);

            PF1.Vender();
            PF1.VerificarEstoque();
            PF1.alteraAtributosPrivados(99, 100.0);
        }
    }
}
