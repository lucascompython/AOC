$newYear = Read-Host "Do you want to add a new year [y|n]: "
if (@("y", "yes") -contains $newYear.ToLower()) {
    $yearToAdd = Read-Host "Enter the year to add: "
    mkdir ../$yearToAdd
    mkdir ../$yearToAdd/Solutions
    mkdir ../$yearToAdd/Inputs
}

$lang = Read-Host "Enter the language (c#, f#, pwsh): "
$year = Read-Host "Enter the year: "
$day = Read-Host "Enter the day (01-25): "

function Add-files{
    param ([string]$ext, [string]$day, [string]$year)
    New-Item -Path "../$year/Solutions/day$day$ext"
    New-Item -Path "../$year/Inputs/$year_$day.txt"
}

if (@("c#", "csx", "cs", "csharp") -contains $lang) {
    $ext = ".csx"
    Add-files $ext $day $year
} 
elseif (@("f#", "fsx", "fs", "fsharp") -contains $lang) {
    $ext = ".fsx"
    Add-files $ext $day $year
} 
elseif (@("pwsh", "ps1", "psm1") -contains $lang) {
    $ext = ".ps1"
    Add-files $ext $day $year
} 
else {
    Write-Host "Invalid language"
    exit 1
}