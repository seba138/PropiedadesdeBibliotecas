using System;

using System.Windows.Forms;

using ClassLibraryBibliotecaEjemplo; // Biblioteca creada anteriormente 



namespace AppFormEjemplo
{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

            btnMostrar.Click += btnMostrar_Click;

        }



        private void btnMostrar_Click(object sender, EventArgs e)

        {

            Producto producto = new Producto();



            producto.Nombre = txtNombre.Text;

            if (decimal.TryParse(txtPrecio.Text, out decimal precio))

            {

                producto.Precio = precio;



                lblResultado.Text = producto.ObtenerDescripcion();

            }

            else

            {

                MessageBox.Show("Ingresa un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
