using Enumerables.Enum;
using PruebaBST.BLL.BO;
using PruebaBST.BLL.BusinessObject;
using PruebaBST.BLL.Helpers;
using PruebaBST.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBST.BLL.Implementacion
{
    public class CalculoImpl : ICalculoImpl
    {
        /// <summary>
        /// Método Procesar génerico
        /// </summary>
        /// <param name="opcion"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        #region [Procesar]
        public string Procesar(OpcionCalculo.OpcionEnum opcion, string valor)
        {
            var parametros = CalculoHelper.SplitValor(valor);

            var implementacion = this.ObtenerImplementacion(opcion);

            var resultado = implementacion.Procesar(parametros);
            return "Resultado obtenido: " + resultado;
        }
        #endregion

        /// <summary>
        /// Método Obtener Implementación
        /// </summary>
        /// <param name="opcion"></param>
        /// <returns></returns>
        #region [Obtener Implementación]
        private IOpcionBo ObtenerImplementacion(OpcionCalculo.OpcionEnum opcion)
        {
            switch (opcion)
            {
                case OpcionCalculo.OpcionEnum.IngresoValores:
                    return new IngresarNodoBo();
                case OpcionCalculo.OpcionEnum.DistanciaNodo:
                    return new DistanciaNodoBo();
                case OpcionCalculo.OpcionEnum.DistanciaValores:
                    return new DistanciaRaizBo();
                default:
                    throw new NotImplementedException("Opcion no implementada");
            }
        }
        #endregion
    }
}
