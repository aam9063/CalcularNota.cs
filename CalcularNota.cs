using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduce la nota del examen (4, 7, 10):");
        int notaExamen = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce la nota de prácticas (4, 7, 10):");
        int notaPracticas = int.Parse(Console.ReadLine());

        decimal? notaFinal = CalcularNotaFinal(notaExamen, notaPracticas);

        if (notaFinal.HasValue)
        {
            Console.WriteLine($"La nota final es: {notaFinal}");
        }
        else
        {
            Console.WriteLine("Nota incorrecta. Las notas permitidas son 4, 7 y 10.");
        }
    }

    static decimal? CalcularNotaFinal(int notaExamen, int notaPracticas)
    {
        return (notaExamen, notaPracticas) switch
        {
            (4, _) => notaExamen,
            (7, 7) => (decimal)(notaExamen + notaPracticas) / 2,
            (7, 4) => 5,
            (10, 10) => 11,
            (10, _) => 9,
            _ => null // Nota incorrecta
        };
    }
}
