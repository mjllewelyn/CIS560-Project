DECLARE @path VARCHAR(max)
SET @path = 'C:\Users\mbrin\source\repos\CIS560-Project\CIS560-Project\CIS560-Project\DATA\';

DECLARE @sql VARCHAR(max)
SET @sql = 'BULK INSERT CrossCountry.[User] FROM "' + @path + 'User.csv" WITH (FIRSTROW=2, FIELDTERMINATOR='','', ROWTERMINATOR=''\n'')'
EXEC(@sql)

SET @sql = 'BULK INSERT CrossCountry.[Coach] FROM "' + @path + 'Coach.csv" WITH (FIRSTROW=2, FIELDTERMINATOR='','', ROWTERMINATOR=''\n'')'
EXEC(@sql)

SET @sql = 'BULK INSERT CrossCountry.[Team] FROM "' + @path + 'Team.csv" WITH (FIRSTROW=2, FIELDTERMINATOR='','', ROWTERMINATOR=''\n'')'
EXEC(@sql)

SET @sql = 'BULK INSERT CrossCountry.[Runner] FROM "' + @path + 'Runner.csv" WITH (FIRSTROW=2, FIELDTERMINATOR='','', ROWTERMINATOR=''\n'')'
EXEC(@sql)

SET @sql = 'BULK INSERT CrossCountry.[TrainingRun] FROM "' + @path + 'TrainingRun.csv" WITH (FIRSTROW=2, FIELDTERMINATOR='','', ROWTERMINATOR=''\n'')'
EXEC(@sql)

SET @sql = 'BULK INSERT CrossCountry.[Location] FROM "' + @path + 'Location.csv" WITH (FIRSTROW=2, FIELDTERMINATOR='','', ROWTERMINATOR=''\n'')'
EXEC(@sql)

SET @sql = 'BULK INSERT CrossCountry.[Race] FROM "' + @path + 'Race.csv" WITH (FIRSTROW=2, FIELDTERMINATOR='','', ROWTERMINATOR=''\n'')'
EXEC(@sql)

SET @sql = 'BULK INSERT CrossCountry.[RaceParticipant] FROM "' + @path + 'RaceParticipant.csv" WITH (FIRSTROW=2, FIELDTERMINATOR='','', ROWTERMINATOR=''\n'')'
EXEC(@sql)
