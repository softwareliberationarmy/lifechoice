# build the lifechoice solution one directory up

Write-Host "Creating build script for lifechoice solution"
dotnet restore ../lifechoice.sln
dotnet build ../lifechoice.sln -c Release --no-restore 
dotnet test ../lifechoice.sln -c Release --no-restore 
