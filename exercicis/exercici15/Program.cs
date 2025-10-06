namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        string nombre = "joel";
        string apellido = "soriano";

        string n_m = char.ToUpper(nombre[0]) + nombre.Substring(1);
        string a_m = char.ToUpper(apellido[0]) + apellido.Substring(1);

        Console.WriteLine($"Tu nombre completo es {n_m} {a_m}");
    }
}
