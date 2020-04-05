namespace QTProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class call_index : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calls", "Index", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calls", "Index");
        }
    }
}
