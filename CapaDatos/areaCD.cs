using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class areaCD
    {
        SistemaFIMDBEntities ctx = new SistemaFIMDBEntities();
        //LISTAR AREAS
        public List<Area> getArea()
        {
            return ctx.Area.ToList();
        }

    }
}
