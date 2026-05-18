using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float val;
            FilaPaciente fila = new FilaPaciente();

            while (true)
            {
                Console.WriteLine("-----Menu-----");

                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Lista dos Pacientes");
                Console.WriteLine("[3] Atender Paciente ");
                Console.WriteLine("[4] Alterar Cadastro");
                Console.WriteLine("[5] Sair");

                val = float.Parse(Console.ReadLine());

                if (val == 1)
                {
                    fila.Cadastro();
                }
                else if (val == 2)
                {
                    fila.Listar();
                }
                else if (val == 3)
                {
                    fila.Atender();
                }
                else if (val == 4)
                {
                    fila.Alterar();
                }
                else if (val == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite numero valido do Menu!");
                }


            }
        }
    }
}

