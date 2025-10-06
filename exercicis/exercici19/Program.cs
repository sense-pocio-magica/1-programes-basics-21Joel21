namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        string palabra = "Joel";

        int longitud = palabra.Length;

        Console.WriteLine($"La paraula es {palabra} i te un total de {longitud} caràcters");

    }
}
