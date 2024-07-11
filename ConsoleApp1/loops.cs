namespace ConsoleApp1;

public class loops
{

    static string[] a = ["batman","iron_man","spider_man"];

    static void Main(){
        foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }

        for (int i = 0; i < a.Length; i++)
        {
            System.Console.WriteLine(a[i]);
        }

        int j = 0;

        while (j < a.Length)
        {
            System.Console.WriteLine(a[j++]);
        }

        
    }
}
