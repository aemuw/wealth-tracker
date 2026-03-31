using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wealth_tracker.Migrations
{
    /// <inheritdoc />
    public partial class AddRecurringTrnsactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRecurring",
                table: "Transactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RecurringDay",
                table: "Transactions",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRecurring",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "RecurringDay",
                table: "Transactions");
        }
    }
}
