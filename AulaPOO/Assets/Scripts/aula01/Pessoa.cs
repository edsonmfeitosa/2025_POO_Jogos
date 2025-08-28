using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Pessoa
    {
        private string nome;
        private string email;

        public void receberUmNome(string nome)
        {
            this.nome = nome;
        }

        public string falarMeuNome()
        {
            return "Meu nome é " + nome;
        }

        public string perguntarONome(Pessoa p)
        {
            string mensagem = "Oi, qual o seu nome? ";
            mensagem += p.falarMeuNome();
            return mensagem;
        }


    }
}
