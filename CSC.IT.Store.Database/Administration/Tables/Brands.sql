CREATE TABLE [Administration].[Brands] (
    [BrandId]          UNIQUEIDENTIFIER NOT NULL,
    [BrandName]        VARCHAR (40)     NOT NULL,
    [CreatedDateTime]  SMALLDATETIME    NULL,
    [ModifiedDateTime] SMALLDATETIME    NULL,
    [CreatedBy]        VARCHAR (100)    NULL,
    CONSTRAINT [PK_Administration.Brands] PRIMARY KEY CLUSTERED ([BrandId] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_BrandName]
    ON [Administration].[Brands]([BrandName] ASC);

