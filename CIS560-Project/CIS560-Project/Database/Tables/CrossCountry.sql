IF NOT EXISTS(
	SELECT *
	FROM sys.schemas s
	WHERE s.[name]=N'CrossCountry'
)
BEGIN
	EXEC(N'CREATE SCHEMA [CrossCountry] AUTHORIZATION [dbo]');
END