using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class facultadCD
    {
        SistemaFIMDBEntities ctx = new SistemaFIMDBEntities();
        //LISTAR FACULTADES
        public List<facultad> getFacultad()
        {
            return ctx.facultad.ToList();
        }

    }
}
