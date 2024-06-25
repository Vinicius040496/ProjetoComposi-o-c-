using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoComposição.Entites.Enums;
using ProjetoComposição.Entites;
using System.Globalization;

namespace ProjetoComposição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com nome do departamento: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("Entre com dados do funcionario: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel (Junior/Intermediário/Senior): ");
            NivelFuncionario nivel = (NivelFuncionario)Enum.Parse(typeof(NivelFuncionario), (Console.ReadLine()));
            Console.Write("Base salarial: ");
            double baseSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Departamento dept = new Departamento(departamento);
            Funcionario funcionario = new Funcionario(dept, nome, nivel, baseSalario);

            Console.Write("Quantos contratos deseja cadastrar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Contrato #{0}",i);
                Console.Write("Data do contrato: DD/MM/YYYY ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor hora do contrato: ");
                double valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duração (Horas) do contrato: ");
                int horas = int.Parse(Console.ReadLine());
                Console.WriteLine();
                HorasContrato contrato = new HorasContrato(data,valorHora, horas);
                funcionario.AdicionarContratos(contrato);
            }
            Console.Write("Entre com dados para calculo de ganhos do mês e ano selecionado: ");
            Console.Write("(MM/YYYY): ");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));

            Console.WriteLine();

            Console.WriteLine("Dados funcionario: ");
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Departamento: " + funcionario.Departamento.Nome);
            Console.WriteLine("Ganhos por hora no periodo {0}: {1} Reais", mesEano,funcionario.Ganho(ano,mes).ToString("f2"),CultureInfo.InvariantCulture);
            Console.ReadLine();
        }
    }
}
