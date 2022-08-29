
namespace EonixConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var monkeyOne = new Monkey(1, new Trick[2] { Trick.Magic, Trick.Acrobatics });
            var handlerOne = new Handler(monkeyOne);

            var monkeyTwo = new Monkey(2, new Trick[2] { Trick.Acrobatics, Trick.Magic });
            var handlerTwo = new Handler(monkeyTwo);

            var observerSpectator = new Spectator();
            monkeyOne.Attach(observerSpectator);
            monkeyTwo.Attach(observerSpectator);

            handlerOne.Monkey.ExecuteTricks(); 
            handlerTwo.Monkey.ExecuteTricks();

            //handlerOne.Monkey.ExecuteOneTrick(Trick.Magic); 
        

            monkeyOne.Detach(observerSpectator);
            monkeyTwo.Detach(observerSpectator);

            System.Console.WriteLine("End of the program");
            System.Console.ReadLine();
        }
    }
}
