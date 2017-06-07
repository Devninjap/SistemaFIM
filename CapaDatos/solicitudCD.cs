using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class solicitudCD
    {
        SistemaFIMDBEntities ctx = new SistemaFIMDBEntities();
        //LISTAR EGRESADOS
        public object getEgresado()
        {
            try
            {
                var query = from tblEgresado in ctx.Egresado
                            join tblFacultad in ctx.Facultad
                            on tblEgresado.idFacultad equals tblFacultad.idFacultad
                            select new
                            {
                                Id = tblEgresado.idEgresado,
                                Egresado = tblEgresado.apePatEgresado.ToUpper() + " " + tblEgresado.apeMatEgresado.ToUpper() + ", " + tblEgresado.nomEgresado.ToUpper(),
                                Facultad = tblFacultad.nomFacultad
                            };
                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }                    
        }

        public object listarSolicitudPorEgresado(int idEgre)
        {
            try
            {
                var query = from tblSolicitud in ctx.Solicitud
                            //join tblEgresado in ctx.Egresado
                            //on tblSolicitud.idEgresado equals tblEgresado.idEgresado
                            where tblSolicitud.idEgresado == idEgre
                            select new
                            {
                                tblSolicitud.idSolicitud,
                                tblSolicitud.asuntoSolicitud,
                                tblSolicitud.numRegSolicitud,
                                tblSolicitud.fechaRecSolicitud
                            };

                return query.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void registrarSol(Solicitud sol)
        {
            try
            {
                ctx.Solicitud.Add(sol);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
