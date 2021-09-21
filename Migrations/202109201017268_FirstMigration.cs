namespace BlogApiChallange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Paylasims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yorums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        YorumPaylasimi_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Paylasims", t => t.YorumPaylasimi_Id)
                .Index(t => t.YorumPaylasimi_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorums", "YorumPaylasimi_Id", "dbo.Paylasims");
            DropIndex("dbo.Yorums", new[] { "YorumPaylasimi_Id" });
            DropTable("dbo.Yorums");
            DropTable("dbo.Paylasims");
        }
    }
}
