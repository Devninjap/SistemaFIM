using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class egresadoCN
    {
        //INSTANCIAS
        egresadoCD obj = new egresadoCD();
        public object getEgresado()
        {
            return obj.getEgresado();
        }
        public void registrarEgresado(egresado eg)
        {
            obj.registrarEgresado(eg);
        }
    }
}
