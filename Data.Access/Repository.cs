using System;
using System.Diagnostics;
using System.Threading;

namespace Data.Access
{
    public class Repository : IRepository
    {
        private static int _increment;
        private readonly Random _random = new Random();
        private readonly static object Lock = new object();

        public string GetData(int value)
        {
            lock (typeof(Repository))
            //lock (Lock)
            {
                var local = _increment++;

                Thread.Sleep(_random.Next(1, 3000));

                var res = string.Format("You sent: {0}, the global increment is : {1}, local variable is {2}", value, _increment, local);

                return res;

            }
        }

        public void Dispose()
        {
            Trace.WriteLine("-------------- Disposed Repository");
        }
    }
}
