using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            logginUser user1 = logginUser.Initialise();
            logginUser user2 = logginUser.Initialise();
            
           /* ... */

            Console.ReadKey();
            
        }
    }
}