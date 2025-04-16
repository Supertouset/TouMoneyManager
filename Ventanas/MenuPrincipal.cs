using TouMoneyManager.Clases;

namespace TouMoneyManager
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string directorioApp = Path.Combine(rutaRoaming, "TouMoneyManager");
            string rutaArchivo = Path.Combine(directorioApp, "data.tou");

            if (!Directory.Exists(directorioApp))
            {
                Directory.CreateDirectory(directorioApp);
            }

            if (!File.Exists(rutaArchivo))
            {
                using (File.Create(rutaArchivo)) { }
            }
            else
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Gasto gasto = Gasto.FromXML(line);
                        ListViewItem item = new ListViewItem(gasto.Concepto);
                        item.SubItems.Add(gasto.Cantidad.ToString());
                        item.SubItems.Add(gasto.FechaInicio.ToShortDateString());
                        item.SubItems.Add(gasto.Categoria);
                        item.SubItems.Add(gasto.Frecuencia);
                        item.Tag = gasto;
                        lvGastosRecurrentes.Items.Add(item);
                    }
                }
            }
        }

        private void btnAddGasto_Click(object sender, EventArgs e)
        {
            Gasto gasto;
            vtnNuevoGasto vtnNuevoGasto;

            if (lvGastosRecurrentes.SelectedItems.Count == 1)
            {
                ListViewItem item = lvGastosRecurrentes.SelectedItems[0];
                gasto = (Gasto)item.Tag;
                vtnNuevoGasto = new vtnNuevoGasto("Modificar", gasto);
            }
            else
            {
                gasto = new Gasto("", 0, DateTime.Now, "", "");
                vtnNuevoGasto = new vtnNuevoGasto("Crear", gasto);
            }

            vtnNuevoGasto.ShowDialog();
            gasto = vtnNuevoGasto.GastoResult;

            if (gasto != null)
            {
                ListViewItem item = new ListViewItem(gasto.Concepto);
                item.SubItems.Add(gasto.Cantidad.ToString());
                item.SubItems.Add(gasto.FechaInicio.ToShortDateString());
                item.SubItems.Add(gasto.Categoria);
                item.SubItems.Add(gasto.Frecuencia);
                item.Tag = gasto;
                lvGastosRecurrentes.Items.Add(item);
                GuardarGasto(gasto);
            }
        }

        private void GuardarGasto(Gasto gasto)
        {
            string rutaRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string directorioApp = Path.Combine(rutaRoaming, "TouMoneyManager");
            string rutaArchivo = Path.Combine(directorioApp, "data.tou");

            if (!Directory.Exists(directorioApp))
            {
                Directory.CreateDirectory(directorioApp);
            }

            if (!File.Exists(rutaArchivo))
            {
                using (File.Create(rutaArchivo)) { }
            }

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine(gasto.ToXML());
            }
        }
    }
}
