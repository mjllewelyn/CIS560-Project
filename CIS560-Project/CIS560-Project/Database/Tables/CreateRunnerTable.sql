CREATE TABLE CrossCountry.Runner
(
	RunnerId INT NOT NULL PRIMARY KEY FOREIGN KEY
		REFERENCES CrossCountry.[User],
	TeamId INT FOREIGN KEY
		REFERENCES CrossCountry.Team,
	StartYear INT NOT NULL,
	EndYear INT
);
