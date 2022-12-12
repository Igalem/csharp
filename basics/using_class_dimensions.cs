using System;

namespace App
{
    public class Malben
        {

        public int length, width;
        
        public void setMes() {
            Console.WriteLine("Enter length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());
        }

        }
    

    public class Program
        {
    public static void Main(string[] args)
    {
        Malben m1 = new Malben();
        Malben m2 = new Malben();
        Console.WriteLine("Enter malben 1 : " );
        m1.setMes();
        Console.WriteLine("Enter malben 2: " );
        m2.setMes();
        Console.WriteLine("Malben 1 length: " + m1.length + " width: " + m1.width);
        Console.WriteLine("Malben 2 length: " + m2.length + " width: " + m2.width);
    }
}

}

App.Program.Main(null);



