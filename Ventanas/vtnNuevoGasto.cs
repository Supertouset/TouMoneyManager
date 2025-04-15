using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouMoneyManager.Clases;

namespace TouMoneyManager
{
    public partial class vtnNuevoGasto : Form
    {
        public Gasto GastoResult { get; private set; }

        public vtnNuevoGasto(string accion, Gasto gasto)
        {
            InitializeComponent();

            if (accion == "Modificar")
            {
                tbConcepto.Text = gasto.Concepto;
                tbCantidad.Text = gasto.Cantidad.ToString();
                tbCategoria.Text = gasto.Categoria;
                cmbPeriodicidad.Text = gasto.Frecuencia;
                this.GastoResult = gasto;
            }
            else
            {
                tbConcepto.Text = "";
                tbCantidad.Text = "";
                tbCategoria.Text = "";
                cmbDivisa.Text = "Euros";
                cmbPeriodicidad.Text = "Semanal";
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string concepto = string.IsNullOrEmpty(tbConcepto.Text) ? "Sin concepto" : tbConcepto.Text;
            double cantidad = double.Parse(string.IsNullOrEmpty(tbCantidad.Text) ? "0" : tbCantidad.Text);
            DateTime fechaInicio = DateTime.Now;
            string categoria = string.IsNullOrEmpty(tbCategoria.Text) ? "Desconocido" : tbCategoria.Text;
            string frecuencia = cmbPeriodicidad.Text;

            Gasto nuevoGasto = new Gasto(concepto, cantidad, fechaInicio, categoria, frecuencia);
            GastoResult = nuevoGasto;

            MessageBox.Show("Gasto guardado correctamente.");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
