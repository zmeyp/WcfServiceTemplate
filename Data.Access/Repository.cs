using System.Diagnostics;

namespace Data.Access
{
    public class Repository : IRepository
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void Dispose()
        {
            Trace.WriteLine("-------------- Disposed Repository");
        }
    }
}
