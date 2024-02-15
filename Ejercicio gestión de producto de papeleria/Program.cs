// See https://aka.ms/new-console-template for more information
using Ejercicio_gestión_de_producto_de_papeleria;

Console.WriteLine("GESTIÓN DE PRODUCTOS");
Console.WriteLine();



// instancia de clases

Producto producto = new Producto();
producto.AlmacenarDatos();
Console.WriteLine("\nDatos del producto:");
producto.MostrarDatos();

Papeles papel = new Papeles();
papel.AlmacenarDatos();
Console.WriteLine("\nDatos del papel:");
papel.MostrarDatos();

Utencilios utensilio = new Utencilios();
utensilio.AlmacenarDatos();
Console.WriteLine("\nDatos del utensilio:");
utensilio.MostrarDatos();



