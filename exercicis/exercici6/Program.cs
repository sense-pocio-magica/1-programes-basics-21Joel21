namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        int costat = 6;

        var resultat = costat + costat + costat + costat;

        Console.WriteLine($"El perimetro del cuadrado de 6 cm de lado es {resultat} cm");
    }
}
