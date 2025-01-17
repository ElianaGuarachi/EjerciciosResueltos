﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;
        }

        public string Mostrar()
        {
            StringBuilder stringB = new StringBuilder();
            stringB.AppendLine($"Nombre: {Nombre}");
            stringB.AppendLine($"DNI: {Dni}");
            return stringB.ToString();
        }

    }
}
