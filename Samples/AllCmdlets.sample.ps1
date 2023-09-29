# This file was generated for the RSC PowerShell SDK
param(
    [switch]$GetGqlRequest
)

. "${PSScriptRoot}/../Utils/import.ps1"
. "${PSScriptRoot}/SampleUtils.ps1"

if ($GetGqlRequest) {
    $gqlDir = "gql"

    # Check if the directory exists
    if (-Not (Test-Path -Path $gqlDir -PathType Container)) {
        # Create the directory if it doesn't exist
        New-Item -Path $gqlDir -ItemType Directory
    }

    # Change to the directory
    Set-Location -Path $gqlDir
}

# -------------------------------------------------------------------
# New-RscMutationAccount -DeleteUsers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAccount -DeleteUsers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAccount -DeleteUsers
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationActivitySeries -Cancel
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationActivitySeries -Cancel).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationActivitySeries -Cancel
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationActivitySeries -DownloadUserCsv
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationActivitySeries -DownloadUserCsv).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationActivitySeries -DownloadUserCsv
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationActivitySeries -DownloadUserFileCsv
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationActivitySeries -DownloadUserFileCsv).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationActivitySeries -DownloadUserFileCsv
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationAws -AddAuthenticationServerBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -AddAuthenticationServerBasedCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -AddAuthenticationServerBasedCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -AddIamUserBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -AddIamUserBasedCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -AddIamUserBasedCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -BulkDeleteCloudAccountWithoutCft
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -BulkDeleteCloudAccountWithoutCft).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -BulkDeleteCloudAccountWithoutCft
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateAutomaticTargetMapping
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateCloudNativeStorageSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateComputeSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateComputeSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateExocomputeConfigs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateReaderTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateReaderTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -DeleteCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -DeleteCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -DeleteComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -DeleteComputeSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -DeleteComputeSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -DeleteExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -DeleteExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -DeleteExocomputeConfigs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -FinalizeCloudAccountDeletion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -FinalizeCloudAccountDeletion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -FinalizeCloudAccountDeletion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -FinalizeCloudAccountProtection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -FinalizeCloudAccountProtection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -FinalizeCloudAccountProtection
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -PatchIamUserBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -PatchIamUserBasedCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -PatchIamUserBasedCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -PrepareCloudAccountDeletion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -PrepareCloudAccountDeletion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -PrepareCloudAccountDeletion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -PrepareFeatureUpdateForCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -PrepareFeatureUpdateForCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -PrepareFeatureUpdateForCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -RegisterFeatureArtifacts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -RegisterFeatureArtifacts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -RegisterFeatureArtifacts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartExocomputeDisableJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartExocomputeDisableJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartExocomputeDisableJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateAutomaticTargetMapping
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateCloudAccountFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateCloudAccountFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateCloudAccountFeature
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateCloudNativeStorageSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateComputeSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateComputeSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateExocomputeConfigs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -ValidateAndCreateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -ValidateAndCreateCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -ValidateAndCreateCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationAwsNative -ExcludeEbsVolumesFromSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAwsNative -ExcludeEbsVolumesFromSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAwsNative -ExcludeEbsVolumesFromSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAwsNative -StartAccountDisableJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAwsNative -StartAccountDisableJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAwsNative -StartAccountDisableJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAwsNative -StartCreateEbsVolumeSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAwsNative -StartCreateEbsVolumeSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAwsNative -StartCreateEbsVolumeSnapshotsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAwsNative -StartEc2InstanceSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAwsNative -StartEc2InstanceSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAwsNative -StartEc2InstanceSnapshotsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAwsNative -StartExportEbsVolumeSnapshotJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAwsNative -StartExportEbsVolumeSnapshotJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAwsNative -StartExportEbsVolumeSnapshotJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAwsNative -StartRdsInstanceSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAwsNative -StartRdsInstanceSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAwsNative -StartRdsInstanceSnapshotsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAwsNative -StartRefreshAccountsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAwsNative -StartRefreshAccountsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAwsNative -StartRefreshAccountsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAwsNative -StartRestoreEc2InstanceSnapshotJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAwsNative -StartRestoreEc2InstanceSnapshotJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAwsNative -StartRestoreEc2InstanceSnapshotJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationAzure -AddCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -AddCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -AddCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -AddCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -AddCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -AddCloudAccountExocomputeConfigurations
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -AddCloudAccountWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -AddCloudAccountWithoutOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -AddCloudAccountWithoutOauth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -BackupAdDirectory
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -BackupAdDirectory).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -BackupAdDirectory
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CompleteAdAppSetup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CompleteAdAppSetup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CompleteAdAppSetup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CompleteAdAppUpdate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CompleteAdAppUpdate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CompleteAdAppUpdate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CompleteCloudAccountOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CompleteCloudAccountOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CompleteCloudAccountOauth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateAutomaticTargetMapping
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateCloudNativeRcvStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateCloudNativeRcvStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateCloudNativeRcvStorageSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateCloudNativeStorageSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateReaderTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateReaderTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateSaasAppAad
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateSaasAppAad).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateSaasAppAad
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteAdDirectory
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteAdDirectory).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteAdDirectory
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteCloudAccountWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteCloudAccountWithoutOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteCloudAccountWithoutOauth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -MapCloudAccountExocomputeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -MapCloudAccountExocomputeSubscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -MapCloudAccountExocomputeSubscription
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -OauthConsentComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -OauthConsentComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -OauthConsentComplete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -OauthConsentKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -OauthConsentKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -OauthConsentKickoff
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -RestoreAdObjectsWithPasswords
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -RestoreAdObjectsWithPasswords).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -RestoreAdObjectsWithPasswords
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -SetCloudAccountCustomerAppCredentials
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -SetCloudAccountCustomerAppCredentials).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -SetCloudAccountCustomerAppCredentials
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartAdAppSetup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartAdAppSetup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartAdAppSetup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartAdAppUpdate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartAdAppUpdate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartAdAppUpdate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartCloudAccountOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartCloudAccountOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartCloudAccountOauth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartDisableCloudAccountJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartDisableCloudAccountJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartDisableCloudAccountJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartExportSqlDatabaseDbJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartExportSqlDatabaseDbJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartExportSqlDatabaseDbJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartExportSqlManagedInstanceDbJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartExportSqlManagedInstanceDbJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartExportSqlManagedInstanceDbJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UnmapPersistentStorageSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UnmapPersistentStorageSubscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UnmapPersistentStorageSubscription
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateAutomaticTargetMapping
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateCloudNativeStorageSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateCustomerAppPermissionForSql
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateCustomerAppPermissionForSql).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateCustomerAppPermissionForSql
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpgradeCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpgradeCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpgradeCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationAzureNative -ExcludeManagedDisksFromSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureNative -ExcludeManagedDisksFromSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureNative -ExcludeManagedDisksFromSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzureNative -StartCreateManagedDiskSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureNative -StartCreateManagedDiskSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureNative -StartCreateManagedDiskSnapshotsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzureNative -StartCreateVirtualMachineSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureNative -StartCreateVirtualMachineSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureNative -StartCreateVirtualMachineSnapshotsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzureNative -StartDisableSubscriptionProtectionJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureNative -StartDisableSubscriptionProtectionJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureNative -StartDisableSubscriptionProtectionJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzureNative -StartExportManagedDiskJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureNative -StartExportManagedDiskJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureNative -StartExportManagedDiskJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzureNative -StartExportVirtualMachineJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureNative -StartExportVirtualMachineJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureNative -StartExportVirtualMachineJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzureNative -StartRefreshSubscriptionsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureNative -StartRefreshSubscriptionsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureNative -StartRefreshSubscriptionsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzureNative -StartRestoreVirtualMachineJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureNative -StartRestoreVirtualMachineJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureNative -StartRestoreVirtualMachineJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationAzureO365 -SetupExocompute
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureO365 -SetupExocompute).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureO365 -SetupExocompute
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationCassandra -BulkDeleteSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -BulkDeleteSources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -BulkDeleteSources
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCassandra -CreateSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -CreateSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -CreateSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCassandra -DeleteSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -DeleteSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -DeleteSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCassandra -RecoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -RecoverSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -RecoverSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCassandra -UpdateSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -UpdateSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -UpdateSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationCertificate -AddClusterCertificate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCertificate -AddClusterCertificate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCertificate -AddClusterCertificate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCertificate -Delete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCertificate -Delete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCertificate -Delete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCertificate -SetSso
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCertificate -SetSso).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCertificate -SetSso
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCertificate -SetWebSigned
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCertificate -SetWebSigned).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCertificate -SetWebSigned
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCertificate -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCertificate -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCertificate -Update
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCertificate -UpdateHost
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCertificate -UpdateHost).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCertificate -UpdateHost
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationCloudAccount -MapExocomputeAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudAccount -MapExocomputeAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudAccount -MapExocomputeAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudAccount -UnmapExocomputeAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudAccount -UnmapExocomputeAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudAccount -UnmapExocomputeAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationCloudNative -AddSqlServerBackupCredentials
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -AddSqlServerBackupCredentials).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -AddSqlServerBackupCredentials
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -CheckRbaConnectivity
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -CheckRbaConnectivity).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -CheckRbaConnectivity
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -ClearSqlServerBackupCredentials
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -ClearSqlServerBackupCredentials).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -ClearSqlServerBackupCredentials
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -CreateLabelRule
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -CreateLabelRule).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -CreateLabelRule
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -CreateTagRule
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -CreateTagRule).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -CreateTagRule
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -DeleteLabelRule
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -DeleteLabelRule).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -DeleteLabelRule
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -DeleteTagRule
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -DeleteTagRule).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -DeleteTagRule
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -DownloadFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -DownloadFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -DownloadFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -SetupSqlServerBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -SetupSqlServerBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -SetupSqlServerBackup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -StartSnapshotsIndexJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -StartSnapshotsIndexJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -StartSnapshotsIndexJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -UpdateIndexingStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -UpdateIndexingStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -UpdateIndexingStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -UpdateLabelRule
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -UpdateLabelRule).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -UpdateLabelRule
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCloudNative -UpdateTagRule
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCloudNative -UpdateTagRule).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCloudNative -UpdateTagRule
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationCluster -AddNodesToCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -AddNodesToCloud).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -AddNodesToCloud
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCluster -BulkDeleteFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -BulkDeleteFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -BulkDeleteFailover
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCluster -CreateFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -CreateFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -CreateFailover
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCluster -DeleteFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -DeleteFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -DeleteFailover
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCluster -RecoverCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -RecoverCloud).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -RecoverCloud
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCluster -RegisterCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -RegisterCloud).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -RegisterCloud
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCluster -RemoveCdm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -RemoveCdm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -RemoveCdm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCluster -UpdateDatabaseLogReportingProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -UpdateDatabaseLogReportingProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -UpdateDatabaseLogReportingProperties
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationCluster -UpdateFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -UpdateFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -UpdateFailover
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationDb2 -AddInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -AddInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -AddInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -CreateOnDemandBackup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DeleteDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DeleteDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DeleteDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DeleteInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DeleteInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DeleteInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DiscoverInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DiscoverInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DiscoverInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DownloadSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DownloadSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -ExpireDownloadedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -ExpireDownloadedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -ExpireDownloadedSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -PatchDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -PatchDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -PatchDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -PatchInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -PatchInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -PatchInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -RefreshDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -RefreshDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -RefreshDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationDownload -AuditLogCsvAsync
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -AuditLogCsvAsync).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -AuditLogCsvAsync
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -ExchangeSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -ExchangeSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -ExchangeSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -FilesetSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -FilesetSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -FilesetSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -FilesetSnapshotFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -FilesetSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -FilesetSnapshotFromLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -ObjectFilesCsv
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -ObjectFilesCsv).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -ObjectFilesCsv
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -ObjectsListCsv
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -ObjectsListCsv).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -ObjectsListCsv
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -ReportCsvAsync
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -ReportCsvAsync).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -ReportCsvAsync
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -ReportPdfAsync
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -ReportPdfAsync).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -ReportPdfAsync
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -ResultsCsv
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -ResultsCsv).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -ResultsCsv
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -SapHanaSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -SapHanaSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -SapHanaSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -SapHanaSnapshotFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -SapHanaSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -SapHanaSnapshotFromLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -SapHanaSnapshotsForPointInTimeRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -SapHanaSnapshotsForPointInTimeRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -SapHanaSnapshotsForPointInTimeRecovery
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -SnapshotResultsCsv
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -SnapshotResultsCsv).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -SnapshotResultsCsv
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -ThreatHuntCsv
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -ThreatHuntCsv).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -ThreatHuntCsv
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -VolumeGroupSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -VolumeGroupSnapshotFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -VolumeGroupSnapshotFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationDownload -VolumeGroupSnapshotFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDownload -VolumeGroupSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDownload -VolumeGroupSnapshotFromLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationExchange -BulkUpdateDag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationExchange -BulkUpdateDag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationExchange -BulkUpdateDag
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationExchange -CreateMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationExchange -CreateMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationExchange -CreateMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationExchange -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationExchange -CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationExchange -CreateOnDemandBackup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationExchange -DeleteSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationExchange -DeleteSnapshotMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationExchange -DeleteSnapshotMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationFileset -BulkCreate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationFileset -BulkCreate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationFileset -BulkCreate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationFileset -BulkCreateTemplates
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationFileset -BulkCreateTemplates).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationFileset -BulkCreateTemplates
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationFileset -BulkDelete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationFileset -BulkDelete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationFileset -BulkDelete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationFileset -BulkDeleteTemplate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationFileset -BulkDeleteTemplate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationFileset -BulkDeleteTemplate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationFileset -BulkUpdateTemplate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationFileset -BulkUpdateTemplate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationFileset -BulkUpdateTemplate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationFileset -RecoverFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationFileset -RecoverFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationFileset -RecoverFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationGcp -CloudAccountAddManualAuthProject
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -CloudAccountAddManualAuthProject).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -CloudAccountAddManualAuthProject
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -CloudAccountAddProjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -CloudAccountAddProjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -CloudAccountAddProjects
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -CloudAccountDeleteProjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -CloudAccountDeleteProjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -CloudAccountDeleteProjects
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -CloudAccountOauthComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -CloudAccountOauthComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -CloudAccountOauthComplete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -CloudAccountOauthInitiate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -CloudAccountOauthInitiate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -CloudAccountOauthInitiate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -CloudAccountUpgradeProjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -CloudAccountUpgradeProjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -CloudAccountUpgradeProjects
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -CreateReaderTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -CreateReaderTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -CreateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -CreateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -SetDefaultServiceAccountJwtConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -SetDefaultServiceAccountJwtConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -SetDefaultServiceAccountJwtConfig
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -UpdateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcp -UpgradeCloudAccountPermissionsWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcp -UpgradeCloudAccountPermissionsWithoutOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcp -UpgradeCloudAccountPermissionsWithoutOauth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationGcpNative -DisableProject
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcpNative -DisableProject).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcpNative -DisableProject
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcpNative -ExcludeDisksFromInstanceSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcpNative -ExcludeDisksFromInstanceSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcpNative -ExcludeDisksFromInstanceSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcpNative -ExportDisk
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcpNative -ExportDisk).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcpNative -ExportDisk
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcpNative -ExportGceInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcpNative -ExportGceInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcpNative -ExportGceInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcpNative -RefreshProjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcpNative -RefreshProjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcpNative -RefreshProjects
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationGcpNative -RestoreGceInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationGcpNative -RestoreGceInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationGcpNative -RestoreGceInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationHost -BulkDelete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHost -BulkDelete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHost -BulkDelete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHost -BulkRefresh
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHost -BulkRefresh).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHost -BulkRefresh
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHost -BulkRegister
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHost -BulkRegister).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHost -BulkRegister
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHost -BulkUpdate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHost -BulkUpdate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHost -BulkUpdate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHost -ChangeVfd
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHost -ChangeVfd).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHost -ChangeVfd
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHost -Refresh
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHost -Refresh).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHost -Refresh
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationHyperv -BatchExportVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -BatchExportVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -BatchExportVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -BatchInstantRecoverVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -BatchInstantRecoverVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -BatchInstantRecoverVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -BatchMountVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -BatchMountVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -BatchMountVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -BatchOnDemandBackupVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -BatchOnDemandBackupVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -BatchOnDemandBackupVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -CreateVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -CreateVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -CreateVirtualMachineSnapshotMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DeleteAllSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DeleteAllSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DeleteAllSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DeleteVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DeleteVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DeleteVirtualMachineSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DownloadSnapshotFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DownloadSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DownloadSnapshotFromLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DownloadVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DownloadVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DownloadVirtualMachineSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -ExportVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -ExportVirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -ExportVirtualMachine
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -OnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -OnDemandSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -OnDemandSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RefreshScvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RefreshScvmm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RefreshScvmm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RefreshServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RefreshServer).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RefreshServer
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RegisterAgentVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RegisterAgentVirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RegisterAgentVirtualMachine
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RegisterScvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RegisterScvmm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RegisterScvmm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -ScvmmDelete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -ScvmmDelete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -ScvmmDelete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -ScvmmUpdate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -ScvmmUpdate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -ScvmmUpdate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -UpdateVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -UpdateVirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -UpdateVirtualMachine
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationK8s -ArchiveCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationK8s -ArchiveCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationK8s -ArchiveCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationK8s -CreateAgentManifest
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationK8s -CreateAgentManifest).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationK8s -CreateAgentManifest
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationK8s -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationK8s -CreateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationK8s -CreateCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationK8s -CreateNamespaceSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationK8s -CreateNamespaceSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationK8s -CreateNamespaceSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationK8s -ExportNamespace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationK8s -ExportNamespace).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationK8s -ExportNamespace
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationK8s -RefreshCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationK8s -RefreshCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationK8s -RefreshCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationK8s -RestoreNamespace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationK8s -RestoreNamespace).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationK8s -RestoreNamespace
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationLdap -DeletePrincipals
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationLdap -DeletePrincipals).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationLdap -DeletePrincipals
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationLdap -RemoveIntegration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationLdap -RemoveIntegration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationLdap -RemoveIntegration
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationLdap -SetMfaSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationLdap -SetMfaSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationLdap -SetMfaSetting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationLdap -UpdateIntegration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationLdap -UpdateIntegration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationLdap -UpdateIntegration
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationM365 -BackupMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationM365 -BackupMailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationM365 -BackupMailbox
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationM365 -BackupOnedrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationM365 -BackupOnedrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationM365 -BackupOnedrive
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationM365 -BackupSharepointDrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationM365 -BackupSharepointDrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationM365 -BackupSharepointDrive
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationM365 -BackupTeam
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationM365 -BackupTeam).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationM365 -BackupTeam
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationManagedVolume -Add
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -Add).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -Add
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -BeginSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -BeginSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -BeginSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -Delete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -Delete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -Delete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -DeleteSnapshotExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -DeleteSnapshotExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -DeleteSnapshotExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -DownloadFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -DownloadFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -DownloadFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -DownloadFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -DownloadFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -DownloadFromLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -EndSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -EndSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -EndSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -ExportSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -ExportSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -ExportSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -Resize
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -Resize).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -Resize
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -TakeOnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -TakeOnDemandSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -TakeOnDemandSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationManagedVolume -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationManagedVolume -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationManagedVolume -Update
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationMongo -AddSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -AddSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -AddSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -AssignSlaToCollection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -AssignSlaToCollection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -AssignSlaToCollection
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -BulkDeleteSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -BulkDeleteSources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -BulkDeleteSources
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -CreateSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -CreateSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -CreateSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -DeleteSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -DeleteSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -DeleteSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -DiscoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -DiscoverSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -DiscoverSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -PatchSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -PatchSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -PatchSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -RecoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -RecoverSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -RecoverSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -RetryAddSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -RetryAddSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -RetryAddSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -UpdateSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -UpdateSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -UpdateSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationMosaic -AddStore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMosaic -AddStore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMosaic -AddStore
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMosaic -DeleteStore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMosaic -DeleteStore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMosaic -DeleteStore
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMosaic -UpdateStore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMosaic -UpdateStore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMosaic -UpdateStore
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationMssql -AssignSlaDomainProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -AssignSlaDomainProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -AssignSlaDomainProperties
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -AssignSlaDomainPropertiesAsync
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -AssignSlaDomainPropertiesAsync).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -AssignSlaDomainPropertiesAsync
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -BrowseDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -BrowseDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -BrowseDatabaseSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -BulkCreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -BulkCreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -BulkCreateOnDemandBackup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -BulkUpdateDbs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -BulkUpdateDbs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -BulkUpdateDbs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -CreateLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -CreateLiveMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -CreateLiveMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -CreateLogShippingConfiguration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -CreateLogShippingConfiguration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -CreateLogShippingConfiguration
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -CreateOnDemandBackup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -DeleteDbSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -DeleteDbSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -DeleteDbSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -DeleteLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -DeleteLiveMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -DeleteLiveMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -DownloadDatabaseBackupFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -DownloadDatabaseBackupFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -DownloadDatabaseBackupFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -ExportDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -ExportDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -ExportDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -RestoreDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -RestoreDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -RestoreDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -TakeLogBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -TakeLogBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -TakeLogBackup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -UpdateDefaultProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -UpdateDefaultProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -UpdateDefaultProperties
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMssql -UpdateLogShippingConfiguration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -UpdateLogShippingConfiguration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -UpdateLogShippingConfiguration
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationNfs -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNfs -CreateReaderTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNfs -CreateReaderTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNfs -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNfs -CreateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNfs -CreateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNfs -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNfs -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNfs -UpdateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationNutanix -BatchExportVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -BatchExportVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -BatchExportVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -BatchMountVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -BatchMountVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -BatchMountVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -BulkOnDemandSnapshotVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -BulkOnDemandSnapshotVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -BulkOnDemandSnapshotVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -CreateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -CreateCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -CreateOnDemandBackup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -CreatePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -CreatePrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -CreatePrismCentral
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeleteCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeleteCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeleteMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeleteMountV1).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeleteMountV1
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeletePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeletePrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeletePrismCentral
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeleteSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeleteSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeleteSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeleteSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeleteSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeleteSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DownloadFilesSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DownloadFilesSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DownloadFilesSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DownloadSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DownloadSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DownloadVmFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DownloadVmFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DownloadVmFromLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -ExportSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -ExportSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -ExportSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -MigrateMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -MigrateMountV1).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -MigrateMountV1
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -MountSnapshotV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -MountSnapshotV1).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -MountSnapshotV1
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -PatchMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -PatchMountV1).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -PatchMountV1
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -RefreshCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -RefreshCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -RefreshCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -RefreshPrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -RefreshPrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -RefreshPrismCentral
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -RegisterAgentVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -RegisterAgentVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -RegisterAgentVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -RestoreFilesSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -RestoreFilesSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -RestoreFilesSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -UpdateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -UpdateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -UpdateCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -UpdatePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -UpdatePrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -UpdatePrismCentral
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -UpdateVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -UpdateVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -UpdateVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationO365 -AddOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -AddOrg).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -AddOrg
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupMailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupMailbox
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupOnedrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupOnedrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupOnedrive
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupSharePointSite
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupSharePointSite).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupSharePointSite
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupSharepointDrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupSharepointDrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupSharepointDrive
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupSharepointList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupSharepointList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupSharepointList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupTeam
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupTeam).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupTeam
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -CreateAppComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -CreateAppComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -CreateAppComplete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -CreateAppKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -CreateAppKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -CreateAppKickoff
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -DeleteAzureApp
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -DeleteAzureApp).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -DeleteAzureApp
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -DeleteOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -DeleteOrg).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -DeleteOrg
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -DeleteServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -DeleteServiceAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -DeleteServiceAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -EnableSharePoint
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -EnableSharePoint).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -EnableSharePoint
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -EnableTeams
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -EnableTeams).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -EnableTeams
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -ExportMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -ExportMailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -ExportMailbox
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -InsertCustomerApp
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -InsertCustomerApp).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -InsertCustomerApp
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -OauthConsentComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -OauthConsentComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -OauthConsentComplete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -OauthConsentKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -OauthConsentKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -OauthConsentKickoff
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -PdlGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -PdlGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -PdlGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RefreshOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RefreshOrg).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RefreshOrg
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RestoreMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RestoreMailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RestoreMailbox
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RestoreSnappable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RestoreSnappable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RestoreSnappable
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RestoreTeamsConversations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RestoreTeamsConversations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RestoreTeamsConversations
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RestoreTeamsFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RestoreTeamsFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RestoreTeamsFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -SaaSSetupKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -SaaSSetupKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -SaaSSetupKickoff
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -SaasSetupComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -SaasSetupComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -SaasSetupComplete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -SetServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -SetServiceAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -SetServiceAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -SetupKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -SetupKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -SetupKickoff
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -UpdateAppAuthStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -UpdateAppAuthStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -UpdateAppAuthStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -UpdateAppPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -UpdateAppPermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -UpdateAppPermissions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationO365 -UpdateOrgCustomName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -UpdateOrgCustomName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -UpdateOrgCustomName
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationOracle -BulkUpdateDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -BulkUpdateDatabases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -BulkUpdateDatabases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -BulkUpdateHosts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -BulkUpdateHosts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -BulkUpdateHosts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -BulkUpdateRacs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -BulkUpdateRacs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -BulkUpdateRacs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -CreatePdbRestore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -CreatePdbRestore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -CreatePdbRestore
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -DeleteAllDatabaseSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -DeleteAllDatabaseSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -DeleteAllDatabaseSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -DeleteMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -DeleteMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -DeleteMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -DownloadDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -DownloadDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -DownloadDatabaseSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -ExportDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -ExportDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -ExportDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -ExportTablespace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -ExportTablespace).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -ExportTablespace
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -InstantRecoverSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -InstantRecoverSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -InstantRecoverSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -MountDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -MountDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -MountDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -RefreshDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -RefreshDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -RefreshDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -RestoreLogs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -RestoreLogs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -RestoreLogs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -TakeOnDemandDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -TakeOnDemandDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -TakeOnDemandDatabaseSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -TakeOnDemandLogSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -TakeOnDemandLogSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -TakeOnDemandLogSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -UpdateDataGuardGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -UpdateDataGuardGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -UpdateDataGuardGroup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -ValidateAcoFile
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -ValidateAcoFile).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -ValidateAcoFile
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationOracle -ValidateDatabaseBackups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -ValidateDatabaseBackups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -ValidateDatabaseBackups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationPolicy -Policies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationPolicy -Policies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationPolicy -Policies
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationRansomware -TriggerDetection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationRansomware -TriggerDetection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationRansomware -TriggerDetection
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationRcs -CreateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationRcs -CreateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationRcs -CreateAutomaticTargetMapping
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationRcs -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationRcs -CreateReaderTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationRcs -CreateReaderTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationRcs -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationRcs -CreateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationRcs -CreateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationRcs -UpdateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationRcs -UpdateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationRcs -UpdateAutomaticTargetMapping
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationRcv -CreateLocationsFromTemplate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationRcv -CreateLocationsFromTemplate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationRcv -CreateLocationsFromTemplate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationRcv -CreatePrivateEndpointApprovalRequest
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationRcv -CreatePrivateEndpointApprovalRequest).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationRcv -CreatePrivateEndpointApprovalRequest
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationRcv -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationRcv -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationRcv -UpdateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationReplication -CreatePair
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReplication -CreatePair).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReplication -CreatePair
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReplication -DeletePair
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReplication -DeletePair).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReplication -DeletePair
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReplication -DisablePause
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReplication -DisablePause).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReplication -DisablePause
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReplication -EnablePause
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReplication -EnablePause).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReplication -EnablePause
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReplication -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReplication -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReplication -UpdateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationReport -CreateCustom
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -CreateCustom).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -CreateCustom
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReport -CreateScheduled
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -CreateScheduled).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -CreateScheduled
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReport -DeleteCustom
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -DeleteCustom).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -DeleteCustom
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReport -DeleteScheduled
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -DeleteScheduled).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -DeleteScheduled
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReport -SendPdf
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -SendPdf).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -SendPdf
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReport -SendScheduledAsync
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -SendScheduledAsync).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -SendScheduledAsync
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReport -StartClusterMigrationJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -StartClusterMigrationJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -StartClusterMigrationJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReport -UpdateCustom
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -UpdateCustom).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -UpdateCustom
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationReport -UpdateScheduled
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationReport -UpdateScheduled).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationReport -UpdateScheduled
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationSapHana -AddSystem
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -AddSystem).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -AddSystem
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSapHana -ConfigureRestore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -ConfigureRestore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -ConfigureRestore
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSapHana -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -CreateOnDemandBackup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSapHana -CreateSystemRefresh
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -CreateSystemRefresh).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -CreateSystemRefresh
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSapHana -DeleteDbSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -DeleteDbSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -DeleteDbSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSapHana -DeleteSystem
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -DeleteSystem).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -DeleteSystem
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSapHana -ExpireDownloadedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -ExpireDownloadedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -ExpireDownloadedSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSapHana -PatchSystem
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -PatchSystem).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -PatchSystem
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSapHana -UnconfigureRestore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSapHana -UnconfigureRestore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSapHana -UnconfigureRestore
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationServiceAccount -Create
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationServiceAccount -Create).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationServiceAccount -Create
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationServiceAccount -Delete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationServiceAccount -Delete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationServiceAccount -Delete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationServiceAccount -Rotate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationServiceAccount -Rotate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationServiceAccount -Rotate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationServiceAccount -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationServiceAccount -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationServiceAccount -Update
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationSharepoint -ExcludeObjectsFromProtection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSharepoint -ExcludeObjectsFromProtection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSharepoint -ExcludeObjectsFromProtection
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationSla -Assign
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -Assign).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -Assign
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSla -AssignRetentionToSnappables
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -AssignRetentionToSnappables).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -AssignRetentionToSnappables
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSla -AssignRetentionToSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -AssignRetentionToSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -AssignRetentionToSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSla -AssignsForSnappableHierarchies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -AssignsForSnappableHierarchies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -AssignsForSnappableHierarchies
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSla -CreateGlobal
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -CreateGlobal).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -CreateGlobal
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSla -ExportManagedVolumeSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -ExportManagedVolumeSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -ExportManagedVolumeSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSla -GetPendingAssignments
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -GetPendingAssignments).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -GetPendingAssignments
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSla -Pause
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -Pause).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -Pause
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSla -UpdateGlobal
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -UpdateGlobal).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -UpdateGlobal
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationSmb -AddAndJoinDomain
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSmb -AddAndJoinDomain).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSmb -AddAndJoinDomain
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSmb -DeleteDomain
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSmb -DeleteDomain).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSmb -DeleteDomain
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSmb -JoinDomain
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSmb -JoinDomain).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSmb -JoinDomain
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSmb -PutConfiguration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSmb -PutConfiguration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSmb -PutConfiguration
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationSnapshot -BatchQuarantine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -BatchQuarantine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -BatchQuarantine
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -BatchReleaseFromQuarantine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -BatchReleaseFromQuarantine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -BatchReleaseFromQuarantine
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -BulkTierExistings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -BulkTierExistings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -BulkTierExistings
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -CreateDownloadForVolumeGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -CreateDownloadForVolumeGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -CreateDownloadForVolumeGroup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -CreateFileset
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -CreateFileset).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -CreateFileset
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -DeleteCloudWorkload
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -DeleteCloudWorkload).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -DeleteCloudWorkload
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -DeleteFilesets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -DeleteFilesets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -DeleteFilesets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -FilesetDownloadFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -FilesetDownloadFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -FilesetDownloadFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -FilesetExportFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -FilesetExportFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -FilesetExportFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -RestoreVolumeGroupFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -RestoreVolumeGroupFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -RestoreVolumeGroupFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -StartEc2InstanceExportJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -StartEc2InstanceExportJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -StartEc2InstanceExportJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -StartRecoverS3Job
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -StartRecoverS3Job).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -StartRecoverS3Job
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -TakeOnDemand
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -TakeOnDemand).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -TakeOnDemand
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -UploadDatabaseToBlobstore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -UploadDatabaseToBlobstore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -UploadDatabaseToBlobstore
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationSnapshot -VmwareDownloadFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSnapshot -VmwareDownloadFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSnapshot -VmwareDownloadFromLocation
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationStorageArray -Add
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationStorageArray -Add).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationStorageArray -Add
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationStorageArray -Delete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationStorageArray -Delete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationStorageArray -Delete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationStorageArray -Refresh
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationStorageArray -Refresh).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationStorageArray -Refresh
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationStorageArray -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationStorageArray -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationStorageArray -Update
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationTape -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationTape -CreateReaderTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationTape -CreateReaderTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationTape -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationTape -CreateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationTape -CreateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationTape -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationTape -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationTape -UpdateTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationThreat -CancelHunt
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationThreat -CancelHunt).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationThreat -CancelHunt
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationThreat -EnableMonitoring
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationThreat -EnableMonitoring).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationThreat -EnableMonitoring
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationThreat -StartHunt
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationThreat -StartHunt).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationThreat -StartHunt
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationVcenter -Create
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -Create).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -Create
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -Delete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -Delete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -Delete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -Refresh
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -Refresh).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -Refresh
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -Update
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -UpdateHotAddBandwidth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -UpdateHotAddBandwidth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -UpdateHotAddBandwidth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -UpdateHotAddNetwork
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -UpdateHotAddNetwork).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -UpdateHotAddNetwork
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationVsphere -BulkOnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -BulkOnDemandSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -BulkOnDemandSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -CreateAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -CreateAdvancedTag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -CreateAdvancedTag
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -DeleteAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -DeleteAdvancedTag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -DeleteAdvancedTag
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -DeleteLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -DeleteLiveMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -DeleteLiveMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -DownloadVirtualMachineFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -DownloadVirtualMachineFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -DownloadVirtualMachineFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -OnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -OnDemandSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -OnDemandSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -UpdateAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -UpdateAdvancedTag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -UpdateAdvancedTag
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationVsphereVm -BatchExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -BatchExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -BatchExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -BatchExportV3
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -BatchExportV3).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -BatchExportV3
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -BatchInPlaceRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -BatchInPlaceRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -BatchInPlaceRecovery
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -DeleteSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -DeleteSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -DeleteSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -DownloadSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -DownloadSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -DownloadSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -DownloadSnapshotFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -DownloadSnapshotFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ExcludeVmDisks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ExcludeVmDisks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ExcludeVmDisks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ExportSnapshotV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ExportSnapshotV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ExportSnapshotV2
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ExportSnapshotV3
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ExportSnapshotV3).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ExportSnapshotV3
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateBatchInstantRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateBatchInstantRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateBatchInstantRecovery
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateBatchLiveMountV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateBatchLiveMountV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateBatchLiveMountV2
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateDiskMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateDiskMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateDiskMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateInPlaceRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateInPlaceRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateInPlaceRecovery
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateInstantRecoveryV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateInstantRecoveryV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateInstantRecoveryV2
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateLiveMountV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateLiveMountV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateLiveMountV2
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ListEsxiDatastores
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ListEsxiDatastores).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ListEsxiDatastores
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -MountRelocate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -MountRelocate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -MountRelocate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -MountRelocateV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -MountRelocateV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -MountRelocateV2
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -PowerOnOffLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -PowerOnOffLiveMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -PowerOnOffLiveMount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -RecoverFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -RecoverFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -RecoverFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -RecoverFilesNew
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -RecoverFilesNew).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -RecoverFilesNew
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -RegisterAgent
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -RegisterAgent).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -RegisterAgent
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -Update
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscMutationWebhook -Create
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationWebhook -Create).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationWebhook -Create
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationWebhook -Delete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationWebhook -Delete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationWebhook -Delete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationWebhook -Test
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationWebhook -Test).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationWebhook -Test
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationWebhook -TestExisting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationWebhook -TestExisting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationWebhook -TestExisting
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationWebhook -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationWebhook -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationWebhook -Update
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryAccount -EnabledFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -EnabledFeatures).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -EnabledFeatures
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Id
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Id).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Id
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Lookup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Lookup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Lookup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Owners
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Owners).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Owners
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Products
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Products).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Products
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Settings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Settings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Settings
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Users
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Users).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Users
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryActivitySeries -ActivitySeries
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryActivitySeries -ActivitySeries).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryActivitySeries -ActivitySeries
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryActivitySeries -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryActivitySeries -List).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryActivitySeries -List
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryActivitySeries -UserFileTimeline
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryActivitySeries -UserFileTimeline).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryActivitySeries -UserFileTimeline
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryActivitySeries -UserTimeline
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryActivitySeries -UserTimeline).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryActivitySeries -UserTimeline
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryAws -ArtifactsToDelete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ArtifactsToDelete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ArtifactsToDelete
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AvailabilityZonesByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AvailabilityZonesByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AvailabilityZonesByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -CdmVersions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CdmVersions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CdmVersions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountConfigs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountListSecurityGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountListSecurityGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountListSecurityGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountListSubnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountListSubnets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountListSubnets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountListVpcs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountListVpcs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountListVpcs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountWithFeatures).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountWithFeatures
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountsWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountsWithFeatures).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountsWithFeatures
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -ComputeSettings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ComputeSettings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ComputeSettings
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -DbParameterGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -DbParameterGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -DbParameterGroupsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -DbSubnetGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -DbSubnetGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -DbSubnetGroupsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -Ec2KeyPairsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -Ec2KeyPairsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -Ec2KeyPairsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -ExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ExocomputeConfigs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -InstanceProfileNames
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -InstanceProfileNames).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -InstanceProfileNames
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -IsS3BucketNameAvailable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -IsS3BucketNameAvailable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -IsS3BucketNameAvailable
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -KmsEncryptionKeysByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -KmsEncryptionKeysByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -KmsEncryptionKeysByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -OptionGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -OptionGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -OptionGroupsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -PermissionPolicies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -PermissionPolicies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -PermissionPolicies
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -RdsInstanceDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -RdsInstanceDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -RdsInstanceDetails
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -Regions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -Regions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -Regions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -S3BucketStateForRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -S3BucketStateForRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -S3BucketStateForRecovery
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -S3Buckets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -S3Buckets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -S3Buckets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -S3BucketsDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -S3BucketsDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -S3BucketsDetails
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -SupportedRdsDatabaseInstanceClasses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -SupportedRdsDatabaseInstanceClasses).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -SupportedRdsDatabaseInstanceClasses
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -TrustPolicy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -TrustPolicy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -TrustPolicy
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -Vpcs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -Vpcs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -Vpcs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -VpcsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -VpcsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -VpcsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryAwsNative -Account
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -Account).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -Account
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -Accounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -Accounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -Accounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -AmiTypeForArchivedSnapshotExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -AmiTypeForArchivedSnapshotExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -AmiTypeForArchivedSnapshotExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -EbsVolume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -EbsVolume).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -EbsVolume
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -EbsVolumes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -EbsVolumes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -EbsVolumes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -EbsVolumesByName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -EbsVolumesByName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -EbsVolumesByName
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -Ec2Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -Ec2Instance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -Ec2Instance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -Ec2Instances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -Ec2Instances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -Ec2Instances
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -Ec2InstancesByName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -Ec2InstancesByName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -Ec2InstancesByName
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -IsEbsVolumeSnapshotRestorable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -IsEbsVolumeSnapshotRestorable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -IsEbsVolumeSnapshotRestorable
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -IsRdsInstanceLaunchConfigurationValid
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -IsRdsInstanceLaunchConfigurationValid).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -IsRdsInstanceLaunchConfigurationValid
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -RdsExportDefaults
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -RdsExportDefaults).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -RdsExportDefaults
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -RdsInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -RdsInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -RdsInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -RdsInstances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -RdsInstances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -RdsInstances
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -RdsPointInTimeRestoreWindow
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -RdsPointInTimeRestoreWindow).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -RdsPointInTimeRestoreWindow
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -Root
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -Root).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -Root
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -S3Bucket
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -S3Bucket).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -S3Bucket
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -ValidateRdsClusterNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -ValidateRdsClusterNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -ValidateRdsClusterNameForExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAwsNative -ValidateRdsInstanceNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAwsNative -ValidateRdsInstanceNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAwsNative -ValidateRdsInstanceNameForExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryAzure -AdDirectories
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AdDirectories).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AdDirectories
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AdDirectory
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AdDirectory).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AdDirectory
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AdObjectsByType
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AdObjectsByType).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AdObjectsByType
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ArmTemplatesByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ArmTemplatesByFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ArmTemplatesByFeature
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CdmVersions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CdmVersions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CdmVersions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountMissingPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountMissingPermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountMissingPermissions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountPermissionConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountPermissionConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountPermissionConfig
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountSubnetsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountSubnetsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountSubnetsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountSubscriptionWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountSubscriptionWithFeatures).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountSubscriptionWithFeatures
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountSubscriptionsByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountSubscriptionsByFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountSubscriptionsByFeature
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountTenant
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountTenant).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountTenant
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountTenantWithExoConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountTenantWithExoConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountTenantWithExoConfigs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountTenants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountTenants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountTenants
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -DiskEncryptionSetsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -DiskEncryptionSetsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -DiskEncryptionSetsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -EncryptionKeys
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -EncryptionKeys).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -EncryptionKeys
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ExocomputeConfigsInAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ExocomputeConfigsInAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ExocomputeConfigsInAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -HostedAzureRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -HostedAzureRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -HostedAzureRegions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -IsStorageAccountNameAvailable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -IsStorageAccountNameAvailable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -IsStorageAccountNameAvailable
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -KeyVaultsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -KeyVaultsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -KeyVaultsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ManagedIdentities
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ManagedIdentities).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ManagedIdentities
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -Nsgs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -Nsgs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -Nsgs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -Regions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -Regions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -Regions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ResourceGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ResourceGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SearchAdSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SearchAdSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SearchAdSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabaseServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabaseServer).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabaseServer
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabaseServerElasticPools
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabaseServerElasticPools).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabaseServerElasticPools
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabaseServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabaseServers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabaseServers
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceDatabases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceDatabases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceServer).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceServer
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceServers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceServers
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -StorageAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -StorageAccounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -StorageAccounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -Subnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -Subnets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -Subnets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SubscriptionWithExocomputeMappings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SubscriptionWithExocomputeMappings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SubscriptionWithExocomputeMappings
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -Subscriptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -Subscriptions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -Subscriptions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -VNets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -VNets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -VNets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryAzureNative -AvailabilitySetsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -AvailabilitySetsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -AvailabilitySetsByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -DoesResourceGroupExist
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -DoesResourceGroupExist).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -DoesResourceGroupExist
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ExportCompatibleDiskTypesByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ExportCompatibleDiskTypesByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ExportCompatibleDiskTypesByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ExportCompatibleVmSizesByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ExportCompatibleVmSizesByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ExportCompatibleVmSizesByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -IsManagedDiskSnapshotRestorable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -IsManagedDiskSnapshotRestorable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -IsManagedDiskSnapshotRestorable
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -IsSqlDatabaseSnapshotPersistent
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -IsSqlDatabaseSnapshotPersistent).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -IsSqlDatabaseSnapshotPersistent
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ManagedDisk
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ManagedDisk).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ManagedDisk
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ManagedDisks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ManagedDisks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ManagedDisks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ResourceGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ResourceGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ResourceGroup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ResourceGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ResourceGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ResourceGroupsInfoIfExist
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ResourceGroupsInfoIfExist).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ResourceGroupsInfoIfExist
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -Root
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -Root).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -Root
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -SecurityGroupsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -SecurityGroupsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -SecurityGroupsByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -StorageAccountsFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -StorageAccountsFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -StorageAccountsFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -SubnetsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -SubnetsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -SubnetsByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -Subscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -Subscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -Subscription
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -Subscriptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -Subscriptions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -Subscriptions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ValidateSqlDatabaseDbNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ValidateSqlDatabaseDbNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ValidateSqlDatabaseDbNameForExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -ValidateSqlManagedInstanceDbNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -ValidateSqlManagedInstanceDbNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -ValidateSqlManagedInstanceDbNameForExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -VirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -VirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -VirtualMachine
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -VirtualMachineSizes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -VirtualMachineSizes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -VirtualMachineSizes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -VirtualMachines
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -VirtualMachines).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -VirtualMachines
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureNative -VirtualNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureNative -VirtualNetworks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureNative -VirtualNetworks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckNSGOutboundRules
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckNSGOutboundRules).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckNSGOutboundRules
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckNetworkSubnet
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckNetworkSubnet).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckNetworkSubnet
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckResourceGroupName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckResourceGroupName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckResourceGroupName
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckStorageAccountAccessibility
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckStorageAccountAccessibility).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckStorageAccountAccessibility
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckStorageAccountName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckStorageAccountName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckStorageAccountName
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckSubscriptionQuota
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckSubscriptionQuota).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckSubscriptionQuota
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckVirtualNetworkName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckVirtualNetworkName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckVirtualNetworkName
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -Exocompute
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -Exocompute).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -Exocompute
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -GetAzureHostType
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -GetAzureHostType).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -GetAzureHostType
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -ValidateUserRoles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -ValidateUserRoles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -ValidateUserRoles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryCassandra -ColumnFamilies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -ColumnFamilies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -ColumnFamilies
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -ColumnFamily
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -ColumnFamily).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -ColumnFamily
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -ColumnFamilyRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -ColumnFamilyRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -ColumnFamilyRecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -ColumnFamilySchema
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -ColumnFamilySchema).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -ColumnFamilySchema
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -Keyspace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -Keyspace).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -Keyspace
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -Keyspaces
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -Keyspaces).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -Keyspaces
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -Source
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -Source).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -Source
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -Sources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -Sources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -Sources
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryCertificate -Certificate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCertificate -Certificate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCertificate -Certificate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCertificate -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCertificate -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCertificate -Cluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCertificate -ClusterWebSigned
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCertificate -ClusterWebSigned).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCertificate -ClusterWebSigned
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCertificate -SigningRequest
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCertificate -SigningRequest).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCertificate -SigningRequest
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCertificate -SigningRequests
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCertificate -SigningRequests).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCertificate -SigningRequests
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCertificate -WithKey
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCertificate -WithKey).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCertificate -WithKey
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryCloudAccount -CloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudAccount -CloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudAccount -CloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudAccount -CurrentFeaturePermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudAccount -CurrentFeaturePermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudAccount -CurrentFeaturePermissions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudAccount -ExocomputeMappings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudAccount -ExocomputeMappings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudAccount -ExocomputeMappings
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudAccount -LatestFeaturePermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudAccount -LatestFeaturePermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudAccount -LatestFeaturePermissions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryCloudNative -CheckArchivedSnapshotsLocked
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -CheckArchivedSnapshotsLocked).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -CheckArchivedSnapshotsLocked
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -CheckLabelRuleNameUniqueness
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -CheckLabelRuleNameUniqueness).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -CheckLabelRuleNameUniqueness
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -CheckRequiredPermissionsForFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -CheckRequiredPermissionsForFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -CheckRequiredPermissionsForFeature
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -CheckTagRuleNameUniqueness
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -CheckTagRuleNameUniqueness).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -CheckTagRuleNameUniqueness
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -CustomerTags
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -CustomerTags).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -CustomerTags
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -FileRecoveryEligibleSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -FileRecoveryEligibleSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -FileRecoveryEligibleSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -IsFileRecoveryFeasible
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -IsFileRecoveryFeasible).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -IsFileRecoveryFeasible
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -LabelKeys
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -LabelKeys).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -LabelKeys
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -LabelRules
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -LabelRules).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -LabelRules
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -LabelValues
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -LabelValues).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -LabelValues
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -RbaInstallers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -RbaInstallers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -RbaInstallers
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -SnapshotDetailsForRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -SnapshotDetailsForRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -SnapshotDetailsForRecovery
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -SnapshotTypeDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -SnapshotTypeDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -SnapshotTypeDetails
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -Snapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -Snapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -Snapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -SqlServerSetupScript
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -SqlServerSetupScript).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -SqlServerSetupScript
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -TagKeys
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -TagKeys).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -TagKeys
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -TagRules
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -TagRules).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -TagRules
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -TagValues
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -TagValues).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -TagValues
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCloudNative -WorkloadVersionedFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCloudNative -WorkloadVersionedFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCloudNative -WorkloadVersionedFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryCluster -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Cluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Connected
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Connected).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Connected
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -DatabaseLogReport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -DatabaseLogReport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -DatabaseLogReport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -DatabaseLogReportingProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -DatabaseLogReportingProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -DatabaseLogReportingProperties
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -DefaultGateway
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -DefaultGateway).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -DefaultGateway
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Dns
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Dns).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Dns
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -FloatingIps
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -FloatingIps).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -FloatingIps
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -GroupByList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -GroupByList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -GroupByList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -HostFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -HostFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -HostFailover
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Ipmi
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Ipmi).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Ipmi
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Ipv6Mode
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Ipv6Mode).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Ipv6Mode
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -IsTotpAckNecessary
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -IsTotpAckNecessary).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -IsTotpAckNecessary
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -List).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -List
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -NetworkInterfaces
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -NetworkInterfaces).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -NetworkInterfaces
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Nodes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Nodes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Nodes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -NtpServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -NtpServers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -NtpServers
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -OperationJobProgress
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -OperationJobProgress).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -OperationJobProgress
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Proxy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Proxy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Proxy
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -RegistrationProductInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -RegistrationProductInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -RegistrationProductInfo
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -ReplicationTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -ReplicationTargets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -ReplicationTargets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -ReportMigrationCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -ReportMigrationCount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -ReportMigrationCount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -ReportMigrationJobStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -ReportMigrationJobStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -ReportMigrationJobStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -ReportMigrationStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -ReportMigrationStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -ReportMigrationStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -TotpAckStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -TotpAckStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -TotpAckStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -TypeList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -TypeList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -TypeList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Vlans
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Vlans).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Vlans
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -WebCertsAndIpmis
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -WebCertsAndIpmis).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -WebCertsAndIpmis
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Windows
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Windows).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Windows
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryCluster -WithUpgradesInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -WithUpgradesInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -WithUpgradesInfo
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryDb2 -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -Database
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -Databases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -Instance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -Instance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -Instances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -Instances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -Instances
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -LogSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -LogSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -LogSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -LogSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -LogSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -LogSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -RecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -RecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -RecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -RecoverableRanges
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryDownload -CdmUpgradesPdf
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDownload -CdmUpgradesPdf).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDownload -CdmUpgradesPdf
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDownload -EdVersionList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDownload -EdVersionList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDownload -EdVersionList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryDownload -PackageStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDownload -PackageStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDownload -PackageStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryExchange -Dag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryExchange -Dag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryExchange -Dag
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryExchange -Dags
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryExchange -Dags).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryExchange -Dags
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryExchange -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryExchange -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryExchange -Database
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryExchange -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryExchange -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryExchange -Databases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryExchange -LiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryExchange -LiveMounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryExchange -LiveMounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryExchange -Server
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryExchange -Server).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryExchange -Server
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryExchange -Servers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryExchange -Servers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryExchange -Servers
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryFileset -Linux
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryFileset -Linux).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryFileset -Linux
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryFileset -RequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryFileset -RequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryFileset -RequestStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryFileset -Share
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryFileset -Share).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryFileset -Share
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryFileset -Template
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryFileset -Template).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryFileset -Template
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryFileset -Templates
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryFileset -Templates).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryFileset -Templates
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryFileset -Windows
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryFileset -Windows).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryFileset -Windows
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryGcp -CloudAccountMissingPermissionsForAddition
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -CloudAccountMissingPermissionsForAddition).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -CloudAccountMissingPermissionsForAddition
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -CloudAccountProjectsByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -CloudAccountProjectsByFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -CloudAccountProjectsByFeature
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -CloudAccountProjectsForOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -CloudAccountProjectsForOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -CloudAccountProjectsForOauth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -FeaturePermissionsForCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -FeaturePermissionsForCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -FeaturePermissionsForCloudAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -GetDefaultCredentialsServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -GetDefaultCredentialsServiceAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -GetDefaultCredentialsServiceAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeAvailableKmsCryptoKeys
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeAvailableKmsCryptoKeys).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeAvailableKmsCryptoKeys
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeCompatibleMachineTypes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeCompatibleMachineTypes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeCompatibleMachineTypes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeNetworks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeNetworks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeProjectsWithAccessibleNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeProjectsWithAccessibleNetworks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeProjectsWithAccessibleNetworks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeRegions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeStoredMachineTypes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeStoredMachineTypes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeStoredMachineTypes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeStoredMachineTypesInProject
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeStoredMachineTypesInProject).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeStoredMachineTypesInProject
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeStoredNetworkNames
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeStoredNetworkNames).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeStoredNetworkNames
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeStoredNetworkNamesInProject
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeStoredNetworkNamesInProject).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeStoredNetworkNamesInProject
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeStoredRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeStoredRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeStoredRegions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcp -NativeStoredRegionsInProject
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcp -NativeStoredRegionsInProject).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcp -NativeStoredRegionsInProject
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryGcpNative -Disk
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcpNative -Disk).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcpNative -Disk
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcpNative -Disks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcpNative -Disks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcpNative -Disks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcpNative -GceInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcpNative -GceInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcpNative -GceInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcpNative -GceInstances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcpNative -GceInstances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcpNative -GceInstances
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcpNative -Project
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcpNative -Project).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcpNative -Project
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcpNative -Projects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcpNative -Projects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcpNative -Projects
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryGcpNative -StoredDiskLocations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryGcpNative -StoredDiskLocations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryGcpNative -StoredDiskLocations
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryHost -Diagnosis
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHost -Diagnosis).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHost -Diagnosis
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHost -PhysicalHost
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHost -PhysicalHost).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHost -PhysicalHost
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHost -PhysicalHosts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHost -PhysicalHosts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHost -PhysicalHosts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHost -Search
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHost -Search).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHost -Search
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHost -Share
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHost -Share).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHost -Share
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHost -Shares
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHost -Shares).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHost -Shares
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryHyperv -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Cluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -HostAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -HostAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -HostAsyncRequestStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Mounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Mounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Mounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Scvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Scvmm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Scvmm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -ScvmmAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -ScvmmAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -ScvmmAsyncRequestStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Scvmms
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Scvmms).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Scvmms
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Server
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Server).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Server
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Servers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Servers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Servers
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -TopLevelDescendants
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -UniqueServersCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -UniqueServersCount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -UniqueServersCount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -VirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -VirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -VirtualMachine
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -VirtualMachineAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -VirtualMachineAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -VirtualMachineAsyncRequestStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -VirtualMachines
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -VirtualMachines).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -VirtualMachines
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -VmDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -VmDetail).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -VmDetail
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryK8s -AppManifest
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryK8s -AppManifest).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryK8s -AppManifest
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryK8s -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryK8s -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryK8s -Cluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryK8s -Clusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryK8s -Clusters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryK8s -Clusters
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryK8s -Namespace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryK8s -Namespace).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryK8s -Namespace
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryK8s -Namespaces
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryK8s -Namespaces).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryK8s -Namespaces
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryK8s -ReplicaSnapshotInfos
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryK8s -ReplicaSnapshotInfos).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryK8s -ReplicaSnapshotInfos
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryK8s -SnapshotInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryK8s -SnapshotInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryK8s -SnapshotInfo
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryLdap -AuthorizedPrincipalList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryLdap -AuthorizedPrincipalList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryLdap -AuthorizedPrincipalList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryLdap -IntegrationList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryLdap -IntegrationList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryLdap -IntegrationList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryLdap -PrincipalList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryLdap -PrincipalList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryLdap -PrincipalList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryM365 -Regions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryM365 -Regions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryM365 -Regions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryManagedVolume -InventoryStats
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryManagedVolume -InventoryStats).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryManagedVolume -InventoryStats
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryManagedVolume -LiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryManagedVolume -LiveMounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryManagedVolume -LiveMounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryManagedVolume -ManagedVolume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryManagedVolume -ManagedVolume).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryManagedVolume -ManagedVolume
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryManagedVolume -ManagedVolumes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryManagedVolume -ManagedVolumes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryManagedVolume -ManagedVolumes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryMongo -BulkRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -BulkRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -BulkRecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -BulkRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -BulkRecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -BulkRecoverableRanges
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Collection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Collection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Collection
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -CollectionRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -CollectionRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -CollectionRecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Collections
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Collections).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Collections
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Database
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Databases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -RecoverableRanges
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Source
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Source).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Source
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Sources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Sources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Sources
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryMosaic -BulkRecoveryRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMosaic -BulkRecoveryRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMosaic -BulkRecoveryRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMosaic -Snapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMosaic -Snapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMosaic -Snapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMosaic -Stores
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMosaic -Stores).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMosaic -Stores
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMosaic -Versions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMosaic -Versions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMosaic -Versions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryMssql -AvailabilityGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -AvailabilityGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -AvailabilityGroup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -CdmLogShippingTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -CdmLogShippingTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -CdmLogShippingTarget
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -CdmLogShippingTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -CdmLogShippingTargets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -CdmLogShippingTargets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -CompatibleInstances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -CompatibleInstances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -CompatibleInstances
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -Database
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseLiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseLiveMounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseLiveMounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseMissedRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseMissedRecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseMissedRecoverableRanges
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseMissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseMissedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseMissedSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseRestoreEstimate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseRestoreEstimate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseRestoreEstimate
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseRestoreFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseRestoreFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseRestoreFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -Databases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DefaultProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DefaultProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DefaultProperties
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -Instance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -Instance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -LogShippingTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -LogShippingTargets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -LogShippingTargets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -RecoverableRanges
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMssql -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -TopLevelDescendants
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryNas -Fileset
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNas -Fileset).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNas -Fileset
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNas -Namespace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNas -Namespace).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNas -Namespace
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNas -Namespaces
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNas -Namespaces).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNas -Namespaces
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNas -Share
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNas -Share).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNas -Share
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNas -System
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNas -System).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNas -System
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNas -Systems
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNas -Systems).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNas -Systems
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNas -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNas -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNas -TopLevelDescendants
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNas -Volume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNas -Volume).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNas -Volume
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryNutanix -BrowseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -BrowseSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -BrowseSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Category
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Category).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Category
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -CategoryValue
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -CategoryValue).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -CategoryValue
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Cluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -ClusterAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -ClusterAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -ClusterAsyncRequestStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -ClusterContainers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -ClusterContainers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -ClusterContainers
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -ClusterNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -ClusterNetworks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -ClusterNetworks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Clusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Clusters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Clusters
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Mounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Mounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Mounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -PrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -PrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -PrismCentral
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -PrismCentrals
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -PrismCentrals).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -PrismCentrals
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -SearchVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -SearchVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -SearchVm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -SnapshotDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -SnapshotDetail).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -SnapshotDetail
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -TopLevelDescendants
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Vm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Vm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Vm
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -VmAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -VmAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -VmAsyncRequestStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -VmMissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -VmMissedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -VmMissedSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Vms
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Vms).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Vms
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryO365 -AdGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -AdGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -AdGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -BrowseTeamConvChannels
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -BrowseTeamConvChannels).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -BrowseTeamConvChannels
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Calendar
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Calendar).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Calendar
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Groups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Groups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Groups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -License
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -License).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -License
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -ListApps
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -ListApps).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -ListApps
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Mailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Mailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Mailbox
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Mailboxes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Mailboxes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Mailboxes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -ObjectAncestors
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -ObjectAncestors).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -ObjectAncestors
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Onedrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Onedrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Onedrive
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Onedrives
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Onedrives).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Onedrives
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Org
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Org).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Org
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -OrgAtSnappableLevel
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -OrgAtSnappableLevel).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -OrgAtSnappableLevel
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -OrgStatuses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -OrgStatuses).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -OrgStatuses
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -OrgSummaries
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -OrgSummaries).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -OrgSummaries
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Orgs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Orgs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Orgs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -ServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -ServiceAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -ServiceAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -ServiceStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -ServiceStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -ServiceStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointDrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointDrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointDrive
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointDrives
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointDrives).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointDrives
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointLists
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointLists).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointLists
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointObjectList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointObjectList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointObjectList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointObjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointObjects
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointSite
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointSite).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointSite
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointSites
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointSites).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointSites
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Site
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Site).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Site
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Sites
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Sites).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Sites
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -StorageStats
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -StorageStats).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -StorageStats
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SubscriptionsAppTypeCounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SubscriptionsAppTypeCounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SubscriptionsAppTypeCounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Team
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Team).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Team
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -TeamChannels
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -TeamChannels).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -TeamChannels
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -TeamConversationsFolderID
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -TeamConversationsFolderID).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -TeamConversationsFolderID
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -TeamPostedBy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -TeamPostedBy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -TeamPostedBy
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Teams
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Teams).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Teams
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -User
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -User).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -User
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -UserObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -UserObjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -UserObjects
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryOracle -AcoExampleDownloadLink
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -AcoExampleDownloadLink).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -AcoExampleDownloadLink
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -AcoParameters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -AcoParameters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -AcoParameters
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -DataGuardGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -DataGuardGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -DataGuardGroup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -Database
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -DatabaseLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -DatabaseLogBackupConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -DatabaseLogBackupConfig
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -Databases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -Host
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -Host).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -Host
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -HostLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -HostLogBackupConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -HostLogBackupConfig
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -LiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -LiveMounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -LiveMounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -MissedRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -MissedRecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -MissedRecoverableRanges
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -MissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -MissedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -MissedSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -PdbDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -PdbDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -PdbDetails
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -Rac
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -Rac).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -Rac
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -RacLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -RacLogBackupConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -RacLogBackupConfig
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -RecoverableRanges
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryOracle -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -TopLevelDescendants
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryPolicy -Details
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryPolicy -Details).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryPolicy -Details
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryPolicy -Obj
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryPolicy -Obj).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryPolicy -Obj
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryPolicy -ObjectUsages
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryPolicy -ObjectUsages).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryPolicy -ObjectUsages
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryPolicy -Objs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryPolicy -Objs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryPolicy -Objs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryPolicy -Policies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryPolicy -Policies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryPolicy -Policies
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryPolicy -Policy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryPolicy -Policy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryPolicy -Policy
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryRansomware -DetectionWorkloadLocations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -DetectionWorkloadLocations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -DetectionWorkloadLocations
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -InvestigationAnalysisSummary
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -InvestigationAnalysisSummary).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -InvestigationAnalysisSummary
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -InvestigationEnablement
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -InvestigationEnablement).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -InvestigationEnablement
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -InvestigationWorkloadScannedCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -InvestigationWorkloadScannedCount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -InvestigationWorkloadScannedCount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -OverallInvestigationSummary
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -OverallInvestigationSummary).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -OverallInvestigationSummary
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -PendingInvestigationResultsCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -PendingInvestigationResultsCount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -PendingInvestigationResultsCount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -ProcessedInvestigationWorkloadCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -ProcessedInvestigationWorkloadCount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -ProcessedInvestigationWorkloadCount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -ProtectedInvestigationWorkloadCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -ProtectedInvestigationWorkloadCount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -ProtectedInvestigationWorkloadCount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -Result
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -Result).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -Result
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -ResultOpt
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -ResultOpt).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -ResultOpt
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -Results
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -Results).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -Results
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRansomware -ResultsGrouped
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRansomware -ResultsGrouped).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRansomware -ResultsGrouped
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryRcs -ArchivalLocationsConsumptionStats
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRcs -ArchivalLocationsConsumptionStats).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRcs -ArchivalLocationsConsumptionStats
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRcs -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRcs -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRcs -Cluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryRcs -Dhcores
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRcs -Dhcores).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRcs -Dhcores
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryRcv -AccountEntitlement
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryRcv -AccountEntitlement).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryRcv -AccountEntitlement
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryReplication -IncomingStats
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryReplication -IncomingStats).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryReplication -IncomingStats
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryReplication -OutgoingStats
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryReplication -OutgoingStats).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryReplication -OutgoingStats
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryReplication -Pairs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryReplication -Pairs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryReplication -Pairs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryReplication -ValidTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryReplication -ValidTargets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryReplication -ValidTargets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryReport -Data
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryReport -Data).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryReport -Data
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryReport -Scheduled
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryReport -Scheduled).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryReport -Scheduled
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQuerySapHana -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySapHana -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySapHana -Database
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySapHana -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySapHana -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySapHana -Databases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySapHana -LogSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySapHana -LogSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySapHana -LogSnapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySapHana -LogSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySapHana -LogSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySapHana -LogSnapshots
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySapHana -RecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySapHana -RecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySapHana -RecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySapHana -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySapHana -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySapHana -RecoverableRanges
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySapHana -System
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySapHana -System).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySapHana -System
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySapHana -Systems
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySapHana -Systems).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySapHana -Systems
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryServiceAccount -ServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryServiceAccount -ServiceAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryServiceAccount -ServiceAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQuerySharepoint -BrowseDrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySharepoint -BrowseDrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySharepoint -BrowseDrive
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySharepoint -BrowseList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySharepoint -BrowseList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySharepoint -BrowseList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySharepoint -SiteDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySharepoint -SiteDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySharepoint -SiteDescendants
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySharepoint -SiteExclusions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySharepoint -SiteExclusions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySharepoint -SiteExclusions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySharepoint -SiteSearch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySharepoint -SiteSearch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySharepoint -SiteSearch
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySharepoint -SnappableDriveSearch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySharepoint -SnappableDriveSearch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySharepoint -SnappableDriveSearch
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySharepoint -SnappableListSearch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySharepoint -SnappableListSearch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySharepoint -SnappableListSearch
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySharepoint -SnapshotDriveSearch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySharepoint -SnapshotDriveSearch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySharepoint -SnapshotDriveSearch
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQuerySla -AuditDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -AuditDetail).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -AuditDetail
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -ClusterDomains
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -ClusterDomains).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -ClusterDomains
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -ClusterGlobals
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -ClusterGlobals).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -ClusterGlobals
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -ConflictObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -ConflictObjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -ConflictObjects
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -CountOfObjectsProtected
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -CountOfObjectsProtected).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -CountOfObjectsProtected
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -Domain
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -Domain).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -Domain
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -Domains
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -Domains).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -Domains
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -GlobalFilterList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -GlobalFilterList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -GlobalFilterList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -GlobalStatuses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -GlobalStatuses).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -GlobalStatuses
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -ManagedVolume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -ManagedVolume).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -ManagedVolume
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -ManagedVolumes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -ManagedVolumes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -ManagedVolumes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -NcdComplianceData
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -NcdComplianceData).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -NcdComplianceData
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -SummariesByIds
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -SummariesByIds).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -SummariesByIds
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -VerifyWithReplicationToCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -VerifyWithReplicationToCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -VerifyWithReplicationToCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQuerySmb -Configuration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySmb -Configuration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySmb -Configuration
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySmb -Domains
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySmb -Domains).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySmb -Domains
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQuerySnapshot -BrowseFileList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -BrowseFileList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -BrowseFileList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -ClosestToPointInTime
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -ClosestToPointInTime).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -ClosestToPointInTime
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -EmailSearch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -EmailSearch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -EmailSearch
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -EventSearch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -EventSearch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -EventSearch
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -FilesDelta
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -FilesDelta).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -FilesDelta
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -FilesDeltaV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -FilesDeltaV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -FilesDeltaV2
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -Fileset
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -Fileset).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -Fileset
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -FilesetFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -FilesetFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -FilesetFiles
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -LegalHoldSnappable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -LegalHoldSnappable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -LegalHoldSnappable
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -OnedriveSearch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -OnedriveSearch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -OnedriveSearch
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -Polaris
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -Polaris).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -Polaris
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -Pvcs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -Pvcs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -Pvcs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -QuarantinedDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -QuarantinedDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -QuarantinedDetails
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -Results
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -Results).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -Results
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -SnappableList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -SnappableList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -SnappableList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -SnappablesList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -SnappablesList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -SnappablesList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -SnappablesWithLegalHoldsSummary
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -SnappablesWithLegalHoldsSummary).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -SnappablesWithLegalHoldsSummary
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -Snapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -Snapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -Snapshot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -UnmanagedObject
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -UnmanagedObject).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -UnmanagedObject
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -VappInstantRecoveryOptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -VappInstantRecoveryOptions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -VappInstantRecoveryOptions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySnapshot -VappTemplateExportOptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySnapshot -VappTemplateExportOptions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySnapshot -VappTemplateExportOptions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQuerySonar -ContentReport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySonar -ContentReport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySonar -ContentReport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySonar -Report
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySonar -Report).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySonar -Report
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySonar -ReportRow
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySonar -ReportRow).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySonar -ReportRow
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySonar -UserGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySonar -UserGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySonar -UserGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySonar -Users
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySonar -Users).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySonar -Users
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryStorageArray -StorageArray
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryStorageArray -StorageArray).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryStorageArray -StorageArray
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryThreat -HuntDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryThreat -HuntDetail).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryThreat -HuntDetail
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryThreat -HuntResult
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryThreat -HuntResult).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryThreat -HuntResult
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryThreat -HuntSummary
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryThreat -HuntSummary).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryThreat -HuntSummary
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryThreat -Hunts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryThreat -Hunts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryThreat -Hunts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryVcenter -AdvancedTagPreview
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -AdvancedTagPreview).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -AdvancedTagPreview
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -HotAddBandwidth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -HotAddBandwidth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -HotAddBandwidth
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -HotAddNetwork
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -HotAddNetwork).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -HotAddNetwork
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -HotAddProxy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -HotAddProxy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -HotAddProxy
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -List).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -List
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -Networks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -Networks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -Networks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -NumProxiesNeeded
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -NumProxiesNeeded).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -NumProxiesNeeded
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -PreAddInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -PreAddInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -PreAddInfo
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -Vcenter
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -Vcenter).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -Vcenter
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryVsphere -ComputeCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -ComputeCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -ComputeCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -ComputeClusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -ComputeClusters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -ComputeClusters
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Datacenter
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Datacenter).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Datacenter
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Datastore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Datastore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Datastore
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -DatastoreCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -DatastoreCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -DatastoreCluster
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -DatastoreClusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -DatastoreClusters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -DatastoreClusters
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -DatastoreList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -DatastoreList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -DatastoreList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Folder
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Folder).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Folder
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Folders
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Folders).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Folders
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Host
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Host).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Host
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -HostDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -HostDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -HostDetails
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -HostList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -HostList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -HostList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -HostsByFids
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -HostsByFids).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -HostsByFids
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -LiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -LiveMounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -LiveMounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Mount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Mount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Mount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -MountList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -MountList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -MountList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Network
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Network).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Network
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -ResourcePool
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -ResourcePool).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -ResourcePool
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -RootRecoveryHierarchy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -RootRecoveryHierarchy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -RootRecoveryHierarchy
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Tag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Tag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Tag
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -TagCategory
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -TagCategory).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -TagCategory
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -TopLevelDescendantsList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -TopLevelDescendantsList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -TopLevelDescendantsList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -VmwareCdpLiveInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -VmwareCdpLiveInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -VmwareCdpLiveInfo
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryVsphereVm -AsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -AsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -AsyncRequestStatus
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -MissedRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -MissedRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -MissedRecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -New
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -New).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -New
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -NewList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -NewList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -NewList
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -RecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -RecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -RecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -RecoverableRangeInBatch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -RecoverableRangeInBatch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -RecoverableRangeInBatch
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


# -------------------------------------------------------------------
# New-RscQueryWebhook -Webhook
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryWebhook -Webhook).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryWebhook -Webhook
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

