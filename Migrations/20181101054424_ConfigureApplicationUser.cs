using Microsoft.EntityFrameworkCore.Migrations;

namespace NLightHouse.Migrations
{
    public partial class ConfigureApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_User_ApplicationUserUserId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_User_ApplicationUserUserId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_User_ApplicationUserUserId2",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPerson_User_ApplicationUserUserId",
                table: "ProjectPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPerson_User_ApplicationUserUserId1",
                table: "ProjectPerson");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_ProjectPerson_ApplicationUserUserId",
                table: "ProjectPerson");

            migrationBuilder.DropIndex(
                name: "IX_ProjectPerson_ApplicationUserUserId1",
                table: "ProjectPerson");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ApplicationUserUserId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ApplicationUserUserId1",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ApplicationUserUserId2",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "ProjectPerson");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId1",
                table: "ProjectPerson");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ApplicationUserUserId1",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserUserId2",
                table: "Persons",
                newName: "ApplicationUserId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ApplicationUserId",
                table: "Persons",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_AspNetUsers_ApplicationUserId",
                table: "Persons",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_AspNetUsers_ApplicationUserId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ApplicationUserId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Persons",
                newName: "ApplicationUserUserId2");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserUserId",
                table: "ProjectPerson",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserUserId1",
                table: "ProjectPerson",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserUserId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserUserId1",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PersonId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_ApplicationUserUserId",
                table: "ProjectPerson",
                column: "ApplicationUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPerson_ApplicationUserUserId1",
                table: "ProjectPerson",
                column: "ApplicationUserUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ApplicationUserUserId",
                table: "Persons",
                column: "ApplicationUserUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ApplicationUserUserId1",
                table: "Persons",
                column: "ApplicationUserUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ApplicationUserUserId2",
                table: "Persons",
                column: "ApplicationUserUserId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_User_ApplicationUserUserId",
                table: "Persons",
                column: "ApplicationUserUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_User_ApplicationUserUserId1",
                table: "Persons",
                column: "ApplicationUserUserId1",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_User_ApplicationUserUserId2",
                table: "Persons",
                column: "ApplicationUserUserId2",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPerson_User_ApplicationUserUserId",
                table: "ProjectPerson",
                column: "ApplicationUserUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPerson_User_ApplicationUserUserId1",
                table: "ProjectPerson",
                column: "ApplicationUserUserId1",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
