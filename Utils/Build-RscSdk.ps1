param(
    [bool]$NoClean = $false,
    [bool]$Release = $false,
    [bool]$NoDocs = $false,
    [bool]$NoTests = $false
)

# Change to the root of the repository
Set-Location $PSScriptRoot\.. 

if (-Not $NoClean) {
    .\Utils\Clean-RscSdk.ps1
}

$OutputDir = ".\Output"
$ProjectDir = ".\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell"
$ProjectOutputDir = "$ProjectDir\bin\Debug"

if ($Release) {
    $OutputDir = ".\Output.Release"
    $ProjectOutputDir = "$ProjectDir\bin\Release"
}

# Stop on error
$ErrorActionPreference = "Stop"

# Build the project
if ($Release) {
    dotnet build --configuration Release /p:GeneratePSDocs=true $ProjectDir
}
else {
    if ($NoDocs) {
        dotnet build $ProjectDir
    }
    else {
        dotnet build /p:GeneratePSDocs=true $ProjectDir
    }
}

# Copy the output to the output directory
Copy-Item -Recurse -Force $ProjectOutputDir $OutputDir
Copy-Item $OutputDir\net6.0\RubrikSecurityCloud.PowerShell.dll-Help.xml $OutputDir\net472\RubrikSecurityCloud.PowerShell.dll-Help.xml

if (-not $NoTests) {
    # Run the tests
    .\Utils\Test-RscSdk.ps1
}