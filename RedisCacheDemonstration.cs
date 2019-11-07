
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RedisCacheDemonstration.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------


using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedishCachingClient
{
    /// <summary>
    /// Redish Cache Operation
    /// </summary>
    class RedisCacheDemonstration
    {
        /// <summary>
        /// Save content of host into cache with label key
        /// </summary>
        /// <param name="host"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        private static bool Save(string host, string key, string value)
        {

            bool isSuccess = false;

            using (RedisClient redisClient = new RedisClient(host))

            {

                if (redisClient.Get<string>(key) == null)

                {

                    isSuccess = redisClient.Set(key, value);

                }

            }

            return isSuccess;

        }
        /// <summary>
        /// Get value with label key 
        /// </summary>
        /// <param name="host"></param>
        /// <param name="key"></param>
        /// <returns>string</returns>
        private static string Get(string host, string key)

        {

            using (RedisClient redisClient = new RedisClient(host))

            {

                return redisClient.Get<string>(key);

            }

        }

        public static void Main(string[] args)
        {
            string host = "localhost";

            string key = "IDG";

            // Store data in the cache

            bool success = Save(host, key, "Hello World!");

            // Retrieve data from the cache using the key

            Console.WriteLine("Data retrieved from Redis Cache: " + Get(host, key));

            Console.Read();
        }
       
    }
}
