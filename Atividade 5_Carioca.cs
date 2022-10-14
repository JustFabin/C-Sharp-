using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aula_14._10._2022
{
    class Funcionario
    {
        private string nome;
        private int matricula;
        private string cpf;
        private int mat;

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

        public string getcpf()
        {
            return this.cpf;
        }

        public void setcpf(string CPF)
        {
            this.cpf = CPF;
        }

        public Funcionario(string nome, int matricula, string cpf)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }

        public Funcionario(string nome, string cpf, int mat)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.mat = mat;
        }

        public void imprimeFuncionario()
        {
            Console.WriteLine(this.nome + " " + this.matricula + " " + this.cpf);
        }


    }
}

class Departamento
    {
        public string nome;
        ArrayList funcionarios = new ArrayList();

        public void adicionaFunc(string nome, string cpf, int mat)
        {
            Funcionario f = new Funcionario(nome, cpf, mat);

            this.funcionarios.Add(f);
        }


        public void imprimeDepartamento()
        {
            foreach (Funcionario f in funcionarios)
            {
                f.imprimeFuncionario();
            }
        }
    }
}

class Program
    {
        static void Main(string[] args)
        {
            Departamento d = new Departamento();

            d.nome = "vendas";
            d.adicionaFunc("Maria", "6765657", 123);
            d.adicionaFunc("Pedro", "2213438", 789);

            d.imprimeDepartamento();

            Console.ReadKey();
        }
    }
}
