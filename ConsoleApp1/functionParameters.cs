namespace ConsoleApp1;

public class functionParameters
{
    static int x = 10;
    static int y = 20;


    
    public static int add1(int x,int y){
        return x + y;
    }
    public static int add2(ref int x,ref int y){
        return x + y;
    }
    public static void add3(int x,int y,out int sum){
        sum  = x + y; 
    }
    public static void inc1(int x){
        x++;
    }
    public static void inc2(ref int x){
        x++;
    }
    public static void inc3(int x, out int y){
        x++;
        y = x;
    }

    public static int op1(int x, int y=45){
        return x + y;
    }

    public static void display(){
        System.Console.WriteLine(add1(x,y));
        System.Console.WriteLine(add2(ref x,ref y));

        add3(x, y, out int sum);
        System.Console.WriteLine(sum);

        System.Console.WriteLine(op1(x,y));
        System.Console.WriteLine(op1(x));

        inc1(x);
        System.Console.WriteLine(x);
        inc2(ref x);
        System.Console.WriteLine(x);
        inc3(x,out int a);
        System.Console.WriteLine(y);
    }



    
}
