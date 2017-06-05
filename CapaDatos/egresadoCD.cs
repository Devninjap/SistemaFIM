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
        public object GetEgresado()
        {
            var query = from item in ctx.egresado
                        select new
                        {
                            item.nomEgresado,
                            item.apePatEgresado,
                            item.apeMatEgresado
                        };
            
            //List<egresado> egreList = query.ToList<egresado>();
            return query.ToList();
            //return ctx.egresado.ToList();
        }
        //INSERTAR EGRESADO
        public void RegistrarEgresado(egresado eg)
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
            egresadoCD obj = new egresadoCD();
            obj.RegistrarEgresado(eg);
        }
    }
}
