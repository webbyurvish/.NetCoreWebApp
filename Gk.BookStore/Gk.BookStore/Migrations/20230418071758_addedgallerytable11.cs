﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gk.BookStore.Migrations
{
    /// <inheritdoc />
    public partial class addedgallerytable11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGallery_Books_BooksId",
                table: "BookGallery");

            migrationBuilder.DropIndex(
                name: "IX_BookGallery_BooksId",
                table: "BookGallery");

            migrationBuilder.DropColumn(
                name: "BooksId",
                table: "BookGallery");

            migrationBuilder.CreateIndex(
                name: "IX_BookGallery_BookId",
                table: "BookGallery",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGallery_Books_BookId",
                table: "BookGallery",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGallery_Books_BookId",
                table: "BookGallery");

            migrationBuilder.DropIndex(
                name: "IX_BookGallery_BookId",
                table: "BookGallery");

            migrationBuilder.AddColumn<int>(
                name: "BooksId",
                table: "BookGallery",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookGallery_BooksId",
                table: "BookGallery",
                column: "BooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGallery_Books_BooksId",
                table: "BookGallery",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
