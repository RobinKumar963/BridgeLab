// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NoteModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ---------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Common.Models.NoteModels
{
    /// <summary>
    /// Note Entity
    /// </summary>
    public class NoteModel
    {

        
        private int NoteID;

        
       
        private string UserEmail;
       
        private string Title;
   
        private string Description;

        private DateTime? CreatedDate;
      
        private DateTime? ModifiedDate;
       
        private string Images;
      
        private string Reminder;
    
        private bool IsArchive;
    
        private bool IsTrash;
 
        private bool IsPin;
   
        private string Color;

        [Key]
        [Required]
        public int NOTEID { get { return NoteID; } set { NoteID = value; } }

       

        [Required]
        [ForeignKey("UserModel")]
        public string USEREMAIL { get { return UserEmail; } set { UserEmail = value; } }

        public string TITLE { get { return Title; } set { Title = value; } }

        public string DESCRIPTION { get { return Description; } set { Description = value; } }

        public DateTime? CREATEDDATE { get { return this.CreatedDate; } set { CreatedDate = value; } }

        public DateTime? MODIFIEDDATA { get { return this.ModifiedDate; } set { ModifiedDate = value; } }

        public string IMAGES { get { return this.Images; } set { Images = value; } }

        public string REMINDER { get { return this.Reminder; } set { Reminder = value; } }

        public bool ISARCHIVE { get { return this.IsArchive; } set { IsArchive = value; } }

        public bool ISTRASH { get { return this.IsTrash; } set { IsTrash = value; } }

        public bool ISPIN { get { return this.IsPin; } set { IsPin = value; } }

        public string COLOR { get { return this.Color; } set { Color = value; } }


    }
}
