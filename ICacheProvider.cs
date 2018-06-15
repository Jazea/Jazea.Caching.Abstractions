using System;
using CacheManager.Core;

namespace Jazea.Caching
{
    public interface ICacheProvider<TValue>
    {
        bool Exists(string key);

        TValue Get(string key);

        void Remove(string key);

        void Add(string key, TValue value, ExpirationMode expiration, TimeSpan timeout);
    }
}
