CREATE TABLE [dbo].[Mensaje]
(
	[IdRegistro] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Asunto] NVARCHAR(50) NOT NULL, 
    [Mensajee] NVARCHAR(50) NOT NULL, 
    [Emisor] NVARCHAR(50) NOT NULL, 
    [Receptor] NVARCHAR(50) NOT NULL, 
    [Urgencia] BIT NOT NULL, 
    [FechayHora] DATETIME NOT NULL
)
