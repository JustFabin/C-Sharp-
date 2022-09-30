using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente[] c1 = new Cliente[4];
            c1[0] = new Cliente();
            c1[1] = new Cliente();
            c1[2] = new Cliente();
            c1[3] = new Cliente();

            c1[0].Nome = "Arnaldo";
            c1[0].Matricula = 0000;
            c1[0].Salario = 7900;

            c1[1].Nome = "Fulano";
            c1[1].Matricula = 0001;
            c1[1].Salario = 7800;

            c1[2].Nome = "Sicrano";
            c1[2].Matricula = 0002;
            c1[2].Salario = 7700;

            c1[3].Nome = "Beltrano";
            c1[3].Matricula = 0003;
            c1[3].Salario = 7600;

            double media = c1[0].media(c1[1], c1[2], c1[3]);

            if (c1[0].Salario > media)
            {
                Console.WriteLine(c1[0].Nome + " " + c1[0].Matricula + " " + c1[0].Salario);
            }
            if (c1[1].Salario > media)
            {
                Console.WriteLine(c1[1].Nome + " " + c1[1].Matricula + " " + c1[1].Salario);
            }
            if (c1[2].Salario > media)
            {
                Console.WriteLine(c1[2].Nome + " " + c1[2].Matricula + " " + c1[2].Salario);
            }
            if (c1[3].Salario > media)
            {
                Console.WriteLine(c1[3].Nome + " " + c1[3].Matricula + " " + c1[3].Salario);
            }

            Console.ReadKey();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cliente
    {

        public string Nome { get; set; }
        public int Matricula { get; set; }
        public double Salario { get; set; }

        public Cliente(string Nome)
        {
            this.Nome = Nome;
        }

        public Cliente(int Matricula)
        {
           this.Matricula = Matricula;
        }

        public Cliente(double Salario)
        {
           this.Salario = Salario;
        }

        public Cliente()
        {
        }

        public Cliente (string Nome, int Matricula, double Salario)
        {
            this.Nome = Nome;
            this.Matricula = Matricula;
            this.Salario = Salario;
        }

        public double media(Cliente c1, Cliente c2, Cliente c3)
        {
            return (this.Salario + c1.Salario + c2.Salario + c3.Salario) / 4;
        }
    }

}
