namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        int p_nota = 8;
        int s_nota = 5;
        double t_nota = 6.4;

        var resultado = (p_nota + s_nota + t_nota) / 3;
        var resultat_dosdecimals = Math.Round(resultado, 2);

        Console.WriteLine($"La mediana de notas de 8 , 5 y 6 es de un {resultat_dosdecimals}" );
    }
}
