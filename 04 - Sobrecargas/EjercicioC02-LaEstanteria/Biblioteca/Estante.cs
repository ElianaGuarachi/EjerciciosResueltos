﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder stringB = new StringBuilder();

            stringB.AppendLine($"Estante ubicacion: {e.ubicacionEstante} \n");

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is not null)
                {
                    stringB.AppendLine(Producto.MostrarProducto(e.productos[i]));
                    stringB.AppendLine(" ");
                }
            }
            return stringB.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            if(e is not null && p is not null)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        { 
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if ((e != p))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }   
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if(e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }

    }
}
