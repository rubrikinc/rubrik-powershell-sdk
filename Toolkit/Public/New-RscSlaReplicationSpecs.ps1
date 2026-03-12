#Requires -Version 3
function New-RscSlaReplicationSpecs
{
    <#
    .SYNOPSIS
    Creates a replication specification input object for use with New-RscSla or Set-RscSla.

    .DESCRIPTION
    Defines how snapshots are replicated to a target Rubrik cluster or cloud
    region, including retention and optional cascading archival. The output is
    passed to New-RscSla or Set-RscSla via the -ReplicationSpecs parameter.
    Use New-RscSlaDuration to build duration values and
    New-RscSlaArchivalSpecs for cascading archival specs.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER ClusterUuid
    UUID of the target Rubrik cluster that will receive replicated snapshots.

    .PARAMETER StorageSettingId
    ID of the storage setting on the target cluster.

    .PARAMETER RetentionDuration
    How long replicated snapshots are retained on the target. Create with New-RscSlaDuration.

    .PARAMETER AwsAccount
    AWS account identifier when replicating to an AWS region.

    .PARAMETER AzureSubscription
    Azure subscription identifier when replicating to an Azure region.

    .PARAMETER AwsRegion
    AWS region for the replication target.

    .PARAMETER AzureRegion
    Azure region for the replication target.

    .PARAMETER ReplicationLocalRetentionDuration
    How long the snapshot is kept on the local (source) cluster after replication.
    Create with New-RscSlaDuration.

    .PARAMETER CascadingArchivalSpecs
    One or more cascading archival specifications that archive replicated
    snapshots to a secondary location. Create with New-RscSlaArchivalSpecs.

    .EXAMPLE
    Replicate to an on-premises cluster with 7-month retention.

    $repl = New-RscSlaReplicationSpecs `
        -ClusterUuid '9c930153-2a3c-4b7d-8603-48145315e71f' `
        -StorageSettingId '7a937a41-6abf-5gja-984f-1f0ea9ac2130' `
        -RetentionDuration (New-RscSlaDuration -Duration 7 -Unit MONTHS)
    New-RscSla -Name "DR-Gold" -ReplicationSpecs @($repl) -ObjectType VSPHERE_OBJECT_TYPE

    .EXAMPLE
    Replicate to AWS with cascading archival to Glacier.

    $archive = New-RscSlaArchivalSpecs -ArchivalThreshold 230 `
        -ArchivalThresholdUnit DAYS `
        -Frequencies @('MONTHS','YEARS') `
        -ArchivalLocationId 'aa137af1-6abf-59aa-984f-a9ac21301f0e'
    New-RscSlaReplicationSpecs `
        -ClusterUuid '9c930153-2a3c-4b7d-8603-48145315e71f' `
        -StorageSettingId '7a937a41-6abf-5gja-984f-1f0ea9ac2130' `
        -RetentionDuration (New-RscSlaDuration -Duration 7 -Unit MONTHS) `
        -AwsAccount 'AWS_ACCOUNT' `
        -AwsRegion 'US_WEST_2' `
        -ReplicationLocalRetentionDuration (New-RscSlaDuration -Duration 3 -Unit MONTHS) `
        -CascadingArchivalSpecs @($archive)
    #>

    [CmdletBinding()]
    Param(
        # Cluster UUID
        [Parameter()]
        [String]$ClusterUuid,

        # Storage Setting ID
        [Parameter()]
        [String]$StorageSettingId,

        # Retention Duration
        [Parameter()]
        [RubrikSecurityCloud.Types.SlaDurationInput]$RetentionDuration,

        # AWS Account
        [Parameter()]
        [String]$AwsAccount,

        # Azure Subscription
        [Parameter()]
        [String]$AzureSubscription,

        # AWS Region
        [Parameter()]
        [RubrikSecurityCloud.Types.AwsNativeRegionForReplication]$AwsRegion,

        # Azure Region
        [Parameter()]
        [RubrikSecurityCloud.Types.AzureNativeRegionForReplication]$AzureRegion,

        # Replication Local Retention Duration
        [Parameter()]
        [RubrikSecurityCloud.Types.SlaDurationInput]$ReplicationLocalRetentionDuration,

        # Cascading Archival Specifications
        [Parameter()]
        [RubrikSecurityCloud.Types.CascadingArchivalSpecInput[]]
        $CascadingArchivalSpecs
    )

    Process {
        $replicationSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ReplicationSpecV2Input
        $replicationSpecs.ClusterUuid = $ClusterUuid
        $replicationSpecs.StorageSettingId = $StorageSettingId
        $replicationSpecs.RetentionDuration = $RetentionDuration
        $replicationSpecs.AwsAccount = $AwsAccount
        $replicationSpecs.AzureSubscription = $AzureSubscription
        $replicationSpecs.AwsRegion = $AwsRegion
        $replicationSpecs.AzureRegion = $AzureRegion
        $replicationSpecs.ReplicationLocalRetentionDuration = $ReplicationLocalRetentionDuration
        $replicationSpecs.CascadingArchivalSpecs = $CascadingArchivalSpecs
        $replicationSpecs
    }
}
