namespace Waltrace
{
    public partial class TrabajadorSeleccionado : Form
    {
        public TrabajadorSeleccionado()
        {
            InitializeComponent();

            /*
            Al cargar la ventana deben imprimirse los datos del trabajador seleccionado en el paso anterior,
            de alguna forma hay que comunicar un método entre scripts. 
            */
        }

        // Botón descargar currículum
        private void CurriculumButton_Click(object sender, EventArgs e)
        {

        }

        private void CurriculumButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void CurriculumButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        // Botón regresar:
        private void RegresarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegresarButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void RegresarButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}