using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using DAL.Entidades;
using DAL.Mapper;
using static Enumerables.Enum.OpcionCalculo;

namespace DAL.Implementacion
{
    public class ArbolDao : IArbolDao
    {
        public ObjectCache cache;

        public ArbolDao()
        {
            cache = MemoryCache.Default;
        }

        /// <summary>
        /// Método que entrega el listado de arboles
        /// </summary>
        /// <returns></returns>
        #region [Obtener Arbol]
        public IList<ArbolEntity> ObtenerArbol()
        {
            if (cache["arbol"] == null)
            {
                #region [Obsoleto]
                /*
                cache["arbol"] = new ArbolEntity
                {
                    Id = indice,
                    Raiz = 4,
                    RamaIzquierda = new ArbolEntity
                    {
                        Id = indice++,
                        Raiz = 3
                    },
                    RamaDerecha = new ArbolEntity
                    {
                        Id = indice++,
                        Raiz = 16,
                        RamaIzquierda = new ArbolEntity
                        {
                            Id = indice++,
                            Raiz = 10,
                            RamaIzquierda = new ArbolEntity
                            {
                                Id = indice++,
                                Raiz = 7
                            },
                            RamaDerecha = new ArbolEntity
                            {
                                Id = indice++,
                                Raiz = 12
                            }
                        },
                        RamaDerecha = new ArbolEntity
                        {
                            Id = indice++,
                            Raiz = 20
                        }
                    }
                };
                */
                #endregion
            }

            return (IList<ArbolEntity>)cache["arbol"];
        }
        #endregion

        /// <summary>
        /// Método que inserta un arbol (Nodo)
        /// </summary>
        /// <param name="idPadre"></param>
        /// <param name="numeroRaiz"></param>
        /// <returns></returns>
        #region [Insertar Arbol]
        public bool InsertarArbol(int idPadre, int numeroRaiz)
        {
            try
            {
                var arbolCache = (IList<ArbolEntity>)cache["arbol"];
                var idMaximo = arbolCache.Max(x => x.Id);

                arbolCache.Add(ArbolMapper.ToEntity(idMaximo, numeroRaiz, idPadre, DireccionEnum.Derecha,0));

                cache["arbol"] = arbolCache;

                return true;
            }
            catch (Exception e)
            {
                //Log
                throw new Exception(e.Message);
            }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodos"></param>
        #region [Ingresar Nodos]
        public void IngresarNodos(IList<int> nodos)
        {
            
        }
        #endregion
    }
}
