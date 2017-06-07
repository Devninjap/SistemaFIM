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
        //LISTAR EGRESADOS
        public object getEgresado()
        {
            return obj.getEgresado();
        }
        //REGISTRAR EGRESADO
        public void registrarEgresado(Egresado eg)
        {
            obj.registrarEgresado(eg);
        }
        //CONSULTAR EGRESADO
        public Egresado consultarEgresado(int idEgre)
        {
            return obj.consultarEgresado(idEgre);
        }

        //MODIFICAR EGRESADO
        public void modificarEgresado(Egresado egre)
        {
            obj.modificarEgresado(egre);
        }
    }
}
