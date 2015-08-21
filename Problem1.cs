using System;
using System.Diagnostics;

class Hello {
    static void Main() {
        TimeSpan ts = new TimeSpan();
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        
        int result = 0;
        for(short i = 3;i<1000;i++)
        {
            if (IsMultiple(3, i) || IsMultiple(5, i))
            {
                result += i;
            }
                
        }
        
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        ts = stopWatch.Elapsed;
        Console.WriteLine(result.ToString());
        Console.WriteLine(ts.ToString());
    }
    
    public static bool IsMultiple(short fixedM, short v)
    {
        return v % fixedM == 0?true:false; 
    }
    
    
}