using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Calculadora
{
    class Operaciones:Valores,ICalculadora //Herede la clase valores e implemente la interfaz de ICalculadora
    {
        //Automaticamente despues de implementar la interfaz se crean los metodos
        public double Division()
        {
                Console.Clear();
                Console.WriteLine("Ingrese los numeros que va a dividir");
                Console.WriteLine();
                Console.WriteLine("DIVISOR: "); N1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("DIVIDENDO: "); N2 = Convert.ToInt16(Console.ReadLine());
                var c = N1 / N2;
                Console.WriteLine("EL RESULTADO ES = " + c);
                return c;       
        }

        public double Multiplicacion()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los numeros que va a multiplicar");
            Console.WriteLine();
            Console.WriteLine("PRIMER NUMERO: "); N1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("SEGUNDO NUMERO: "); N2 = Convert.ToInt16(Console.ReadLine());
            var c = N1 * N2;
            Console.WriteLine("EL RESULTADO ES = " + c);
            return c;
        }

        public double Resta()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los numeros que va a restar");
            Console.WriteLine();
            Console.WriteLine("PRIMER NUMERO: "); N1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("SEGUNDO NUMERO: "); N2 = Convert.ToInt16(Console.ReadLine());
            var c = N1 - N2;
            Console.WriteLine("EL RESULTADO ES =" + c);
            return c;
        }

        public double Sumar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los numeros que va a sumar");
            Console.WriteLine();
            Console.WriteLine("PRIMER NUMERO: "); N1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("SEGUNDO NUMERO: "); N2 = Convert.ToInt16(Console.ReadLine());
            var c = N1 + N2;
            Console.WriteLine("EL RESULTADO ES = " + c);
            return c;
        }
    }
}
