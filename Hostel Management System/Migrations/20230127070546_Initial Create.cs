using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hostel_Management_System.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lookUpCollections",
                columns: table => new
                {
                    LookUpCollectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LookUpCollectionName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsDeleted = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookUpCollections", x => x.LookUpCollectionId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserCNIC = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserPhone = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserBD = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsDeleted = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ModifiedOn = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserLogin = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "lookUpCollectionValues",
                columns: table => new
                {
                    LookUpCollectionValueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LookUpCollectionValue = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IsDeleted = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ModifiedOn = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LookUpCollectionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LookUpCollectionId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookUpCollectionValues", x => x.LookUpCollectionValueId);
                    table.ForeignKey(
                        name: "FK_lookUpCollectionValues_lookUpCollections_LookUpCollectionId1",
                        column: x => x.LookUpCollectionId1,
                        principalTable: "lookUpCollections",
                        principalColumn: "LookUpCollectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lookUpCollectionValues_LookUpCollectionId1",
                table: "lookUpCollectionValues",
                column: "LookUpCollectionId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lookUpCollectionValues");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "lookUpCollections");
        }
    }
}
