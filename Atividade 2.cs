using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2___Carioca
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] func = new Funcionario[4];
            func[0] = new Funcionario();
            func[1] = new Funcionario();
            func[2] = new Funcionario();
            func[3] = new Funcionario();

            func[0].setnome("Arnaldo");
            func[0].setmatricula(1);
            func[0].setsalario(2000);

            func[1].setnome("Fulano");
            func[1].setmatricula(2);
            func[1].setsalario(3000);

            func[2].setnome("Sicrano");
            func[2].setmatricula(3);
            func[2].setsalario(4000);

            func[3].setnome("Beltrano");
            func[3].setmatricula(4);
            func[3].setsalario(1500);

            double media = 0;

            media = (func[0].getsalario() + func[1].getsalario() + func[2].getsalario() + func[3].getsalario()) / 4;

            for (int i = 0; i < 4; i++)
            {
                if (func[i].getsalario() > media)
                {
                    Console.WriteLine(func[i].getnome() + " " + func[i].getmatricula() + " " + func[i].getsalario());
                }
            }
            Console.ReadKey();
        }
    }
    
    class Funcionario
    {
        private string nome;
        private int matricula;
        private double salario;

        public string getnome()
        {
            return this.nome;
        }

        public void setnome(string name)
        {
            this.nome = name;
        }

        public int getmatricula()
        {
            return this.matricula;
        }

        public void setmatricula(int mat)
        {
            this.matricula = mat;
        }

        public double getsalario()
        {
            return this.salario;
        }

        public void setsalario(double sal)
        {
            this.salario = sal;
        }

    }

}
