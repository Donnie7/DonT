using System;
using System.Diagnostics;

class Hello {
    static void Main() {
        TimeSpan ts = new TimeSpan();
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        
        uint termValue = 0;
        uint result = 0;
        uint firstTerm = 1;
        uint secondTerm = 1;
        
        while(termValue < 4000001)
        {
            uint tempSum = firstTerm + secondTerm;
            if(tempSum % 2 == 0)
                result += tempSum;
            firstTerm = secondTerm;
            secondTerm = tempSum;
            termValue = tempSum;
        }
        
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        ts = stopWatch.Elapsed;
        Console.WriteLine(result.ToString());
        Console.WriteLine(ts.ToString());
    }
}