// <copyright file="Update.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System.Linq;
using Deal.Data.Dtos;
using Deal.Domain.DomainObjects.Seasons;

namespace Deal.Data.Crud
{
    /// <summary>
    /// Data access layer.
    /// </summary>
    /// <seealso cref="Deal.Data.Crud.IDealData" />
    public partial class DealData
    {
        /// <inheritdoc/>
        public void UpdateSeason(ISeason season)
        {
            SeasonDto seasonDto = SeasonDto.ToDto(season);

            this.Context.Entry(
                    this.Context.Seasons
                        .Single(s => s.Id == seasonDto.Id))
                        .CurrentValues.SetValues(seasonDto);
            this.Context.SaveChanges();
        }
    }
}