BULK INSERT CrossCountry.[User]
FROM 'User.csv'
WITH (
  FIRSTROW=2,
  FIELDTERMINATOR=',',
  ROWTERMINATOR='\n');
GO

BULK INSERT CrossCountry.Coach
FROM 'Coach.csv'
WITH (
  FIRSTROW=2,
  FIELDTERMINATOR=',',
  ROWTERMINATOR='\n');
GO

BULK INSERT CrossCountry.Team
FROM 'Team.csv'
WITH (
  FIRSTROW=2,
  FIELDTERMINATOR=',',
  ROWTERMINATOR='\n');
GO

BULK INSERT CrossCountry.Runner
FROM 'Runner.csv'
WITH (
  FIRSTROW=2,
  FIELDTERMINATOR=',',
  ROWTERMINATOR='\n');
GO

BULK INSERT CrossCountry.TrainingRun
FROM 'TrainingRun.csv'
WITH (
  FIRSTROW=2,
  FIELDTERMINATOR=',',
  ROWTERMINATOR='\n');
GO

BULK INSERT CrossCountry.[Location]
FROM 'Location.csv'
WITH (
  FIRSTROW=2,
  FIELDTERMINATOR=',',
  ROWTERMINATOR='\n');
GO

BULK INSERT CrossCountry.Race
FROM 'Race.csv'
WITH (
  FIRSTROW=2,
  FIELDTERMINATOR=',',
  ROWTERMINATOR='\n');
GO

BULK INSERT CrossCountry.RaceParticipant
FROM 'RaceParticipant.csv'
WITH (
  FIRSTROW=2,
  FIELDTERMINATOR=',',
  ROWTERMINATOR='\n');
