namespace MVCMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class payam2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "ReviewrEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "ReviewrEmail", c => c.String());
        }
    }
}
