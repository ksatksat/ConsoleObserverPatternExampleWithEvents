using System;
namespace ConsoleObserverPatternExampleWithEvents
{
    class Program
    {
        public static void Main(String[] args)
        {
            NewsAggregator newsAggregator = new NewsAggregator();
            Reader steve = new Reader("Steve");
            Reader bill = new Reader("Bill");

            IDisposable steveSubscription = newsAggregator.Subscribe(steve);
            IDisposable billSubscription = newsAggregator.Subscribe(bill);

            News news1 = new News("Title# 1", "Content# 1");
            News news2 = new News("Title# 2", "Content# 2");
            News news3 = new News("Title# 3", "Content# 3");

            newsAggregator.Notify(news1);
            Thread.Sleep(1000);
            newsAggregator.Notify(news2);
            Thread.Sleep(500);
            billSubscription.Dispose();
            newsAggregator.Notify(news3);

            //Steve
            //Title# 1
            //Content# 1
            //=================================
            //
            //Bill
            //Title# 1
            //Content# 1
            //=================================
            //
            //Steve
            //Title# 2
            //Content# 2
            //=================================
            //
            //Bill
            //Title# 2
            //Content# 2
            //=================================
            //
            //Steve
            //Title# 3
            //Content# 3
            //=================================
        }
    }
}