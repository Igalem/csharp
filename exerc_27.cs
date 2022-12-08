using System;

public class Test {

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any word: ");
        string name = Console.ReadLine();
        string c1;
        int charUpper = 0, charLower = 0, charIsNumeric=0, n=1;

        foreach (char c in name) {
            c1 = c.ToString();
            Console.WriteLine(c1 + " - " + c1.ToUpper());

            if (c1 == c1.ToUpper()) {
                charUpper++;
            } 
            else {
                charLower++;
            }

        }

        // Console.WriteLine("");
        Console.WriteLine("Upper characters: " + charUpper + "  |  Lower characters: " + charLower);
        Console.WriteLine("Numeric characters: " + charIsNumeric);

        

        
    }
}


Test.Main(null);