using System;
namespace ConsoleObserverPatternExampleWithEvents
{
    public sealed class Unsubscriber<TypeDefinition> : IDisposable
    {
        private readonly List<IObserver<TypeDefinition>> observers;
        private readonly IObserver<TypeDefinition> observer;
        public Unsubscriber(List<IObserver<TypeDefinition>> observers, IObserver<TypeDefinition> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }
        public void Dispose()
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }
    }
}