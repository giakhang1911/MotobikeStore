using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotobikeStore.Migrations
{
    /// <inheritdoc />
    public partial class Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tenxe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mieuta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    soluong = table.Column<int>(type: "int", nullable: false),
                    DongxeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_DongXe_DongxeId",
                        column: x => x.DongxeId,
                        principalTable: "DongXe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_DongxeId",
                table: "SanPham",
                column: "DongxeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
