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
<<<<<<< HEAD
        egresadoCD obj = new egresadoCD();
        solicitudCD objSolcitud = new solicitudCD();
=======
        egresadoCD objEgresado= new egresadoCD();
        solicitudCD objSolicitud = new solicitudCD();
>>>>>>> 6b554cc98c693fbbced66219c51124d2b408b193
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
        public void registrarSol(Solicitud sol)
        {
            objSolcitud.registrarSol(sol);
        }
    }

}
