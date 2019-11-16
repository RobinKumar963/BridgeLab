using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.LabelledNoteModels
{
    public class LabelledNote
    {
        private string LabelledNoteID;
        private string NoteID;
        private string LabelID;

        [Key]
        [Required]
        public string LABELLEDNOTEID { get { return this.LabelledNoteID; } set { this.LabelledNoteID = value; } }




        [Required]
        [ForeignKey("NoteModel")]
        public string NOTEID { get { return this.NoteID; } set { this.NoteID = value; } }


        [Required]
        [ForeignKey("LabelModel")]
        public string LABELID { get { return this.LabelID; } set { this.LabelID = value; } }

    }
}
