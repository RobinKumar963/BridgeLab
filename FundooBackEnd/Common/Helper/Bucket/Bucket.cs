using Common.Helper.Bucket.BucketInterfaces;
using Common.Models.NoteModels;
using Common.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;
using Common;

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
        public static class UserBucket
        {
            public static UserModel Get(string host, string key)
            {
                return RedishCacheHelper.Get<UserModel>(host, key);
            }

            public static bool Save(string host, string key, UserModel user)
            {
                return RedishCacheHelper.Save<UserModel>(host, key, user);

            }



        }

        /// <summary>
        /// Save and get Note Model In bucket
        /// </summary>
        /// <seealso cref="Common.Helper.Bucket.BucketInterfaces.INoteBucket" />
        public static class NotesBucket
        {
            public static List<NoteModelView> Get(string host, string key)
            {
                return RedishCacheHelper.Get<List<NoteModelView>>(host, key);
            }

            public static bool Save(string host, string key, List<NoteModelView> noteModelViews)
            {
                return RedishCacheHelper.Save<List<NoteModelView>>(host, key, noteModelViews);
            }

            public static void Update(string host, string key, int id, string attribute)
            {
                switch (attribute)
                {

                    case Constants.Constants.NoteDescriptionAttributeName:
                        break;




                    case Constants.Constants.NoteTitleAttributeName:
                        break;


                    case Constants.Constants.NotesPinAttributeName:
                        break;





                    default:
                        break;

                }
            }







            /// <summary>
            /// Save all Labels in LabelBucket
            /// </summary>
            public static class LabelBucket
            {

            }

            /// <summary>
            /// Save and get Collabarator of notes in Collabarator Bucket
            /// </summary>
            public static class CollabaratorBucket
            {

            }
        }
    }
}
