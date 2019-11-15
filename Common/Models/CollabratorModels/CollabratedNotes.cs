using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.CollabratorModels
{
    /// <summary>
    /// CollabratedNotes model to be used to display collabrated notes
    /// </summary>
    public class CollabratedNotes
    {
        private int NoteID;
        private string SenderEmail;
        private List<string> RecieverEmail;
        private string Image;
        private string Description;

       
        public int NOTEID
        {
            get
            {
                return NoteID;
            }
            set
            {
                NoteID = value;
            }
        }

        public string SENDEREMAIL
        {
            get
            {
                return SenderEmail;
            }
            set
            {
                SenderEmail = value;
            }
        }



        public List<string> RECIEVEREMAIL
        {
            get
            {
                return RecieverEmail;
            }
            set
            {
                RecieverEmail = value;
            }
        }

    
        public string IMAGE
        {
            get
            {
                return Image;
            }
            set
            {
                Image = value;
            }
        }


        public string DESCRIPTION
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }


    }
}
