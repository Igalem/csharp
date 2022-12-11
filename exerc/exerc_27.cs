using System;

namespace Test
{
    public class PB
    {
        public static void Main(string[] args) {
            
            string str;
            const int num = 20;
            char[] arr = new char[num];
            int counterUpper=0, counterLower=0, counterNumber=0, counterOther=0;


            Console.WriteLine("Please enter String:");
            str = Console.ReadLine();

            Console.WriteLine("STR length: " + str.Length);

            for (int i=0; i<str.Length; i++) {
                arr[i] = str[i];
                int charAscii = (char)str[i];

                if (charAscii>=97 && charAscii<=122) {
                    counterLower++;
                }
                else if (charAscii>=65 && charAscii<=90) {
                    counterUpper++;
                }
                else if (charAscii>=48 && charAscii<=57) {
                    counterNumber++;
                }
                else {
                    counterOther++;
                }
            }

            Console.WriteLine("Array value:");
            Console.WriteLine(arr);
            Console.WriteLine("Uppers: " + counterUpper);
            Console.WriteLine("Lowers: " + counterLower);
            Console.WriteLine("Numbers: " + counterNumber);
            Console.WriteLine("Others: " + counterOther);
        }
        
    }
}

Test.PB.Main(null);