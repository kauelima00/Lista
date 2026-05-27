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
            string val = "w";
            FilaPaciente fila = new FilaPaciente();

            while (val != "q")
            {
                Console.WriteLine(">>>>>>>>>>Menu<<<<<<<<<<");

                Console.WriteLine("[1] Cadastrar");
                Console.WriteLine("[2] Lista dos Pacientes");
                Console.WriteLine("[3] Atender Paciente ");
                Console.WriteLine("[4] Alterar Cadastro");
                Console.WriteLine("[q] Sair");

                val = Console.ReadLine();

                switch(val = "q")
                {
                    case "1":
                            fila.Cadastro();
                        break;
                    case "2":
                             fila.Listar();
                        break;
                    case "3":
                             fila.Atender();
                        break;
                    case "4":
                             fila.Alterar();
                        break;
                    case "q":
                    case "Q":
                            Console.WriteLine("\nSaindo do program...");
                        break;
                    default:
                        Console.WriteLine("\nDigite numero valido do Menu!");
                        break;
                }
            }
        }
    }
}

