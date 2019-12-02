CREATE TABLE CrossCountry.Coach
(
	CoachId INT NOT NULL PRIMARY KEY FOREIGN KEY
		REFERENCES CrossCountry.[User],
	StartYear INT NOT NULL,
	EndYear INT
);