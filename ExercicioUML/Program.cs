using ExercicioUML;
using System.Text.RegularExpressions;

namespace ExercicioUML
{
    internal class Program
    {
        public static ConsoleKeyInfo input;
        static void Main(string[] args)
        {
            bool teste = true;
            Empresa empresa = new("Carrefour", "1234567890001");

            
            do
            {
                Console.WriteLine("MENU\n1 - Cadastro de Funcionários.\n2 - Listar todos os empregados cadastrados." +
                "\n3 - Promover Empregado.\n4 - Demitir Empregado.\n5 - Listar salário anual do empregado.\n6 - Sair");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        empresa.CadastrarEmpregado("Afonso", "Freitas", 19, new DateTime(2010, 09, 14), new DateTime(2023, 10, 01), 1100.0D);
                        empresa.CadastrarEmpregado("Amanda", "Silva", 23, new DateTime(2010, 09, 14), new DateTime(2023, 10, 01), 1100.0D);
                        empresa.CadastrarEmpregado("Carlos", "Silva", 24, new DateTime(2010, 09, 14), new DateTime(2023, 10, 01), 1500.0D);
                        empresa.CadastrarEmpregado("Augusto", "Souza", 27, new DateTime(2010, 09, 14));
                        empresa.CadastrarEmpregado("Camila", "Lima", 18, new DateTime(2010, 09, 14));
                        Console.WriteLine("Funcionários cadastrados!");
                        Console.WriteLine("Digite qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        empresa.ListarEmpregados();
                        Console.WriteLine("Digite qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        empresa.PromoverEmpregado("Amanda", "Silva");
                        Console.WriteLine("Digite qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        empresa.DemitirEmpregado("Afonso", "Freitas");
                        Console.WriteLine("Digite qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        empresa.ListarSalarioAnual("Amanda", "Silva");
                        empresa.ListarSalarioAnual("Carlos", "Silva");
                        Console.WriteLine("Digite qualquer tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        teste = false;
                        break;
                    default: 
                        break;
                }
            } while(teste);
            //Empresa empresa = new("Carrefour", "1234567890001");
            //empresa.CadastrarEmpregado("Afonso", "Freitas", 19, new DateTime(2010, 09, 14), new DateTime(2023, 10, 01), 1100.0D);
            //empresa.CadastrarEmpregado("Amanda", "Silva", 23, new DateTime(2010, 09, 14), new DateTime(2023, 10, 01), 1100.0D);
            //empresa.CadastrarEmpregado("Carlos", "Silva", 24, new DateTime(2010, 09, 14), new DateTime(2023, 10, 01), 1500.0D);
            //empresa.ListarEmpregados();

            //Console.WriteLine("Demissão");
            //empresa.DemitirEmpregado("Afonso", "Freitas");
            //empresa.ListarEmpregados();

            //empresa.ListarSalarioAnual("Amanda", "Silva");
            //empresa.ListarSalarioAnual("Carlos", "Silva");

            //Console.WriteLine("\nAumento de salario");
            //empresa.PromoverEmpregado("Amanda", "Silva");
            //empresa.ListarSalarioAnual("Amanda", "Silva");
            //empresa.ListarSalarioAnual("Carlos", "Silva");


        }
    }
}