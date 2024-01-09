using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using static Program;
using ConsoleApp1.Model;
using Newtonsoft.Json;
namespace ConsoleApp1
{
    public class Cache
    {
        public void CacheMethod()
        {

            string key = "MyKey";


            for (int i = 1; i <= 4; i++)
            {
                CacheClass item = new CacheClass();

                item.Id = i;
                item.Name = "My Name";
                item.CreatedAt = DateTime.Now;

                CacheClass cachedItem = CommonResponseCache.GetOrSet(key, item);
                Console.WriteLine(JsonConvert.SerializeObject(cachedItem));
            }

        }


    }

    public class CommonResponseCache
    {
        private static ObjectCache Cache = MemoryCache.Default;
        private static int CacheTime = 1; // Cache time in minutes

        public static CacheClass GetOrSet(string key, CacheClass item)
        {
            if (Cache.Contains(key))
            {
                return (CacheClass)Cache[key];
            }
            else
            {
                CacheItemPolicy policy = new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(CacheTime) };
                Cache.Add(key, item, policy);
                return item;
            }
        }
    }
}
