using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using EventWebsite.Migrations;

namespace EventWebsite.Migrations
{
    [ContextType(typeof(RegistrationContext))]
    partial class Initial
    {
        public override string Id
        {
            get { return "20150701093248_Initial"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("EventWebsite.Models.Registration", b =>
                    {
                        b.Property<string>("Email")
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("FirstName")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 2)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("LastName")
                            .Annotation("OriginalValueIndex", 3);
                        b.Property<bool>("Session1")
                            .Annotation("OriginalValueIndex", 4);
                        b.Property<bool>("Session2")
                            .Annotation("OriginalValueIndex", 5);
                        b.Key("Id");
                    });
                
                return builder.Model;
            }
        }
    }
}
