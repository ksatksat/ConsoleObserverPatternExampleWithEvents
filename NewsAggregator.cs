using System;
namespace ConsoleObserverPatternExampleWithEvents
{
    public sealed class NewsAggregator : IObservable<News>
    {
        private readonly List<IObserver<News>> observers;
        public NewsAggregator()
        {
            observers = new List<IObserver<News>>();
        }
        public IDisposable Subscribe(IObserver<News> observer)
        {
            observers.Add(observer);
            return new Unsubscriber<News>(observers, observer);
        }
        public void Notify(News news)
        {
            foreach (IObserver<News> observer in observers)
            {
                observer.OnNext(news);
            }
        }
    }
}