using Alura.Filmes.App.Migrations;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Alura.Filmes.App.Migrations
{
    public partial class FilmeCheckConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"ALTER TABLE [dbo].[film]
                ADD CONSTRAINT [check_rating] 
                CHECK ([rating]='NC-17' 
                OR [rating]='R' 
                OR [rating]='PG-13' 
                OR [rating]='PG' 
                OR [rating]='G');";

            migrationBuilder.Sql(sql);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_update",
                table: "language",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_update",
                table: "film_actor",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_update",
                table: "film",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_update",
                table: "actor",
                type: "datetime",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("ALTER TABLE [dbo].[film] DROP CONSTRAINT [check_rating]");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_update",
                table: "language",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_update",
                table: "film_actor",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_update",
                table: "film",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_update",
                table: "actor",
                type: "datetime",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "getdate()");
        }
    }
}
