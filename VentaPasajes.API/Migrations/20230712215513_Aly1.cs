using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VentaPasajes.API.Migrations
{
    /// <inheritdoc />
    public partial class Aly1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cooperativas",
                columns: table => new
                {
                    Id_Cooperativa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_Registro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperativas", x => x.Id_Cooperativa);
                });

            migrationBuilder.CreateTable(
                name: "Movil",
                columns: table => new
                {
                    Id_Movil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Chofer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo_Movil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular_Chofer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movil", x => x.Id_Movil);
                });

            migrationBuilder.CreateTable(
                name: "Oficina",
                columns: table => new
                {
                    Id_Oficina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Oficina = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Cooperativa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficina", x => x.Id_Oficina);
                    table.ForeignKey(
                        name: "FK_Oficina_Cooperativas_Id_Cooperativa",
                        column: x => x.Id_Cooperativa,
                        principalTable: "Cooperativas",
                        principalColumn: "Id_Cooperativa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Completo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Registro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Oficina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id_Usuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Oficina_Id_Oficina",
                        column: x => x.Id_Oficina,
                        principalTable: "Oficina",
                        principalColumn: "Id_Oficina",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Encomienda",
                columns: table => new
                {
                    Id_Encomienda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Cliente_Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_Cliente_Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aclaracion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Movil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Registro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    MovilId = table.Column<int>(type: "int", nullable: false),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ClienteId_Cliente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encomienda", x => x.Id_Encomienda);
                    table.ForeignKey(
                        name: "FK_Encomienda_Clientes_ClienteId_Cliente",
                        column: x => x.ClienteId_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente");
                    table.ForeignKey(
                        name: "FK_Encomienda_Movil_MovilId",
                        column: x => x.MovilId,
                        principalTable: "Movil",
                        principalColumn: "Id_Movil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Encomienda_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pasaje",
                columns: table => new
                {
                    Id_Pasaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monto_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad_Pasajes = table.Column<int>(type: "int", nullable: false),
                    Movil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha_Registro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    Id_Movil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasaje", x => x.Id_Pasaje);
                    table.ForeignKey(
                        name: "FK_Pasaje_Movil_Id_Movil",
                        column: x => x.Id_Movil,
                        principalTable: "Movil",
                        principalColumn: "Id_Movil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pasaje_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Encomienda",
                columns: table => new
                {
                    ID_Detalle_Encomienda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ID_Encomienda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Encomienda", x => x.ID_Detalle_Encomienda);
                    table.ForeignKey(
                        name: "FK_Detalle_Encomienda_Encomienda_ID_Encomienda",
                        column: x => x.ID_Encomienda,
                        principalTable: "Encomienda",
                        principalColumn: "Id_Encomienda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Pasaje",
                columns: table => new
                {
                    Id_Detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fecha_Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Pasaje = table.Column<int>(type: "int", nullable: false),
                    Id_Cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Pasaje", x => x.Id_Detalle);
                    table.ForeignKey(
                        name: "FK_Detalle_Pasaje_Clientes_Id_Cliente",
                        column: x => x.Id_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Pasaje_Pasaje_Id_Pasaje",
                        column: x => x.Id_Pasaje,
                        principalTable: "Pasaje",
                        principalColumn: "Id_Pasaje",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Nombre_Cliente",
                table: "Clientes",
                column: "Nombre_Cliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Encomienda_ID_Encomienda",
                table: "Detalle_Encomienda",
                column: "ID_Encomienda");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Pasaje_Id_Cliente",
                table: "Detalle_Pasaje",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Pasaje_Id_Pasaje",
                table: "Detalle_Pasaje",
                column: "Id_Pasaje");

            migrationBuilder.CreateIndex(
                name: "IX_Encomienda_ClienteId_Cliente",
                table: "Encomienda",
                column: "ClienteId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Encomienda_Id_Usuario",
                table: "Encomienda",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Encomienda_MovilId",
                table: "Encomienda",
                column: "MovilId");

            migrationBuilder.CreateIndex(
                name: "IX_Oficina_Id_Cooperativa",
                table: "Oficina",
                column: "Id_Cooperativa");

            migrationBuilder.CreateIndex(
                name: "IX_Pasaje_Id_Movil",
                table: "Pasaje",
                column: "Id_Movil");

            migrationBuilder.CreateIndex(
                name: "IX_Pasaje_Id_Usuario",
                table: "Pasaje",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Id_Oficina",
                table: "Usuario",
                column: "Id_Oficina");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle_Encomienda");

            migrationBuilder.DropTable(
                name: "Detalle_Pasaje");

            migrationBuilder.DropTable(
                name: "Encomienda");

            migrationBuilder.DropTable(
                name: "Pasaje");

            migrationBuilder.DropTable(
                name: "Movil");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Oficina");

            migrationBuilder.DropTable(
                name: "Cooperativas");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_Nombre_Cliente",
                table: "Clientes");
        }
    }
}
