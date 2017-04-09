using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CompetitionTracker.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    CompetitorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alias = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitors", x => x.CompetitorId);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Awards = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CompetitorId = table.Column<int>(nullable: false),
                    Experience = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    HSName = table.Column<string>(nullable: true),
                    IsCompeting = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    NextCollege = table.Column<string>(nullable: true),
                    UserForeignKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_Competitors_CompetitorId",
                        column: x => x.CompetitorId,
                        principalTable: "Competitors",
                        principalColumn: "CompetitorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_AspNetUsers_UserForeignKey",
                        column: x => x.UserForeignKey,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_CompetitorId",
                table: "Person",
                column: "CompetitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_UserForeignKey",
                table: "Person",
                column: "UserForeignKey",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Competitors");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
