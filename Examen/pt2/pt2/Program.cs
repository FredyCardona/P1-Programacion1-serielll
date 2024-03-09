using System;

class GeneradorDeCorreo
{
    static void Main()
    {
        // Mensaje de bienvenida
        Console.WriteLine("Bienvenido al generador de correos electrónicos!");

        // Solicitar nombre y apellido
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ahora, ingresa tu apellido: ");
        string apellido = Console.ReadLine();

        // Ingresar un dominio de correo electrónico
        Console.Write("Ingresa el dominio de correo electrónico (ejemplo: gmail.com): ");
        string dominio = Console.ReadLine();

        // Generar y mostrar un correo con las primeras 3 letras del nombre y del apellido
        string correo = nombre.Substring(0, Math.Min(3, nombre.Length)) +
                        apellido.Substring(0, Math.Min(3, apellido.Length)) +
                        "@" + dominio;

        // Mostrar el correo generado
        Console.WriteLine("Tu nuevo correo es: " + correo);
    }
}
