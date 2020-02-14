using Deal.Data.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Deal.Migration.DbContexts
{
    public partial class MigrationContext
    {
        public DbSet<CardDto> Cards { get; set; }
        public DbSet<DealerDto> Dealers { get; set; }
        public DbSet<ErrorReasonDto> ErrorReasons { get; set; }
        public DbSet<ErrorReasonGroupDto> ErrorReasonGroups { get; set; }
        public DbSet<EventDto> Events { get; set; }
        public DbSet<EventSetDto> EventSets { get; set; }
        public DbSet<OrganiserDto> Organisers { get; set; }
        public DbSet<OwnerDto> Owners { get; set; }
        public DbSet<PackColourDto> PackColours { get; set; }
        public DbSet<PackDealErrorDto> PackDealErrors { get; set; }
        public DbSet<PackDto> Packs { get; set; }
        public DbSet<RankDto> Ranks { get; set; }
        public DbSet<SeasonDto> SeasonsDtos { get; set; }
        public DbSet<SetColourDto> SetColours { get; set; }
        public DbSet<SetDealErrorDto> SetDealErrors { get; set; }
        public DbSet<SetDto> Sets { get; set; }
        public DbSet<SetPurposeDto> SetPurposes { get; set; }
        public DbSet<SuitDto> Suits { get; set; }
    }

}