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

SELECT RP.RaceParticipantId, Rn.RunnerId, RP.[Time], RP.AvgHeartRate
FROM CrossCountry.Race R
	INNER JOIN CrossCountry.RaceParticipant RP ON R.RaceId = RP.RaceId
	INNER JOIN CrossCountry.Runner Rn ON RP.RunnerId = Rn.RunnerId
WHERE R.RaceId = @RaceId;
GO

-- Double check this
CREATE OR ALTER PROCEDURE CrossCountry.FetchRacesForRunner
	@RunnerId INT
AS

SELECT L.Name, R.DateTime, R.Distance, RP.Time, RP.AvgHeartRate
FROM CrossCountry.RaceParticipant RP
     INNER JOIN CrossCountry.Race R ON RP.RaceId = R.RaceId
	 INNER JOIN CrossCountry.Location L ON L.LocationId = R.LocationId
WHERE RP.RunnerId = @RunnerId

GO

-- Might need to change this one
CREATE OR ALTER PROCEDURE CrossCountry.FetchRacesForTeam
	@TeamId INT
AS

SELECT Rc.RaceId, Rc.CreatorId, Rc.[DateTime], Rc.Distance, Rc.IsArchived, Rc.ChangeInElevation
FROM CrossCountry.Race Rc
	INNER JOIN CrossCountry.RaceParticipant RP ON Rc.RaceId = RP.RaceId
	INNER JOIN CrossCountry.Runner Rn ON RP.RunnerId = Rn.RunnerId
WHERE Rn.TeamId = @TeamId AND RP.[Time] IS NOT NULL AND Rc.IsArchived IS NULL;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetCoach
	@CoachId INT
AS

SELECT	*
FROM CrossCountry.Coach C
WHERE C.CoachId = @CoachId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetLocation
	@LocationId INT
AS

SELECT L.LocationId, L.[Name], L.City, L.StateProvince
FROM CrossCountry.[Location] L
WHERE L.LocationId = @LocationId;

GO

CREATE OR ALTER PROCEDURE CrossCountry.GetLocationIdFromName
	@Name NVARCHAR(100)
AS

SELECT L.LocationId
FROM CrossCountry.[Location] L
WHERE L.[Name] = @Name;

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

SELECT R.RaceId, CONCAT(U.FirstName, U.LastName) AS CreatorName, L.[Name] AS LocationName, R.[DateTime], R.Distance
FROM CrossCountry.Race R
  INNER JOIN CrossCountry.[User] U ON R.CreatorId = U.UserId
  INNER JOIN CrossCountry.[Location] L ON L.LocationId = R.LocationId
WHERE IsArchived = 0;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetRace
	@RaceId INT
AS

SELECT *
FROM CrossCountry.Race R
WHERE R.RaceId = @RaceId;

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
WHERE Rn.TeamId IS NULL;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetTeam
	@TeamId INT
AS

SELECT *
FROM CrossCountry.Team T
WHERE T.TeamId = @TeamId;

GO

CREATE OR ALTER PROCEDURE CrossCountry.GetTeam
	@Name VARCHAR(50)
AS

SELECT *
FROM CrossCountry.Team T
WHERE T.Name = @Name;

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

SELECT Rn.TeamId
FROM CrossCountry.Race R
	INNER JOIN CrossCountry.RaceParticipant RP ON R.RaceId = RP.RaceId
	INNER JOIN CrossCountry.Runner Rn ON RP.RunnerId = Rn.RunnerId
WHERE R.RaceId = @RaceId
GROUP BY Rn.TeamId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.CreateTeam
	@Name NVARCHAR(64),
	@CoachId INT,
	@StartYear INT
AS

INSERT CrossCountry.Team([Name], CoachId, StartYear)
VALUES (@Name, @CoachId, @StartYear);

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


CREATE OR ALTER PROCEDURE CrossCountry.GetRunnersNoTeam
AS

SELECT *
FROM CrossCountry.Runner R
WHERE R.TeamId IS NULL AND R.EndYear IS NULL;

GO


CREATE OR ALTER PROCEDURE CrossCountry.RetireTeam
	@TeamId	INT
AS

UPDATE CrossCountry.Runner
SET EndYear = YEAR(SYSDATETIMEOFFSET()),
	TeamId = NULL
WHERE TeamId = @TeamId;

UPDATE CrossCountry.Team
SET 
	EndYear = YEAR(SYSDATETIMEOFFSET()),
	UpdatedOn = SYSDATETIMEOFFSET()
WHERE TeamId = @TeamId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.RetireUser
	@UserId INT
AS

UPDATE CrossCountry.Coach
SET EndYear = YEAR(SYSDATETIMEOFFSET())
WHERE CoachId = @UserId;

UPDATE CrossCountry.Runner
SET 
	EndYear = YEAR(SYSDATETIMEOFFSET()),
	TeamId = NULL
WHERE RunnerId = @UserId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.FetchLocations
AS

SELECT *
FROM CrossCountry.[Location] L;

GO


CREATE OR ALTER PROCEDURE CrossCountry.GetDatesForLocation
	@LocationId INT
AS

SELECT R.[DateTime]
FROM CrossCountry.Race R
WHERE R.[DateTime] > SYSDATETIMEOFFSET() AND R.LocationId = @LocationId;

GO




-- Check these queries
CREATE OR ALTER PROCEDURE CrossCountry.RaceSummary
	@RaceId INT
AS

SELECT
	COUNT(*) AS NumberOfRacers,
	AVG(ALL (R.Distance/RP.[Time])) AS AveragePace,
	(
		SELECT TOP(1) RP.[Time]
		FROM CrossCountry.RaceParticipant RP
		WHERE RP.RaceId = @RaceId
	) AS WinningTime
FROM CrossCountry.RaceParticipant RP
	INNER JOIN CrossCountry.Race R ON RP.RaceId = R.RaceId
WHERE RP.RaceId = @RaceId;

GO


CREATE OR ALTER PROCEDURE CrossCountry.TeamPlacingForRace
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

SELECT T.TeamId, RANK() OVER(
	ORDER BY T.AverageTime DESC) AS TeamPlacing
FROM TeamAverageCte T
ORDER BY TeamPlacing ASC;

GO


CREATE OR ALTER PROCEDURE CrossCountry.RunnerSummary
	@RunnerId INT
AS

SELECT ROUND(AVG(ALL TR.Distance * 1.0), 2) AS AverageDistance, 
	ROUND(AVG(ALL TR.[Time] * 1.0), 2) AS AverageTime, 
	ROUND(AVG(ALL (TR.Distance/(TR.[Time]/3600.0))), 2) AS AveragePace
FROM CrossCountry.TrainingRun TR
WHERE TR.RunnerId = @RunnerId AND TR.IsArchived = 0;

GO


CREATE OR ALTER PROCEDURE CrossCountry.FastestTimeForEachRunnerOnTeam
	@TeamId INT
AS

SELECT R.RunnerId,
	MIN(RP.[Time]) AS FastestTime
FROM CrossCountry.Runner R
	INNER JOIN CrossCountry.RaceParticipant RP ON R.RunnerId = RP.RunnerId
	INNER JOIN CrossCountry.Race Rc ON RP.RaceId = Rc.RaceId
WHERE R.TeamId = @TeamId AND Rc.IsArchived IS NULL AND RP.[Time] IS NOT NULL
GROUP BY R.RunnerId;

GO
