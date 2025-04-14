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
                File.Create(rutaArchivo);                
            }
        }

        private void btnAddGasto_Click(object sender, EventArgs e)
        {
            vtnNuevoGasto nuevoGasto = new vtnNuevoGasto();
            nuevoGasto.ShowDialog();
        }
    }
}
