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
# New-RscMutationAws -ExcludeNativeEbsVolumesFromSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -ExcludeNativeEbsVolumesFromSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -ExcludeNativeEbsVolumesFromSnapshot
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
# New-RscMutationAws -StartCreateNativeEbsVolumeSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartCreateNativeEbsVolumeSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartCreateNativeEbsVolumeSnapshotsJob
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
# New-RscMutationAws -StartExportNativeEbsVolumeSnapshotJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartExportNativeEbsVolumeSnapshotJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartExportNativeEbsVolumeSnapshotJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartNativeAccountDisableJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartNativeAccountDisableJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartNativeAccountDisableJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartNativeEc2InstanceSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartNativeEc2InstanceSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartNativeEc2InstanceSnapshotsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartNativeRdsInstanceSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartNativeRdsInstanceSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartNativeRdsInstanceSnapshotsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartRefreshNativeAccountsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartRefreshNativeAccountsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartRefreshNativeAccountsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartRestoreNativeEc2InstanceSnapshotJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartRestoreNativeEc2InstanceSnapshotJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartRestoreNativeEc2InstanceSnapshotJob
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
# New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot
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
# New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob
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
# New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartExportNativeManagedDiskJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartExportNativeManagedDiskJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartExportNativeManagedDiskJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartExportNativeVirtualMachineJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartExportNativeVirtualMachineJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartExportNativeVirtualMachineJob
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
# New-RscMutationAzure -StartRefreshNativeSubscriptionsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartRefreshNativeSubscriptionsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartRefreshNativeSubscriptionsJob
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartRestoreNativeVirtualMachineJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartRestoreNativeVirtualMachineJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartRestoreNativeVirtualMachineJob
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
# New-RscMutationCluster -ArchiveK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -ArchiveK8s).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -ArchiveK8s
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
# New-RscMutationCluster -CreateK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -CreateK8s).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -CreateK8s
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
# New-RscMutationCluster -RefreshK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -RefreshK8s).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -RefreshK8s
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
# New-RscMutationMongo -AssignSlaToDbCollection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -AssignSlaToDbCollection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -AssignSlaToDbCollection
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -BulkDeletedbSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -BulkDeletedbSources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -BulkDeletedbSources
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscMutationMongo -CreatedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -CreatedbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -CreatedbSource
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
# New-RscMutationMongo -DeletedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -DeletedbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -DeletedbSource
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
# New-RscMutationMongo -RecoverdbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -RecoverdbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -RecoverdbSource
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
# New-RscMutationMongo -UpdatedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -UpdatedbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -UpdatedbSource
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
# New-RscQueryAccount -WithExocomputeMappings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -WithExocomputeMappings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -WithExocomputeMappings
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
# New-RscQueryAws -AllAvailabilityZonesByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllAvailabilityZonesByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllAvailabilityZonesByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllCdmVersions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllCdmVersions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllCdmVersions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllCloudAccountConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllCloudAccountConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllCloudAccountConfigs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllCloudAccountsWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllCloudAccountsWithFeatures).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllCloudAccountsWithFeatures
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllComputeSettings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllComputeSettings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllComputeSettings
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllDbParameterGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllDbParameterGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllDbParameterGroupsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllDbSubnetGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllDbSubnetGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllDbSubnetGroupsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllEc2KeyPairsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllEc2KeyPairsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllEc2KeyPairsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllExocomputeConfigs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllInstanceProfileNames
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllInstanceProfileNames).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllInstanceProfileNames
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllKmsEncryptionKeysByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllKmsEncryptionKeysByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllKmsEncryptionKeysByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllOptionGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllOptionGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllOptionGroupsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllPermissionPolicies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllPermissionPolicies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllPermissionPolicies
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllRegions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllS3Buckets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllS3Buckets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllS3Buckets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllS3BucketsDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllS3BucketsDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllS3BucketsDetails
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllVpcs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllVpcs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllVpcs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllVpcsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllVpcsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllVpcsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport
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
# New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid
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
# New-RscQueryAws -NativeAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeAccounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeAccounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEbsVolume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEbsVolume).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEbsVolume
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEbsVolumes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEbsVolumes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEbsVolumes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEbsVolumesByName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEbsVolumesByName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEbsVolumesByName
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEc2Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEc2Instance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEc2Instance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEc2Instances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEc2Instances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEc2Instances
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEc2InstancesByName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEc2InstancesByName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEc2InstancesByName
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRdsExportDefaults
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRdsExportDefaults).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRdsExportDefaults
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRdsInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRdsInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRdsInstance
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRdsInstances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRdsInstances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRdsInstances
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRdsPointInTimeRestoreWindow
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRdsPointInTimeRestoreWindow).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRdsPointInTimeRestoreWindow
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRoot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRoot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRoot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeS3Bucket
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeS3Bucket).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeS3Bucket
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
# New-RscQueryAws -ValidateNativeRdsClusterNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ValidateNativeRdsClusterNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ValidateNativeRdsClusterNameForExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAws -ValidateNativeRdsInstanceNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ValidateNativeRdsInstanceNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ValidateNativeRdsInstanceNameForExport
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
# New-RscQueryAzure -AllArmTemplatesByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllArmTemplatesByFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllArmTemplatesByFeature
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCdmVersions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCdmVersions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCdmVersions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCloudAccountMissingPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCloudAccountMissingPermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCloudAccountMissingPermissions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCloudAccountSubnetsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCloudAccountSubnetsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCloudAccountSubnetsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCloudAccountTenants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCloudAccountTenants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCloudAccountTenants
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllDiskEncryptionSetsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllDiskEncryptionSetsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllDiskEncryptionSetsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllEncryptionKeys
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllEncryptionKeys).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllEncryptionKeys
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllExocomputeConfigsInAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllExocomputeConfigsInAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllExocomputeConfigsInAccount
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllHostedRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllHostedRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllHostedRegions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllKeyVaultsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllKeyVaultsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllKeyVaultsByRegion
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllManagedIdentities
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllManagedIdentities).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllManagedIdentities
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeStorageAccountsFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeStorageAccountsFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeStorageAccountsFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeVirtualMachineSizes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeVirtualMachineSizes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeVirtualMachineSizes
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeVirtualNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeVirtualNetworks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeVirtualNetworks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNsgs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNsgs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNsgs
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllRegions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllResourceGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllResourceGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllResourceGroupsFrom
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllResourceGroupsFrom).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllResourceGroupsFrom
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllSqlDatabaseServerElasticPools
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllSqlDatabaseServerElasticPools).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllSqlDatabaseServerElasticPools
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllStorageAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllStorageAccounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllStorageAccounts
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllSubnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllSubnets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllSubnets
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllSubscriptionWithExocomputeMappings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllSubscriptionWithExocomputeMappings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllSubscriptionWithExocomputeMappings
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllVnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllVnets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllVnets
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
# New-RscQueryAzure -DoesNativeResourceGroupExist
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -DoesNativeResourceGroupExist).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -DoesNativeResourceGroupExist
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent
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
# New-RscQueryAzure -NativeManagedDisk
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeManagedDisk).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeManagedDisk
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeManagedDisks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeManagedDisks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeManagedDisks
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeResourceGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeResourceGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeResourceGroup
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeResourceGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeResourceGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeRoot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeRoot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeRoot
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeSubscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeSubscription
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeSubscriptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeSubscriptions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeSubscriptions
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeVirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeVirtualMachine
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeVirtualMachines
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeVirtualMachines).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeVirtualMachines
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
# New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport
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
# New-RscQueryCluster -Certificates
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Certificates).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Certificates
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
# New-RscQueryCluster -Csr
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Csr).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Csr
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
# New-RscQueryCluster -GlobalSlas
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -GlobalSlas).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -GlobalSlas
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
# New-RscQueryCluster -K8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -K8s).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -K8s
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
# New-RscQueryCluster -SlaDomains
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -SlaDomains).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -SlaDomains
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
# New-RscQueryCluster -VerifySlaWithReplicationTo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -VerifySlaWithReplicationTo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -VerifySlaWithReplicationTo
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
# New-RscQueryCluster -WebSignedCertificate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -WebSignedCertificate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -WebSignedCertificate
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
# New-RscQueryMongo -DbBulkRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbBulkRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbBulkRecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbCollection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbCollection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbCollection
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbCollectionRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbCollectionRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbCollectionRecoverableRange
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbCollections
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbCollections).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbCollections
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbDatabase
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbDatabases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbDatabases
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbSource
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbSources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbSources
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
# New-RscQueryMssql -AllDatabaseRestoreFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -AllDatabaseRestoreFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -AllDatabaseRestoreFiles
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
# New-RscQueryO365 -AllAdGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -AllAdGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -AllAdGroups
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -AllOrgStatuses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -AllOrgStatuses).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -AllOrgStatuses
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQueryO365 -AllSubscriptionsAppTypeCounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -AllSubscriptionsAppTypeCounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -AllSubscriptionsAppTypeCounts
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
# New-RscQuerySla -AllNcdComplianceData
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -AllNcdComplianceData).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -AllNcdComplianceData
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}

# -------------------------------------------------------------------
# New-RscQuerySla -AllSummariesByIds
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -AllSummariesByIds).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -AllSummariesByIds
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

