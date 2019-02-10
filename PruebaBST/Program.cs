using Enumerables.Enum;
using PruebaBST.BLL.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBST
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese listado Inicial: ");

            //Se obtiene el ingreso
            var valoresIngresados = Console.ReadLine();

            //Se crea objeto cálculo
            var calculo = new CalculoImpl();

            /*---Ingreso de Valores--*/
            //Se ingresan valores
            calculo.Procesar((OpcionCalculo.OpcionEnum)1, valoresIngresados);

            /*-----Ejercicio 2-----*/
            Console.WriteLine("Ingrese la raiz a consultar: ");
            //Se obtiene el ingreso
            var raiz = Console.ReadLine();

            //Se obtiene distancia
            calculo.Procesar((OpcionCalculo.OpcionEnum) 2, raiz);

            //Salir

        }
    }
}
