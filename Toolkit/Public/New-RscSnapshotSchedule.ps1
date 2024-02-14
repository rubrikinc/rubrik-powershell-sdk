#Requires -Version 3
function New-RscSnapshotSchedule {
    <#
    .SYNOPSIS
    Creates a Snapshot Schedule for use with New-RscSlaDomain

    .DESCRIPTION
    Creates a Snapshot Schedule for use with New-RscSlaDomain

    .PARAMETER Type
    The Type of Schedule
    (Minute, Hourly, Daily, Weekly, Monthly, Quarterly, Yearly)

    .PARAMETER Frequency
    The frequency to take a snapshot, based on the schedule type.

    .PARAMETER Retention
    Length of time to retain the snapshot

    .PARAMETER RetentionUnit
    Unit of time to retain the snapshot
    (Minute, Hourly, Daily, Weekly, Monthly, Quarterly, Yearly)

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Create a Snapshot schedule to take a snapshot every 1 hour and retain that snapshot for 7 days. Then create the SLA Domain with that schedule.

    $hourlySchedule = New-RscSnapshotSchedule -Type Hourly -Frequency 1 -Retention 7 -RetentionUnit DAYS
    New-RscSlaDomain -Name "Platinum" -HourlySchedule $hourlySchedule -ObjectType VSPHERE_OBJECT_TYPE
    
    #>

    [CmdletBinding()]
    Param(
        [Parameter(Mandatory)]
        [ValidateSet("Minute","Hourly","Daily","Weekly","Monthly","Quarterly","Yearly")]
        $Type,
        
        [Parameter(Mandatory)]
        [Int]$Frequency,
        
        [Parameter(Mandatory)]
        [Int]$Retention,

        [Parameter(Mandatory)]
        [RubrikSecurityCloud.Types.RetentionUnit]
        $RetentionUnit,

        [Parameter()]
        [RubrikSecurityCloud.Types.DayOfWeek]
        $DayOfWeek = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY,

        [Parameter()]
        [RubrikSecurityCloud.Types.DayOfMonth]
        $DayOfMonth = [RubrikSecurityCloud.Types.DayOfMonth]::LAST_DAY,

        [Parameter()]
        [RubrikSecurityCloud.Types.DayOfQuarter]
        $DayOfQuarter = [RubrikSecurityCloud.Types.DayOfQuarter]::LAST_DAY,

        [Parameter()]
        [RubrikSecurityCloud.Types.Month]
        $QuarterStartMonth = [RubrikSecurityCloud.Types.Month]::JANUARY,

        [Parameter()]
        [RubrikSecurityCloud.Types.DayOfYear]
        $DayOfYear = [RubrikSecurityCloud.Types.DayOfYear]::LAST_DAY,

        [Parameter()]
        [RubrikSecurityCloud.Types.Month]
        $YearStartMonth = [RubrikSecurityCloud.Types.Month]::JANUARY

    )
    
    Process {
        $schedule = New-Object -TypeName "RubrikSecurityCloud.Types.$($Type)SnapshotScheduleInput"
        $schedule.BasicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotScheduleInput
        $schedule.BasicSchedule.Frequency = $Frequency
        $schedule.BasicSchedule.Retention = $Retention
        $schedule.BasicSchedule.RetentionUnit = $RetentionUnit

       if ($Type -eq "Weekly") {
            $schedule.DayOfWeek = $DayOfWeek
       } elseif ($Type -eq "Monthly") {
            $schedule.DayOfMonth = $DayOfMonth
       } elseif ($Type -eq "Quarterly") {
            $schedule.DayOfQuarter = $DayOfQuarter
            $schedule.QuarterStartMonth = $QuarterStartMonth
       } elseif ($Type -eq "Yearly") {
            $schedule.DayOfYear = $DayOfYear
            $schedule.YearStartMonth = $YearStartMonth
       }
        $schedule
    } 
}