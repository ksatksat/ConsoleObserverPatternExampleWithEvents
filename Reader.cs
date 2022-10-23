using System;
namespace ConsoleObserverPatternExampleWithEvents
{
    public sealed class Reader : IObserver<News>
    {
        public String Name {get; set;}
        public Reader(String name)
        {
            Name = name;
        }
        public void OnNext(News value)
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(value.Title);
            System.Console.WriteLine(value.Content);
            System.Console.WriteLine("=================================");
            System.Console.WriteLine();
        }
        public void OnError(Exception error)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(error.Message);
            Console.ResetColor();
        }
        public void OnCompleted()
        {

        }
    }
}