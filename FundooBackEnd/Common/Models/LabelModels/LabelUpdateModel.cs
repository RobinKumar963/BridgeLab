using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.LabelModels
{
    public class LabelUpdateModel
    {
        public int id { get; set; }
        public string newValue { get; set; }
        public string labelAttributeName { get; set; }
    }
}
