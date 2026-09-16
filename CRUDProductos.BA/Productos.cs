using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDProductos.BA
{
    public class Productos
    {
        public Producto[] Lista { get; set; } = new Producto[10];

        private int UltimoRegistroCargado = -1;

        public void Agregar(Producto producto)
        {
            int nuevoRegistro = UltimoRegistroCargado + 1;

            Lista[nuevoRegistro] = producto;
            UltimoRegistroCargado = nuevoRegistro;
        }

        public string Listar()
        {
            string listado = "";
            for (int i = 0; i <= UltimoRegistroCargado; i++)
            {
                listado = listado + Lista[i].Renglon() + "\n";
            }

            return listado;
        }
    }
}
