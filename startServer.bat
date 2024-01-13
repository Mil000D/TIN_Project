@echo off

set SOLUTION_PATH=%~dp0\TIN_Project.sln

dotnet build %SOLUTION_PATH%

cd Server

dotnet run

pause