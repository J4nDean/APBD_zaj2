// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(String[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello, APBD!");
        }
        
        int [] tab = {10, 20, 30, 40, 50};
        Srednia(tab);
        
    }

    public static void Srednia(int[] tab)
    {
        int sum = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            sum += tab[i];
        }
        Console.WriteLine("Srednia tablicy wynosi: " + sum/tab.Length);
    }
}