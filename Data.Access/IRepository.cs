using System;

namespace Data.Access
{
    public interface IRepository : IDisposable
    {
        string GetData(int value);
    }
}