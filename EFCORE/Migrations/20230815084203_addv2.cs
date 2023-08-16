using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramwork.Migrations
{
    /// <inheritdoc />
    public partial class addv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayDangKy",
                table: "HocVien_tbl",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayDangKy",
                table: "HocVien_tbl");
        }
    }
}
