﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Alumno()
        {
            Nombre = "Pendiente";
            Matricula = "Sin Asignar";
            Nacimiento = "Sin Asignar";
            Direccion = "Sin Asignar";
            Telefono = "Sin Asignar";
        }
    }
}
