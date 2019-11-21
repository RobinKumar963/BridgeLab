using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Text;

namespace Common.Helper
{
    public class TrialRedishCacheHelper
    {
        private const string CacheKey = "availableStocks";

        public IEnumerable GetAvailableStocks()
        {
            ObjectCache cache = MemoryCache.Default;

            if (cache.Contains(CacheKey))
                return (IEnumerable)cache.Get(CacheKey);
            else
            {
                IEnumerable availableStocks = this.GetDefaultStocks();

                // Store data in the cache    
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddHours(1.0);
                cache.Add(CacheKey, availableStocks, cacheItemPolicy);

                return availableStocks;
            }
        }
        public IEnumerable GetDefaultStocks()
        {
            return new List<string>() { "Pen", "Pencil", "Eraser" };
        }
    }
}
