using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.NoteModels
{
    public class NoteModelView
    {
        private int NoteID;
        private string UserEmail;
        private string Title;
        private string Description;
        private DateTime? CreatedDate;
        private DateTime? ModifiedDate;
        private string Images;
        private DateTime? Reminder;
        private bool IsArchive;
        private bool IsTrash;
        private bool IsPin;
        private string Color;
        private List<string> Labels;
        private List<string> Collabarators;
        
        public int NOTEID { get { return NoteID; } set { NoteID = value; } }
        public string USEREMAIL { get { return UserEmail; } set { UserEmail = value; } }
        public string TITLE { get { return Title; } set { Title = value; } }
        public string DESCRIPTION { get { return Description; } set { Description = value; } }
        public DateTime? CREATEDDATE { get { return this.CreatedDate; } set { CreatedDate = value; } }
        public DateTime? MODIFIEDDATA { get { return this.ModifiedDate; } set { ModifiedDate = value; } }
        public string IMAGES { get { return this.Images; } set { Images = value; } }
        public DateTime? REMINDER { get { return this.Reminder; } set { Reminder = value; } }
        public bool ISARCHIVE { get { return this.IsArchive; } set { IsArchive = value; } }
        public bool ISTRASH { get { return this.IsTrash; } set { IsTrash = value; } }
        public bool ISPIN { get { return this.IsPin; } set { IsPin = value; } }
        public string COLOR { get { return this.Color; } set { Color = value; } }
        public List<string> LABELS { get { return this.Labels; } set { this.Labels = value; } }
        public List<string> COLLABRATORS { get { return this.Collabarators; } set { this.Collabarators = value; } }

    }
}
