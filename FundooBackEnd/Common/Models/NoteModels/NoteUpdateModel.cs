using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.NoteModels
{
    public class NoteUpdateModel
    {
        public int id { get; set; }
        public string newValue { get; set; }
        public string noteAttributeName { get; set; }
    }
}
