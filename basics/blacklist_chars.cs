using System;
namespace Test
{
    public class PB
    {
        public static void Main(string[] args) {
        
        // int N = 5;
        char[] blackChar = {'x', 'w', '!', ' '};
        string word="";
        int blacked=0;

        Console.WriteLine("Enter string: ");
        string str = Console.ReadLine();

        for (int i=0; i<str.Length ; i++) {
            for (int w=0; w<blackChar.Length; w++) {
                if (str[i] == blackChar[w]) {
                    blacked+=1 ;
                }
            }
            
            if (blacked == 0) {word+= str[i];}
            blacked=0;
        }

        Console.WriteLine(word);
        } // end of main()
    } // end of class
} // end of namespace

Test.PB.Main(null);