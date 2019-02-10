using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enumerables.Enum.OpcionCalculo;

namespace DAL.Entidades
{
    public class ArbolEntity
    {
        public int Id { get; set; }
        public int NumeroRaiz { get; set; }
        public int? IdPadre { get; set; }
        public DireccionEnum Direccion { get; set; }
        public int Nivel { get; set; }
    }
}
