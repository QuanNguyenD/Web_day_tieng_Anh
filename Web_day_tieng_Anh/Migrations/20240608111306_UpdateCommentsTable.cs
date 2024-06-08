﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_day_tieng_Anh.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCommentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
