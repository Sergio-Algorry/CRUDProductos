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
            //for (int i = 0; i <= UltimoRegistroCargado; i++)
            //{
            //    listado = listado + Lista[i].Codigo + " - " + Lista[i].Nombre + "\n";
            //}

            foreach (Producto producto in Lista)
            {
                if (producto != null)
                {
                    listado = listado 
                        + producto.Codigo 
                        + " - " 
                        + producto.Nombre
                        + " - "
                        + producto.Cantidad.ToString()
                        + "\n";
                }
            }

            return listado;
        }

        public int BuscarPorCodigo(string codigo)
        {
            int posicion = -1;

            //foreach (Producto item in Lista)
            //{
            //    if (item != null && item.Codigo == codigo)
            //    {
            //        posicion = Array.IndexOf(Lista, item);
            //        break;
            //    }
            //}

            for (int i = 0; i <= UltimoRegistroCargado; i++)
            {
                if (Lista != null)
                {
                    if (Lista[i].Codigo == codigo)
                    {
                        posicion = i;
                        break;
                    }
                }
            }

            return posicion;
        }

        public void Eliminar(int posicion)
        {
            for (int i = posicion+1; i <= UltimoRegistroCargado; i++)
            {
                Lista[i-1] = Lista[i];
            }
            Lista[UltimoRegistroCargado] = null;
        }
    }
}
