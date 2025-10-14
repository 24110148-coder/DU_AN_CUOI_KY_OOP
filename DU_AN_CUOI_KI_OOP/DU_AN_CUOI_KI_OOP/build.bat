@echo off
echo Building DU_AN_CUOI_KI_OOP project...

REM Try to find MSBuild
set MSBUILD_PATH=""
if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe" (
    set MSBUILD_PATH="C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\MSBuild.exe"
) else if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" (
    set MSBUILD_PATH="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe"
) else if exist "C:\Program Files (x86)\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" (
    set MSBUILD_PATH="C:\Program Files (x86)\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe"
) else if exist "C:\Program Files (x86)\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
    set MSBUILD_PATH="C:\Program Files (x86)\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
) else if exist "C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe" (
    set MSBUILD_PATH="C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe"
) else if exist "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
    set MSBUILD_PATH="C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
)

if %MSBUILD_PATH%=="" (
    echo MSBuild not found. Please install Visual Studio or build from Visual Studio IDE.
    pause
    exit /b 1
)

echo Using MSBuild at: %MSBUILD_PATH%
%MSBUILD_PATH% DU_AN_CUOI_KI_OOP.csproj /p:Configuration=Debug /p:Platform="Any CPU"

if %ERRORLEVEL% EQU 0 (
    echo Build successful!
) else (
    echo Build failed with error code %ERRORLEVEL%
)

pause
