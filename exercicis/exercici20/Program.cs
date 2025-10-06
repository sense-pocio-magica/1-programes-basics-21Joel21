namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime el nuemro que quieres invertir");
        string num = Console.ReadLine();



        string num_1 = num.Substring(2,1);
        string num_2 = num.Substring(1, 1);
        string num_3 = num.Substring(0, 1);

        string resultado = num_1 + num_2 + num_3;

        Console.WriteLine($"El numero inicial es {num}");
        
        Console.WriteLine($"El numero invertido es {resultado}");
    }
}
