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
        int Topor = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            Topor += tab[i];
        }
        Console.WriteLine("Srednia tablicy wynosi: " + Topor/tab.Length);
    }
    
    public static void MaxInt(int[] tab)
    {
        int max = tab[0];
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] > max)
            {
                max = tab[i];
            }
        }
        Console.WriteLine("Max tablicy wynosi: " + max + " na pozycji: " + Array.IndexOf(tab, max));
    }
}