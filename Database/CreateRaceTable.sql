CREATE TABLE CrossCountry.Race
(
	RaceId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	CreatorId INT NOT NULL FOREIGN KEY
		REFERENCES CrossCountry.Coach,
	LocationId INT NOT NULL FOREIGN KEY
		REFERENCES CrossCountry.[Location],
	[DateTime] DATETIME2 NOT NULL,
	Distance INT NOT NULL,
	ChangeInElevation INT,
	IsArchived INT,

	UNIQUE(LocationId, [DateTime], Distance)

);