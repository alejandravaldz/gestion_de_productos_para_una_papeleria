using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_gestión_de_producto_de_papeleria
{
    internal class Papeles : Producto
    {
        protected string tipo { get; set; }
        protected string color { get; set; }
        protected string tamaño { get; set; }


        

        public virtual void AlmacenarDatos()
        {
            Console.WriteLine();
            Console.WriteLine("Datos del los papeles");
            Console.WriteLine();
            Console.Write("Ingrese el tipo de papel: ");
            tipo = Console.ReadLine();
            Console.Write("Ingrese el color: ");
            color = Console.ReadLine();
            Console.Write("Ingrese el Tamaño del papel: ");
            tamaño= Console.ReadLine();
           

        }
        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Tipo{tipo}");
            Console.WriteLine($"color{color}");
            Console.WriteLine($"tamaño{tamaño}");
           
        }

    }
}
