using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class responsableCN
    {
        responsableCD obj = new responsableCD(); 
        public object getResponsable()
        {
            return obj.getResponsable();
        }
        public void registrarResponsable(responsable resp)
        {
            obj.registrarResponsable(resp);
        }
        public responsable consultarResponsable(int idResp)
        {
            return obj.consultarResponsable(idResp);
        }
        public void modificarResponsable(responsable resp)
        {
            obj.modificarResponsable(resp);
        }
    }
}
