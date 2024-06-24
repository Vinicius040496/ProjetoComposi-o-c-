using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComposição.Entites
{
    internal class HorasContrato
    {
        public  DateTime Data { get; set; }

        public double ValorHora { get; set; }
        public int Horas {  get; set; }

        public HorasContrato()
        {

        }

        public HorasContrato(DateTime data, double valorHora, int horas)
        {
            Data = data;
            ValorHora = valorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return Horas * ValorHora;
        } 
    }
}
