#Requires -Version 3
function Get-RscNasShare {
    <#
    .SYNOPSIS
    Retrieves Nas Shares present in Rubrik Security Cloud.

    .DESCRIPTION
    Use this cmdlet to retrieve Network Attached Storage (NAS) shares
    connected to Rubrik Security Cloud (RSC).

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Name
    The Name of the Nas Share object.

    .PARAMETER Id
    The Rubrik UUID of the Nas Share object.

    .PARAMETER List
    Switch to list all NAS Share objects.

    .PARAMETER NasSystem
    The object representing the NAS system.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Retrieve list of NAS shares.
    Get-RscNasShare
        or 
    Get-RscNasShare -List
    
    .EXAMPLE
    Retrieve all NAS shares with the name containing "foo".
    Get-RscNasShare -Name "foo"
        or
    Get-RscNasShare "foo"

    .EXAMPLE
    Get details of the NAS share with specified ID.
    Get-RscNasShare -Id "d93ddffc-5a70-53f4-9cfa-be54ebeaa5cb"

    .EXAMPLE
    Get details of all the Nas shares for a given Nas System.
    Get-RscNasSystem -Id "72859a28-6276-555a-9a66-d93fe99d2751" | Get-RscNasShare
 
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        # The name of the NAS share to filter on.
        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false,
            Position = 0
        )]
        [ValidateNotNullOrEmpty()]
        [String]$Name,

        # The Rubrik UUID of the Nas Share object.
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [ValidateNotNullOrEmpty()]
        [String]$Id,

        # Retrieve list of NAS systems.
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )]
        [Switch]$List,

        # The object representing the NAS system.
        [Parameter(
            Mandatory = $true,
            ParameterSetName = "NasSystem",
            ValueFromPipeline = $true
        )]
        [ValidateNotNullOrEmpty()]
        [RubrikSecurityCloud.Types.NasSystem]$NasSystem,

        # Should Cmdlet return the query object instead of running it
        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        function InitializeNasSystemFields {
            Param ($NasSystemField)
    
            $NasSystemField.Id = "FETCH"
            $NasSystemField.Name = "FETCH"
            $NasSystemField.VendorType = "FETCH"
            $NasSystemField.OsVersion = "FETCH"
            $NasSystemField.IsSmbSupported = $true
            $NasSystemField.IsNfsSupported = $true
            $NasSystemField.ShareCount = -2147483648
            $NasSystemField.VolumeCount = -2147483648
        }
    
        function InitializeDescendantConnectionNodes {
            Param ($Nodes)
    
            $Nodes = New-Object -TypeName RubrikSecurityCloud.Types.NasFileset
            $Nodes.Id = "FETCH"
            $Nodes.Name = "FETCH"
            $Nodes.TemplateFid = "FETCH"
            $Nodes.OnDemandSnapshotCount = -2147483648
            $Nodes.IsPassThrough = $true
            $Nodes.IsRelic = $true
            $Nodes.PathsIncluded = [string[]]@()
            $Nodes.PathsExcluded = [string[]]@()
            $Nodes.PathsExceptions = [string[]]@()
            $Nodes.CdmId = "FETCH"
            $Nodes.SlaPauseStatus = $true
            $Nodes.SymlinkResolutionEnabled = $true
            $Nodes.ReplicatedObjectCount = -2147483648
    
            return $Nodes
        }
    
        function InitializeCluster {
            Param ($ClusterField)
    
            $ClusterField.Id = "FETCH"
            $ClusterField.Name = "FETCH"
            $ClusterField.Version = "FETCH"
        }
        

        function InitializeNasShareOutputFields {
            Param ($Field)

            $Field.NasSystem = New-Object -TypeName RubrikSecurityCloud.Types.NasSystem
            InitializeNasSystemFields -NasSystemField $Field.NasSystem

            $Field.DescendantConnection = New-Object -TypeName `
                RubrikSecurityCloud.Types.NasShareDescendantTypeConnection
            
            $Field.DescendantConnection.Nodes = [RubrikSecurityCloud.Types.NasFileset[]](InitializeDescendantConnectionNodes)

            $Field.Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            InitializeCluster -ClusterField $Field.Cluster
        }

        Switch ($PSCmdlet.ParameterSetName) {
            "Id" {
                $query = New-RscQueryNas -Operation Share `
                    -RemoveField ObjectType `
                    -AddField ShareType, `
                    ExportPoint, `
                    HostAddress, `
                    HostIdForRestore, `
                    PrimaryFileset

                # Set query variables.
                $query.Var.Fid = $Id

                # Specify additional fields not in default field profile.           
                InitializeNasShareOutputFields -Field $query.Field
            }

            "Name" {
                $query = New-RscQueryNas -Operation Shares
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $InputObj.Field = "Name"
                $InputObj.Texts = [string[]]@($Name)
                $query.Var.Filter = [RubrikSecurityCloud.Types.Filter[]]@($InputObj)
                
                # Specify additional fields not in default field profile.
                $query.Field.Nodes[0].HostAddress = "FETCH"
                InitializeNasShareOutputFields -Field $query.Field.Nodes[0]
            }

            "List" {
                $query = New-RscQueryNas -Operation Shares

                # Specify additional fields not in default field profile.
                $query.Field.Nodes[0].HostAddress = "FETCH"
                InitializeNasShareOutputFields -Field $query.Field.Nodes[0]
            }

            "NasSystem" {
                $query = New-RscQueryNas -Operation System `
                    -RemoveField ObjectType `
                    -AddField ShareCount, `
                    OsVersion, `
                    VendorType, `
                    VolumeCount

                # Set query variables.
                $query.Var.Fid = $NasSystem.Id

                # Specify additional fields not in default field profile.
                $query.Field.DescendantConnection = New-Object -TypeName `
                    RubrikSecurityCloud.Types.NasSystemDescendantTypeConnection
                $query.Field.DescendantConnection.Nodes = [RubrikSecurityCloud.Types.NasShare[]](New-Object -TypeName RubrikSecurityCloud.Types.NasShare)
                $query.Field.DescendantConnection.Nodes[0].Id = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].Name = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].IsStale = $true
                $query.Field.DescendantConnection.Nodes[0].IsNasShareManuallyAdded = $true
                $query.Field.DescendantConnection.Nodes[0].ShareType = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].ExportPoint = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].IsChangelistEnabled = $true
                $query.Field.DescendantConnection.Nodes[0].IsHidden = $true
                $query.Field.DescendantConnection.Nodes[0].IsRelic = $true
                $query.Field.DescendantConnection.Nodes[0].CdmId = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].HostAddress = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].HostIdForRestore = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].ConnectedThrough =
                    [RubrikSecurityCloud.Types.ConnectedThroughEnumType]::SRC_UNSPECIFIED
                $query.Field.DescendantConnection.Nodes[0].SlaAssignment =
                    [RubrikSecurityCloud.Types.SlaAssignmentTypeEnum]::Derived
                $query.Field.DescendantConnection.Nodes[0].SlaPauseStatus = $true
                
                $query.Field.DescendantConnection.Nodes[0].EffectiveSlaDomain =
                    New-Object -TypeName RubrikSecurityCloud.Types.globalSlaReply
                $query.Field.DescendantConnection.Nodes[0].EffectiveSlaDomain.Id = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].EffectiveSlaDomain.Name = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].EffectiveSlaDomain.Version = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].EffectiveSlaDomain.IsRetentionLockedSla = $true

                $query.Field.Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
                InitializeCluster -ClusterField $query.Field.Cluster
            }
        }

        if ($AsQuery) {
            return $query
        }

        $result = Invoke-Rsc -Query $query

        if ($PSCmdlet.ParameterSetName -eq "NasSystem") {
            $result = $result.DescendantConnection.Nodes
        } elseif ($PSCmdlet.ParameterSetName -eq "Name" -or $PSCmdlet.ParameterSetName -eq "List") {
            $result = $result.Nodes
        }

        $result | Remove-NullProperties
    }
}