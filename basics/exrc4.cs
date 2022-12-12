using System;

int[,] m = new int[10,10];

for (int i=0; i<m.GetLength(0); i++) {
    m[i,0] = 0;
    // Console.WriteLine(m);
}

Console.WriteLine(m[0,0]);


