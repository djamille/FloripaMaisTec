using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountVersion3
{
    public class Cliente              //Classe Cliente criada, juntamente com os atributos e contrutor solicitados no EXERCICIO 01 [M1S04] 
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public EstadoCivil EstadoCivil { get; private set; }
        public TipoPessoa TipoPessoa { get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, EstadoCivil estadoCivil, TipoPessoa tipoPessoa)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;
        }
    }
}
