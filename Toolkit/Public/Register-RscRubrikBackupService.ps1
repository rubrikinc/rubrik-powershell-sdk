#Requires -Version 3
function Register-RscRubrikBackupService
{
    <#
    .SYNOPSIS
    Registers Rubrik Backup Service(RBS) on a Nutanix, HyperV, or VMware VM.

    .DESCRIPTION
    Once RBS is installed on a VM, this command will register it with Rubrik Security Cloud

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER VM
    The VMware or Nutanix VM object

    .EXAMPLE
    # Register RBS on a VMware VM
    Get-RscVmwareVm -Name "jake-001" | Register-RscRubrikBackupService

    .EXAMPLE
    # Register RBS on all Nutanix VMs
    Get-RscNutanixVm | Register-RscRubrikBackupService
    #>

    [CmdletBinding()]
    Param(
        # SLA Domain Duration
        [Parameter(Mandatory=$true, 
        Position=0,
        ValueFromPipeline=$true)]
        [RubrikSecurityCloud.Types.BaseType]$VM
    )

    Process {
        if($VM -is [RubrikSecurityCloud.Types.NutanixVm]){
            $query = New-RscMutation -GqlMutation registerAgentNutanixVm
            $query.var.input = New-Object RubrikSecurityCloud.Types.RegisterAgentNutanixVmInput
            $query.var.input.id = $VM.id
        }
        elseif ($VM -is [RubrikSecurityCloud.Types.VsphereVm]) {
            $query = New-RscMutation -GqlMutation vsphereVmRegisterAgent
            $query.var.input = New-Object RubrikSecurityCloud.Types.VsphereVmRegisterAgentInput
            $query.var.input.id = $VM.id
        }
        elseif ($VM -is [RubrikSecurityCloud.Types.HyperVvirtualMachine]) {
            $query = New-RscMutation -GqlMutation registerAgentHypervVirtualMachine
            $query.var.input = New-Object RubrikSecurityCloud.Types.RegisterAgentHypervVirtualMachineInput
            $query.var.input.id = $VM.id
        }
        else {
            Write-Error "Unsupported Type to register RBS: $($VM.gettype().Fullname)" -ErrorAction Stop
        }
        try {
            Invoke-Rsc $query
        }
        catch {
            Write-Error ($_ | Select-String -Pattern '(?<=message":)(.*)(?=,)').matches.value
        }

    }
}
