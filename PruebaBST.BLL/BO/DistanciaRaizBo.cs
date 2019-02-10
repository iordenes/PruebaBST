using DAL.Implementacion;
using PruebaBST.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBST.BLL.BusinessObject
{
    public class DistanciaRaizBo : IOpcionBo
    {
        public int Procesar(IList<int> lstParametros)
        {
            ArbolDao arbolDao = new ArbolDao();

            var arbol = arbolDao.ObtenerArbol();

            //arbol.Where(x=>x.NumeroRaiz == lstParametros.fir)

            return 0;
        }
    }
}
