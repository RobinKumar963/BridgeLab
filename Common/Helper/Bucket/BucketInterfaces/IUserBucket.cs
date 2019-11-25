using Common.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Helper.Bucket.BucketInterfaces
{
    /// <summary>
    /// Contract to manage user bucket
    /// </summary>
    public interface IUserBucket
    {
        bool Save(string host, string key, UserModel user);
        UserModel Get(string host, string key);



    }
}
