namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableJaqueta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jaquetas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tecido = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jaquetas");
        }
    }
}
