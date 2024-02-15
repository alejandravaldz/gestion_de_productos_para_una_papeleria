using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_gestión_de_producto_de_papeleria
{
    internal class Producto
    {
        protected int Codigo { get; set; }
        protected string Nombre { get; set; }
        protected string Marca { get; set; }
        protected int Precio { get; set; }




        public virtual void AlmacenarDatos()
        {
            Console.WriteLine("Datos del producto");
            Console.WriteLine();
            Console.Write("Ingrese el codigo: ");
            Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese la marca: ");
            Marca = Console.ReadLine();
            Console.Write("Ingrese el precio: ");
            Precio = Convert.ToInt32(Console.ReadLine());

        }
        public virtual void MostrarDatos()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Precio: ${Precio}");
        }



    }
}
