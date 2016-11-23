﻿using System;

namespace Tienda.Pe.Aplicacion.Seguridad.Entidades
{
    public class Rol
    {
        public int RolId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }

    }
}
