using PriorityApp.Services;

namespace PriorityApp
{
    internal class program
    {
        static void Main(string[] args)
        {
            IItemSelector selector = new weightItemSelector();

            var runner = new selectionRunner(selector);
            runner.run();
            Console.WriteLine();
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}