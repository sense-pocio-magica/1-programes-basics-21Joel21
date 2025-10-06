namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriu el teu carrer");
        string carrer = Console.ReadLine();

        Console.WriteLine("Escriu el teu numero");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriu el teu codi postal");
        int cp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriu la teva poblacio");
        string poblacio = Console.ReadLine();

        Console.WriteLine($"La teva adreça es {carrer} {num} {cp} {poblacio}");
    }
}
