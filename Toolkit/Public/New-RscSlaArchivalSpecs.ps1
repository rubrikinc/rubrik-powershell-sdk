#Requires -Version 3
function New-RscSlaArchivalSpecs
{
    <#
    .SYNOPSIS
    Creates an archival or cascading archival specification input object for use with New-RscSla.

    .DESCRIPTION
    Defines when and where snapshots are archived to long-term storage. When
    ClusterUuids and LocationIds are provided, a standard archival spec is
    created for New-RscSla or Set-RscSla. When ArchivalLocationId is provided
    instead, a cascading archival spec is created for
    New-RscSlaReplicationSpecs. Optional tiering parameters control cold
    storage placement.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER ArchivalGroupId
    ID of the archival group that owns the archival location.

    .PARAMETER ArchivalThreshold
    Number of time units after which a snapshot becomes eligible for archival.

    .PARAMETER ArchivalThresholdUnit
    Unit of time for the archival threshold (MINUTES, HOURS, DAYS, WEEKS,
    MONTHS, QUARTERS, YEARS). Defaults to MINUTES.

    .PARAMETER Frequencies
    Which snapshot cadences are eligible for archival (e.g. MONTHS, YEARS).

    .PARAMETER InstantTiering
    Enable instant tiering so snapshots are moved to cold storage immediately.

    .PARAMETER TierExistingSnapshots
    Tier snapshots that already exist, not only future ones.

    .PARAMETER MinAccessibleDuration
    Minimum number of seconds archived data must remain instantly accessible
    before being moved to cold storage (smart tiering).

    .PARAMETER ColdStorageClass
    Cold storage tier to use (AWS_GLACIER, AWS_GLACIER_DEEP_ARCHIVE,
    AZURE_ARCHIVE).

    .PARAMETER ClusterUuids
    UUIDs of clusters whose snapshots are archived. Must be the same length
    and in the same order as LocationIds.

    .PARAMETER LocationIds
    Archival location IDs that correspond to each cluster in ClusterUuids.

    .PARAMETER ArchivalLocationId
    Archival location on the replication target for cascading archival.
    Using this parameter creates a cascading archival spec instead of a
    standard archival spec.

    .EXAMPLE
    Create a standard archival spec and pass it to New-RscSla.

    $archival = New-RscSlaArchivalSpecs -ArchivalThreshold 230 -ArchivalThresholdUnit DAYS `
        -Frequencies @('MONTHS','YEARS') `
        -ClusterUuids @('9c930153-2a3c-4b7d-8603-48145315e71f') `
        -LocationIds @('aa137af1-6abf-59aa-984f-a9ac21301f0e')
    New-RscSla -Name "Archive-Gold" -ArchivalSpecs @($archival) -ObjectType VSPHERE_OBJECT_TYPE

    .EXAMPLE
    Create a cascading archival spec with instant tiering for use with New-RscSlaReplicationSpecs.

    $cascade = New-RscSlaArchivalSpecs -ArchivalThreshold 230 -ArchivalThresholdUnit DAYS `
        -Frequencies @('MONTHS','YEARS') -InstantTiering -TierExistingSnapshots `
        -MinAccessibleDuration 86400 -ColdStorageClass AWS_GLACIER `
        -ArchivalLocationId 'aa137af1-6abf-59aa-984f-a9ac21301f0e'
    New-RscSlaReplicationSpecs -CascadingArchivalSpecs @($cascade) -ClusterUuid '9c930153-...'
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
