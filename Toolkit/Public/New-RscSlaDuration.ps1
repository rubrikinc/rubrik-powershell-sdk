#Requires -Version 3
function New-RscSlaDuration
{
    <#
    .SYNOPSIS
    Creates a new Rubrik SLA Duration Input

    .DESCRIPTION
    The New-RscSlaDuration cmdlet will create a new SLA Duration Input to use
    with New-RscSla and Set-RscSla Cmdlets.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Duration
    The duration of the SLA Domain.

    .PARAMETER Unit
    Unit of duration

    .EXAMPLE
    New-RscSlaDuration -Duration 7 -Unit DAYS

    .EXAMPLE
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
