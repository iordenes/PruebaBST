using Enumerables.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBST.BLL.Interface
{
    public interface ICalculoImpl
    {
        string Procesar(OpcionCalculo.OpcionEnum opcion, string valor);
    }
}
