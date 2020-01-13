using System;
using System.Collections.Generic;
using System.Text;
using Common.Models;
using Common.Models.Admin;
using Common.Models.CollabratorModels;
using Common.Models.LabelledNoteModels;
using Common.Models.LabelModels;
using Common.Models.NoteModels;
using Common.Models.ReminderModel;
using Common.Models.UserModels;

namespace Common.Helper.Bucket.BucketContext
{
    public class RedishFundooContext
    {
        public List<UserModel> Users { get; set; }
        public List<NoteModel> Notes { get; set; }
        public List<LabelModel> Labels { get; set; }
        public List<CollabratorModel> Collabration { get; set; }
        public List<LabelledNote> Labelnotes { get; set; }
        public List<ReminderModel> Reminders { get; set; }
        public List<AdminModel> Admin { get; set; }
        public List<UserStatistics> UserStatistics { get; set; }
        public List<NoteModelView> noteModelViews { get; set; }

    }
}
