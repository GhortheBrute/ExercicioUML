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
        public static void AumentarSalario(Empregado empregado)
        {
            empregado.SalarioMensal = empregado.SalarioMensal + (empregado.SalarioMensal * 10 / 100);
        }


        public double VerificarSalarioMinimo(double salariomensal)
        {
            if (salariomensal < salarioMinimo) return salarioMinimo;
            return salariomensal;
            
        }
    }
}
