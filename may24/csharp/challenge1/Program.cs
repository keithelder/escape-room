using System;
using System.Threading;

/* This is a simple output, but it it multi-threaded.
 * In order to escape, you must figure out how to make it thread-safe.
 * You should always get the same answer when running it. 
 * However, you may get different answers each time you run it.
 * Good luck!
 */

class Program {
    static int sum = 0;
   // static object lockObject = new object();
    static void AddToSum(int number) 
    {
     //   lock(lockObject) // Lock the shared resource (sum
     //   {
            int temp = sum;
            Thread.Sleep(new Random().Next(1, 10)); // Simulate work
            sum = temp + number;
     //   }
    
    }

    static void Main() 
    {
        int[] numbers = {1, 2, 3, 4, 5};

        // Create and start multiple threads to add numbers
        Thread[] threads = new Thread[numbers.Length];
        for (int i = 0; i < numbers.Length; i++) {
            int local = i; 
            threads[i] = new Thread(() => AddToSum(numbers[local]));
            threads[i].Start();
        }

        // Wait for all threads to complete
        foreach (Thread t in threads) {
            t.Join();
        }

        Console.WriteLine("Total Sum is: " + sum);
    }
}

