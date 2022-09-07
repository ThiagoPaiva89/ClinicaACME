using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicaACME.Migrations
{
    public partial class CorrigindoColunaSatusAtivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Cadastro_Pacientes",
                newName: "Status_Ativo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status_Ativo",
                table: "Cadastro_Pacientes",
                newName: "Status");
        }
    }
}
