using System;

namespace _13.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            AppState startState = new StopState(); //new StartState();
            startState.doAction(context);

            Console.WriteLine(context.getState());

        }
    }
}
