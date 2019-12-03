$csv1 = "C:\Users\User\Homework\CIS560\CIS560-Project\DATA\TrainingRun.csv"
$csv2 = "C:\Users\User\Homework\CIS560\CIS560-Project\DATA\RaceParticipant.csv"

Import-Csv $csv1 |`
ForEach-Object{
    
    $_.Time=[string](Get-Random -Minimum 1560 -Maximum 3360)
    Write-Host $_.Time
}|Export-Csv -Path C:\Users\User\Homework\CIS560\TrainingRun.csv -NoTypeInformation

Import-Csv -Path $csv2 |`
ForEach-Object{
    $_.Time=[string](Get-Random -Minimum 1560 -Maximum 3360)
}|Export-Csv -Path  C:\Users\User\Homework\CIS560\RaceParticipant.csv -NoTypeInformation