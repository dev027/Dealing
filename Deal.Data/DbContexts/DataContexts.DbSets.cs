// <copyright file="DataContexts.DbSets.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using Deal.Data.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Deal.Data.DbContexts
{
    /// <summary>
    /// Database Context - DB Sets.
    /// </summary>
    /// <seealso cref="DbContext" />
    public partial class DataContext
    {
        /// <summary>
        /// Gets or sets the Cards.
        /// </summary>
        public DbSet<CardDto> Cards { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Dealers.
        /// </summary>
        public DbSet<DealerDto> Dealers { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Error Reasons.
        /// </summary>
        public DbSet<ErrorReasonDto> ErrorReasons { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Error Reason Groups.
        /// </summary>
        public DbSet<ErrorReasonGroupDto> ErrorReasonGroups { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Events.
        /// </summary>
        public DbSet<EventDto> Events { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Event Sets.
        /// </summary>
        public DbSet<EventSetDto> EventSets { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Organisers.
        /// </summary>
        public DbSet<OrganiserDto> Organisers { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Owners.
        /// </summary>
        public DbSet<OwnerDto> Owners { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Pack Colours.
        /// </summary>
        public DbSet<PackColourDto> PackColours { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Pack Deal Errors.
        /// </summary>
        public DbSet<PackDealErrorDto> PackDealErrors { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Packs.
        /// </summary>
        public DbSet<PackDto> Packs { get; set; } = null!;

        /// <summary>
        /// Gets or sets the ranks.
        /// </summary>
        public DbSet<RankDto> Ranks { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Seasons dtos.
        /// </summary>
        public DbSet<SeasonDto> Seasons { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Set Colours.
        /// </summary>
        public DbSet<SetColourDto> SetColours { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Set Deal Errors.
        /// </summary>
        public DbSet<SetDealErrorDto> SetDealErrors { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Sets.
        /// </summary>
        public DbSet<SetDto> Sets { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Set Purposes.
        /// </summary>
        public DbSet<SetPurposeDto> SetPurposes { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Suits.
        /// </summary>
        public DbSet<SuitDto> Suits { get; set; } = null!;
    }
}