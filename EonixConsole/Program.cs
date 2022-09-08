
using Azure.Messaging.EventHubs.Processor;
using System;

namespace EonixConsole
{
    class Program
    {
        public static void Main()
        {
            Monkey bl = new Monkey(1, new Trick[2] { Trick.Music, Trick.Acrobatics });
            bl.ProcessCompleted += Spectator.bl_ProcessCompleted; // register with an event
            bl.ExecuteTricks();
        }
    }

   
}

#region Observator Pattern solution
// >> First solution with Observer pattern
//static void Main(string[] args)
//{
//    var monkeyOne = new Monkey(1, new Trick[2] { Trick.Music, Trick.Acrobatics });
//    var handlerOne = new Handler(monkeyOne);

//    var monkeyTwo = new Monkey(2, new Trick[2] { Trick.Acrobatics, Trick.Music });
//    var handlerTwo = new Handler(monkeyTwo);

//    var observerSpectator = new Spectator();
//    monkeyOne.Attach(observerSpectator);
//    monkeyTwo.Attach(observerSpectator);

//    handlerOne.Monkey.ExecuteTricks(); 
//    handlerTwo.Monkey.ExecuteTricks();

//    //handlerOne.Monkey.ExecuteOneTrick(Trick.Magic); 


//    monkeyOne.Detach(observerSpectator);
//    monkeyTwo.Detach(observerSpectator);

//    System.Console.WriteLine("End of the program");
//    System.Console.ReadLine();
//}

// << First solution with Observer pattern 
#endregion