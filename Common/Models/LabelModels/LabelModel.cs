// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------




using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models.LabelModels
{
    /// <summary>
    /// Label Entity
    /// </summary>
    public class LabelModel
    {
        private string UserEmail;
        private string Label;
        private string LabelID;
        [Required]
        public string USEREMAIL { get { return this.UserEmail; } set { this.UserEmail = value; } }
        [Required]
        public string LABEL { get { return this.Label; } set { this.Label = value; } }
        [Required]
        [Key]
        public string LABELID
        {
            get { return this.LabelID; }
            set { this.LabelID = value; }
        }
    }
}
