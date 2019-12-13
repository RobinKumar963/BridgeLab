using Common.Models.NoteModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Helper.Bucket.BucketInterfaces
{
    /// <summary>
    /// Contract to manage Note Bucket
    /// </summary>
    public interface INoteBucket
    {
        bool Save(string host, string key, List<NoteModelView> noteModelViews);
        List<NoteModelView> Get(string host, string key);
    }
}
