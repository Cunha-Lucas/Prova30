using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lucas.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Funcionarios",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "Funcionarios",
                newName: "cpf");

            migrationBuilder.AlterColumn<string>(
                name: "cpf",
                table: "Funcionarios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Funcionarios",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Funcionarios",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Funcionarios",
                newName: "CPF");

            migrationBuilder.AlterColumn<int>(
                name: "CPF",
                table: "Funcionarios",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Funcionarios",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
