using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NLightHouse.Migrations
{
    public partial class AddMockProjectAndPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PersonId1 = table.Column<string>(nullable: true),
                    PersonId2 = table.Column<string>(nullable: true),
                    PersonId3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Persons_Persons_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Persons_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Persons_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDetail",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    PurposeId = table.Column<string>(nullable: true),
                    Deadline = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectDetail_PurposeId",
                        column: x => x.PurposeId,
                        principalTable: "ProjectDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPerson",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PersonId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<string>(nullable: true),
                    PersonId1 = table.Column<string>(nullable: true),
                    ProjectId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_Persons_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectPerson_Projects_ProjectId1",
                        column: x => x.ProjectId1,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonId1",
                table: "Persons",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonId2",
                table: "Persons",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonId3",
                table: "Persons",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_PersonId",
                table: "ProjectPerson",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_PersonId1",
                table: "ProjectPerson",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_ProjectId",
                table: "ProjectPerson",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_ProjectId1",
                table: "ProjectPerson",
                column: "ProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_PurposeId",
                table: "Projects",
                column: "PurposeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectPerson");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ProjectDetail");
        }
    }
}
