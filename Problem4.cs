using System;
using System.Diagnostics;

class Hello {
    static void Main() {
        TimeSpan ts = new TimeSpan();
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        if(capicua("22333322"))
            Console.WriteLine("NICE");
        else
            Console.WriteLine("FUCK");
        
        int aux1;        
        int bestOne = 0;
        for(int i = 999; i > 0; i--)
        {
            for(int j = 999; j > 0; j--)
            {
                aux1 = j * i;
               /* if(aux1<1000)
                    Console.Write("0");
                if(aux1<100)
                    Console.Write("0");
                if(aux1<10)
                    Console.Write("0");
                Console.Write(aux1.ToString() + " ");        */
                if (capicua(aux1.ToString()) && aux1 > bestOne)
                    bestOne = aux1;
            }
         //   Console.WriteLine();
        }
        Console.WriteLine(bestOne.ToString());
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        ts = stopWatch.Elapsed;
        Console.WriteLine(ts.ToString());
    }
    
    public static bool capicua(string a)
    {
        int i = 0;
        int l = a.Length-1;
        
        while(i<l)
        {
            if(a[i]!=a[l])
                return false;
            i++;
            l--;
        }
        return true;
        
    }
}