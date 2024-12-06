@echo off
REM Default to Release if no argument is provided
SET CONFIG=Release
IF NOT "%1"=="" (
    IF /I "%1"=="debug" SET CONFIG=Debug
)

REM Windows Batch script version
REM Attempts to find MSBuild from common Visual Studio 2022 installation paths
IF EXIST "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
    SET MSBUILD="C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
) ELSE IF EXIST "C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" (
    SET MSBUILD="C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe"
) ELSE IF EXIST "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe" (
    SET MSBUILD="C:\Program Files\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe"
) ELSE (
    echo MSBuild not found! Please check your Visual Studio installation.
    exit /b 1
)

echo Building in %CONFIG% configuration...
%MSBUILD% AndroidSideloader.sln /t:AndroidSideloader /p:Configuration=%CONFIG%