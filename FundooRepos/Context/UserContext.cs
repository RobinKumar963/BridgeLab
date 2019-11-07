// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Robin Kumar"/>
// ----------------------------------------------------------------------------------------------------


using Common.Models.UserModels;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepos.Context
{
    /// <summary>
    /// Represents a user session(allows for easy access of user model for using in query and saving changes in database)
    /// </summary>
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        /// <summary>
        /// Get all users of user model
        /// </summary>
        public DbSet<UserModel> users { get; set; }
    }
}
