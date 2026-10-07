using CRUDProductos.Shared.ENUM;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDProductos.BA
{
    /// <summary>
    /// Clase que representa una lista de productos y proporciona métodos para agregar, 
    /// listar, buscar y eliminar productos.
    /// </summary>
    public class Productos
    {
        /// <summary>
        /// Lista de productos almacenados en un arreglo de tamaño fijo (10).
        /// </summary>
        public Producto[] Lista { get; set; } = new Producto[10];
        
        private int UltimoRegistroCargado = -1;

        public void Agregar(Producto producto)
        {
            int nuevoRegistro = UltimoRegistroCargado + 1;

            producto.EstadoRegistro = EnumEstadoRegistro.Activo;

            Lista[nuevoRegistro] = producto;
            UltimoRegistroCargado = nuevoRegistro;
        }

        public void Actualizar(int posicion,Producto producto)
        {
            Lista[posicion] = producto;
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
                    //listado = listado 
                    //    + producto.Codigo 
                    //    + " - " 
                    //    + producto.Nombre
                    //    + " - "
                    //    + producto.Cantidad.ToString()
                    //    + "\n";
                    listado = listado
                        + producto.RenglonResumido()
                        + "\n";

                }
            }

            return listado;
        }

        public string ListarActivos()
        { 
            string listado = "";

            foreach (Producto item in Lista)
            {
                if (item != null && item.EstadoRegistro == EnumEstadoRegistro.Activo)
                {
                    listado = listado + item.RenglonResumido() + "\n";
                }
            }

            return listado;
        }

        /// <summary>
        /// Busca un producto por su código y devuelve su posición en la lista
        /// </summary>
        /// <param name="codigo"> Código del producto a buscar</param>
        /// <returns>Posición del producto en la lista o -1 si no se encuentra</returns>
        public int BuscarPorCodigo(string codigo)
        {
            // si devuelve -1 es que no encontró el producto
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
            UltimoRegistroCargado = UltimoRegistroCargado - 1;
        }

        public void CambiarEstado(int posicion, EnumEstadoRegistro nuevoEstado)
        {
            Lista[posicion].EstadoRegistro = nuevoEstado;
        }
    }
}
