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
            migration.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Email = table.Column(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column(type: "nvarchar(max)", nullable: true),
                    Id = table.Column(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGeneration", "Identity"),
                    LastName = table.Column(type: "nvarchar(max)", nullable: true),
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
            migration.DropTable("Registration");
        }
    }
}
