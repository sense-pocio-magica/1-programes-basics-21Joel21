namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        string usuario = "Rex";
        string dominio = "@gmail.com";

        var correo_electronico = usuario + dominio;

        Console.WriteLine($"El correo sera --> {correo_electronico}");
        
    }
}
