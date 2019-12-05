BULK INSERT CrossCountry.User
FROM 'User.csv'
WITH (FORMAT='CSV');

BULK INSERT CrossCountry.Coach
FROM 'Coach.csv'
WITH (FORMAT='CSV');

BULK INSERT CrossCountry.Team
FROM 'Team.csv'
WITH (FORMAT='CSV');

BULK INSERT CrossCountry.Runner
FROM 'Runner.csv'
WITH (FORMAT='CSV');

BULK INSERT CrossCountry.TrainingRun
FROM 'TrainingRun.csv'
WITH (FORMAT='CSV');

BULK INSERT CrossCountry.Location
FROM 'Location.csv'
WITH (FORMAT='CSV');

BULK INSERT CrossCountry.Race
FROM 'Race.csv'
WITH (FORMAT='CSV');

BULK INSERT CrossCountry.RaceParticipant
FROM 'RaceParticipant.csv'
WITH (FORMAT='CSV');