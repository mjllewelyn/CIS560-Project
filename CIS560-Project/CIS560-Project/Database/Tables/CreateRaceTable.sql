CREATE TABLE CrossCountry.Race
(
	RaceId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	[DateTime] DATETIME2 NOT NULL,
	CreatorId INT NOT NULL FOREIGN KEY
		REFERENCES CrossCountry.Coach,
	LocationId INT NOT NULL FOREIGN KEY
		REFERENCES CrossCountry.[Location],
	Distance INT NOT NULL,
	ChangeInElevation INT,
	IsArchived INT NOT NULL DEFAULT 0,

	UNIQUE(LocationId, [DateTime], Distance)

);