namespace CSC.IT.Store.Data.CodeFirst.Administration.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateBrandTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Administration.Brands",
                c => new
                {
                    BrandId = c.Guid(nullable: false),
                    BrandName = c.String(nullable: false, maxLength: 40, unicode: false),
                    CreatedDateTime = c.DateTime(storeType: "smalldatetime"),
                    ModifiedDateTime = c.DateTime(storeType: "smalldatetime"),
                    CreatedBy = c.String(maxLength: 100, unicode: false),
                })
                .PrimaryKey(t => t.BrandId)
                .Index(t => t.BrandName, unique: true);

        }

        public override void Down()
        {
            DropIndex("Administration.Brands", new[] { "BrandName" });
            DropTable("Administration.Brands");
        }
    }
}
