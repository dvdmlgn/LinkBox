using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LinkBoxWeb.Migrations
{
    public partial class RemovedChapter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Chapters_ChapterId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Chapters_Link_ChapterId",
                table: "Contents");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Contents_ChapterId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_Link_ChapterId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "ChapterId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Link_ChapterId",
                table: "Contents");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Link_TopicId",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_TopicId",
                table: "Contents",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_Link_TopicId",
                table: "Contents",
                column: "Link_TopicId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Topics_TopicId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Topics_Link_TopicId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Contents_TopicId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_Link_TopicId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "Link_TopicId",
                table: "Contents");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChapterId",
                table: "Contents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Link_ChapterId",
                table: "Contents",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TopicId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapters_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_ChapterId",
                table: "Contents",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_Link_ChapterId",
                table: "Contents",
                column: "Link_ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_TopicId",
                table: "Chapters",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Chapters_ChapterId",
                table: "Contents",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Chapters_Link_ChapterId",
                table: "Contents",
                column: "Link_ChapterId",
                principalTable: "Chapters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
