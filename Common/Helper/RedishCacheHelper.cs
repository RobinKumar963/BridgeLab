// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RedishCacheHelper.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------




using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Helper
{
    public class RedishCacheHelper
    {
        /// <summary>
        /// Save content of host into cache with label key
        /// </summary>
        /// <param name="host"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns>bool</returns>
        private static bool Save<T>(string host, string key,T value)
        {

            bool isSuccess = false;

            using (RedisClient redisClient = new RedisClient(host))

            {

                if (redisClient.Get<T>(key) == null)

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
        /// <returns>T</returns>
        private static T Get<T>(string host, string key)
        {

            using (RedisClient redisClient = new RedisClient(host))

            {

                return redisClient.Get<T>(key);

            }

        }


    }
}
