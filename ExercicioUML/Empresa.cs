using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExercicioUML
{
    internal class Empresa
    {
        public string Nome { get; private set; }
        public static int QtdFuncionarios { get; private set; }
        public string CNPJ { get; private set; }
        public List<Empregado> Empregados { get; private set; }

        public Empresa(string nome, string CNPJ)
        {
            this.Nome = nome;
            this.CNPJ = CNPJ;
            this.Empregados = new();
        }
        public void ListarEmpregados()
        {
            foreach (var empregado in Empregados)
            {
                Console.WriteLine($"Nome:\t{empregado.Nome} {empregado.Sobrenome}\n" +
                    $"Matrícula:\t{empregado.Matricula}\n\n");

            }
        }
        public void CadastrarEmpregado(string nome, string sobrenome, int idade, DateTime dataNascimento, DateTime dataContratacao, double salarioMensal)
        { 
            this.Empregados.Add(new Empregado(nome, sobrenome, idade, dataNascimento, dataContratacao, salarioMensal));
            AdicionarFuncionario();
        }
        public static void AdicionarFuncionario()
        {
            QtdFuncionarios++;
        }
        public void CadastrarEmpregado(string nome, string sobrenome, int idade, DateTime dataNascimento)
        {
            this.Empregados.Add(new Empregado(nome, sobrenome, idade, dataNascimento));
            AdicionarFuncionario();
        }
        public void DemitirEmpregado(string nome, string sobrenome)
        {
            var buscaEmpregado = this.Empregados.SingleOrDefault(b => b.Nome == nome && b.Sobrenome == sobrenome);
            if (buscaEmpregado != null)
            {
                this.Empregados.Remove(buscaEmpregado);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            
        }
        public void ListarSalarioAnual(string nome, string sobrenome)
        {
            var buscaEmpregado = this.Empregados.SingleOrDefault(b => b.Nome == nome && b.Sobrenome == sobrenome);
            if(buscaEmpregado != null) 
            {
                Console.WriteLine($"{nome} {sobrenome}");
                Console.WriteLine($"Salário Anual:\t{buscaEmpregado.SalarioMensal*12:C}");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            
        }
        public void PromoverEmpregado(string nome, string sobrenome)
        {
            var buscaEmpregado = this.Empregados.SingleOrDefault(b => b.Nome == nome && b.Sobrenome == sobrenome);
            if (buscaEmpregado != null)
            {
                Empregado.AumentarSalario(buscaEmpregado);
                Console.WriteLine($"{nome} {sobrenome}");
                Console.WriteLine($"Novo Salário Mensal:\t{buscaEmpregado.SalarioMensal:C}");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
    }
}
