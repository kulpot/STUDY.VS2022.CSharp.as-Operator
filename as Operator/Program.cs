using System;

//ref link:https://www.youtube.com/watch?v=PmMPSHBNi7w&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=32
//

class Base { }
class Derived : Base { }

class MainClass
{
    static void Main()
    {
        var randy = new Random(); 
        bool randomBool = randy.Next() % 2 == 0;
        //Base b = new Derived();
        Base b = randomBool ? new Base() : new Derived();   // error or 1 result
        //Unhandled exception. System.InvalidCastException: Unable to
        //cast object of type 'Base' to type 'Derived'.

        
        //Derived d = b; // error 
        //Derived d = (Derived)b; // random: if returns fail -- output error exception
        Derived d = b as Derived;   // random: if Null -- instead of output error exceiption
        if (d == null)
            Console.WriteLine("Oh, well that failed.");
        else
            Console.WriteLine("WE GOT AN OBJECT!");
    }
}