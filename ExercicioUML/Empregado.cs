using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUML
{
    internal class Empregado
    {
        public string Nome {  get; private set; }
        public string Sobrenome { get; private set; }
        public int Matricula {  get; private set; }
        public int Idade {  get; private set; }
        public DateTime DataNascimento {  get; private set; }
        public DateTime DataContracacao { get; private set; }
        public double SalarioMensal {  get; private set; }
        private double salarioMinimo = 1320.0D;
        //private double SalarioMinimo 


        /// <summary>
        /// Método construtor com dados básicos
        /// </summary>
        /// <param name="nome">Nome do Empregado</param>
        /// <param name="sobrenome">Sobrenome do Empregado</param>
        /// <param name="idade">Idade do Empregado</param>
        /// <param name="dataNascimento">Data Nascimento do Empregado</param>
        public Empregado(string nome, string sobrenome, int idade, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.Matricula = new Random().Next(9999);
            this.DataNascimento = dataNascimento;
            this.DataContracacao = DateTime.Now;
            this.SalarioMensal = salarioMinimo;
        }
        /// <summary>
        /// Método construtor completo
        /// </summary>
        /// <param name="nome">Nome do Empregado</param>
        /// <param name="sobrenome">Sobrenome do Empregado</param>
        /// <param name="idade">Idade do Empregado</param>
        /// <param name="dataNascimento">Data Nascimento do Empregado</param>
        /// <param name="dataContratacao">Data da contratação</param>
        /// <param name="salarioMensal">Salario Mensal</param>
        public Empregado(string nome, string sobrenome, int idade, DateTime dataNascimento, DateTime dataContratacao, double salarioMensal)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;
            this.Matricula = new Random().Next(9999);
            this.DataNascimento = dataNascimento;
            this.DataContracacao = dataContratacao;
            this.SalarioMensal = VerificarSalarioMinimo(salarioMensal);
        }
        //public void CadastrarEmpregado(string nome, string sobrenome, int idade, DateTime dataNascimento, DateTime dataContratacao, double salariomensal)
        //{
        //    this.Nome = nome;
        //    this.Sobrenome = sobrenome;
        //    this.Idade = idade;
        //    this.DataNascimento = dataNascimento;
        //    this.DataContracacao = dataContratacao;
        //    this.SalarioMensal = VerificarSalarioMinimo(salariomensal);
        //}

        /// <summary>
        /// Método para Aumentar Salario
        /// </summary>
        /// <param name="empregado">Objeto Empregado</param>
        public static void AumentarSalario(Empregado empregado)
        {
            empregado.SalarioMensal = empregado.SalarioMensal + (empregado.SalarioMensal * 10 / 100);
        }

        /// <summary>
        /// Método para verificar se o salário Mensal é menor que o mínimo
        /// </summary>
        /// <param name="salariomensal"></param>
        /// <returns></returns>
        public double VerificarSalarioMinimo(double salariomensal)
        {
            if (salariomensal < salarioMinimo) return salarioMinimo;
            return salariomensal;
            
        }
    }
}
