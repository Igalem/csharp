using System;
using System.Collections;

class QueueExample
{
    public static void Main()
    {
        Queue shlemin = new Queue();
        int mispar ;
        int element;

        // insert elements into queue
        shlemin.Enqueue(100);
        shlemin.Enqueue(43);
        shlemin.Enqueue(53);
        shlemin.Enqueue(72);

        // set mispar value
        mispar = 72;        

        // create list var from queue[ToArray]
        var mylist = shlemin.ToArray();

        // looping by i to list length 
        for (int i = 0; i < mylist.Length; i++) 
            {
                // set element to list[i] value
                element = Convert.ToInt32(mylist[i]);

                // comparing element with mispar values
                if (element == mispar) {
                    Console.WriteLine("{0} found on index {1}", mispar, i); 
                    }
            }
    }
}    

QueueExample.Main();