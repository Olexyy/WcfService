namespace WcfService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLastLogin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LastLogin", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "LastLogin");
        }
    }
}
