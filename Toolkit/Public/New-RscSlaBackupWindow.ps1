#Requires -Version 3
function New-RscSlaBackupWindow
{
    <#
    .SYNOPSIS
    Creates a new Rubrik SLA Backup Window Input

    .DESCRIPTION
    The New-RscSlaBackupWindow cmdlet will create a new SLA Backup Window Input to use
    with New-RscSla and Set-RscSla Cmdlets.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Duration
    The duration of backup window in hours.

    .PARAMETER DayOfWeek
    Specifies the day of the week.

    .PARAMETER Hour
    Specifies the hour of the day.

    .PARAMETER Minute
    Specifies the minute of the hour.

    .EXAMPLE
    New-RscSlaBackupWindow -Duration 2

    .EXAMPLE
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
