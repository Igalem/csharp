// Method of "print" the same as in Python instead using "Console.WriteLine" function

using System;
class Program  
    {  
        

        public static void Main(string[] args)  
        {  
            print("\n Welcome to Python!! :) ");
        }  


        public static string print(string str) {
            if (str.Length > 0) {
                Console.Write(str);
            }
            return "XX";
        }
    }

Program.Main(null);