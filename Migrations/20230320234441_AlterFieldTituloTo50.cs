using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtividadesApi.Migrations
{
    /// <inheritdoc />
    public partial class AlterFieldTituloTo50 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Atividade",
                table: "Atividade");

            migrationBuilder.RenameTable(
                name: "Atividade",
                newName: "Atividades");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Atividades",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atividades",
                table: "Atividades",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Atividades",
                table: "Atividades");

            migrationBuilder.RenameTable(
                name: "Atividades",
                newName: "Atividade");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Atividade",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atividade",
                table: "Atividade",
                column: "Id");
        }
    }
}
