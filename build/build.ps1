
# set the current directory to the directory of the script
$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Definition
Set-Location $scriptPath

function Write-Status($message) {
    Write-Host $message -ForegroundColor Green
}

Write-Status "BUILDING the LifeChoice solution" -ForegroundColor Green

Write-Status "RESTORING SOLUTION PACKAGES..." 
dotnet restore ../lifechoice.sln
Write-Status "BUILDING SOLUTION..."
dotnet build ../lifechoice.sln -c Release --no-restore 
Write-Status "RUNNING .NET TESTS..."
dotnet test ../lifechoice.sln -c Release --no-restore

Write-Status "RUNNING WEB TESTS..." 
cd ..\client-app
npm install
npm run build
npm test run -- --coverage

Set-Location $scriptPath
