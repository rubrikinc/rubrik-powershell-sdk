#Requires -Version 3
function New-RscSlaSnapshotSchedule {
    <#
    .SYNOPSIS
    Creates a snapshot schedule input object for use with New-RscSla.

    .DESCRIPTION
    Builds a typed snapshot schedule that defines how often snapshots are
    taken and how long they are retained. The output is passed to New-RscSla
    or Set-RscSla via the corresponding schedule parameter (e.g.
    -HourlySchedule, -DailySchedule). Use one schedule per cadence and
    combine several schedules in a single SLA domain.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Type
    The cadence of the schedule. Determines which schedule type is created
    (Minute, Hourly, Daily, Weekly, Monthly, Quarterly, Yearly).

    .PARAMETER Frequency
    How often a snapshot is taken within the chosen cadence. For example,
    a Frequency of 4 with Type Hourly means one snapshot every 4 hours.

    .PARAMETER Retention
    The number of time units to keep each snapshot before it expires.

    .PARAMETER RetentionUnit
    The unit of time for the Retention value
    (Minutes, Hours, Days, Weeks, Months, Quarters, Years).

    .PARAMETER DayOfWeek
    Day of the week on which weekly snapshots are taken. Defaults to Friday.

    .PARAMETER DayOfMonth
    Day of the month on which monthly snapshots are taken. Defaults to LAST_DAY.

    .PARAMETER DayOfQuarter
    Day of the quarter on which quarterly snapshots are taken. Defaults to LAST_DAY.

    .PARAMETER QuarterStartMonth
    Month in which each quarter begins for quarterly schedules. Defaults to January.

    .PARAMETER DayOfYear
    Day of the year on which yearly snapshots are taken. Defaults to LAST_DAY.

    .PARAMETER YearStartMonth
    Month in which the year begins for yearly schedules. Defaults to January.

    .EXAMPLE
    Create an hourly schedule and pass it to New-RscSla.

    $hourlySchedule = New-RscSlaSnapshotSchedule -Type Hourly -Frequency 1 -Retention 7 -RetentionUnit DAYS
    New-RscSla -Name "Platinum" -HourlySchedule $hourlySchedule -ObjectType VSPHERE_OBJECT_TYPE

    .EXAMPLE
    Create a weekly schedule that snapshots every Friday and retains for 4 weeks.

    $weeklySchedule = New-RscSlaSnapshotSchedule -Type Weekly -Frequency 1 -Retention 4 -RetentionUnit WEEKS -DayOfWeek FRIDAY
    New-RscSla -Name "Gold" -WeeklySchedule $weeklySchedule -ObjectType VSPHERE_OBJECT_TYPE
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
