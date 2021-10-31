CREATE TABLE [dbo].[Transacties]
(
	[TransactieId] INT NOT NULL PRIMARY KEY, 
    [AandeelId] INT NULL, 
    [AantalGekocht] INT NULL, 
    [AantalVerkocht] INT NULL, 
    [Koers] MONEY NULL, 
    [TransactieDatum] DATETIME NULL, 
    CONSTRAINT [FK_AndeelId] FOREIGN KEY (AandeelId) REFERENCES Andelen(AandeelId)
)
