using DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IArbolDao
    {
        IList<ArbolEntity> ObtenerArbol();

        bool InsertarArbol(int idPadre, int numeroRaiz);
    }
}
