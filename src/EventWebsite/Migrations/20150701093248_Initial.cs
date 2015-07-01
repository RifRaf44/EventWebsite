using System.Collections.Generic;
using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Operations;

namespace EventWebsite.Migrations
{
    public partial class Initial : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateSequence(
                name: "DefaultSequence",
                type: "bigint",
                startWith: 1L,
                incrementBy: 10);
            migration.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Email = table.Column(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column(type: "nvarchar(max)", nullable: false),
                    Id = table.Column(type: "int", nullable: false),
                    LastName = table.Column(type: "nvarchar(max)", nullable: false),
                    Session1 = table.Column(type: "bit", nullable: false),
                    Session2 = table.Column(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.Id);
                });
        }
        
        public override void Down(MigrationBuilder migration)
        {
            migration.DropSequence("DefaultSequence");
            migration.DropTable("Registration");
        }
    }
}
