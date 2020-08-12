﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GestorCyF.COMMON.Entidades
{
    public class Servicios : BaseDTO
    {
        public string folio_servicio { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string descripcion { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} ({3}", folio_servicio, nombre, precio, descripcion);
        }
    }
}
