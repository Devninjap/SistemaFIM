using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class responsableCD
    {
        SistemaFIMDBEntities ctx = new SistemaFIMDBEntities();
        //LISTAR RESPONSABLES
        public object getResponsable()
        {
            var query = from tblResponsable in ctx.Responsable
                        select new
                        {
                            tblResponsable.idResponsable,
                            tblResponsable.nomResponsable,
                            tblResponsable.apePatResponsable,
                            tblResponsable.apeMatResponsable
                        };
            return query.ToList();
        }
        //INSERTAR RESPONSABLE
        public void registrarResponsable(Responsable resp)
        {
            try
            {
                ctx.Responsable.Add(resp);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //CONSULTAR RESPONSABLE
        public Responsable consultarResponsable(int idResp)
        {
            try
            {
                var query = from tblResponsable in ctx.Responsable
                            where tblResponsable.idResponsable == idResp
                            select tblResponsable;

                return query.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }

        }
        //MODIFICAR RESPONSABLE
        public void modificarResponsable(Responsable resp)
        {
            try
            {
                //LINQ
                /*
                var query1 = (from a in ctx.responsable
                              where a.idEgresado == resp.idEgresado
                              select a).Single();
                */
                //LAMBDA
                var query2 = ctx.Responsable.Where(q => q.idResponsable == resp.idResponsable).FirstOrDefault();

                //llamada a cada atributo de la tabla
                query2.nomResponsable = resp.nomResponsable;
                query2.apePatResponsable = resp.apePatResponsable;
                query2.apeMatResponsable = resp.apeMatResponsable;
                query2.cargoResponsable = resp.cargoResponsable;
                query2.gradoAcaResponsable = resp.gradoAcaResponsable;
                query2.idArea = resp.idArea;
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
