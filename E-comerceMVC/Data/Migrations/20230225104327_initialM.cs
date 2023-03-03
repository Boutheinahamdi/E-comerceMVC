using Microsoft.EntityFrameworkCore.Migrations;

namespace E_comerceMVC.Data.Migrations
{
    public partial class initialM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Catgorie_catgorieId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catgorie",
                table: "Catgorie");

            migrationBuilder.RenameTable(
                name: "Catgorie",
                newName: "catgories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catgories",
                table: "catgories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_catgories_catgorieId",
                table: "products",
                column: "catgorieId",
                principalTable: "catgories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_catgories_catgorieId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catgories",
                table: "catgories");

            migrationBuilder.RenameTable(
                name: "catgories",
                newName: "Catgorie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catgorie",
                table: "Catgorie",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Catgorie_catgorieId",
                table: "products",
                column: "catgorieId",
                principalTable: "Catgorie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
