#Requires -Version 3
function New-RscSlaBackupWindow
{
    <#
    .SYNOPSIS
    Creates a backup window input object for use with New-RscSla or Set-RscSla.

    .DESCRIPTION
    Defines a time window during which backups are allowed to run. Use this
    to restrict snapshot activity to off-peak hours. The output is passed to
    New-RscSla or Set-RscSla via the -BackupWindow or
    -FirstFullBackupWindow parameters.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Duration
    Length of the backup window in hours.

    .PARAMETER DayOfWeek
    Day of the week when the backup window applies. Defaults to Monday.

    .PARAMETER Hour
    Hour of the day (0-23) when the backup window starts. Defaults to 0.

    .PARAMETER Minute
    Minute of the hour (0-59) when the backup window starts. Defaults to 0.

    .EXAMPLE
    Create a 2-hour backup window starting at midnight on Monday and assign it to an SLA.

    $window = New-RscSlaBackupWindow -Duration 2
    New-RscSla -Name "NightOnly" -BackupWindow $window -ObjectType VSPHERE_OBJECT_TYPE

    .EXAMPLE
    Create a backup window starting Sunday at 1:30 AM for 2 hours.

    New-RscSlaBackupWindow -Duration 2 -DayOfWeek SUNDAY -Hour 1 -Minute 30
    #>

    [CmdletBinding()]
    Param(
        # Duration of the Backup Window
        [Parameter(Mandatory)]
        [Int]$Duration,

        # Day of the week in which back up window is applicable
        [Parameter()]
        [ValidateSet("SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY")]
        [RubrikSecurityCloud.Types.DayOfWeek]
        $DayOfWeek = [RubrikSecurityCloud.Types.DayOfWeek]::MONDAY,

        # Hour of the day in which back up window is applicable
        [Parameter()]
        [Int]$Hour = 0,

        # Minute of the hour in which back up window is applicable
        [Parameter()]
        [Int]$Minute = 0
    )

    Process {
        $slaBackupWindow = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindowInput
        $slaBackupWindow.DurationInHours = $Duration
        $slaBackupWindow.StartTimeAttributes =
            New-Object -TypeName RubrikSecurityCloud.Types.StartTimeAttributesInput
        $slaBackupWindow.StartTimeAttributes.Hour = $Hour
        $slaBackupWindow.StartTimeAttributes.Minute = $Minute
        $slaBackupWindow.StartTimeAttributes.DayOfWeek =
            New-Object -TypeName RubrikSecurityCloud.Types.DayOfWeekOptInput
        $slaBackupWindow.StartTimeAttributes.DayOfWeek.Day = $DayOfWeek
        $slaBackupWindow
    }
}
