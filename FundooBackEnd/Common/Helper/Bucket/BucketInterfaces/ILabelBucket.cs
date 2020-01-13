using Common.Models.LabelModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.Bucket.BucketInterfaces
{
    public interface ILabelBucket
    {
        Task Add(LabelModel labelModel);

        Task Updates(int id, string newValue, string attribute);

        Task<List<LabelModel>> GetByID(string email);
        Task<string> GetLabelNameByLabelID(int id);

        Task Delete(int id);
    }
}
