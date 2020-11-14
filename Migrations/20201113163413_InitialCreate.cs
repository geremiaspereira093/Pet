using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    AgendamentoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataAgendamento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Serviços = table.Column<int>(type: "INTEGER", nullable: false),
                    Petivery = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.AgendamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    CadastroId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    NomeTutor = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<long>(type: "INTEGER", nullable: false),
                    Telefone = table.Column<long>(type: "INTEGER", nullable: false),
                    endereco = table.Column<string>(type: "TEXT", nullable: true),
                    NomePet = table.Column<string>(type: "TEXT", nullable: true),
                    Especie = table.Column<bool>(type: "INTEGER", nullable: false),
                    senha = table.Column<string>(type: "TEXT", nullable: true),
                    confirmaSenha = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.CadastroId);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Usuario = table.Column<string>(type: "TEXT", nullable: true),
                    Senha = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");

            migrationBuilder.DropTable(
                name: "Cadastro");

            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}
