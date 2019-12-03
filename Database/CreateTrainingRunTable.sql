CREATE TABLE CrossCountry.TrainingRun
(
	TrainingRunId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	RunnerId INT NOT NULL FOREIGN KEY
		REFERENCES CrossCountry.Runner,
	[Date] DATE NOT NULL,
	Distance INT NOT NULL,
	[Time] INT NOT NULL,
	AvgHeartRate INT,
	ChangeInElevation INT,
	IsArchived INT
);
