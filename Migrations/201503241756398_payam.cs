namespace MVCMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class payam : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "Artist_ArtistID" });
            RenameColumn(table: "dbo.Albums", name: "Artist_ArtistID", newName: "ArtistID");
            AlterColumn("dbo.Albums", "ArtistID", c => c.Int(nullable: false));
            CreateIndex("dbo.Albums", "ArtistID");
            AddForeignKey("dbo.Albums", "ArtistID", "dbo.Artists", "ArtistID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "ArtistID", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "ArtistID" });
            AlterColumn("dbo.Albums", "ArtistID", c => c.Int());
            RenameColumn(table: "dbo.Albums", name: "ArtistID", newName: "Artist_ArtistID");
            CreateIndex("dbo.Albums", "Artist_ArtistID");
            AddForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists", "ArtistID");
        }
    }
}
