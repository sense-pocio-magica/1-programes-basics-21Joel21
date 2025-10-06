namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime tu nombre y el año el cual naciste");

        var nombre = Console.ReadLine();

        int año_nacimietno = Convert.ToInt32(Console.ReadLine());

        int año_actual = 2025;

        int edad_actual = año_actual - año_nacimietno;

        Console.WriteLine($"Hola {nombre}! Ja tienes {edad_actual} años ?");
    }
}
