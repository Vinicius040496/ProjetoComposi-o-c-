using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoComposição.Entites.Enums;
using ProjetoComposição.Entites;

namespace ProjetoComposição.Entites
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public NivelFuncionario Nivel { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();

        public Funcionario()
        {

        }

        public Funcionario(string nome, NivelFuncionario nivel, double baseSalario, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }
        public void AdicionarContratos(HorasContrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoverContratos(HorasContrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Ganho(int ano, int mes)
        {
            double sum = BaseSalario;
            foreach (HorasContrato c in Contratos)
            {
                if (c.Data.Year == ano && c.Data.Month == mes)
                {
                    sum += c.ValorTotal();
                }
                
            }
            return sum;

            }
        }
    }
