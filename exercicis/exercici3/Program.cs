namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        var producto = "Sudadera Gymshark";
        double precio = 80;
        var modelo = "Shark Pro";
        string veurestock;
        bool stock = true;

        if (stock == true)
        {
            veurestock = "hay stock";
        }
        else
        {
            veurestock = "No hay stock";
        }

        Console.WriteLine($"El producto {producto} modelo {modelo} tiene un precio de {precio} y {veurestock}");
    }
}


