using System;

class ProgramaDeTienda
{
    static void Main()
    {
        // Mostrar mensaje de bienvenida
        Console.WriteLine("Bienvenido a la tienda de productos!");

        // Ingresar el precio de 3 productos (en centavos para mayor precisión)
        Console.Write("Ingresa el precio del producto 1 (en centavos): ");
        int precioProducto1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el precio del producto 2 (en centavos): ");
        int precioProducto2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el precio del producto 3 (en centavos): ");
        int precioProducto3 = Convert.ToInt32(Console.ReadLine());

        // Calcular el total de los 3 productos
        int totalCentimos = precioProducto1 + precioProducto2 + precioProducto3;
        decimal total = totalCentimos / 100m; // Convertir centavos a dólares/euros

        // Aplicar descuento del 10% si el total sobrepasa los 500
        if (total > 500)
        {
            decimal descuento = total * 0.10m; // Calcular el 10% de descuento
            total -= descuento; // Aplicar descuento al total
            Console.WriteLine($"Se aplicó un descuento de {descuento:C2}. El total con descuento es {total:C2}.");
        }
        else
        {
            Console.WriteLine($"El total de tu compra es {total:C2}.");
        }
    }
}
