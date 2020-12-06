CREATE TABLE [dbo].[Staff]
(
	[StaffID] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [DNo] INT NOT NULL, 
    [Street] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [State] VARCHAR(50) NOT NULL, 
    [ZipCode] NUMERIC NOT NULL
)
