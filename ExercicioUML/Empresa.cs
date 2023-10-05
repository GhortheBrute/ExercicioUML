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

        /// <summary>
        /// Método construtor da Empresa
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="CNPJ"></param>
        public Empresa(string nome, string CNPJ)
        {
            this.Nome = nome;
            this.CNPJ = CNPJ;
            this.Empregados = new();
        }
        /// <summary>
        /// Método para Listar todos Empregados contratados
        /// </summary>
        public void ListarEmpregados()
        {
            foreach (var empregado in Empregados)
            {
                Console.WriteLine($"Nome:\t{empregado.Nome} {empregado.Sobrenome}\n" +
                    $"Matrícula:\t{empregado.Matricula}\n\n");

            }
        }

        /// <summary>
        /// Método completo para cadastrar Empregados na empresa
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="idade"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="dataContratacao"></param>
        /// <param name="salarioMensal"></param>
        public void CadastrarEmpregado(string nome, string sobrenome, int idade, DateTime dataNascimento, DateTime dataContratacao, double salarioMensal)
        { 
            this.Empregados.Add(new Empregado(nome, sobrenome, idade, dataNascimento, dataContratacao, salarioMensal));
            AdicionarFuncionario();
        }

        /// <summary>
        /// Método basico para cadastrar Empregados na empresa
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <param name="idade"></param>
        /// <param name="dataNascimento"></param>
        public void CadastrarEmpregado(string nome, string sobrenome, int idade, DateTime dataNascimento)
        {
            this.Empregados.Add(new Empregado(nome, sobrenome, idade, dataNascimento));
            AdicionarFuncionario();
        }

        /// <summary>
        /// Método para adicionar + 1 ao contador de Empregados
        /// </summary>
        public static void AdicionarFuncionario()
        {
            QtdFuncionarios++;
        }
        
        /// <summary>
        /// Método para demitir Empregado
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        public void DemitirEmpregado(string nome, string sobrenome)
        {
            var buscaEmpregado = this.Empregados.SingleOrDefault(b => b.Nome == nome && b.Sobrenome == sobrenome);
            if (buscaEmpregado != null)
            {
                this.Empregados.Remove(buscaEmpregado);
                QtdFuncionarios--;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            
        }

        /// <summary>
        /// Método para listar o salário Anual do Empregado
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
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
        /// <summary>
        /// Método para promover aumento de sálario do Empregado
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
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
