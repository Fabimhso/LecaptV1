CREATE TABLE [dbo].[People]
(
	[ContactID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(100) NULL, 
    [Empresa] NVARCHAR(100) NULL, 
    [Telefone] NVARCHAR(100) NULL, 
    [E-Mail] NVARCHAR(100) NULL, 
    [Cliente] BIT NULL, 
    [Última Call] DATETIME NULL
)
