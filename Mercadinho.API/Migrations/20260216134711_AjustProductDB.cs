using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mercadinho.API.Migrations
{
    /// <inheritdoc />
    public partial class AjustProductDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_category_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "product");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "product",
                newName: "IX_product_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product",
                column: "CategoryId",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_category_CategoryId",
                table: "product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
