USE noahk;

CREATE TABLE CrossCountry.RaceParticipant
(
	RaceParticipantId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	RaceId INT NOT NULL FOREIGN KEY
		REFERENCES CrossCountry.Race,
	RunnerId INT NOT NULL FOREIGN KEY
		REFERENCES CrossCountry.Runner,
	[Time] INT,
	AvgHeartRate INT,

	UNIQUE(RaceId, RunnerId)

);
