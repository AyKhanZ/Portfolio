using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbEcommerceApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserDetailId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserPaymentId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserDetailId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserPaymentId",
                table: "Users");
        }
    }
}
