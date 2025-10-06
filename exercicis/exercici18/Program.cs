namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Que hora es ?");
        int h_a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hores a incrementar ?");
        int h_i = Convert.ToInt32(Console.ReadLine());

        int resultado = h_a + h_i;

        if (resultado > 12)
        {
            int reslut_major_12 = resultado - 12;

            Console.WriteLine($"D'aqui {h_i} sera les {reslut_major_12}");
        }
        else
        {
            Console.WriteLine($"D'aqui {h_i} hores seran les {resultado}");
        }

    }
}
