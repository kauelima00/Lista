using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPC
{
    internal class Paciente
    {
       
        public string Nome;
        public int Idade;
        public bool Preferencial;
        public string  Cpf;

        public Paciente (string nome, int idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Preferencial = idade >= 60;
        }
    }
}
