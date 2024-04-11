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

    .PARAMETER NasShareId
    The Rubrik UUID of the Nas Share object.

    .PARAMETER NasSystemId
    The Rubrik UUID of the Nas System object.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Get details of the NAS share with specified ID.
    Get-RscNasShare -NasShareId "d93ddffc-5a70-53f4-9cfa-be54ebeaa5cb"

    .EXAMPLE
    Get details of all the Nas shares for a given Nas System.
    Get-RscNasShare -NasSystemId "4322ac6a-8be6-59cb-82e4-fa163fb426e3"
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Share"
    )]
    Param(
        # The Rubrik UUID of the Nas Share object.
        [Parameter(
            Mandatory = $true,
            position = 0,
            ParameterSetName = "Share"
        )]
        [ValidateNotNullOrEmpty()]
        [String]$NasShareId,

        # The Rubrik UUID of the Nas System object.
        [Parameter(
            Mandatory = $true,
            ParameterSetName = "NasSystem"
        )]
        [ValidateNotNullOrEmpty()]
        [String]$NasSystemId,

        # Should Cmdlet return the query object instead of running it
        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        Switch ($PSCmdlet.ParameterSetName) {
            "Share" {
                $query = New-RscQueryNas -Operation Share `
                    -RemoveField ObjectType `
                    -AddField ShareType, `
                    ExportPoint, `
                    HostAddress, `
                    HostIdForRestore, `
                    PrimaryFileset

                # Set query variables.
                $query.Var.Fid = $NasShareId

                # Specify additional fields not in default field profile.
                $query.Field.NasSystem = New-Object -TypeName RubrikSecurityCloud.Types.NasSystem
                $query.Field.NasSystem.Id = "FETCH"
                $query.Field.NasSystem.Name = "FETCH"
                $query.Field.NasSystem.VendorType = "FETCH"
                $query.Field.NasSystem.OsVersion = "FETCH"
                $query.Field.NasSystem.IsSmbSupported = $true
                $query.Field.NasSystem.IsNfsSupported = $true
                $query.Field.NasSystem.ShareCount = -2147483648
                $query.Field.NasSystem.VolumeCount = -2147483648

                $query.Field.DescendantConnection = New-Object -TypeName `
                    RubrikSecurityCloud.Types.NasShareDescendantTypeConnection
                $query.Field.DescendantConnection.Nodes = @(New-Object -TypeName `
                    RubrikSecurityCloud.Types.NasFileset)
                $query.Field.DescendantConnection.Nodes[0].Id = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].Name = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].TemplateFid = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].OnDemandSnapshotCount = -2147483648
                $query.Field.DescendantConnection.Nodes[0].IsPassThrough = $true
                $query.Field.DescendantConnection.Nodes[0].IsRelic = $true
                $query.Field.DescendantConnection.Nodes[0].PathsIncluded = @()
                $query.Field.DescendantConnection.Nodes[0].PathsExcluded = @()
                $query.Field.DescendantConnection.Nodes[0].PathsExceptions = @()
                $query.Field.DescendantConnection.Nodes[0].CdmId = "FETCH"
                $query.Field.DescendantConnection.Nodes[0].SlaPauseStatus = $true
                $query.Field.DescendantConnection.Nodes[0].SymlinkResolutionEnabled = $true
                $query.Field.DescendantConnection.Nodes[0].ReplicatedObjectCount = -2147483648
            }
            "NasSystem" {
                $query = New-RscQueryNas -Operation System `
                    -RemoveField ObjectType `
                    -AddField ShareCount, `
                    OsVersion, `
                    VendorType, `
                    VolumeCount `


                # Set query variables.
                $query.Var.Fid = $NasSystemId

                # Specify additional fields not in default field profile.
                $query.Field.DescendantConnection = New-Object -TypeName `
                    RubrikSecurityCloud.Types.NasSystemDescendantTypeConnection
                $query.Field.DescendantConnection.Nodes = @(New-Object -TypeName `
                    RubrikSecurityCloud.Types.NasShare)
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
            }
        }

        # Both NasShare and NasSystem types expose Cluster information.
        $query.Field.Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
        $query.Field.Cluster.Id = "FETCH"
        $query.Field.Cluster.Name = "FETCH"
        $query.Field.Cluster.Version = "FETCH"
        

        if ($AsQuery) {
            return $query
        }

        $result = Invoke-Rsc -Query $query
        $result | Remove-NullProperties
    }
}