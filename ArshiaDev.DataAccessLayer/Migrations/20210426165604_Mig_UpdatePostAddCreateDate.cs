﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArshiaDev.DataAccessLayer.Migrations
{
    public partial class Mig_UpdatePostAddCreateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Posts");
        }
    }
}
