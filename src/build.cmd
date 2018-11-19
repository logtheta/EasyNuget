
set currentDir=%~dp0
set in=%1
set out=%2
set pver=%3


dotnet build %in% -c Debug -o %out% /p:AssemblyVersion=%pver%
pause