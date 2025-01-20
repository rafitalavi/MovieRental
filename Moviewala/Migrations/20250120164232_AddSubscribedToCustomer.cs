using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moviewala.Migrations
{
    /// <inheritdoc />
    public partial class AddSubscribedToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribedToNewletter",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubscribedToNewletter",
                table: "Customers");
        }
    }
}
