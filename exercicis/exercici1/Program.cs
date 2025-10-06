namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriu el teu nom");
        string nom = Console.ReadLine();

        Console.WriteLine("Escriu el teu cognom");
        string cognom = Console.ReadLine();

        Console.WriteLine($"Em dic {cognom}, {nom} {cognom} ");
    }
}
