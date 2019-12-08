using Microsoft.EntityFrameworkCore.Migrations;

namespace ValidateModel.Migrations
{
    public partial class ValidateDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    MaKhoa = table.Column<string>(nullable: false),
                    TenKhoa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.MaKhoa);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSV = table.Column<string>(nullable: false),
                    HoTen = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreditCard = table.Column<string>(nullable: true),
                    Hinh = table.Column<string>(nullable: true),
                    Diem = table.Column<double>(nullable: false),
                    HeSo = table.Column<double>(nullable: false),
                    MaBaoMat = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    MaKhoa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_SinhVien_Khoa_MaKhoa",
                        column: x => x.MaKhoa,
                        principalTable: "Khoa",
                        principalColumn: "MaKhoa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinhVien_MaKhoa",
                table: "SinhVien",
                column: "MaKhoa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVien");

            migrationBuilder.DropTable(
                name: "Khoa");
        }
    }
}
