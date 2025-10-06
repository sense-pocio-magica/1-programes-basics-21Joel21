namespace exercici17;

/* Hi ha una secta d’adoradors dels decimals que volen que els hi feu un programa que a partir d’un nombre real, 
ex. 4.56, només ens retorni els decimals, 0,56. Als números que només tenen decimals els anomenen “nombres meravellosos”

Número lleig: 23,45
Nombre meravellós: 0,45


Número lleig: 8,5
Nombre meravellós: 0,5
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola miembro de la secta, digame su numero decimal con la coma ");

        string e_d = Console.ReadLine();

        int posicion_coma = e_d.IndexOf(",");

        if (posicion_coma != -1)
        {
            string resultado_coma = e_d.Substring(posicion_coma);

            Console.WriteLine($"numero lleig : {e_d}");
            Console.WriteLine($"numero marevellos :0 {resultado_coma}");

        }
        else
        {
            Console.WriteLine("tu numero no contiene decimales");
        }

    }
}
