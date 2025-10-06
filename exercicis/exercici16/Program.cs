namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nota de examen :");
        double n_exmanen = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nota de Practicas");
        double n_practicas = Convert.ToInt32(Console.ReadLine());

        double media = (0.7 * n_exmanen) + (0.3 * n_practicas);

        double n_final = Math.Round(media, MidpointRounding.AwayFromZero);

        Console.WriteLine($"La nota final es {media} o sigui un {n_final}" );
    }
}
