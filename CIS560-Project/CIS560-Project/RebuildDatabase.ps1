Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "mcsmih"
)

Import-Module Sqlps -DisableNameChecking;

Write-Host "Rebuilding Database"

Write-Host "Dropping Tables"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\DropTables.sql"
Write-Host "Creating schema"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CrossCountry.sql"
Write-Host "Creating Tables"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CreateUserTable.sql"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CreateLocationTable.sql"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CreateCoachTable.sql"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CreateTeamTable.sql"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CreateRunnerTable.sql"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CreateTrainingRunTable.sql"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CreateRaceTable.sql"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "Database\Tables\CreateRaceParticipantTable.sql"
Write-Host "Stored Procedures"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile ""

Write-Host "Inserting Data"
Invoke-Sqlcmd -ServerInstance $Server -Database $Database -InputFile "DATA\InsertData.sql"

Write-Host "Rebuild Complete."