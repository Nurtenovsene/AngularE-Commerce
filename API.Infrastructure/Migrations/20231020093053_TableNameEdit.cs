using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TableNameEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBrand_ProductBrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductType_ProductTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductBrand",
                table: "ProductBrand");

            migrationBuilder.RenameTable(
                name: "ProductType",
                newName: "ProductsTypes");

            migrationBuilder.RenameTable(
                name: "ProductBrand",
                newName: "ProductsBrands");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsTypes",
                table: "ProductsTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsBrands",
                table: "ProductsBrands",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsBrands_ProductBrandId",
                table: "Products",
                column: "ProductBrandId",
                principalTable: "ProductsBrands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductsTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductsTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsBrands_ProductBrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductsTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsTypes",
                table: "ProductsTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsBrands",
                table: "ProductsBrands");

            migrationBuilder.RenameTable(
                name: "ProductsTypes",
                newName: "ProductType");

            migrationBuilder.RenameTable(
                name: "ProductsBrands",
                newName: "ProductBrand");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductType",
                table: "ProductType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductBrand",
                table: "ProductBrand",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBrand_ProductBrandId",
                table: "Products",
                column: "ProductBrandId",
                principalTable: "ProductBrand",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductType_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductType",
                principalColumn: "Id");
        }
    }
}
