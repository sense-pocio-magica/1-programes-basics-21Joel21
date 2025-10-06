namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime un numero entero");
        int p_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dime otro numero entero");
        int s_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("La suma, resta, multiplicación y divsión de los numeros enviados, su resultado es el siguiente");

        int r_suma = p_num + s_num;
        int r_resta = p_num - s_num;
        int r_multi = p_num * s_num;
        int r_div = p_num / s_num;
        int r_resi = p_num % s_num;


        Console.WriteLine($"{p_num} + {s_num} = {r_suma}");
        Console.WriteLine($"{p_num} - {s_num} = {r_resta}");
        Console.WriteLine($"{p_num} * {s_num} = {r_multi}");
        Console.WriteLine($"{p_num} / {s_num} = {r_div} y sobre {r_resi}" );

    

    }
}
