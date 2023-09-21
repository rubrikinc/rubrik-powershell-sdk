<#
.SYNOPSIS
Utility functions to work with Files and Directories
#>

function BackupFile {
    param (
        [string]$FilePath,
        [int]$MaxBackups = 3
    )

    # Rename existing backups
    for ($i = $MaxBackups - 1; $i -ge 0; $i--) {
        $oldBackup = if ($i -eq 0) { "$FilePath.bak" } else { "$FilePath.$i.bak" }
        $newBackup = "$FilePath." + ($i + 1) + ".bak"

        if (Test-Path $oldBackup) {
            if (Test-Path $newBackup) {
                Remove-Item -Path $newBackup -Force
            }
            Rename-Item -Path $oldBackup -NewName $newBackup
        }
    }

    # Create a new backup
    Copy-Item -Path $FilePath -Destination "$FilePath.bak" -Force
}

function CopyFileIfDifferent {
    param (
        [string]$SourceFile,
        [string]$DestinationFile
    )
    # Check if the source and destination files are identical
    $sourceContent = Get-Content $SourceFile
    $destinationContent = Get-Content $DestinationFile -ErrorAction SilentlyContinue
    if ($null -ne $destinationContent -and ($null -eq $sourceContent -or -not (Compare-Object $sourceContent $destinationContent))) {
        return $false
    }
    else {
        # Backup the existing file if it exists
        if (Test-Path -Path $destinationFile) {
            BackupFile -FilePath $destinationFile -MaxBackups 3
        }

        Copy-Item -Path $SourceFile -Destination $DestinationFile -Force
        return $true
    }
}

function CompareFiles {
    param (
        [string]$FileA,
        [string]$FileB
    )
    $AInfo = Get-Item -Path $FileA -ErrorAction SilentlyContinue
    $Binfo = Get-Item -Path $FileB -ErrorAction SilentlyContinue
    if ( $null -eq $AInfo -or $null -eq $Binfo ) {
        if ( $null -eq $AInfo -and $null -eq $Binfo ) {
            return "both missing"
        }
        elseif ( $null -eq $AInfo ) {
            return "FileA missing"
        }
        else {
            return "FileB missing"
        }
    }
    $ContentA = Get-Content $AInfo
    $ContentB = Get-Content $Binfo
    if ( $null -eq $ContentA -or $null -eq $ContentB ) {
        if ( $null -eq $ContentA -and $null -eq $ContentB ) {
            return "both empty"
        }
        elseif ( $null -eq $ContentA ) {
            return "FileA empty"
        }
        else {
            return "FileB empty"
        }
    }
    if (Compare-Object $ContentA $ContentB) {
        if ($AInfo.LastWriteTime -gt $Binfo.LastWriteTime) {
            return "FileA newer"
        }
        else {
            return "FileB newer"
        }
    }
    return "same"
}