﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                bool resultado = this + value;
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

       

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if(cliente == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            if(n.ClientesPendientes > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

    }
}
