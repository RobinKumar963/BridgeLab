using Common.Helper.Bucket.BucketInterfaces;
using Common.Models.NoteModels;
using Common.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Helper.Bucket
{
    /// <summary>
    /// Stores frequently used object in Cache 
    /// </summary>
    public class Bucket
    {
        /// <summary>
        /// Save and get UserModel in UserBucket
        /// </summary>
        /// <seealso cref="Common.Helper.Bucket.BucketInterfaces.IUserBucket" />
        public class UserBucket : IUserBucket
        {
            public UserModel Get(string host, string key)
            {
                return RedishCacheHelper.Get<UserModel>(host, key);
            }

            public bool Save(string host, string key, UserModel user)
            {
                return RedishCacheHelper.Save<UserModel>(host, key, user);
            }
        }

        /// <summary>
        /// Save and get Note Model In bucket
        /// </summary>
        /// <seealso cref="Common.Helper.Bucket.BucketInterfaces.INoteBucket" />
        public class NotesBucket : INoteBucket
        {
            public List<NoteModelView> Get(string host, string key)
            {
                return RedishCacheHelper.Get<List<NoteModelView>>(host, key);
            }

            public bool Save(string host, string key, List<NoteModelView> noteModelViews)
            {
                return RedishCacheHelper.Save<List<NoteModelView>>(host, key, noteModelViews);
            }
        }
        /// <summary>
        /// Save and get Collabarator of notes in Collabarator Bucket
        /// </summary>
        public class CollabaratorBucket :ICollabartorBucket
        {

        }
    }
}
