using CRUDProductos.BA;

namespace CRUDProductos.FE
{
    public partial class frmCRUDProductos : Form
    {
        Productos listaProductos = new Productos();
        int posicion = -1;

        public frmCRUDProductos()
        {
            InitializeComponent();
            Limpiar();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Codigo = txtCodigo.Text;
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            listaProductos.Agregar(producto);

            Limpiar();
            lblSalida.Text = $"Producto agregado {producto.Nombre} correctamente";
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            lblSalida.Text = listaProductos.Listar();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            BuscarPorCodigo();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int posicion = BuscarPorCodigo();
            string mensaje = "¿Está seguro que desea eliminar el producto con código: "
                               + listaProductos.Lista[posicion].Codigo
                               + "-"
                               + listaProductos.Lista[posicion].Nombre
                               + "?";
            DialogResult resultado = MessageBox.Show(mensaje,
                            "Eliminar producto",
                            MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                listaProductos.Eliminar(posicion);
                Limpiar();
                lblSalida.Text = "Producto eliminado correctamente";
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Codigo = txtCodigo.Text;
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Cantidad = Convert.ToInt32(txtCantidad.Text);

            listaProductos.Actualizar(posicion, producto);

            Limpiar();
            lblSalida.Text = $"Producto actualizado {producto.Nombre} correctamente";
        }

        private int BuscarPorCodigo()
        {
            if (txtCodigo.Text == "")
            {
                lblSalida.Text = "Debe ingresar un código para buscar";
                posicion = -1;
            }
            else
            {
                posicion = listaProductos.BuscarPorCodigo(txtCodigo.Text);
                if (posicion == -1)
                {
                    lblSalida.Text = "No se encontró el producto con código: " + txtCodigo.Text;
                }
                else
                {
                    txtCodigo.Text = listaProductos.Lista[posicion].Codigo;
                    txtNombre.Text = listaProductos.Lista[posicion].Nombre;
                    txtPrecio.Text = listaProductos.Lista[posicion].Precio.ToString();
                    txtCantidad.Text = listaProductos.Lista[posicion].Cantidad.ToString();

                    btActualizar.Enabled = true;
                    btEliminar.Enabled = true;
                    btAgregar.Enabled=false;

                    txtCodigo.Enabled = false;
                    txtNombre.Focus();
                }
            }
            return posicion;
        }

        private void Limpiar()
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtNombre.Clear();
            txtPrecio.Clear();

            lblSalida.Text = "";

            btActualizar.Enabled = false;
            btEliminar.Enabled = false;
            btAgregar.Enabled = true;

            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }
    }
}