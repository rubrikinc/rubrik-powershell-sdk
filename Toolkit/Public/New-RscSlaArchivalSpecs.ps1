#Requires -Version 3
function New-RscSlaArchivalSpecs
{
    <#
    .SYNOPSIS
    Creates a new Rubrik SLA Archival Specs Input or Cascading Archival Specs Input

    .DESCRIPTION
    The New-RscSlaArchivalSpecs cmdlet will create a new SLA Archival Specs Input
    or Cascading Archival Specs Input to use with New-RscSla and Set-RscSla Cmdlets.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER ArchivalGroupId
    ID of the Archival Group

    .PARAMETER ArchivalThreshold
    The threshold for archival

    .PARAMETER ArchivalThresholdUnit
    The unit of the threshold for archival

    .PARAMETER Frequencies
    Frequencies for archival of Snapshots

    .PARAMETER InstantTiering
    Should Instant Tiering be enabled

    .PARAMETER TierExistingSnapshots
    Should existing snapshots be tiered

    .PARAMETER MinAccessibleDuration
    Min accessible duration in seconds specified for smart tiering

    .PARAMETER ColdStorageClass
    The cold storage class for tiering

    .PARAMETER ClusterUuids
    The UUIDs of the clusters

    .PARAMETER LocationIds
    The location IDs associated with the provided clusters.
    Must be of the same length as ClusterUuids and in the same order.

    .PARAMETER ArchivalLocationId
    CDM archival location on the replication target the snapshot will be uploaded to.

    .EXAMPLE
    New-RscSlaArchivalSpecs -ArchivalThreshold 230 -ArchivalThresholdUnit DAYS
    -Frequencies @('MONTHS','YEARS')
    -ClusterUuids @('9c930153-2a3c-4b7d-8603-48145315e71f')
    -LocationIds @('aa137af1-6abf-59aa-984f-a9ac21301f0e')

    .EXAMPLE
    Creates a cascading archival spec with the provided parameters.
    New-RscSlaArchivalSpecs -ArchivalThreshold 230 -ArchivalThresholdUnit DAYS
    -Frequencies @('MONTHS','YEARS') -InstantTiering -TierExistingSnapshots
    -MinAccessibleDuration 86400 -ColdStorageClass AWS_GLACIER
    -ArchivalLocationId 'aa137af1-6abf-59aa-984f-a9ac21301f0e'
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Archival"
    )]
    Param(
        # Archival Group ID
        [Parameter(ParameterSetName="Archival")]
        [String]$ArchivalGroupId,

        # Archival Threshold
        [Parameter(ParameterSetName="Archival")]
        [Parameter(ParameterSetName="CascadingArchival")]
        [Int]$ArchivalThreshold,

        # Archival Threshold Unit
        [Parameter(ParameterSetName="Archival")]
        [Parameter(ParameterSetName="CascadingArchival")]
        [ValidateSet("MINUTES","HOURS","DAYS","WEEKS","MONTHS","QUARTERS", "YEARS")]
        [RubrikSecurityCloud.Types.RetentionUnit]
        $ArchivalThresholdUnit = [RubrikSecurityCloud.Types.RetentionUnit]::MINUTES,

        # Archival Frequencies
        [Parameter(ParameterSetName="Archival")]
        [Parameter(ParameterSetName="CascadingArchival")]
        [RubrikSecurityCloud.Types.RetentionUnit[]]
        $Frequencies,

        # Instant Tiering
        [Parameter(ParameterSetName="Archival")]
        [Parameter(ParameterSetName="CascadingArchival")]
        [Switch]$InstantTiering,

        # Tier Existing Snapshots
        [Parameter(ParameterSetName="Archival")]
        [Parameter(ParameterSetName="CascadingArchival")]
        [Switch]$TierExistingSnapshots,

        # Min accessible duration in seconds specified for smart tiering.
        [Parameter(ParameterSetName="Archival")]
        [Parameter(ParameterSetName="CascadingArchival")]
        [Long]$MinAccessibleDuration,

        # Cold Storage Class
        [Parameter(ParameterSetName="Archival")]
        [Parameter(ParameterSetName="CascadingArchival")]
        [ValidateSet(
                "COLD_STORAGE_CLASS_UNKNOWN",
                "AZURE_ARCHIVE",
                "AWS_GLACIER_DEEP_ARCHIVE",
                "AWS_GLACIER"
        )]
        [RubrikSecurityCloud.Types.ColdStorageClass]
        $ColdStorageClass,

        # Cluster UUIDs
        [Parameter(ParameterSetName="Archival")]
        [String[]]$ClusterUuids,

        # Location IDs that Cluster UUIDs are associated with.
        [Parameter(ParameterSetName="Archival")]
        [String[]]$LocationIds,

        [Parameter(ParameterSetName="CascadingArchival")]
        [String]$ArchivalLocationId
    )

    Process {
        $archivalTieringSpecInput = $null
        if ($InstantTiering -or $TierExistingSnapshots -or $MinAccessibleDuration -or $ColdStorageClass) {
            $archivalTieringSpecInput =
                New-Object -TypeName RubrikSecurityCloud.Types.ArchivalTieringSpecInput
            if ($InstantTiering) {
                $archivalTieringSpecInput.IsInstantTieringEnabled = $true
            }
            if ($TierExistingSnapshots) {
                $archivalTieringSpecInput.ShouldTierExistingSnapshots = $true
            }
            $archivalTieringSpecInput.MinAccessibleDurationInSeconds = $MinAccessibleDuration
            $archivalTieringSpecInput.ColdStorageClass = $ColdStorageClass
        }

        if ($PsCmdlet.ParameterSetName -eq "CascadingArchival") {
            $slaArchivalSpecs =
                New-Object -TypeName RubrikSecurityCloud.Types.CascadingArchivalSpecInput
            $slaArchivalSpecs.ArchivalLocationId = $ArchivalLocationId
            $slaArchivalSpecs.ArchivalThreshold =
                New-RscSlaDuration -Duration $ArchivalThreshold -Unit $ArchivalThresholdUnit
            $slaArchivalSpecs.Frequency = $Frequencies
        } else {
            $slaArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalSpecInput
            $slaArchivalSpecs.ArchivalGroupId = $ArchivalGroupId
            $slaArchivalSpecs.Threshold = $ArchivalThreshold
            $slaArchivalSpecs.ThresholdUnit = $ArchivalThresholdUnit
            $slaArchivalSpecs.Frequencies = $Frequencies

            if ($ClusterUuids.Length -ne $LocationIds.Length) {
                throw "Cluster UUIDs and Location IDs must be of the same length"
            }

            $slaArchivalSpecs.ArchivalLocationToClusterMapping = @()
            for ($i = 0; $i -lt $ClusterUuids.Length; $i++) {
                $archivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMappingInput
                $archivalLocationToClusterMapping.ClusterUuid = $ClusterUuids[$i]
                $archivalLocationToClusterMapping.LocationId = $LocationIds[$i]
                $slaArchivalSpecs.ArchivalLocationToClusterMapping.add($archivalLocationToClusterMapping)
            }
        }
        $slaArchivalSpecs.archivalTieringSpecInput = $archivalTieringSpecInput
        $slaArchivalSpecs
    }
}
