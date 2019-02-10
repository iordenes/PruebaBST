using DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enumerables.Enum.OpcionCalculo;

namespace DAL.Mapper
{
    public class ArbolMapper
    {
        public static ArbolEntity ToEntity(int id, int numeroRaiz, int? idPadre, DireccionEnum direccion, int nivel)
        {
            return new ArbolEntity
            {
                Id = id,
                NumeroRaiz = numeroRaiz,
                IdPadre = idPadre,
                Direccion = direccion,
                Nivel = nivel
            };
        }
    }
}
