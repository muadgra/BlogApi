namespace BlogApiChallange.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YorumGuncelleme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Yorums", "YorumPaylasimi_Id", "dbo.Paylasims");
            DropIndex("dbo.Yorums", new[] { "YorumPaylasimi_Id" });
            RenameColumn(table: "dbo.Yorums", name: "YorumPaylasimi_Id", newName: "PaylasimId");
            AlterColumn("dbo.Yorums", "PaylasimId", c => c.Int(nullable: false));
            CreateIndex("dbo.Yorums", "PaylasimId");
            AddForeignKey("dbo.Yorums", "PaylasimId", "dbo.Paylasims", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorums", "PaylasimId", "dbo.Paylasims");
            DropIndex("dbo.Yorums", new[] { "PaylasimId" });
            AlterColumn("dbo.Yorums", "PaylasimId", c => c.Int());
            RenameColumn(table: "dbo.Yorums", name: "PaylasimId", newName: "YorumPaylasimi_Id");
            CreateIndex("dbo.Yorums", "YorumPaylasimi_Id");
            AddForeignKey("dbo.Yorums", "YorumPaylasimi_Id", "dbo.Paylasims", "Id");
        }
    }
}
