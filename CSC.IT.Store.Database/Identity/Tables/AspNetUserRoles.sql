CREATE TABLE [Identity].[AspNetUserRoles] (
    [UserId] NVARCHAR (128) NOT NULL,
    [RoleId] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_Identity.AspNetUserRoles] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC),
    CONSTRAINT [FK_Identity.AspNetUserRoles_Identity.AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Identity].[AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Identity.AspNetUserRoles_Identity.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [Identity].[AspNetUsers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [Identity].[AspNetUserRoles]([UserId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_RoleId]
    ON [Identity].[AspNetUserRoles]([RoleId] ASC);

