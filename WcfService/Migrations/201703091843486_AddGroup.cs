namespace WcfService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroup : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "Name" });
            AddColumn("dbo.Users", "Group", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Users", "Name", unique: true);
        }
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Name" });
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Users", "Group");
            CreateIndex("dbo.Users", "Name", unique: true);
        }
    }
}
