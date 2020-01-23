namespace FormsDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonDbModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PersonDbModels");
        }
    }
}
