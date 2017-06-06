using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class egresadoCD
    {
        SistemaFIMDBEntities ctx = new SistemaFIMDBEntities();
        //LISTAR EGRESADOS
        public object getEgresado()
        {
            var query = from tblEgresado in ctx.egresado
                        join tblFacultad in ctx.facultad 
                        on tblEgresado.idFacultad equals tblFacultad.idFacultad //aqui un RICO JOIN
                        select new
                        {
                            tblEgresado.idEgresado,
                            tblEgresado.nomEgresado,
                            tblEgresado.apePatEgresado,
                            tblEgresado.apeMatEgresado,
                            tblFacultad.nomFacultad
                        };
            
            //List<egresado> egreList = query.ToList<egresado>();
            return query.ToList();
            //return ctx.egresado.ToList();
        }
        //INSERTAR EGRESADO
        public void registrarEgresado(egresado eg)
        {
            try
            {
                ctx.egresado.Add(eg);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
