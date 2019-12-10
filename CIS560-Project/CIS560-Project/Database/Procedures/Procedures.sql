-- Gets all of a race participant's info based on a certain RaceParticipan ID
CREATE OR ALTER PROCEDURE CrossCountry.GetRaceParticipant
	@RaceParticipantId	INT
AS

SELECT *
FROM CrossCountry.RaceParticipant RP
WHERE RP.RaceParticipantId = @RaceParticipantId;

GO


-- Gets all runners (race participants) in a given race based on RaceId (includes runner name)
CREATE OR ALTER PROCEDURE CrossCountry.FetchRacersForRace
	@RaceId INT
AS

SELECT RP.RaceParticipantId, CONCAT(U.FirstName, U.LastName) AS [Name], RP.[Time], RP.AvgHeartRate
FROM CrossCountry.Race R
	INNER JOIN CrossCountry.RaceParticipant RP ON R.RaceId = RP.RaceId
	INNER JOIN CrossCountry.Runner Rn ON RP.RunnerId = Rn.RunnerId
	INNER JOIN CrossCountry.[User] U ON U.UserId = Rn.RunnerId
WHERE R.RaceId = @RaceId;
GO


-- Gets all runners (race participants) in a given race, only runner info
CREATE OR ALTER PROCEDURE CrossCountry.FetchRunnersForRace
	@RaceId INT
AS

SELECT RP.RaceParticipantId, Rn.RunnerId, RP.[Time], RP.AvgHeartRate
FROM CrossCountry.Race R
	INNER JOIN CrossCountry.RaceParticipant RP ON R.RaceId = RP.RaceId
	INNER JOIN CrossCountry.Runner Rn ON RP.RunnerId = Rn.RunnerId
WHERE R.RaceId = @RaceId;
GO


-- Gets all races a runner will participate in
CREATE OR ALTER PROCEDURE CrossCountry.FetchRacesForRunner
	@RunnerId INT
AS

SELECT L.Name, R.DateTime, R.Distance, RP.Time, RP.AvgHeartRate
FROM CrossCountry.RaceParticipant RP
     INNER JOIN CrossCountry.Race R ON RP.RaceId = R.RaceId
	 INNER JOIN CrossCountry.Location L ON L.LocationId = R.LocationId
WHERE RP.RunnerId = @RunnerId

GO


-- Gets all races a team has participated in
CREATE OR ALTER PROCEDURE CrossCountry.FetchRacesForTeam
	@TeamId INT
AS

SELECT Rc.RaceId, Rc.CreatorId, Rc.[DateTime], Rc.Distance, Rc.IsArchived, Rc.ChangeInElevation
FROM CrossCountry.Race Rc
	INNER JOIN CrossCountry.RaceParticipant RP ON Rc.RaceId = RP.RaceId
	INNER JOIN CrossCountry.Runner Rn ON RP.RunnerId = Rn.RunnerId
WHERE Rn.TeamId = @TeamId AND RP.[Time] IS NOT NULL AND Rc.IsArchived IS NULL;

GO


-- Gets a specific coach based on coach id
CREATE OR ALTER PROCEDURE CrossCountry.GetCoach
	@CoachId INT
AS

SELECT	*
FROM CrossCountry.Coach C
WHERE C.CoachId = @CoachId;

GO


-- Gets a specific location based on location id
CREATE OR ALTER PROCEDURE CrossCountry.GetLocation
	@LocationId INT
AS

SELECT L.LocationId, L.[Name], L.City, L.StateProvince
FROM CrossCountry.[Location] L
WHERE L.LocationId = @LocationId;

GO


-- Gets a location id based on a location's name
CREATE OR ALTER PROCEDURE CrossCountry.GetLocationIdFromName
	@Name NVARCHAR(100)
AS

SELECT L.LocationId
FROM CrossCountry.[Location] L
WHERE L.[Name] = @Name;

GO


-- Updates a race participants time for a race given the participant id and new time
CREATE OR ALTER PROCEDURE CrossCountry.UpdateRaceParticipantTime
	@RaceParticipantId INT,
	@Time INT
AS

UPDATE CrossCountry.RaceParticipant
SET [Time] = @Time
WHERE RaceParticipantId = @RaceParticipantId;

GO


-- Inserts a race participant into the race participant table
CREATE OR ALTER PROCEDURE CrossCountry.CreateRaceParticipant
	@RaceId INT,
	@RunnerId INT,
	@Time INT,
	@AverageHeartRate INT
AS

INSERT CrossCountry.RaceParticipant(RaceId, RunnerId, [Time], AvgHeartRate)
VALUES (@RaceId, @RunnerId, @Time, @AverageHeartRate);

GO


-- Gets all non-archived races, their locations, and who created them from the race list
CREATE OR ALTER PROCEDURE CrossCountry.RetrieveRaces
AS

SELECT R.RaceId, CONCAT(U.FirstName, U.LastName) AS CreatorName, L.[Name] AS LocationName, R.[DateTime], R.Distance
FROM CrossCountry.Race R
  INNER JOIN CrossCountry.[User] U ON R.CreatorId = U.UserId
  INNER JOIN CrossCountry.[Location] L ON L.LocationId = R.LocationId
WHERE IsArchived = 0;

GO


-- Gets a specific race (and all its info) based on a race id
CREATE OR ALTER PROCEDURE CrossCountry.GetRace
	@RaceId INT
AS

SELECT *
FROM CrossCountry.Race R
WHERE R.RaceId = @RaceId;

GO


-- Inserts a race into the race table
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


-- Archives a race, effectively deleting it from all future information pulls
CREATE OR ALTER PROCEDURE CrossCountry.ArchiveRace
	@RaceId INT
AS

UPDATE CrossCountry.Race
SET IsArchived = 1
WHERE RaceId = @RaceId;

GO


-- Gets all active runners from the runner table
CREATE OR ALTER PROCEDURE CrossCountry.RetrieveRunners
AS

SELECT Rn.RunnerId, Rn.TeamId, Rn.StartYear, Rn.EndYear
FROM CrossCountry.Runner Rn
WHERE Rn.EndYear IS NULL;

GO

-- Gets all runners and their associated team name
CREATE OR ALTER PROCEDURE CrossCountry.RetrieveRunnerNamesAndTeams
AS

SELECT CONCAT(U.FirstName, U.LastName) AS RunnerName, T.[Name] AS TeamName, Rn.StartYear, Rn.EndYear
FROM CrossCountry.Runner Rn
  INNER JOIN CrossCountry.[User] U ON U.UserId = Rn.RunnerId
  INNER JOIN CrossCountry.Team T ON T.TeamId = Rn.TeamId
WHERE Rn.EndYear IS NULL;
GO


-- Gets a specific runner based on runner id
CREATE OR ALTER PROCEDURE CrossCountry.GetRunner
	@RunnerId INT
AS

SELECT *
FROM CrossCountry.Runner R
WHERE R.RunnerId = @RunnerId;

GO


-- Gets all active runners on a specific team based on team id
CREATE OR ALTER PROCEDURE CrossCountry.GetTeamRunners
	@TeamId INT
AS

SELECT Rn.RunnerId, Rn.TeamId, Rn.StartYear, Rn.EndYear
FROM CrossCountry.Team T
	INNER JOIN CrossCountry.Runner Rn ON T.TeamId = Rn.TeamId
WHERE T.TeamId = @TeamId AND Rn.EndYear IS NULL;

GO

-- Gets a Runners with no TeamId
CREATE OR ALTER PROCEDURE CrossCountry.GetRunnersNoTeam
AS

SELECT *
FROM CrossCountry.Runner Rn
WHERE Rn.TeamId IS NULL;

GO


-- Gets a specific team based on team id
CREATE OR ALTER PROCEDURE CrossCountry.GetTeam
	@TeamId INT
AS

SELECT *
FROM CrossCountry.Team T
WHERE T.TeamId = @TeamId;

GO


-- Gets a team based on team name
CREATE OR ALTER PROCEDURE CrossCountry.FetchTeam
	@Name VARCHAR(50)
AS

SELECT *
FROM CrossCountry.Team T
WHERE T.Name = @Name;

GO


-- Gets all active teams that the coach is in charge of based on coach id
CREATE OR ALTER PROCEDURE CrossCountry.FetchCoachTeams
	@CoachId INT
AS

SELECT *
FROM CrossCountry.Team T
WHERE T.CoachId = @CoachId AND T.EndYear IS NULL;

GO


-- gets all the teams for a specific race based on race id
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


-- Inserts a team into the team table
CREATE OR ALTER PROCEDURE CrossCountry.CreateTeam
	@Name NVARCHAR(64),
	@CoachId INT
AS

INSERT CrossCountry.Team([Name], CoachId)
VALUES (@Name, @CoachId);

GO


-- Updates a specific runner's team
CREATE OR ALTER PROCEDURE CrossCountry.UpdateRunnersTeam
	@RunnerId INT,
	@TeamId INT
AS

UPDATE CrossCountry.Runner
SET TeamId = @TeamId
WHERE RunnerId = @RunnerId

UPDATE CrossCountry.[User]
SET UpdatedOn = SYSDATETIMEOFFSET()
WHERE UserId = @RunnerId

GO


-- Gets a specific training run
CREATE OR ALTER PROCEDURE CrossCountry.GetTrainingRun
	@TrainingRunId INT
AS

SELECT *
FROM CrossCountry.TrainingRun T
WHERE T.TrainingRunId = @TrainingRunId;

GO


-- Gets all un-archived training runs for a given runner
CREATE OR ALTER PROCEDURE CrossCountry.FetchTrainingRuns
	@RunnerId INT
AS

SELECT *
FROM CrossCountry.TrainingRun T
WHERE T.RunnerId = @RunnerId AND IsArchived = 0;

GO


-- Inserts a new training run
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


-- Gets a specific user based on email
CREATE OR ALTER PROCEDURE CrossCountry.GetUser
	@Email NVARCHAR(64)
AS

SELECT *
FROM CrossCountry.[User] U
WHERE U.Email = @Email;

GO


-- Validates a user's login based on email and password
CREATE OR ALTER PROCEDURE CrossCountry.ValidateUser
	@Email NVARCHAR(64),
	@Password NVARCHAR(128)
AS

SELECT *
FROM CrossCountry.[User] U
WHERE U.Email = @Email AND U.PassHash = @Password;

GO


-- Gets all runners that a coach is in charge of
CREATE OR ALTER PROCEDURE CrossCountry.GetCoachsRunners
	@CoachId INT
AS

SELECT R.RunnerId, R.TeamId, R.StartYear, R.EndYear
FROM CrossCountry.Team T
	INNER JOIN CrossCountry.Runner R ON T.TeamId = R.TeamId
WHERE T.CoachId = @CoachId AND R.EndYear IS NULL;

GO


-- Gets all runners without a team
CREATE OR ALTER PROCEDURE CrossCountry.GetRunnersNoTeam
AS

SELECT *
FROM CrossCountry.Runner R
WHERE R.TeamId IS NULL AND R.EndYear IS NULL;

GO


-- Retires a team, archives the team
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

		       
-- Retires a user (coach or runner), archiving them
CREATE OR ALTER PROCEDURE CrossCountry.RetireUser
	@UserId INT
AS

UPDATE CrossCountry.Coach
SET EndYear = YEAR(SYSDATETIMEOFFSET())
WHERE CoachId = @UserId;

UPDATE CrossCountry.Runner
SET EndYear = YEAR(SYSDATETIMEOFFSET())
WHERE RunnerId = @UserId;
		   
UPDATE CrossCountry.[User]
SET UpdatedOn = SYSDATETIMEOFFSET()
WHERE UserId = @UserId		 

GO


-- Gets all locations in the location table
CREATE OR ALTER PROCEDURE CrossCountry.FetchLocations
AS

SELECT *
FROM CrossCountry.[Location] L;

GO


-- Gets all scheduled race times for a given location
CREATE OR ALTER PROCEDURE CrossCountry.GetDatesForLocation
	@LocationId INT
AS

SELECT R.[DateTime]
FROM CrossCountry.Race R
WHERE R.[DateTime] > SYSDATETIMEOFFSET() AND R.LocationId = @LocationId;

GO




-- Summarizes the race with # of racers, average pace of all runners in distance/min, and gets the winning time
CREATE OR ALTER PROCEDURE CrossCountry.RaceSummary
	@RaceId INT
AS

SELECT
	COUNT(*) AS NumberOfRacers,
	AVG(ALL (RP.[Time]/R.Distance)) AS AveragePace
	(
		SELECT TOP(1) RP.[Time]
		FROM CrossCountry.RaceParticipant RP
		WHERE RP.RaceId = @RaceId
	) AS WinningTime
FROM CrossCountry.RaceParticipant RP
	INNER JOIN CrossCountry.Race R ON RP.RaceId = R.RaceId
WHERE RP.RaceId = @RaceId;

GO


-- Determines the placement of teams for a given race based on the average of runners times, lowest being first place
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

SELECT CT.[Name], T.AverageTime,
RANK() OVER(ORDER BY T.AverageTime DESC) AS TeamPlacing
FROM TeamAverageCte T INNER JOIN CrossCountry.Team CT ON T.TeamId = CT.TeamId
ORDER BY TeamPlacing DESC;

GO


-- Summarizes a runners training run data with their average distance, average pace (distance/min), and average time per run
CREATE OR ALTER PROCEDURE CrossCountry.GetRunnerSummary
	@RunnerId INT
AS

SELECT AVG(ALL TR.Distance) AS AverageDistance, 
	AVG(ALL TR.[Time]) AS AverageTime, 
FROM CrossCountry.TrainingRun TR
WHERE TR.RunnerId = @RunnerId AND TR.IsArchived IS NULL;

GO


-- Gets a runners lifetime records in official races
CREATE OR ALTER PROCEDURE CrossCountry.GetRunnersRecord
	@RunnerId INT
AS

SELECT CONCAT(U.FirstName, U.LastName) AS [Name],
	RP.[Time],
	Rc.Distance,
	Rc.[DateTime] AS [Date],
	L.[Name] AS LocationName 
FROM CrossCountry.Runner R
	INNER JOIN CrossCountry.[User] U ON U.UserId = R.RunnerId
	INNER JOIN CrossCountry.RaceParticipant RP ON R.RunnerId = RP.RunnerId
	INNER JOIN CrossCountry.Race Rc ON RP.RaceId = Rc.RaceId
	INNER JOIN CrossCountry.[Location] L ON L.LocationId = Rc.LocationId
WHERE RP.RaceParticipantId IN (
	SELECT TOP(1) RP.RaceParticipantId
	FROM CrossCountry.RaceParticipant RP
	INNER JOIN CrossCountry.Race Rc ON Rc.RaceId = RP.RaceId
	WHERE RP.RunnerId = @RunnerId AND Rc.IsArchived = 0 AND RP.[Time] IS NOT NULL
	ORDER BY RP.[Time] ASC
);
GO
