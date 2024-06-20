@echo off

echo Killing AndroidSideloader processes...
taskkill /F /FI "IMAGENAME eq AndroidSideloader*" /T

echo Killing adb.exe processes...
taskkill /F /FI "IMAGENAME eq adb.exe" /T


set "folderPath=C:\Users\%username%\AppData\Local\Rookie.WTF\"
echo Deleting contents of %folderPath%...
for /D %%i in ("%folderPath%\*") do (
    rd /s /q "%%i"
)
del /q "%folderPath%\*.*"


set "folderPath=C:\Users\%username%\AppData\Local\Rookie.AndroidSideloader\"
echo Deleting contents of %folderPath%...
for /D %%i in ("%folderPath%\*") do (
    rd /s /q "%%i"
)
del /q "%folderPath%\*.*"

echo Cleanup complete.
pause
