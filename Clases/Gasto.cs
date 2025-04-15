using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouMoneyManager.Clases
{
    public class Gasto
    {
        private string concepto;
        private double cantidad;
        private DateTime? fechaInicio;
        private string? categoria;
        private string frecuencia;

        public Gasto(string concepto, double cantidad, DateTime fechaInicio, string categoria, string frecuencia)
        {
            this.concepto = concepto;
            this.cantidad = cantidad;
            this.fechaInicio = fechaInicio;
            this.categoria = categoria;
            this.frecuencia = frecuencia;
        }
        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }
        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public DateTime FechaInicio
        {
            get { return fechaInicio ?? DateTime.Now; }
            set { fechaInicio = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Frecuencia
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }
        public override string ToString()
        {
            return $"{concepto} - {cantidad} - {fechaInicio?.ToShortDateString()} - {categoria} - {frecuencia}";
        }
        public string ToXML()
        {
            return $"<Gasto>\n" +
                   $"  <Concepto>{concepto}</Concepto>\n" +
                   $"  <Cantidad>{cantidad}</Cantidad>\n" +
                   $"  <FechaInicio>{fechaInicio?.ToString("yyyy-MM-dd")}</FechaInicio>\n" +
                   $"  <Categoria>{categoria}</Categoria>\n" +
                   $"  <Frecuencia>{frecuencia}</Frecuencia>\n" +
                   $"</Gasto>";
        }
    }
}
