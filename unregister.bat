@echo off

set a=%~dp0

cmd /v:on /c dotnet new uninstall !a:~0,-1!

pause