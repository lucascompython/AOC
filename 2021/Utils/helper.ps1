$lang = Read-Host "Enter the language (c#, f#, pwsh): "
$day = Read-Host "Enter the day (01-25): "

function Add-files{
    param ([string]$ext, [string]$day)
    New-Item -Path "../Solutions/day$day$ext"
    New-Item -Path "../Inputs/2021_$day.txt"
}

if (@("c#", "csx", "cs", "csharp") -contains $lang) {
    $ext = ".csx"
    Add-files $ext $day
} 
elseif (@("f#", "fsx", "fs", "fsharp") -contains $lang) {
    $ext = ".fsx"
    Add-files $ext $day
} 
elseif (@("pwsh", "ps1", "psm1") -contains $lang) {
    $ext = ".ps1"
    Add-files $ext $day
} 
else {
    Write-Host "Invalid language"
    exit 1
}