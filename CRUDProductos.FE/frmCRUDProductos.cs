using CRUDProductos.BA;

namespace CRUDProductos.FE
{
    public partial class frmCRUDProductos : Form
    {
        Productos listaProductos = new Productos();
        public frmCRUDProductos()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Codigo = txtCodigo.Text;
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            listaProductos.Agregar(producto);

            lblSalida.Text = listaProductos.Listar();
        }
    }
}
