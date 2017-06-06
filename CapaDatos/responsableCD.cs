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
            var query = from tblResponsable in ctx.responsable
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
        public void registrarResponsable(responsable resp)
        {
            try
            {
                ctx.responsable.Add(resp);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
