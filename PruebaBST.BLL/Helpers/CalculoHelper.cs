using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBST.BLL.Helpers
{
    public class CalculoHelper
    {
        public static IList<int> SplitValor(string valor)
        {
            try
            {
                var valores = valor.Split(',').ToList();
                var lstEnteros = new List<int>();
                foreach(var item in valores)
                {
                    lstEnteros.Add(Convert.ToInt32(item));
                }
                return lstEnteros;
            }
            catch(Exception e)
            {
                //Log antes de exponer error
                throw new Exception(e.Message);
            }
        }
    }
}
