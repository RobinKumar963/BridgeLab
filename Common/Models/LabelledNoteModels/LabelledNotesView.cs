using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.LabelledNoteModels
{

    public class LabelledNotesView
    {
        private int NoteID;
       
        private List<string> Labels;

        
        public int NOTEID { get { return this.NoteID; } set { this.NoteID = value; } }
        public List<string> LABELS { get { return this.Labels; } set { this.Labels = value; } }



    }
}
