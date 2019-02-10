using DAL.Entidades;
using DAL.Implementacion;
using DAL.Mapper;
using PruebaBST.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enumerables.Enum.OpcionCalculo;

namespace PruebaBST.BLL.BO
{
    public class IngresarNodoBo : IOpcionBo
    {
        /// <summary>
        /// Método que ingresa el listado Inicial
        /// </summary>
        /// <param name="lstParametros"></param>
        /// <returns></returns>
        #region [Procesar]
        public int Procesar(IList<int> lstParametros)
        {
            var arbol = new List<ArbolEntity>();
            int i = 0;
            int idPadre = 0;
            int nivel = 0;
            foreach (var item in lstParametros)
            {
                int ultimoNivel = arbol.Any() ? arbol.Max(x => x.Nivel) : 0;
                if (!arbol.Any())
                {
                    arbol.Add(ArbolMapper.ToEntity(i, item, null, DireccionEnum.Derecha, nivel));
                    nivel++;
                }
                else
                {
                    foreach (var itemNodo in arbol)
                    {
                        if (itemNodo.NumeroRaiz < item)
                        {
                            if (ultimoNivel == itemNodo.Nivel)
                            {
                                arbol.Add(ArbolMapper.ToEntity(i, item, idPadre, DireccionEnum.Derecha, nivel));
                                nivel++;
                                break;
                            }

                        }
                        else
                        {
                            if (ultimoNivel == itemNodo.Nivel)
                            {
                                arbol.Add(ArbolMapper.ToEntity(i, item, idPadre, DireccionEnum.Izquierda, nivel));
                                nivel++;
                                break;
                            }
                        }
                    }
                }
                idPadre = i;
            }
            return 0;
        }
        #endregion
    }
}
