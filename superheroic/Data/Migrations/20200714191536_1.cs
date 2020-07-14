using Microsoft.EntityFrameworkCore.Migrations;

namespace superheroic.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Supers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Allies",
                table: "Supers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Durability",
                table: "Supers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnergyProjection",
                table: "Supers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FightingSkill",
                table: "Supers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Foes",
                table: "Supers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Intelligence",
                table: "Supers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Supers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "Supers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Supers");

            migrationBuilder.DropColumn(
                name: "Allies",
                table: "Supers");

            migrationBuilder.DropColumn(
                name: "Durability",
                table: "Supers");

            migrationBuilder.DropColumn(
                name: "EnergyProjection",
                table: "Supers");

            migrationBuilder.DropColumn(
                name: "FightingSkill",
                table: "Supers");

            migrationBuilder.DropColumn(
                name: "Foes",
                table: "Supers");

            migrationBuilder.DropColumn(
                name: "Intelligence",
                table: "Supers");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Supers");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "Supers");
        }
    }
}
