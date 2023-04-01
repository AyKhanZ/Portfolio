using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbEcommerceApp.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyMigration23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPayments_Users_UserId",
                table: "UserPayments");

            migrationBuilder.DropIndex(
                name: "IX_UserPayments_UserId",
                table: "UserPayments");

            migrationBuilder.DropColumn(
                name: "UserPaymentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Money",
                table: "UserPayments");

            migrationBuilder.CreateIndex(
                name: "IX_UserPayments_UserId",
                table: "UserPayments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPayments_Users_UserId",
                table: "UserPayments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPayments_Users_UserId",
                table: "UserPayments");

            migrationBuilder.DropIndex(
                name: "IX_UserPayments_UserId",
                table: "UserPayments");

            migrationBuilder.AddColumn<int>(
                name: "UserPaymentId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Money",
                table: "UserPayments",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UserPayments_UserId",
                table: "UserPayments",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPayments_Users_UserId",
                table: "UserPayments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
