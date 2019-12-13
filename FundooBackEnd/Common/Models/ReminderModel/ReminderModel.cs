using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.ReminderModel
{
    public class ReminderModel
    {
        private int ReminderID;
        private string UserEmail;
        private int NoteID;
        private DateTime? ReminderTime;


        [Key]
        [Required]
        public int REMINDERID { get { return ReminderID; } set { ReminderID = value; } }


        [Required]
        [ForeignKey("UserModel")]
        public string USEREMAIL { get { return UserEmail; } set { UserEmail = value; } }



        [Required]
        [ForeignKey("NoteModel")]
        public int NOTEID { get { return NoteID; } set { NoteID = value; } }


        
        [Required]
        public DateTime? REMINDERTIME { get { return ReminderTime; } set { ReminderTime = value; } }
    }
}
