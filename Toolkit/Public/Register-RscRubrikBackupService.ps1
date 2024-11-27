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

    .PARAMETER Hostname
    Hostname of a physical host

    .PARAMETER Cluster
    Rubrik Cluster Object

    .PARAMETER Async
    Register physical host using async mutation

    .EXAMPLE
    # Register RBS on a VMware VM
    Get-RscVmwareVm -Name "jake-001" | Register-RscRubrikBackupService

    .EXAMPLE
    # Register RBS on all Nutanix VMs
    Get-RscNutanixVm | Register-RscRubrikBackupService

    .EXAMPLE
    # Register Physical Host
    Register-RscRubrikBackupService -Hostname "foo.example.com" -Cluster (Get-RscCluster "mycluster.example.com")
    #>

    [CmdletBinding()]
    Param(
        # Virtual Machine to be registered.
        [Parameter(Mandatory=$true,
        ValueFromPipeline=$true, ParameterSetName="vm")]
        [RubrikSecurityCloud.Types.BaseType]$VM,

        # Physical Host to be registered.
        [Parameter(Mandatory=$true, 
        ParameterSetName = "host",
        ValueFromPipeline=$false)]
        [String[]]$Hostname,

        # Cluster Object.
        [Parameter(Mandatory=$true, 
        ParameterSetName = "host",
        ValueFromPipeline=$true)]
        [RubrikSecurityCloud.Types.Cluster]$Cluster,

        # Async option.
        [Parameter(Mandatory=$false, 
        ParameterSetName = "host",
        ValueFromPipeline=$false)]
        [switch]$Async

    )

    Process {
        if ($VM) {
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
        }
        elseif($Hostname) {
            if ($PSBoundParameters.ContainsKey('Async')) {
                # Don't think we're actually doing Async here.
                $query = New-RscMutation -GqlMutation bulkRegisterHostAsync
                $query.var.input =  New-Object -TypeName RubrikSecurityCloud.Types.BulkRegisterHostAsyncInput
            }
            else {
                $query = New-RscMutation -GqlMutation bulkRegisterHost
                $query.var.input =  New-Object -TypeName RubrikSecurityCloud.Types.BulkRegisterHostInput
            }
            
            $query.var.input.hosts = [System.Collections.Generic.List[RubrikSecurityCloud.Types.HostRegisterInput]]::new()
            foreach ($h in $Hostname) {
                $hostRegisterInput = New-Object -TypeName RubrikSecurityCloud.Types.HostRegisterInput
                $hostRegisterInput.Hostname = $h
                $query.var.input.hosts.add($hostRegisterInput) 
            }
            $query.var.input.clusterUuid = $Cluster.Id
        }
        
        try {
            Invoke-Rsc $query
        }
        catch {
            Write-Error ($_ | Select-String -Pattern '(?<=message":)(.*)(?=,)').matches.value
        }

    }
}
