using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Calculadora
{
    interface ICalculadora //Aqui se crea la interfaz
    {
        double Sumar(); //Aqui declare los metodos que voy a utilizar
        double Resta();
        double Division();
        double Multiplicacion();
    }
}
