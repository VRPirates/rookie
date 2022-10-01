


@echo off

for /f "tokens=* usebackq" %%f in (`dir /b AndroidSideloader*.exe`) do (set "sideloader=%%f" & goto :next)
:next

echo %sideloader%
start "" "%sideloader%" "--offline"