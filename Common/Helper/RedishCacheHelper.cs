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
        public static bool Save<T>(string host, string key,T value)
        {

            bool isSuccess = false;

            using (RedisClient redisClient = new RedisClient(host))
            {
                try 
                {
                    if (redisClient.Get<T>(key) == null)
                    {

                        isSuccess = redisClient.Set(key, value);


                    }
                }
                catch(Exception ex)
                {
                    return false;
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
        public static T  Get<T>(string host, string key) where T : class
        {

            using (RedisClient redisClient = new RedisClient(host))
            {
                try
                {
                    if (redisClient.ContainsKey(key))
                        return redisClient.Get<T>(key);
                    return null;
                }
                catch(Exception ex)
                {
                    return null;
                }
                

                
            }

        }


    }
}
