CREATE TABLE Patient
(
	[ID] INT NOT NULL IDENTITY , 
    [First Name] NCHAR(10) NULL, 
    [Last Name] NCHAR(10) NULL, 
    [Age] NCHAR(10) NULL, 
    [NIC] NCHAR(10) NOT NULL, 
    [Disease/Injury] NVARCHAR(50) NOT NULL, 
    [Ward] NCHAR(10) NOT NULL, 
    [Doctor ID] NCHAR(10) NULL, 
    [Date & Time] TIMESTAMP  NULL, 
    PRIMARY KEY ([ID])
)
