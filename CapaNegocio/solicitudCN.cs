﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class solicitudCN
    {
        //INSTANCIAS
        egresadoCD obj = new egresadoCD();
        solicitudCD objSolcitud = new solicitudCD();
        //LISTAR EGRESADOS
        public object getEgresado()
        {
            return obj.getEgresado();
        }
        public void registrarSol(Solicitud sol)
        {
            objSolcitud.registrarSol(sol);
        }
    }

}