# Extensions-DevTools.ps1

$global:ExtensionsInstallDir = [System.IO.Path]::GetDirectoryName((Get-Command Get-RscCluster).ScriptBlock.File)
$global:ExtensionsSourceDir = (Resolve-Path "$PSScriptRoot/../Extensions").Path

function Backup-File {
    param (
        [string]$FilePath,
        [int]$MaxBackups = 5
    )

    # Rename existing backups
    for ($i = $MaxBackups - 1; $i -ge 0; $i--) {
        $oldBackup = if ($i -eq 0) { "$FilePath.bak" } else { "$FilePath.$i.bak" }
        $newBackup = "$FilePath." + ($i + 1) + ".bak"

        if (Test-Path $oldBackup) {
            Rename-Item -Path $oldBackup -NewName $newBackup
        }
    }

    # Create a new backup
    Copy-Item -Path $FilePath -Destination "$FilePath.bak" -Force
}

function Update-RscExtension {
    param (
        [string]$ExtensionName
    )

    $sourcePath = "$global:ExtensionsSourceDir/$ExtensionName.psm1"
    $destinationFile = "$global:ExtensionsInstallDir/$ExtensionName.psm1"

    if (-Not (Test-Path -Path $sourcePath)) {
        Write-Error "Source extension $ExtensionName not found at $sourcePath."
        return
    }

    # Check if the source and destination files are identical
    $sourceContent = Get-Content $sourcePath
    $destinationContent = Get-Content $destinationFile -ErrorAction SilentlyContinue
    if ($null -ne $destinationContent -and ($null -eq $sourceContent -or -not (Compare-Object $sourceContent $destinationContent))) {
        Write-Host "No update done: installed file is identical to source file."
    }
    else {

        # Backup the existing file if it exists
        if (Test-Path -Path $destinationFile) {
            Backup-File -FilePath $destinationFile -MaxBackups 3
        }

        Copy-Item -Path $sourcePath -Destination $destinationFile -Force
        Import-Module -Name $destinationFile -Force

        Write-Host "Updated and imported $ExtensionName extension."
    }

    Compare-RscExtensions -Filter "$ExtensionName.psm1"
}

function Compare-RscExtensions {
    param (
        [string]$Filter = "*.psm1"
    )
    $results = @()

    # Add the directories as the first entry
    $results += [PSCustomObject]@{
        Source    = $global:ExtensionsSourceDir
        Installed = $global:ExtensionsInstallDir
        Diff      = $null
    }

    # Compare source files with destination files
    Get-ChildItem -Path $global:ExtensionsSourceDir -Filter $Filter | ForEach-Object {
        $sourceFile = $_
        $extensionName = $sourceFile.Name
        $destinationFile = Get-Item -Path "$global:ExtensionsInstallDir/$extensionName" -ErrorAction SilentlyContinue

        $diff = if ($destinationFile) {
            $sourceContent = Get-Content $sourceFile
            $destinationContent = Get-Content $destinationFile
            if ($null -eq $destinationContent -and $null -eq $sourceContent) {
                "same (empty)"
            }
            elseif ($null -eq $destinationContent -or $null -eq $sourceContent) {
                "one empty"
            }
            elseif (Compare-Object $sourceContent $destinationContent) {
                if ($sourceFile.LastWriteTime -gt $destinationFile.LastWriteTime) {
                    "source newer"
                }
                else {
                    "source older"
                }
            }
            else {
                "same"
            }
        }
        else {
            "source only"
        }

        $results += [PSCustomObject]@{
            Source    = [System.IO.Path]::GetFileName($sourceFile.FullName)
            Installed = if ($destinationFile) { [System.IO.Path]::GetFileName($destinationFile.FullName) } else { $null }
            Diff      = $diff
        }
    }

    # Check for destination files without a corresponding source file
    Get-ChildItem -Path $global:ExtensionsInstallDir -Filter $Filter | Where-Object {
        $_.Name -notin (Get-ChildItem -Path $global:ExtensionsSourceDir -Filter "*.psm1").Name
    } | ForEach-Object {
        $results += [PSCustomObject]@{
            Source    = $null
            Installed = [System.IO.Path]::GetFileName($_.FullName)
            Diff      = "installed only"
        }
    }

    $results | Format-Table -AutoSize
}

function New-RscExtension {
    param (
        [string]$Verb,
        [string]$Noun
    )

    $newExtensionName = "$Verb-Rsc$Noun"
    $templatePath = "$global:ExtensionsSourceDir/extension.psm1.template"
    $newExtensionPath = "$global:ExtensionsSourceDir/$newExtensionName.psm1"

    if (Test-Path -Path $newExtensionPath) {
        Write-Error "Extension $newExtensionName already exists at $newExtensionPath."
        return
    }

    # Read the content of the template file
    $templateContent = Get-Content -Path $templatePath

    # Perform global replacements
    $templateContent = $templateContent -replace '___VERB___', $Verb -replace '___NOUN___', $Noun

    # Write the updated content to the new extension file
    Set-Content -Path $newExtensionPath -Value $templateContent

    Write-Host "Created new extension $newExtensionName at $newExtensionPath."
}

