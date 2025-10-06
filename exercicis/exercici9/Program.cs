namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime un valor en metros");
        int metros = Convert.ToInt32(Console.ReadLine());

        
        double resultat_final = metros * 3.28084;

        Console.WriteLine($"El resultado de {metros} m  a pies es de {resultat_final} pies");

    }
}
