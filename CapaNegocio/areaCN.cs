using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class areaCN
    {
        //INSTANCIAS
        areaCD obj = new areaCD();
        public List<area> getArea()
        {
            return obj.getArea();
        }
    }
}
