using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.LabelledNoteModels
{
    public class LabelledNote
    {
        private int LabelNoteID;
        private int NoteID;
        private int LabelID;

        [Key]
        [Required]
        public int LABELNOTEID { get { return this.LabelNoteID; } set { this.LabelNoteID = value; } }




        [Required]
        [ForeignKey("NoteModel")]
        public int NOTEID { get { return this.NoteID; } set { this.NoteID = value; } }


        [Required]
        [ForeignKey("LabelModel")]
        public int LABELID { get { return this.LabelID; } set { this.LabelID = value; } }

    }
}
