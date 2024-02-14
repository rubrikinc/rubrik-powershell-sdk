#Requires -Version 3
function New-RscSlaDomain
{
  <#
    .SYNOPSIS
    Creates a new Rubrik SLA Domain

    .DESCRIPTION
    The New-RscSlaDomain cmdlet will create a new SLA Domain. Rubrik SLA Domains are policies that define the frequency, retention, and rules for acrhival and replication.

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
    # SLA Domain Name
    [Parameter(Mandatory)]
    [ValidateNotNullOrEmpty()]
    [String]$Name,

    # Hourly Schedule object
    [Parameter()]
    [RubrikSecurityCloud.Types.HourlySnapshotScheduleInput]$HourlySchedule,

    # Weekly Schedule object
    [Parameter()]
    [RubrikSecurityCloud.Types.WeeklySnapshotScheduleInput]$WeeklySchedule,

    # Monthly Schedule object
    [Parameter()]
    [RubrikSecurityCloud.Types.MonthlySnapshotScheduleInput]$MonthlySchedule,

    # Quarterly Schedule object
    [Parameter()]
    [RubrikSecurityCloud.Types.QuarterlySnapshotScheduleInput]$QuarterlySchedule,

    # Yearly Schedule object
    [Parameter()]
    [RubrikSecurityCloud.Types.YearlySnapshotScheduleInput]$YearlySchedule,

    # Yearly Schedule object
    [Parameter()]
    [RubrikSecurityCloud.Types.SlaObjectType]$ObjectType
  )
    Process {

        $query = New-RscMutation -GqlMutation createGlobalSla
        $query.Var.Input = New-Object -TypeName RubrikSecurityCloud.Types.CreateGlobalSlaInput
        $query.Var.Input.name = $Name
        $query.Var.Input.SnapshotSchedule = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSnapshotScheduleInput
        $query.Var.Input.ObjectTypes = @($ObjectType)

        if ($HourlySchedule) {
            $query.var.input.SnapshotSchedule.Hourly = $HourlySchedule
        }
        if ($MonthlySchedule) {
            $query.var.input.SnapshotSchedule.Monthly = $MonthlySchedule
        }
        if ($QuarterlySchedule) {
            $query.var.input.SnapshotSchedule.Quarterly = $QuarterlySchedule
        }
        if ($YearlySchedule) {
            $query.var.input.SnapshotSchedule.Yearly = $YearlySchedule
        }
        $result = Invoke-Rsc -Query $query
        $result
    }
} 