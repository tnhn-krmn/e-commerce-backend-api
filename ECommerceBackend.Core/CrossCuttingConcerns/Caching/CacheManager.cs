using ECommerceBackend.Core.Utilities.IoC;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ECommerceBackend.Core.CrossCuttingConcerns.Caching
{
    public class CacheManager : ICacheManager
    {
        private IMemoryCache _cache;

        public CacheManager()
        {
            _cache = ServiceTool.ServiceProvider.GetService<IMemoryCache>();
        }

        public void Add(string key, object data, int duration)
        {
            _cache.Set(key, data, TimeSpan.FromMinutes(duration));
        }

        public T Get<T>(string key)
        {
            return _cache.Get<T>(key);
        }

        public object Get(string key)
        {
            return _cache.Get(key);
        }

        public bool IsAdd(string key)
        {
            return _cache.TryGetValue(key, out _);
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var cacheEntriesCollectionDefinition = typeof(MemoryCache).GetProperty("EntriesCollection",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            var cacheEntriesCollection = cacheEntriesCollectionDefinition.GetValue(_cache) as dynamic;

            List<ICacheEntry> cacheCollectionValues = new List<ICacheEntry>();

            foreach (var cacheEntry in cacheEntriesCollection)
            {
                ICacheEntry cacheEntryValue = cacheEntry.GetType().GetProperty("Value").GetValue(cacheEntry, null);
                cacheCollectionValues.Add(cacheEntryValue);
            }

            var regEx = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);

            var keysToRemove = cacheCollectionValues.Where(x => regEx.IsMatch(x.Key.ToString())).Select(x => x.Key).ToList();

            foreach (var keyToRemove in keysToRemove)
            {
                _cache.Remove(keyToRemove);
            }
        }
    }
}
