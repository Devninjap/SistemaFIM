﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class facultadCN
    {
        //INSTANCIAS
        facultadCD obj = new facultadCD();
        public List<facultad> getFacultad()
        {
            return obj.getFacultad();
        }
    }
}