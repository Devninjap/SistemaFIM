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

        public egresado consultarEgresado(int idEgre)
        {
            try
            {
                var query = from tblEgresado in ctx.egresado
                            where tblEgresado.idEgresado == idEgre
                            select tblEgresado;

                return query.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void modificarEgresado(egresado egre)
        {
            try
            {
                //LINQ
                var query1 = (from a in ctx.egresado
                            where a.idEgresado == egre.idEgresado
                            select a).Single();
                //LAMBDA
                var query2 = ctx.egresado.Where(q => q.idEgresado == egre.idEgresado).FirstOrDefault();

                //llamada a cada atributo de la tabla
                query1.nomEgresado = egre.nomEgresado;
                query1.apePatEgresado = egre.apePatEgresado;
                query1.apeMatEgresado = egre.apeMatEgresado;
                query1.dniEgresado = egre.dniEgresado;
                query1.codMatEgresado = egre.codMatEgresado;
                query1.condicionEgresado = egre.condicionEgresado;
                query1.domicilioEgresado = egre.domicilioEgresado;
                query1.celEgresado = egre.celEgresado;
                query1.emailEgresado = egre.emailEgresado;
                query1.fotografiaEgresado = egre.fotografiaEgresado;
                query1.idFacultad = egre.idFacultad;
                //guardando cambios
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
