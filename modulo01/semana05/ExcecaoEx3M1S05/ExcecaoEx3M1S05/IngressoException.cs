using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecaoEx3M1S05
{
    public class IngressoException : Exception          //Herança
    {
        public IngressoException(String msg) : base(msg)            //Construtor
        {
        }

        public IngressoException(String msg, Exception causa) : base(msg, causa)            //Construtor
        {
        }

        public IngressoException()             //Construtors
        {
        }
    }
}