namespace CRUDProductos.FE
{
    partial class frmCRUDProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            btAgregar = new Button();
            lblSalida = new Label();
            btListar = new Button();
            btLimpiar = new Button();
            btBuscar = new Button();
            btEliminar = new Button();
            btActualizar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 22);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 45);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(203, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(149, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(368, 45);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(368, 22);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(499, 45);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 7;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(499, 22);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // btAgregar
            // 
            btAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btAgregar.Location = new Point(12, 93);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(94, 29);
            btAgregar.TabIndex = 8;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(24, 132);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(0, 20);
            lblSalida.TabIndex = 9;
            // 
            // btListar
            // 
            btListar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btListar.Location = new Point(324, 93);
            btListar.Name = "btListar";
            btListar.Size = new Size(94, 29);
            btListar.TabIndex = 10;
            btListar.Text = "Listar";
            btListar.UseVisualStyleBackColor = true;
            btListar.Click += btListar_Click;
            // 
            // btLimpiar
            // 
            btLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btLimpiar.Location = new Point(530, 93);
            btLimpiar.Name = "btLimpiar";
            btLimpiar.Size = new Size(94, 29);
            btLimpiar.TabIndex = 11;
            btLimpiar.Text = "Limpiar";
            btLimpiar.UseVisualStyleBackColor = true;
            btLimpiar.Click += btLimpiar_Click;
            // 
            // btBuscar
            // 
            btBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btBuscar.Location = new Point(424, 93);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(94, 29);
            btBuscar.TabIndex = 12;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // btEliminar
            // 
            btEliminar.Enabled = false;
            btEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btEliminar.Location = new Point(224, 93);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(94, 29);
            btEliminar.TabIndex = 13;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btActualizar
            // 
            btActualizar.Enabled = false;
            btActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btActualizar.Location = new Point(112, 93);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(94, 29);
            btActualizar.TabIndex = 14;
            btActualizar.Text = "Actualizar";
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // frmCRUDProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 450);
            Controls.Add(btActualizar);
            Controls.Add(btEliminar);
            Controls.Add(btBuscar);
            Controls.Add(btLimpiar);
            Controls.Add(btListar);
            Controls.Add(lblSalida);
            Controls.Add(btAgregar);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "frmCRUDProductos";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btAgregar;
        private Label lblSalida;
        private Button btListar;
        private Button btLimpiar;
        private Button btBuscar;
        private Button btEliminar;
        private Button btActualizar;
    }
}
