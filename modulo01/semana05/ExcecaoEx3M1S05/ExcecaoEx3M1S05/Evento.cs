using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecaoEx3M1S05
{
    public class Evento
    {

        int qtdLugares;
        int qtdIngressosVendidos;

        public Evento()
        {
        }

        public void ingressoVendido()
        {
            Console.WriteLine("Ingresso vendido com sucesso!");
        }

        public int QtdLugares { get; set; }
        public int QtdIngressosVendidos { get; set; }
    }
}
