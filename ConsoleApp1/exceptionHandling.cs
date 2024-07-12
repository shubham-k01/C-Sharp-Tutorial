namespace ConsoleApp1;

public class exceptionHandling
{
    static int a;

    public void Main(){
        System.Console.WriteLine("enter a number: ");

        // This line can throw error if user does not enter valid number
        a = Convert.ToInt32(System.Console.ReadLine());

        try
        {
            a = Convert.ToInt32(System.Console.ReadLine());
        }
        catch ( System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

    }
}
