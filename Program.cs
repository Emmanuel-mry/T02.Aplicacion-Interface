using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cree el menu en el main y automaticamente entra al menu

            Operaciones OP = new Operaciones();

            Console.WriteLine("-BIENVENIDO A SU CALCULADORA-");
            Console.WriteLine();
            Console.WriteLine("SELECIONE LA OPERACION QUE DESEA REALIZAR");
            Console.WriteLine("1) SUMA");
            Console.WriteLine("2) RESTA");
            Console.WriteLine("3) MULTIPLICACION");
            Console.WriteLine("4) DIVISION");
            Console.WriteLine("5) SALIR");
            switch (Convert.ToInt16(Console.ReadLine())) //Switch para elegir el metodo que el usuario selecciono
            {
                case 1: 
                    var r = OP.Sumar();
                    Console.ReadKey();


                    break;
                case 2:
                    OP.Resta();
                    Console.ReadKey();
                    break;
                case 3:
                    OP.Multiplicacion();
                    Console.ReadKey();
                    break;
                case 4:
                    OP.Division();
                    Console.ReadKey();
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}
