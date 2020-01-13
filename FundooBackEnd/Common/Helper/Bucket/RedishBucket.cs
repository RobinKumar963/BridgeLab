using Common.Helper.Bucket.BucketContext;
using Common.Helper.Bucket.BucketInterfaces;
using Common.Models.LabelModels;
using Common.Models.NoteModels;
using Common.Models.UserModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.Bucket
{
    public class RedishBucket
    {

        internal static RedishFundooContext redishFundooContext;


        public class AccountBucket
        {

            public static List<UserModel> userModels;

            public static void Save(UserModel userModel)
            {
                userModels = RedishCacheHelper.Get<List<UserModel>>("localhost", "FundooUsersBucket");
                userModels.Add(userModel);
                RedishCacheHelper.Save("localhost", "FundooNotesBucket", userModels);
                RedishCacheHelper.Save("localhost", userModel.USERID, userModel);

            }
            public static List<UserModel> GetAll()
            {
                return RedishCacheHelper.Get<List<UserModel>>("localhost", "FundooUsersBucket");
            }
            public static UserModel GetNoteByKeyID(string key)
            {
                return RedishCacheHelper.Get<UserModel>("localhost", key);
            }

        }

        public class AdminBucket
        {
       
        }

        public class LabelBucket
        {
            public static List<LabelModel> labelModels;

            public static void Save(LabelModel labelModel)
            {
                labelModels = RedishCacheHelper.Get<List<LabelModel>>("localhost", "FundooLabelsBucket");
                labelModels.Add(labelModel);
                RedishCacheHelper.Save("localhost", "FundooLabelsBucket", labelModel);
                RedishCacheHelper.Save("localhost", labelModel.LABELID.ToString(), labelModel);

            }
            public static List<LabelModel> GetAll()
            {
                return RedishCacheHelper.Get<List<LabelModel>>("localhost", "FundooLabelsBucket");
            }
            public static LabelModel GetLabelByKeyID(string key)
            {
                return RedishCacheHelper.Get<LabelModel>("localhost", key);
            }

        }

        public class NoteBucket
        {
            public static List<NoteModel> noteModels;

            public static void Save(NoteModel noteModel)
            {
                noteModels = RedishCacheHelper.Get<List<NoteModel>>("localhost", "FundooNotesBucket");
                noteModels.Add(noteModel);
                RedishCacheHelper.Save("localhost", "FundooNotesBucket", noteModels);
                RedishCacheHelper.Save("localhost", noteModel.NOTEID.ToString(), noteModel);

            }
            public static List<NoteModel> GetAll()
            {
                return RedishCacheHelper.Get<List<NoteModel>>("localhost", "FundooNotesBucket");
            }
            
        }



    }
}
