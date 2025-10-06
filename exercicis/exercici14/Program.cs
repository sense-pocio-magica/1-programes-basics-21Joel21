namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        string palabra = "Rocco";

        char p_l = palabra[0];
        char m_l = palabra[2];
        char u_l = palabra[4];

        Console.WriteLine($"La palabra Rocco su primera letra es la {p_l} ,la letra del medio es {m_l} y su ultima letra es la {u_l}");

    }
}
