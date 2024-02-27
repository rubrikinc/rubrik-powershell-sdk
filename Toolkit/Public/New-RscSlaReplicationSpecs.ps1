#Requires -Version 3
function New-RscSlaReplicationSpecs
{
    <#
    .SYNOPSIS
    Creates a new Rubrik SLA Replication Specs Input

    .DESCRIPTION
    The New-RscSlaReplicationSpecs cmdlet will create a new SLA Replication
    Specs Input to use with New-RscSlaDomain and Set-RscSlaDomain Cmdlets.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER ClusterUuid
    The UUID of the cluster

    .PARAMETER StorageSettingId
    The ID of the Storage Setting

    .PARAMETER RetentionDuration
    Retention duration

    .PARAMETER AwsAccount
    The AWS Account

    .PARAMETER AzureSubscription
    The Azure Subscription

    .PARAMETER AwsRegion
    AWS Region

    .PARAMETER AzureRegion
    Azure Region

    .PARAMETER ReplicationLocalRetentionDuration
    Time snapshot is kept on local target cluster

    .PARAMETER CascadingArchivalSpecs
    Cascading Archival Specifications - create using New-RscSlaArchivalSpecs

    .EXAMPLE
    $cascadingArchivalSpecs = New-RscSlaArchivalSpecs -ArchivalThreshold 230
    -ArchivalThresholdUnit DAYS
    -Frequencies @('MONTHS','YEARS')
    -ArchivalLocationId 'aa137af1-6abf-59aa-984f-a9ac21301f0e'

    New-RscSlaReplicationSpecs -ClusterUuid '9c930153-2a3c-4b7d-8603-48145315e71f'
    -StorageSettingId '7a937a41-6abf-5gja-984f-1f0ea9ac2130'
    -RetentionDuration (New-RscSlaDuration -Duration 7 -Unit MONTHS)
    -AwsAccount 'AWS_ACCOUNT'
    -AwsRegion 'US_WEST_2'
    -ReplicationLocalRetentionDuration (New-RscSlaDuration -Duration 3 -Unit MONTHS)
    -CascadingArchivalSpecs @($cascadingArchivalSpecs)
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
