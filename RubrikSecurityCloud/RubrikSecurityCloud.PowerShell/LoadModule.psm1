#
# Load Core DLL:
#
# Record the user's current working directory so that we can return to it when we 
# are done loading the module
$currentPath = Get-Location

try {
    # Determine the module directory based on the PowerShell edition
    If ($PSVersionTable.PSEdition -eq "Desktop") {
       # Write-Host "`nLoading Rubrik Security Cloud PowerShell Module (WindowsPowerShell)...`n"
        $moduleDir = Join-Path -Path $PSScriptRoot -ChildPath "net481"

        # Load the specific versions of required assemblies
        $unsafeAssemblyPath = Join-Path -Path $moduleDir -ChildPath 'System.Runtime.CompilerServices.Unsafe.dll'
        $vectorsAssemblyPath = Join-Path -Path $moduleDir -ChildPath 'System.Numerics.Vectors.dll'
        $buffersAssemblyPath = Join-Path -Path $moduleDir -ChildPath 'System.Buffers.dll'
        $annotationsAssemblyPath = Join-Path -Path $moduleDir -ChildPath 'System.ComponentModel.Annotations.dll'
        $textJsonAssemblyPath = Join-Path -Path $moduleDir -ChildPath 'System.Text.Json.dll'
        
        # Force loading the correct assembly versions
        # [System.Reflection.Assembly]::LoadFrom($unsafeAssemblyPath)

        # Add the AssemblyResolve event handler to persist throughout the session
        $onAssemblyResolve = [System.ResolveEventHandler] {
            param($sender, $e)
            if ($e.Name -like 'System.Runtime.CompilerServices.Unsafe, *') {
                # Write-Host "LoadModule.psm1: Redirecting $e.Name to version 6.0.0.0 via AssemblyResolve event handler"
                return [System.Reflection.Assembly]::LoadFrom($unsafeAssemblyPath)
            }
            elseif ($e.Name -like 'System.Numerics.Vectors, *') {
                # Write-Host "LoadModule.psm1: Redirecting $e.Name to the correct System.Numerics.Vectors assembly"
                return [System.Reflection.Assembly]::LoadFrom($vectorsAssemblyPath)
            }
            elseif ($e.Name -like 'System.Buffers, *') {
                # Write-Host "LoadModule.psm1: Redirecting $e.Name to the correct System.Buffers assembly"
                return [System.Reflection.Assembly]::LoadFrom($buffersAssemblyPath)
            }
            elseif ($e.Name -like 'System.ComponentModel.Annotations, *') {
                # Write-Host "LoadModule.psm1: Redirecting $e.Name to the correct System.ComponentModel.Annotations assembly"
                return [System.Reflection.Assembly]::LoadFrom($annotationsAssemblyPath)
            }
            elseif ($e.Name -like 'System.Text.Json, *') {
                # Write-Host "LoadModule.psm1: Redirecting $e.Name to the correct System.ComponentModel.Annotations assembly"
                return [System.Reflection.Assembly]::LoadFrom($textJsonAssemblyPath)
            }
        }

        # Register the event handler
        [System.AppDomain]::CurrentDomain.add_AssemblyResolve($onAssemblyResolve)
    }
    else {
      # Write-Host "`nLoading Rubrik Security Cloud PowerShell Module (PowerShell Core)...`n"
        $moduleDir = Join-Path -Path $PSScriptRoot -ChildPath "net6.0"
    }

    # Change to the directory containing the module
    Set-Location -Path $moduleDir
    $modulePath = Join-Path -Path $moduleDir -ChildPath "RubrikSecurityCloud.PowerShell.dll"
    
    # Write-Host "LoadModule.psm1: Import-Module $modulePath"
    Import-Module $modulePath -ErrorAction Stop

   # Write-Host "Welcome to the Rubrik Security Cloud PowerShell SDK!`n"
   # Write-Host "`tPlease refer to the Getting Started section of the Readme documentation: "
   # Write-Host "`thttps://github.com/rubrikinc/rubrik-powershell-sdk#getting-started`n"
}
catch {
    Write-Error "Unable to load Rubrik Security Cloud Module: $_"
}
finally {
    # Ensure the working directory has been set back to the original when the script exits
    Set-Location $currentPath
}
