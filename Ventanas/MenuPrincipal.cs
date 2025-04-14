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

        }

        private void btnAddGasto_Click(object sender, EventArgs e)
        {
            vtnNuevoGasto nuevoGasto = new vtnNuevoGasto();
            nuevoGasto.ShowDialog();
        }
    }
}
