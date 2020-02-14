using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deal.Migration.Migrations
{
    public partial class Initial : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dealers",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Name = table.Column<string>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorReasonGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Name = table.Column<string>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorReasonGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organisers",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Name = table.Column<string>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Name = table.Column<string>(),
                    IsClub = table.Column<bool>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PackColours",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Code = table.Column<string>(),
                    Colour = table.Column<string>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackColours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Code = table.Column<string>(),
                    Name = table.Column<string>(),
                    SortOrder = table.Column<short>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetColours",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Name = table.Column<string>(),
                    Code = table.Column<string>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetColours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetPurposes",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Name = table.Column<string>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetPurposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suits",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Code = table.Column<string>(),
                    Name = table.Column<string>(),
                    SortOrder = table.Column<short>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorReasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    Name = table.Column<string>(),
                    Code = table.Column<string>(),
                    ErrorReasonGroupId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorReasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ErrorReasons_ErrorReasonGroups_ErrorReasonGroupId",
                        column: x => x.ErrorReasonGroupId,
                        principalTable: "ErrorReasonGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    OrganiserId = table.Column<Guid>(),
                    Description = table.Column<string>(),
                    StartDate = table.Column<DateTime>(),
                    EndDate = table.Column<DateTime>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_Organisers_OrganiserId",
                        column: x => x.OrganiserId,
                        principalTable: "Organisers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    OwnerId = table.Column<Guid>(),
                    SetPurposeId = table.Column<Guid>(),
                    SetColourId = table.Column<Guid>(),
                    LowBoardNumber = table.Column<int>(),
                    HighBoardNumber = table.Column<int>(),
                    Description = table.Column<string>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sets_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sets_SetColours_SetColourId",
                        column: x => x.SetColourId,
                        principalTable: "SetColours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sets_SetPurposes_SetPurposeId",
                        column: x => x.SetPurposeId,
                        principalTable: "SetPurposes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    SuitId = table.Column<Guid>(),
                    RankId = table.Column<Guid>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Ranks_RankId",
                        column: x => x.RankId,
                        principalTable: "Ranks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cards_Suits_SuitId",
                        column: x => x.SuitId,
                        principalTable: "Suits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    SeasonId = table.Column<Guid>(),
                    Name = table.Column<string>(),
                    SubName = table.Column<string>(),
                    HandCopies = table.Column<int>(),
                    IsDoubleSidedHandCopies = table.Column<bool>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    PackColourId = table.Column<Guid>(),
                    SetId = table.Column<Guid>(),
                    EnteredService = table.Column<DateTime>(),
                    BoardNumber = table.Column<int>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packs_PackColours_PackColourId",
                        column: x => x.PackColourId,
                        principalTable: "PackColours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packs_Sets_SetId",
                        column: x => x.SetId,
                        principalTable: "Sets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    EventId = table.Column<Guid>(),
                    SetId = table.Column<Guid>(),
                    DealerId = table.Column<Guid>(),
                    Dealt = table.Column<DateTime>(),
                    IsBoardsReturnedOutOfSequence = table.Column<bool>()
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventSets_Dealers_DealerId",
                        column: x => x.DealerId,
                        principalTable: "Dealers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventSets_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventSets_Sets_SetId",
                        column: x => x.SetId,
                        principalTable: "Sets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PackDealErrors",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    EventSetId = table.Column<Guid>(),
                    PackId = table.Column<Guid>(),
                    ErrorReasonId = table.Column<Guid>(),
                    ActualCardId = table.Column<Guid>(),
                    ClaimedCardId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackDealErrors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackDealErrors_Cards_ActualCardId",
                        column: x => x.ActualCardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackDealErrors_Cards_ClaimedCardId",
                        column: x => x.ClaimedCardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackDealErrors_ErrorReasons_ErrorReasonId",
                        column: x => x.ErrorReasonId,
                        principalTable: "ErrorReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackDealErrors_EventSets_EventSetId",
                        column: x => x.EventSetId,
                        principalTable: "EventSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackDealErrors_Packs_PackId",
                        column: x => x.PackId,
                        principalTable: "Packs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SetDealErrors",
                columns: table => new
                {
                    Id = table.Column<Guid>(),
                    EventSetId = table.Column<Guid>(),
                    ErrorReasonId = table.Column<Guid>(),
                    NorthCount = table.Column<int>(nullable: true),
                    EastCount = table.Column<int>(nullable: true),
                    WestCount = table.Column<int>(nullable: true),
                    SouthCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetDealErrors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetDealErrors_ErrorReasons_ErrorReasonId",
                        column: x => x.ErrorReasonId,
                        principalTable: "ErrorReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SetDealErrors_EventSets_EventSetId",
                        column: x => x.EventSetId,
                        principalTable: "EventSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_RankId",
                table: "Cards",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_SuitId",
                table: "Cards",
                column: "SuitId");

            migrationBuilder.CreateIndex(
                name: "IX_ErrorReasons_ErrorReasonGroupId",
                table: "ErrorReasons",
                column: "ErrorReasonGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SeasonId",
                table: "Events",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSets_DealerId",
                table: "EventSets",
                column: "DealerId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSets_EventId",
                table: "EventSets",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSets_SetId",
                table: "EventSets",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_PackDealErrors_ActualCardId",
                table: "PackDealErrors",
                column: "ActualCardId");

            migrationBuilder.CreateIndex(
                name: "IX_PackDealErrors_ClaimedCardId",
                table: "PackDealErrors",
                column: "ClaimedCardId");

            migrationBuilder.CreateIndex(
                name: "IX_PackDealErrors_ErrorReasonId",
                table: "PackDealErrors",
                column: "ErrorReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_PackDealErrors_EventSetId",
                table: "PackDealErrors",
                column: "EventSetId");

            migrationBuilder.CreateIndex(
                name: "IX_PackDealErrors_PackId",
                table: "PackDealErrors",
                column: "PackId");

            migrationBuilder.CreateIndex(
                name: "IX_Packs_PackColourId",
                table: "Packs",
                column: "PackColourId");

            migrationBuilder.CreateIndex(
                name: "IX_Packs_SetId",
                table: "Packs",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_OrganiserId",
                table: "Seasons",
                column: "OrganiserId");

            migrationBuilder.CreateIndex(
                name: "IX_SetDealErrors_ErrorReasonId",
                table: "SetDealErrors",
                column: "ErrorReasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SetDealErrors_EventSetId",
                table: "SetDealErrors",
                column: "EventSetId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_OwnerId",
                table: "Sets",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_SetColourId",
                table: "Sets",
                column: "SetColourId");

            migrationBuilder.CreateIndex(
                name: "IX_Sets_SetPurposeId",
                table: "Sets",
                column: "SetPurposeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackDealErrors");

            migrationBuilder.DropTable(
                name: "SetDealErrors");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Packs");

            migrationBuilder.DropTable(
                name: "ErrorReasons");

            migrationBuilder.DropTable(
                name: "EventSets");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "Suits");

            migrationBuilder.DropTable(
                name: "PackColours");

            migrationBuilder.DropTable(
                name: "ErrorReasonGroups");

            migrationBuilder.DropTable(
                name: "Dealers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "SetColours");

            migrationBuilder.DropTable(
                name: "SetPurposes");

            migrationBuilder.DropTable(
                name: "Organisers");
        }
    }
}
