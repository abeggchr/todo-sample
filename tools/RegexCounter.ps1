param(
  [string]$path,
  [string]$regex,
  [string]$name
)

$counter = 0

Get-ChildItem $path -Recurse -Filter "*.cs" | Get-Content | % { 
    $result = [regex]::Matches($_, $regex, "IgnoreCase") 
    $counter += $result.Count
}

Write-Host "##teamcity[buildStatisticValue key='$name' value='$counter']"
