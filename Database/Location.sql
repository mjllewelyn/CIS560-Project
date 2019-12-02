CREATE TABLE CrossCountry.[Location]
(
	LocationId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(32) NOT NULL,
	City NVARCHAR(32) NOT NULL,
	StateProvince NVARCHAR(32) NOT NULL,

	UNIQUE([Name], City, StateProvince)

);