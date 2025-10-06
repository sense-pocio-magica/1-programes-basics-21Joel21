namespace exercici13;

/* Un alumne ha inventat un sistema per codificar dates que consisteix a eliminar els separadors de les dates 
per fer no es vegi que són dates (la data 24/09/2024 la converteix en 24092024). 
El problema és que ho ha aplicat a tots els documents de l’institut i ara la direcció no sap 
ordenar els documents.

Necessitem un programa que faci el procés invers

Entra la data sense formatar: 25092024
La data és 25/09/2024

Entra la data sense formatar: 12031970
La data és 12/03/1970 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entra una fehca sin formatear de 8 digitos");
        string fecha = Console.ReadLine();

        string dia = "";
        string mes = "";
        string any = "";

        if (fecha.Length != 8)
        {
            Console.WriteLine("Los numeros introducidos superan o no los 8 caracteres");
        }
        else
        {
            dia = fecha.Substring(0, 2);
            mes = fecha.Substring(2, 2);
            any = fecha.Substring(4, 4);

        }

        Console.WriteLine($"La fecha es {dia}/{mes}/{any}");
    }
}
