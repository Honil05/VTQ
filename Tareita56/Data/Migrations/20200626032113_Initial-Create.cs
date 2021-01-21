using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tareita56.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Historico",
                columns: table => new
                {
                    HistoricoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    H_Chasis = table.Column<string>(nullable: true),
                    H_Marca = table.Column<string>(nullable: true),
                    H_Modelo = table.Column<string>(nullable: true),
                    H_Color = table.Column<string>(nullable: true),
                    H_Placa = table.Column<string>(nullable: true),
                    H_Year = table.Column<int>(nullable: false),
                    H_FechaRetencion = table.Column<DateTime>(nullable: false),
                    H_FechaSalida = table.Column<DateTime>(nullable: false),
                    H_Lugar = table.Column<string>(nullable: true),
                    H_Lat = table.Column<string>(nullable: true),
                    H_Long = table.Column<string>(nullable: true),
                    H_NombreConductor = table.Column<string>(nullable: true),
                    H_Cedula = table.Column<string>(nullable: true),
                    H_Comentarios = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historico", x => x.HistoricoID);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VehiculosID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chasis = table.Column<string>(nullable: true),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Placa = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    FechaRetencion = table.Column<DateTime>(nullable: false),
                    Lugar = table.Column<string>(nullable: false),
                    Lat = table.Column<string>(nullable: true),
                    Long = table.Column<string>(nullable: true),
                    NombreConductor = table.Column<string>(nullable: true),
                    Cedula = table.Column<string>(nullable: false),
                    Comentarios = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.VehiculosID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historico");

            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
