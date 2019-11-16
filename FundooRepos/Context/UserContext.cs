// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------------------------
using Common.Models.CollabratorModels;
using Common.Models.LabelledNoteModels;
using Common.Models.LabelModels;
using Common.Models.NoteModels;
using Common.Models.UserModels;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepos.Context
{
    /// <summary>
    /// Used for a Connected Session with Data Source
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class UserContext : DbContext
    {
        
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<NoteModel> Notes { get; set; }
        public DbSet<LabelModel> Labels { get; set; }
        public DbSet<CollabratorModel> Collabration { get; set; }
        public DbSet<LabelledNote> Labelnotes { get; set; }

    }
}
