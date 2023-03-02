using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEConstrutores
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preco;

        public Produto(string nome, string cor)
        {
            this.nome = nome;
            this.cor = cor;
        }

        public Produto()
        {
        }

        public void VerificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }

        protected void Vender() 
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void Descartar()
        {
            Console.WriteLine("Descartando produto, acessando metodo da classe produto");
        }
        
        protected void alteraAtributosPrivados(double peso2, double preco)
        {
            peso = peso2;

            Console.WriteLine("Variável peso de escopo da classe: {0}", peso);
        }
    }
}
