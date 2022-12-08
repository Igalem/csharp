using System;

public class Test {

    public static void Main(string[] args)
    {
        int N=5, intChar;
        char[] array = new char[10];
        bool isOdd;
        int index;
        char charReplace;

        Console.WriteLine("\nEnter string to encrypt: ");
        string msg = Console.ReadLine();

        for (int i=0; i < msg.Length ; i++) {
            if (i%2!=0 && msg[i] != ' ') {
                if (msg[i] == 'A') { charReplace = 'Z';}
                else if (msg[i] == 'a') { charReplace = 'z'; }
                else {
                    intChar = (int)Convert.ToChar(msg[i]) - 1;
                    charReplace = (char)intChar;
                }
            }
            else if (i%2==0 && msg[i] != ' ') {
                    if (msg[i] == 'Z') { charReplace = 'A'; }
                    else if (msg[i] == 'z') { charReplace = 'a'; }
                    else {
                    intChar = (int)Convert.ToChar(msg[i]) + 1;
                    charReplace = (char)intChar;
                    }
                }
            else {charReplace=msg[i];}
            
            array[i] = charReplace;
        } 

        Console.WriteLine("Encrypted string: ");
        Console.WriteLine(array);

    } // end of Main
} // end of class

Test.Main(null);