namespace Waltrace
{
    public partial class TrabajadorSeleccionado : Form
    {
        public TrabajadorSeleccionado()
        {
            InitializeComponent();

            /*
            Al cargar la ventana deben imprimirse los datos del trabajador seleccionado mediante la llamada
            de un método en este paso o en el anterior.
            */
        }

        // Botón Aceptar:
        private void AceptarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void AceptarButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}