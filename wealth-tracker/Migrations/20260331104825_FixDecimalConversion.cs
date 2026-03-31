using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wealth_tracker.Migrations
{
    /// <inheritdoc />
    public partial class FixDecimalConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpentAmount",
                table: "BudgetLimits");

            migrationBuilder.AlterColumn<double>(
                name: "TargetAmount",
                table: "SavingsGoals",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<double>(
                name: "SavedAmount",
                table: "SavingsGoals",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<double>(
                name: "LimitAmount",
                table: "BudgetLimits",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TargetAmount",
                table: "SavingsGoals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "SavedAmount",
                table: "SavingsGoals",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<decimal>(
                name: "LimitAmount",
                table: "BudgetLimits",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AddColumn<decimal>(
                name: "SpentAmount",
                table: "BudgetLimits",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
