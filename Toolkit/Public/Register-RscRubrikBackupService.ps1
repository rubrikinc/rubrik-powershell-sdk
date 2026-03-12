#Requires -Version 3
function Register-RscRubrikBackupService
{
    <#
    .SYNOPSIS
    Registers the Rubrik Backup Service on a virtual machine or physical host.

    .DESCRIPTION
    After the Rubrik Backup Service (RBS) agent has been installed on a VM or physical host, use this cmdlet to register it with Rubrik Security Cloud. Supports VMware VMs, Nutanix VMs, Hyper-V VMs, and physical hosts. For physical hosts, provide the hostname and the Rubrik cluster to register against.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER VM
    A VMware, Nutanix, or Hyper-V virtual machine object. Accepts pipeline input.

    .PARAMETER Hostname
    One or more hostnames of physical hosts to register.

    .PARAMETER Cluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .PARAMETER Async
    Register physical hosts asynchronously.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Register RBS on a VMware VM.

    Get-RscVmwareVm -Name "jake-001" | Register-RscRubrikBackupService

    .EXAMPLE
    Register RBS on all Nutanix VMs.

    Get-RscNutanixVm | Register-RscRubrikBackupService

    .EXAMPLE
    Register a physical host.

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
        [switch]$Async,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery

    )

    Process {
        if ($VM) {
            if($VM -is [RubrikSecurityCloud.Types.NutanixVm]){
                $query = New-RscMutation -Gql registerAgentNutanixVm
                $query.var.input = New-Object RubrikSecurityCloud.Types.RegisterAgentNutanixVmInput
                $query.var.input.id = $VM.id
            }
            elseif ($VM -is [RubrikSecurityCloud.Types.VsphereVm]) {
                $query = New-RscMutation -Gql vsphereVmRegisterAgent
                $query.var.input = New-Object RubrikSecurityCloud.Types.VsphereVmRegisterAgentInput
                $query.var.input.id = $VM.id
            }
            elseif ($VM -is [RubrikSecurityCloud.Types.HyperVvirtualMachine]) {
                $query = New-RscMutation -Gql registerAgentHypervVirtualMachine
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
                $query = New-RscMutation -Gql bulkRegisterHostAsync
                $query.var.input =  New-Object -TypeName RubrikSecurityCloud.Types.BulkRegisterHostAsyncInput
            }
            else {
                $query = New-RscMutation -Gql bulkRegisterHost
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
        
        if ( $AsQuery ) { return $query }
        try {
            Invoke-Rsc $query
        }
        catch {
            Write-Error ($_ | Select-String -Pattern '(?<=message":)(.*)(?=,)').matches.value
        }

    }
}
