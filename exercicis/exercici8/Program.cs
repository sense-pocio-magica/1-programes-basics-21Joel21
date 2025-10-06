namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        int minuts_totals = 100;

        var hores_totals = minuts_totals / 60;

        var minuts_restants = minuts_totals - hores_totals * 60 ;

        Console.WriteLine($"Les hores senceres de 100 minuts son {hores_totals} y els minuts restans son {minuts_restants} ");
    }
}
