using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_gestión_de_producto_de_papeleria
{
    internal class Utencilios: Producto
    { 
        protected string categoria { get; set; }
        protected int peso { get; set; }

        public virtual void AlmacenarDatos()
        {
            Console.WriteLine("Datos de utensilio");
            Console.WriteLine();
            Console.Write("Ingrese la categoria: ");
            categoria = Console.ReadLine();
            Console.Write("Ingrese el peso del utensiolio: ");
            peso = Convert.ToInt32(Console.ReadLine());

        }
        public virtual void MostrarDatos()
        {
            Console.WriteLine($"categoria: {categoria}");
            Console.WriteLine($"peso: {peso}");
            
        }

    }
}
