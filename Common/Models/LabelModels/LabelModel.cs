using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models.LabelModels
{
    public class LabelModel
    {
        private string email;
        private string label;
        private string id;
        [Required]
        public string Email { get { return this.email; } set { this.email = value; } }
        [Required]
        public string Label { get { return this.label; } set { this.label = value; } }
        [Required]
        [Key]
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}
