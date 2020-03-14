Write-Host "Exception expected in both cases but none occurs indicating that the finalizer is not automatically called when the program exits.:"

Write-Host "`tExecuting dotnet run -property:TargetFramework=net46..." 
dotnet run -property:TargetFramework=net46

Write-Host "`tExecuting dotnet run -property:TargetFramework=netcoreapp3.1..." 
dotnet run -property:TargetFramework=netcoreapp3.1