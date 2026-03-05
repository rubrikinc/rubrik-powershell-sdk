#Requires -Version 3
function Protect-RscWorkload
{
  <#
    .SYNOPSIS
    Assigns an SLA Domain to one or more workloads in Rubrik Security Cloud.

    .DESCRIPTION
    Protects workloads by assigning them to an SLA Domain, which controls snapshot frequency and retention. Accepts any snappable workload object (VMs, databases, filesets, etc.) via pipeline or the -InputObject parameter. For bulk operations, pass an array to -InputObject so all assignments are made in a single API call. You can also set a workload to DO NOT PROTECT or remove its SLA assignment entirely.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Id
    The RSC object ID.

    .PARAMETER InputObject
    One or more workload objects to assign. Accepts pipeline input.

    .PARAMETER Sla
    An SLA Domain object to filter by. Pipe from Get-RscSla.

    .PARAMETER AssignmentType
    The type of SLA assignment: PROTECT_WITH_SLA_ID (default), doNotProtect, or noAssignment.

    .PARAMETER ShouldApplyToExistingSnapshots
    Apply the new SLA policy to existing snapshots.

    .PARAMETER ShouldApplyToNonPolicySnapshots
    Apply the new SLA policy to snapshots not created by an SLA policy.

    .PARAMETER ExistingSnapshotAction
    Controls what happens to existing snapshots when changing SLA assignment.

    .EXAMPLE
    Assign a VM to the Gold SLA.

    Get-RscVmwareVm -Name "Foo" | Protect-RscWorkload -Sla (Get-RscSla -Name "Gold")

    .EXAMPLE
    Bulk-assign all VMs to an SLA in a single API call.

    Protect-RscWorkload -InputObject (Get-RscVmwareVm) -Sla (Get-RscSla -Name "Gold")

    .EXAMPLE
    Set a VM to DO NOT PROTECT.

    Get-RscVmwareVm -Name "Foo" | Protect-RscWorkload -AssignmentType doNotProtect

    .EXAMPLE
    Remove the SLA assignment from a VM.

    Get-RscVmwareVm -Name "Foo" | Protect-RscWorkload -AssignmentType noAssignment

    .PARAMETER MssqlLogConfigFromSla
    For MSSQL workloads: after assigning the SLA, automatically set the
    database to inherit its log backup configuration from the SLA Domain
    (equivalent to the RSC UI option "Follow the log configuration in the SLA Domain").
    This fires a follow-up assignMssqlSlaDomainPropertiesAsync mutation.

    .EXAMPLE
    Protect an MSSQL database and use the SLA's log backup configuration:

    Get-RscMssqlDatabase -Name "MyDB" | Protect-RscWorkload -Sla (Get-RscSla -Name "Gold") -MssqlLogConfigFromSla
  #>

  [CmdletBinding()]
  Param(
    # Id of a Workload to be assigned
    [Parameter()]
    [String]$Id,

    # Input object that accepts an array of objects for bulk assignment
    [Parameter(ValueFromPipeline=$true)]
    $InputObject,

    # RSC Sla Object
    [Parameter()]
    [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,

    # RSC Assignment Type
    [Parameter()]
    [RubrikSecurityCloud.Types.SlaAssignTypeEnum]$AssignmentType = [RubrikSecurityCloud.Types.SlaAssignTypeEnum]::PROTECT_WITH_SLA_ID,
  
    # RSC Apply to existing snapshots
    [Parameter()]
    [Switch]$ShouldApplyToExistingSnapshots,

    # RSC Apply to non-policy snapshots
    [Parameter()]
    [Switch]$ShouldApplyToNonPolicySnapshots,

    # RSC Snapshot retention setting
    [Parameter()]
    [RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]$ExistingSnapshotAction,

    # For MSSQL workloads: inherit log backup configuration from the SLA Domain
    [Parameter()]
    [switch]$MssqlLogConfigFromSla,

    [Parameter(
        Mandatory = $false,
        ValueFromPipeline = $false,
        HelpMessage = "Return the query object instead of running the query"
    )][Switch]$AsQuery
  )
    Process {

        $query = New-RscMutation -Gql assignSla
        $query.Var.Input = New-Object -TypeName RubrikSecurityCloud.Types.AssignSlaInput
        $query.Var.Input.slaDomainAssignType = $AssignmentType
        $query.Var.Input.existingSnapshotRetention = $ExistingSnapshotAction

        if ($Id) {
          $query.Var.Input.ObjectIds = @($Id)
        }
        elseif ($InputObject) {
          $query.Var.Input.ObjectIds = $InputObject.id
        }

        if ($Sla) {
          $query.Var.Input.slaOptionalId = $Sla.Id
        }

        if ($ShouldApplyToExistingSnapshots) {
          $query.Var.Input.ShouldApplyToExistingSnapshots = "true"
        }

        if ($ShouldApplyToNonPolicySnapshots) {
          $query.Var.Input.ShouldApplyToNonPolicySnapshots = "true"
        }
        
        if ( $AsQuery ) { return $query }
        $result = Invoke-Rsc -Query $query

        # Follow-up: set MSSQL log config to inherit from SLA Domain
        if ($MssqlLogConfigFromSla) {
            if (-not $Sla) {
                throw "-MssqlLogConfigFromSla requires -Sla to be specified."
            }
            $mssqlQuery = New-RscMutation -GqlMutation assignMssqlSlaDomainPropertiesAsync
            $mssqlQuery.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.AssignMssqlSlaDomainPropertiesAsyncInput
            $mssqlQuery.Var.input.userNote = ""
            $mssqlQuery.Var.input.updateinfo = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaDomainAssignInfoInput
            $mssqlQuery.Var.input.updateinfo.ids = $query.Var.Input.ObjectIds
            $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaPatchPropertiesInput
            $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.configuredSLADomainId = $Sla.Id
            $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties = New-Object -TypeName RubrikSecurityCloud.Types.MssqlSlaRelatedPropertiesInput
            $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hasLogConfigFromSla = $true
            $mssqlQuery.Var.input.updateinfo.mssqlSlaPatchProperties.mssqlSlaRelatedProperties.hostLogRetention = -1
            try {
                $mssqlQuery.invoke() | Out-Null
            } catch {
                Write-Warning "SLA assigned successfully, but failed to set MSSQL log config from SLA: $_"
            }
        }

        $result
    }
} 
