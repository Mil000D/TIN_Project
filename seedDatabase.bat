@echo off

cd %~dp0\Server

dotnet ef database update

pause