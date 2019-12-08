CREATE OR ALTER PROCEDURE CrossCountry.GetRaceParticipant
	@RaceParticipantId	INT
AS

SELECT *
FROM CrossCountry.RaceParticipant RP
WHERE RP.RaceParticipantId = @RaceParticipantId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.FetchRunnersForRace
	@RaceId INT
AS

SELECT Rn.RunnerId, Rn.TeamId, Rn.StartYear, Rn.EndYear
FROM CrossCountry.Race R
	INNER JOIN CrossCountry.RaceParticipant RP ON R.RaceId = RP.RaceId
	INNER JOIN CrossCountry.Runner Rn ON RP.RunnerId = Rn.RunnerId
WHERE R.RaceId = @RaceId;
GO


CREATE OR ALTER PROCEDURE CrossCountry.FetchRacesForRunner
	@RunnerId INT
AS

SELECT L.Name, R.DateTime, R.Distance, RP.Time, RP.AvgHeartRate
FROM CrossCountry.RaceParticipant RP
     INNER JOIN CrossCountry.Race R ON RP.RaceId = R.RaceId
	 INNER JOIN CrossCountry.Location L ON L.LocationId = R.LocationId
WHERE RP.RunnerId = @RunnerId

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetCoach
	@CoachId INT
AS

SELECT	*
FROM CrossCountry.Coach C
WHERE C.CoachId = @CoachId;

GO

CREATE OR ALTER PROCEDURE CrossCountry.FetchLocations
AS

SELECT L.LocationId, L.[Name], L.City, L.StateProvince
FROM CrossCountry.[Location] L

GO

CREATE OR ALTER PROCEDURE CrossCountry.GetLocation
	@LocationId INT
AS

SELECT L.LocationId, L.[Name], L.City, L.StateProvince
FROM CrossCountry.[Location] L
WHERE L.LocationId = @LocationId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.UpdateRaceParticipantTime
	@RaceParticipantId INT,
	@Time INT
AS

UPDATE CrossCountry.RaceParticipant
SET [Time] = @Time
WHERE RaceParticipantId = @RaceParticipantId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.CreateRaceParticipant
	@RaceId INT,
	@RunnerId INT,
	@Time INT,
	@AverageHeartRate INT
AS

INSERT CrossCountry.RaceParticipant(RaceId, RunnerId, [Time], AvgHeartRate)
VALUES (@RaceId, @RunnerId, @Time, @AverageHeartRate);

GO


CREATE OR ALTER PROCEDURE CrossCountry.RetrieveRaces
AS

SELECT *
FROM CrossCountry.Race
WHERE IsArchived = 0;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetRace
	@RaceId INT
AS

SELECT *
FROM CrossCountry.Race R
WHERE R.RaceId = @RaceId AND R.IsArchived = 0;

GO


CREATE OR ALTER PROCEDURE CrossCountry.CreateRace
	@CreatorId INT, 
	@LocationId INT, 
	@DateTime DATETIME2, 
	@Distance INT, 
	@IsArchived INT
AS

INSERT CrossCountry.Race(CreatorId, LocationId, [DateTime], Distance, IsArchived)
VALUES (@CreatorId, @LocationId, @DateTime, @Distance, @IsArchived);

GO


CREATE OR ALTER PROCEDURE CrossCountry.ArchiveRace
	@RaceId INT
AS

UPDATE CrossCountry.Race
SET IsArchived = 1
WHERE RaceId = @RaceId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.RetrieveRunners
AS

SELECT Rn.RunnerId, Rn.TeamId, Rn.StartYear, Rn.EndYear
FROM CrossCountry.Runner Rn
WHERE Rn.EndYear IS NULL;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetRunner
	@RunnerId INT
AS

SELECT *
FROM CrossCountry.Runner R
WHERE R.RunnerId = @RunnerId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetTeamRunners
	@TeamId INT
AS

SELECT Rn.RunnerId, Rn.TeamId, Rn.StartYear, Rn.EndYear
FROM CrossCountry.Team T
	INNER JOIN CrossCountry.Runner Rn ON T.TeamId = Rn.TeamId
WHERE T.TeamId = @TeamId AND Rn.EndYear IS NULL;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetRunnersNoTeam
AS

SELECT *
FROM CrossCountry.Runner Rn
WHERE Rn.TeamId = 1;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetTeam
	@TeamId INT
AS

SELECT *
FROM CrossCountry.Team T
WHERE T.TeamId = @TeamId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.FetchCoachTeams
	@CoachId INT
AS

SELECT *
FROM CrossCountry.Team T
WHERE T.CoachId = @CoachId AND T.EndYear IS NULL;

GO


-- CHECK THIS ONE
CREATE OR ALTER PROCEDURE CrossCountry.GetTeamsForRace
	@RaceId INT
AS

SELECT FIRST_VALUE(Rn.TeamId) OVER(
		PARTITION BY Rn.TeamId
		ORDER BY Rn.TeamId ASC) AS TeamId
FROM CrossCountry.Race R
	INNER JOIN CrossCountry.RaceParticipant RP ON R.RaceId = RP.RaceId
	INNER JOIN CrossCountry.Runner Rn ON RP.RunnerId = Rn.RunnerId
WHERE R.RaceId = @RaceId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.CreateTeam
	@Name NVARCHAR(64),
	@CoachId INT,
	@CreatedOn DATETIMEOFFSET,
	@UpdatedOn DATETIMEOFFSET,
	@StartYear INT,
	@EndYear INT
AS

INSERT CrossCountry.Team([Name], CoachId, CreatedOn, UpdatedOn, StartYear, EndYear)
VALUES (@Name, @CoachId, @CreatedOn, @UpdatedOn, @StartYear, @EndYear);

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetTrainingRun
	@TrainingRunId INT
AS

SELECT *
FROM CrossCountry.TrainingRun T
WHERE T.TrainingRunId = @TrainingRunId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.FetchTrainingRuns
	@RunnerId INT
AS

SELECT *
FROM CrossCountry.TrainingRun T
WHERE T.RunnerId = @RunnerId AND IsArchived = 0;

GO


CREATE OR ALTER PROCEDURE CrossCountry.CreateTrainingRun
	@RunnerId INT,
	@Date DATE,
	@Distance INT,
	@Time INT,
	@AverageHeartRate INT,
	@IsArchived INT
AS

INSERT CrossCountry.TrainingRun(RunnerId, [Date], Distance, [Time], AvgHeartRate, IsArchived)
VALUES (@RunnerId, @Date, @Distance, @Time, @AverageHeartRate, @IsArchived);

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetUser
	@Email NVARCHAR(64)
AS

SELECT *
FROM CrossCountry.[User] U
WHERE U.Email = @Email;

GO


CREATE OR ALTER PROCEDURE CrossCountry.ValidateUser
	@Email NVARCHAR(64),
	@Password NVARCHAR(128)
AS

SELECT *
FROM CrossCountry.[User] U
WHERE U.Email = @Email AND U.PassHash = @Password;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetCoachsRunners
	@CoachId INT
AS

SELECT R.RunnerId, R.TeamId, R.StartYear, R.EndYear
FROM CrossCountry.Team T
	INNER JOIN CrossCountry.Runner R ON T.TeamId = R.TeamId
WHERE T.CoachId = @CoachId AND R.EndYear IS NULL;

GO






CREATE OR ALTER PROCEDURE CrossCountry.RaceSummary
	@RaceId INT
AS

SELECT 
	COUNT(*) AS NumberOfRacers,
	AVG(ALL RP.[Time]) AS AveragePace,
	FIRST_VALUE(RP.[Time]) OVER(
		ORDER BY RP.[Time] DESC) AS WinningTime
FROM CrossCountry.RaceParticipant RP
WHERE RP.RaceId = @RaceId
GROUP BY RP.RaceParticipantId, RP.[Time];

GO


CREATE OR ALTER PROCEDURE CrossCountry.TeamPlaceingForRace
	@RaceId INT
AS

WITH TeamAverageCte(TeamId, AverageTime) AS
	(
		SELECT R.TeamId, AVG(ALL RP.[Time])
		FROM CrossCountry.Runner R
			INNER JOIN CrossCountry.RaceParticipant RP ON R.RunnerId = RP.RunnerId
		WHERE RP.RaceId = @RaceId
		GROUP BY R.TeamId
	)

SELECT RANK() OVER(
	ORDER BY T.AverageTime DESC) AS TeamPlacing
FROM TeamAverageCte T;

GO


CREATE OR ALTER PROCEDURE CrossCountry.RunnerSummary
	@RunnerId INT
AS

SELECT AVG(ALL TR.Distance) AS AverageDistance, 
	AVG(ALL TR.[Time]) AS AverageTime, 
	AVG(ALL (TR.Distance/TR.[Time])) AS AveragePace
FROM CrossCountry.TrainingRun TR
WHERE TR.RunnerId = @RunnerId;