using System;
namespace Test
{
    public class PB
    {
        public static void Main(string[] args) {
        
        int N = 5;
        char[] arr = new char[N];

        for (int i=0; i<N; i++) {
            Console.WriteLine("Enter char: ");
            arr[i] = char.Parse(Console.ReadLine());

        }

        Console.WriteLine("-------------");
        Console.WriteLine(arr);




        }
    }
}

Test.PB.Main(null);