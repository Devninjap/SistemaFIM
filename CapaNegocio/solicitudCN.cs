using System;
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
        egresadoCD objEgresado= new egresadoCD();
        solicitudCD objSolicitud = new solicitudCD();
        //LISTAR EGRESADOS
        public object getEgresado()
        {
            return objEgresado.getEgresado();
        }
        //CONSULTAR SOLICITUDES
        public object listarSolicitudPorEgresado(int idEgre)
        {
            return objSolicitud.listarSolicitudPorEgresado(idEgre);
        }
    }
}
