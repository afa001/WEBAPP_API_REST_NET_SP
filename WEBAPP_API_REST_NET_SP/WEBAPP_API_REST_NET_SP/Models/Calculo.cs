﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPP_API_REST_NET_SP.Models
{
    public class Calculo
    {
        public int Id { get; set; }
        public int Respuesta { get; set; }
        public System.DateTime FechaHora { get; set; }
        public int UsuarioId { get; set; }

        //public virtual Usuario Usuario { get; set; }
    }
}