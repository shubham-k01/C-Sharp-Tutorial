using System;
namespace ConsoleApp1

{
    class BasicIO{

        int a;

        void Main(){
            Console.WriteLine("Enter a number: ");
            // input is read as a string by default , so need to convert it into required format
            a = Convert.ToInt32(Console.ReadLine());
        }

    }
}