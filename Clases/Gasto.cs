using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        internal static Gasto FromXML(string xml)
        {
            // Cargar el XML en un XDocument
            XDocument doc = XDocument.Parse(xml);

            // Extraer los valores de los elementos
            string concepto = doc.Root.Element("Concepto")?.Value ?? string.Empty;
            double cantidad = double.Parse(doc.Root.Element("Cantidad")?.Value ?? "0");
            DateTime fechaInicio = DateTime.Parse(doc.Root.Element("FechaInicio")?.Value ?? DateTime.Now.ToString("yyyy-MM-dd"));
            string categoria = doc.Root.Element("Categoria")?.Value ?? string.Empty;
            string frecuencia = doc.Root.Element("Frecuencia")?.Value ?? string.Empty;

            // Crear y devolver un nuevo objeto Gasto
            return new Gasto(concepto, cantidad, fechaInicio, categoria, frecuencia);
        }
        public override string ToString()
        {
            return $"{concepto} - {cantidad} - {fechaInicio?.ToShortDateString()} - {categoria} - {frecuencia}";
        }
        public string ToXML()
        {
            return $"<Gasto>" +
                    $"<Concepto>{concepto}</Concepto>" +
                    $"<Cantidad>{cantidad}</Cantidad>" +
                    $"<FechaInicio>{fechaInicio?.ToString("yyyy-MM-dd")}</FechaInicio>" +
                    $"<Categoria>{categoria}</Categoria>" +
                    $"<Frecuencia>{frecuencia}</Frecuencia>" +
                    $"</Gasto>";
        }
    }
}
