namespace ConsoleApp1;

public class Arrays
{
    static int[] a = [7,8,15,96,102,54];

    static void Main(){
        System.Console.WriteLine(a.Length);
        System.Console.WriteLine(a.First());
        System.Console.WriteLine(a.ElementAt(1));
        System.Console.WriteLine(a.All( (x) => x>7 ));
    }
}
