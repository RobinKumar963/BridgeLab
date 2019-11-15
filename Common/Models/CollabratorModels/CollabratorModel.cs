using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.CollabratorModels
{
    /// <summary>
    /// Collabrator Entity
    /// </summary>
    public class CollabratorModel
    {
        private int CollabrationID;
        private int NoteID;
        private string SenderEmail;
        private string RecievedEmail;

        [Key]
        [Required]
        public int COLLABRATIONID { get { return CollabrationID; } set { CollabrationID = value; } }


        [Required]
        [ForeignKey("NoteModel")]
        public int NOTEID { get { return NoteID; } set { NoteID = value; } }


        [Required]
        [ForeignKey("UserModel")]
        public string SENDEREMAIL { get { return SenderEmail; } set { SenderEmail = value; } }

        [Required]
        [ForeignKey("UserModel")]
        public string RECIEVEDEMAIL { get { return RecievedEmail; } set { RecievedEmail = value; } }
    }
}
