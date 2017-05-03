CREATE PROCEDURE [Administration].[InsertBrand]
	@BrandName varchar(40),
	@CreatedBy varchar(100),
	@BarndId uniqueidentifier out
AS
	SET @BarndId = NEWID();
	INSERT INTO Administration.Brands VALUES(@BarndId, @BrandName, GETDATE(), GETDATE(), @CreatedBy) 
RETURN 1
