using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LinkBoxWeb.Migrations
{
    public partial class submission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Topics_TopicId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Topics_Link_TopicId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_TopicId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Contents");

            migrationBuilder.RenameColumn(
                name: "Link_TopicId",
                table: "Contents",
                newName: "TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Contents_Link_TopicId",
                table: "Contents",
                newName: "IX_Contents_TopicId");

            migrationBuilder.AddColumn<bool>(
                name: "IsExcercise",
                table: "Contents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Topics_TopicId",
                table: "Contents",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Topics_TopicId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "IsExcercise",
                table: "Contents");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Contents",
                newName: "Link_TopicId");

            migrationBuilder.RenameIndex(
                name: "IX_Contents_TopicId",
                table: "Contents",
                newName: "IX_Contents_Link_TopicId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Contents",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Contents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Contents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contents_TopicId",
                table: "Contents",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Topics_TopicId",
                table: "Contents",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Topics_Link_TopicId",
                table: "Contents",
                column: "Link_TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
