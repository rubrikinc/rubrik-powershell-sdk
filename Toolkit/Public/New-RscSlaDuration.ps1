#Requires -Version 3
function New-RscSlaDuration
{
    <#
    .SYNOPSIS
    Creates a duration input object for use with SLA-related cmdlets.

    .DESCRIPTION
    Builds a duration value that represents a length of time with a unit.
    The output is passed to parameters on New-RscSla, Set-RscSla,
    New-RscSlaReplicationSpecs, and New-RscSlaObjectSpecificConfig that
    accept duration inputs (e.g. -RetentionDuration, -LogRetention,
    -Frequency).

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Duration
    The numeric duration value. Interpreted according to the Unit parameter.

    .PARAMETER Unit
    The time unit for the duration (MINUTES, HOURS, DAYS, WEEKS, MONTHS,
    QUARTERS, YEARS). Defaults to MINUTES.

    .EXAMPLE
    Create a 7-day duration and use it as log retention for an Oracle SLA config.

    $retention = New-RscSlaDuration -Duration 7 -Unit DAYS
    New-RscSlaObjectSpecificConfig -Oracle -LogRetention $retention

    .EXAMPLE
    Create a 10-minute duration (unit defaults to MINUTES).

    New-RscSlaDuration -Duration 10
    #>

    [CmdletBinding()]
    Param(
        # SLA Domain Duration
        [Parameter(Mandatory=$true, Position=0)]
        [Int]$Duration,

        # SLA Domain Duration Unit
        [Parameter(Position=1)]
        [ValidateSet("MINUTES","HOURS","DAYS","WEEKS","MONTHS","QUARTERS", "YEARS")]
        [RubrikSecurityCloud.Types.RetentionUnit]
        $Unit = [RubrikSecurityCloud.Types.RetentionUnit]::MINUTES
    )

    Process {
        $slaDuration = New-Object -TypeName RubrikSecurityCloud.Types.SlaDurationInput
        $slaDuration.Duration = $Duration
        $slaDuration.Unit = $Unit
        $slaDuration
    }
}
