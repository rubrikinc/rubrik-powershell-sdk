# This file was generated for the RSC PowerShell SDK
param(
    [switch]$GetGqlRequest,
    [switch]$FieldCounts
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

$entries = @()

# -------------------------------------------------------------------
# New-RscMutationAccount -DeleteUsers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAccount -Operation DeleteUsers).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAccount -Operation DeleteUsers
    $entries += @{
        Operation="New-RscMutationAccount -DeleteUsers" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAccount -Operation DeleteUsers
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
    (New-RscMutationActivitySeries -Operation Cancel).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationActivitySeries -Operation Cancel
    $entries += @{
        Operation="New-RscMutationActivitySeries -Cancel" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationActivitySeries -Operation Cancel
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
    (New-RscMutationActivitySeries -Operation DownloadUserCsv).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationActivitySeries -Operation DownloadUserCsv
    $entries += @{
        Operation="New-RscMutationActivitySeries -DownloadUserCsv" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationActivitySeries -Operation DownloadUserCsv
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
    (New-RscMutationActivitySeries -Operation DownloadUserFileCsv).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationActivitySeries -Operation DownloadUserFileCsv
    $entries += @{
        Operation="New-RscMutationActivitySeries -DownloadUserFileCsv" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationActivitySeries -Operation DownloadUserFileCsv
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
    (New-RscMutationAws -Operation AddAuthenticationServerBasedCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation AddAuthenticationServerBasedCloudAccount
    $entries += @{
        Operation="New-RscMutationAws -AddAuthenticationServerBasedCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation AddAuthenticationServerBasedCloudAccount
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
    (New-RscMutationAws -Operation AddIamUserBasedCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation AddIamUserBasedCloudAccount
    $entries += @{
        Operation="New-RscMutationAws -AddIamUserBasedCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation AddIamUserBasedCloudAccount
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
    (New-RscMutationAws -Operation BulkDeleteCloudAccountWithoutCft).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation BulkDeleteCloudAccountWithoutCft
    $entries += @{
        Operation="New-RscMutationAws -BulkDeleteCloudAccountWithoutCft" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation BulkDeleteCloudAccountWithoutCft
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
    (New-RscMutationAws -Operation CreateAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation CreateAccount
    $entries += @{
        Operation="New-RscMutationAws -CreateAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation CreateAccount
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
    (New-RscMutationAws -Operation CreateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation CreateAutomaticTargetMapping
    $entries += @{
        Operation="New-RscMutationAws -CreateAutomaticTargetMapping" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation CreateAutomaticTargetMapping
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
    (New-RscMutationAws -Operation CreateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation CreateCloudNativeStorageSetting
    $entries += @{
        Operation="New-RscMutationAws -CreateCloudNativeStorageSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation CreateCloudNativeStorageSetting
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
    (New-RscMutationAws -Operation CreateCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation CreateCluster
    $entries += @{
        Operation="New-RscMutationAws -CreateCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation CreateCluster
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
    (New-RscMutationAws -Operation CreateComputeSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation CreateComputeSetting
    $entries += @{
        Operation="New-RscMutationAws -CreateComputeSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation CreateComputeSetting
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
    (New-RscMutationAws -Operation CreateExocomputeConfigs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation CreateExocomputeConfigs
    $entries += @{
        Operation="New-RscMutationAws -CreateExocomputeConfigs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation CreateExocomputeConfigs
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
    (New-RscMutationAws -Operation CreateReaderTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation CreateReaderTarget
    $entries += @{
        Operation="New-RscMutationAws -CreateReaderTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation CreateReaderTarget
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
    (New-RscMutationAws -Operation CreateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation CreateTarget
    $entries += @{
        Operation="New-RscMutationAws -CreateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation CreateTarget
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
    (New-RscMutationAws -Operation DeleteCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation DeleteCluster
    $entries += @{
        Operation="New-RscMutationAws -DeleteCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation DeleteCluster
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
    (New-RscMutationAws -Operation DeleteComputeSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation DeleteComputeSetting
    $entries += @{
        Operation="New-RscMutationAws -DeleteComputeSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation DeleteComputeSetting
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
    (New-RscMutationAws -Operation DeleteExocomputeConfigs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation DeleteExocomputeConfigs
    $entries += @{
        Operation="New-RscMutationAws -DeleteExocomputeConfigs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation DeleteExocomputeConfigs
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
    (New-RscMutationAws -Operation FinalizeCloudAccountDeletion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation FinalizeCloudAccountDeletion
    $entries += @{
        Operation="New-RscMutationAws -FinalizeCloudAccountDeletion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation FinalizeCloudAccountDeletion
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
    (New-RscMutationAws -Operation FinalizeCloudAccountProtection).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation FinalizeCloudAccountProtection
    $entries += @{
        Operation="New-RscMutationAws -FinalizeCloudAccountProtection" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation FinalizeCloudAccountProtection
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
    (New-RscMutationAws -Operation PatchAuthenticationServerBasedCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation PatchAuthenticationServerBasedCloudAccount
    $entries += @{
        Operation="New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation PatchAuthenticationServerBasedCloudAccount
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
    (New-RscMutationAws -Operation PatchIamUserBasedCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation PatchIamUserBasedCloudAccount
    $entries += @{
        Operation="New-RscMutationAws -PatchIamUserBasedCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation PatchIamUserBasedCloudAccount
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
    (New-RscMutationAws -Operation PrepareCloudAccountDeletion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation PrepareCloudAccountDeletion
    $entries += @{
        Operation="New-RscMutationAws -PrepareCloudAccountDeletion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation PrepareCloudAccountDeletion
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
    (New-RscMutationAws -Operation PrepareFeatureUpdateForCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation PrepareFeatureUpdateForCloudAccount
    $entries += @{
        Operation="New-RscMutationAws -PrepareFeatureUpdateForCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation PrepareFeatureUpdateForCloudAccount
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
    (New-RscMutationAws -Operation RegisterFeatureArtifacts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation RegisterFeatureArtifacts
    $entries += @{
        Operation="New-RscMutationAws -RegisterFeatureArtifacts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation RegisterFeatureArtifacts
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
    (New-RscMutationAws -Operation StartExocomputeDisableJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation StartExocomputeDisableJob
    $entries += @{
        Operation="New-RscMutationAws -StartExocomputeDisableJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation StartExocomputeDisableJob
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
    (New-RscMutationAws -Operation UpdateAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpdateAccount
    $entries += @{
        Operation="New-RscMutationAws -UpdateAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpdateAccount
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
    (New-RscMutationAws -Operation UpdateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpdateAutomaticTargetMapping
    $entries += @{
        Operation="New-RscMutationAws -UpdateAutomaticTargetMapping" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpdateAutomaticTargetMapping
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
    (New-RscMutationAws -Operation UpdateCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpdateCloudAccount
    $entries += @{
        Operation="New-RscMutationAws -UpdateCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpdateCloudAccount
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
    (New-RscMutationAws -Operation UpdateCloudAccountFeature).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpdateCloudAccountFeature
    $entries += @{
        Operation="New-RscMutationAws -UpdateCloudAccountFeature" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpdateCloudAccountFeature
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
    (New-RscMutationAws -Operation UpdateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpdateCloudNativeStorageSetting
    $entries += @{
        Operation="New-RscMutationAws -UpdateCloudNativeStorageSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpdateCloudNativeStorageSetting
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
    (New-RscMutationAws -Operation UpdateComputeSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpdateComputeSetting
    $entries += @{
        Operation="New-RscMutationAws -UpdateComputeSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpdateComputeSetting
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
    (New-RscMutationAws -Operation UpdateExocomputeConfigs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpdateExocomputeConfigs
    $entries += @{
        Operation="New-RscMutationAws -UpdateExocomputeConfigs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpdateExocomputeConfigs
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
    (New-RscMutationAws -Operation UpdateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpdateTarget
    $entries += @{
        Operation="New-RscMutationAws -UpdateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpdateTarget
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
    (New-RscMutationAws -Operation UpgradeCloudAccountFeaturesWithoutCft).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpgradeCloudAccountFeaturesWithoutCft
    $entries += @{
        Operation="New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpgradeCloudAccountFeaturesWithoutCft
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
    (New-RscMutationAws -Operation UpgradeIamUserBasedCloudAccountPermissions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation UpgradeIamUserBasedCloudAccountPermissions
    $entries += @{
        Operation="New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation UpgradeIamUserBasedCloudAccountPermissions
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
    (New-RscMutationAws -Operation ValidateAndCreateCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAws -Operation ValidateAndCreateCloudAccount
    $entries += @{
        Operation="New-RscMutationAws -ValidateAndCreateCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAws -Operation ValidateAndCreateCloudAccount
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
    (New-RscMutationAwsNative -Operation ExcludeEbsVolumesFromSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAwsNative -Operation ExcludeEbsVolumesFromSnapshot
    $entries += @{
        Operation="New-RscMutationAwsNative -ExcludeEbsVolumesFromSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAwsNative -Operation ExcludeEbsVolumesFromSnapshot
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
    (New-RscMutationAwsNative -Operation StartAccountDisableJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAwsNative -Operation StartAccountDisableJob
    $entries += @{
        Operation="New-RscMutationAwsNative -StartAccountDisableJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAwsNative -Operation StartAccountDisableJob
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
    (New-RscMutationAwsNative -Operation StartCreateEbsVolumeSnapshotsJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAwsNative -Operation StartCreateEbsVolumeSnapshotsJob
    $entries += @{
        Operation="New-RscMutationAwsNative -StartCreateEbsVolumeSnapshotsJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAwsNative -Operation StartCreateEbsVolumeSnapshotsJob
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
    (New-RscMutationAwsNative -Operation StartEc2InstanceSnapshotsJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAwsNative -Operation StartEc2InstanceSnapshotsJob
    $entries += @{
        Operation="New-RscMutationAwsNative -StartEc2InstanceSnapshotsJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAwsNative -Operation StartEc2InstanceSnapshotsJob
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
    (New-RscMutationAwsNative -Operation StartExportEbsVolumeSnapshotJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAwsNative -Operation StartExportEbsVolumeSnapshotJob
    $entries += @{
        Operation="New-RscMutationAwsNative -StartExportEbsVolumeSnapshotJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAwsNative -Operation StartExportEbsVolumeSnapshotJob
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
    (New-RscMutationAwsNative -Operation StartRdsInstanceSnapshotsJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAwsNative -Operation StartRdsInstanceSnapshotsJob
    $entries += @{
        Operation="New-RscMutationAwsNative -StartRdsInstanceSnapshotsJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAwsNative -Operation StartRdsInstanceSnapshotsJob
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
    (New-RscMutationAwsNative -Operation StartRefreshAccountsJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAwsNative -Operation StartRefreshAccountsJob
    $entries += @{
        Operation="New-RscMutationAwsNative -StartRefreshAccountsJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAwsNative -Operation StartRefreshAccountsJob
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
    (New-RscMutationAwsNative -Operation StartRestoreEc2InstanceSnapshotJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAwsNative -Operation StartRestoreEc2InstanceSnapshotJob
    $entries += @{
        Operation="New-RscMutationAwsNative -StartRestoreEc2InstanceSnapshotJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAwsNative -Operation StartRestoreEc2InstanceSnapshotJob
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
    (New-RscMutationAzure -Operation AddCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation AddCloudAccount
    $entries += @{
        Operation="New-RscMutationAzure -AddCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation AddCloudAccount
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
    (New-RscMutationAzure -Operation AddCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation AddCloudAccountExocomputeConfigurations
    $entries += @{
        Operation="New-RscMutationAzure -AddCloudAccountExocomputeConfigurations" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation AddCloudAccountExocomputeConfigurations
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
    (New-RscMutationAzure -Operation AddCloudAccountWithoutOauth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation AddCloudAccountWithoutOauth
    $entries += @{
        Operation="New-RscMutationAzure -AddCloudAccountWithoutOauth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation AddCloudAccountWithoutOauth
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
    (New-RscMutationAzure -Operation BackupAdDirectory).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation BackupAdDirectory
    $entries += @{
        Operation="New-RscMutationAzure -BackupAdDirectory" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation BackupAdDirectory
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
    (New-RscMutationAzure -Operation CompleteAdAppSetup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CompleteAdAppSetup
    $entries += @{
        Operation="New-RscMutationAzure -CompleteAdAppSetup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CompleteAdAppSetup
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
    (New-RscMutationAzure -Operation CompleteAdAppUpdate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CompleteAdAppUpdate
    $entries += @{
        Operation="New-RscMutationAzure -CompleteAdAppUpdate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CompleteAdAppUpdate
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
    (New-RscMutationAzure -Operation CompleteCloudAccountOauth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CompleteCloudAccountOauth
    $entries += @{
        Operation="New-RscMutationAzure -CompleteCloudAccountOauth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CompleteCloudAccountOauth
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
    (New-RscMutationAzure -Operation CreateAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CreateAccount
    $entries += @{
        Operation="New-RscMutationAzure -CreateAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CreateAccount
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
    (New-RscMutationAzure -Operation CreateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CreateAutomaticTargetMapping
    $entries += @{
        Operation="New-RscMutationAzure -CreateAutomaticTargetMapping" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CreateAutomaticTargetMapping
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
    (New-RscMutationAzure -Operation CreateCloudNativeRcvStorageSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CreateCloudNativeRcvStorageSetting
    $entries += @{
        Operation="New-RscMutationAzure -CreateCloudNativeRcvStorageSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CreateCloudNativeRcvStorageSetting
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
    (New-RscMutationAzure -Operation CreateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CreateCloudNativeStorageSetting
    $entries += @{
        Operation="New-RscMutationAzure -CreateCloudNativeStorageSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CreateCloudNativeStorageSetting
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
    (New-RscMutationAzure -Operation CreateCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CreateCluster
    $entries += @{
        Operation="New-RscMutationAzure -CreateCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CreateCluster
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
    (New-RscMutationAzure -Operation CreateReaderTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CreateReaderTarget
    $entries += @{
        Operation="New-RscMutationAzure -CreateReaderTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CreateReaderTarget
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
    (New-RscMutationAzure -Operation CreateSaasAppAad).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CreateSaasAppAad
    $entries += @{
        Operation="New-RscMutationAzure -CreateSaasAppAad" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CreateSaasAppAad
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
    (New-RscMutationAzure -Operation CreateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation CreateTarget
    $entries += @{
        Operation="New-RscMutationAzure -CreateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation CreateTarget
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
    (New-RscMutationAzure -Operation DeleteAdDirectory).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation DeleteAdDirectory
    $entries += @{
        Operation="New-RscMutationAzure -DeleteAdDirectory" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation DeleteAdDirectory
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
    (New-RscMutationAzure -Operation DeleteCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation DeleteCloudAccount
    $entries += @{
        Operation="New-RscMutationAzure -DeleteCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation DeleteCloudAccount
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
    (New-RscMutationAzure -Operation DeleteCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation DeleteCloudAccountExocomputeConfigurations
    $entries += @{
        Operation="New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation DeleteCloudAccountExocomputeConfigurations
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
    (New-RscMutationAzure -Operation DeleteCloudAccountWithoutOauth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation DeleteCloudAccountWithoutOauth
    $entries += @{
        Operation="New-RscMutationAzure -DeleteCloudAccountWithoutOauth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation DeleteCloudAccountWithoutOauth
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
    (New-RscMutationAzure -Operation DeleteCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation DeleteCluster
    $entries += @{
        Operation="New-RscMutationAzure -DeleteCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation DeleteCluster
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
    (New-RscMutationAzure -Operation MapCloudAccountExocomputeSubscription).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation MapCloudAccountExocomputeSubscription
    $entries += @{
        Operation="New-RscMutationAzure -MapCloudAccountExocomputeSubscription" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation MapCloudAccountExocomputeSubscription
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
    (New-RscMutationAzure -Operation MapCloudAccountToPersistentStorageLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation MapCloudAccountToPersistentStorageLocation
    $entries += @{
        Operation="New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation MapCloudAccountToPersistentStorageLocation
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
    (New-RscMutationAzure -Operation OauthConsentComplete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation OauthConsentComplete
    $entries += @{
        Operation="New-RscMutationAzure -OauthConsentComplete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation OauthConsentComplete
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
    (New-RscMutationAzure -Operation OauthConsentKickoff).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation OauthConsentKickoff
    $entries += @{
        Operation="New-RscMutationAzure -OauthConsentKickoff" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation OauthConsentKickoff
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
    (New-RscMutationAzure -Operation RestoreAdObjectsWithPasswords).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation RestoreAdObjectsWithPasswords
    $entries += @{
        Operation="New-RscMutationAzure -RestoreAdObjectsWithPasswords" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation RestoreAdObjectsWithPasswords
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
    (New-RscMutationAzure -Operation SetCloudAccountCustomerAppCredentials).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation SetCloudAccountCustomerAppCredentials
    $entries += @{
        Operation="New-RscMutationAzure -SetCloudAccountCustomerAppCredentials" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation SetCloudAccountCustomerAppCredentials
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
    (New-RscMutationAzure -Operation StartAdAppSetup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation StartAdAppSetup
    $entries += @{
        Operation="New-RscMutationAzure -StartAdAppSetup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation StartAdAppSetup
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
    (New-RscMutationAzure -Operation StartAdAppUpdate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation StartAdAppUpdate
    $entries += @{
        Operation="New-RscMutationAzure -StartAdAppUpdate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation StartAdAppUpdate
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
    (New-RscMutationAzure -Operation StartCloudAccountOauth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation StartCloudAccountOauth
    $entries += @{
        Operation="New-RscMutationAzure -StartCloudAccountOauth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation StartCloudAccountOauth
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
    (New-RscMutationAzure -Operation StartDisableCloudAccountJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation StartDisableCloudAccountJob
    $entries += @{
        Operation="New-RscMutationAzure -StartDisableCloudAccountJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation StartDisableCloudAccountJob
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
    (New-RscMutationAzure -Operation StartExportSqlDatabaseDbJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation StartExportSqlDatabaseDbJob
    $entries += @{
        Operation="New-RscMutationAzure -StartExportSqlDatabaseDbJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation StartExportSqlDatabaseDbJob
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
    (New-RscMutationAzure -Operation StartExportSqlManagedInstanceDbJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation StartExportSqlManagedInstanceDbJob
    $entries += @{
        Operation="New-RscMutationAzure -StartExportSqlManagedInstanceDbJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation StartExportSqlManagedInstanceDbJob
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
    (New-RscMutationAzure -Operation UnmapCloudAccountExocomputeSubscription).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UnmapCloudAccountExocomputeSubscription
    $entries += @{
        Operation="New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UnmapCloudAccountExocomputeSubscription
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
    (New-RscMutationAzure -Operation UnmapPersistentStorageSubscription).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UnmapPersistentStorageSubscription
    $entries += @{
        Operation="New-RscMutationAzure -UnmapPersistentStorageSubscription" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UnmapPersistentStorageSubscription
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
    (New-RscMutationAzure -Operation UpdateAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpdateAccount
    $entries += @{
        Operation="New-RscMutationAzure -UpdateAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpdateAccount
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
    (New-RscMutationAzure -Operation UpdateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpdateAutomaticTargetMapping
    $entries += @{
        Operation="New-RscMutationAzure -UpdateAutomaticTargetMapping" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpdateAutomaticTargetMapping
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
    (New-RscMutationAzure -Operation UpdateCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpdateCloudAccount
    $entries += @{
        Operation="New-RscMutationAzure -UpdateCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpdateCloudAccount
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
    (New-RscMutationAzure -Operation UpdateCloudNativeRcvStorageSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpdateCloudNativeRcvStorageSetting
    $entries += @{
        Operation="New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpdateCloudNativeRcvStorageSetting
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
    (New-RscMutationAzure -Operation UpdateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpdateCloudNativeStorageSetting
    $entries += @{
        Operation="New-RscMutationAzure -UpdateCloudNativeStorageSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpdateCloudNativeStorageSetting
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
    (New-RscMutationAzure -Operation UpdateCustomerAppPermissionForSql).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpdateCustomerAppPermissionForSql
    $entries += @{
        Operation="New-RscMutationAzure -UpdateCustomerAppPermissionForSql" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpdateCustomerAppPermissionForSql
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
    (New-RscMutationAzure -Operation UpdateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpdateTarget
    $entries += @{
        Operation="New-RscMutationAzure -UpdateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpdateTarget
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
    (New-RscMutationAzure -Operation UpgradeCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpgradeCloudAccount
    $entries += @{
        Operation="New-RscMutationAzure -UpgradeCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpgradeCloudAccount
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
    (New-RscMutationAzure -Operation UpgradeCloudAccountPermissionsWithoutOauth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzure -Operation UpgradeCloudAccountPermissionsWithoutOauth
    $entries += @{
        Operation="New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzure -Operation UpgradeCloudAccountPermissionsWithoutOauth
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
    (New-RscMutationAzureNative -Operation ExcludeManagedDisksFromSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureNative -Operation ExcludeManagedDisksFromSnapshot
    $entries += @{
        Operation="New-RscMutationAzureNative -ExcludeManagedDisksFromSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureNative -Operation ExcludeManagedDisksFromSnapshot
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
    (New-RscMutationAzureNative -Operation StartCreateManagedDiskSnapshotsJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureNative -Operation StartCreateManagedDiskSnapshotsJob
    $entries += @{
        Operation="New-RscMutationAzureNative -StartCreateManagedDiskSnapshotsJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureNative -Operation StartCreateManagedDiskSnapshotsJob
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
    (New-RscMutationAzureNative -Operation StartCreateVirtualMachineSnapshotsJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureNative -Operation StartCreateVirtualMachineSnapshotsJob
    $entries += @{
        Operation="New-RscMutationAzureNative -StartCreateVirtualMachineSnapshotsJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureNative -Operation StartCreateVirtualMachineSnapshotsJob
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
    (New-RscMutationAzureNative -Operation StartDisableSubscriptionProtectionJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureNative -Operation StartDisableSubscriptionProtectionJob
    $entries += @{
        Operation="New-RscMutationAzureNative -StartDisableSubscriptionProtectionJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureNative -Operation StartDisableSubscriptionProtectionJob
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
    (New-RscMutationAzureNative -Operation StartExportManagedDiskJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureNative -Operation StartExportManagedDiskJob
    $entries += @{
        Operation="New-RscMutationAzureNative -StartExportManagedDiskJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureNative -Operation StartExportManagedDiskJob
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
    (New-RscMutationAzureNative -Operation StartExportVirtualMachineJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureNative -Operation StartExportVirtualMachineJob
    $entries += @{
        Operation="New-RscMutationAzureNative -StartExportVirtualMachineJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureNative -Operation StartExportVirtualMachineJob
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
    (New-RscMutationAzureNative -Operation StartRefreshSubscriptionsJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureNative -Operation StartRefreshSubscriptionsJob
    $entries += @{
        Operation="New-RscMutationAzureNative -StartRefreshSubscriptionsJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureNative -Operation StartRefreshSubscriptionsJob
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
    (New-RscMutationAzureNative -Operation StartRestoreVirtualMachineJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureNative -Operation StartRestoreVirtualMachineJob
    $entries += @{
        Operation="New-RscMutationAzureNative -StartRestoreVirtualMachineJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureNative -Operation StartRestoreVirtualMachineJob
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
    (New-RscMutationAzureO365 -Operation SetupExocompute).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationAzureO365 -Operation SetupExocompute
    $entries += @{
        Operation="New-RscMutationAzureO365 -SetupExocompute" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationAzureO365 -Operation SetupExocompute
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
    (New-RscMutationCassandra -Operation BulkDeleteSources).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCassandra -Operation BulkDeleteSources
    $entries += @{
        Operation="New-RscMutationCassandra -BulkDeleteSources" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCassandra -Operation BulkDeleteSources
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
    (New-RscMutationCassandra -Operation CreateSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCassandra -Operation CreateSource
    $entries += @{
        Operation="New-RscMutationCassandra -CreateSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCassandra -Operation CreateSource
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
    (New-RscMutationCassandra -Operation DeleteSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCassandra -Operation DeleteSource
    $entries += @{
        Operation="New-RscMutationCassandra -DeleteSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCassandra -Operation DeleteSource
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
    (New-RscMutationCassandra -Operation RecoverSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCassandra -Operation RecoverSource
    $entries += @{
        Operation="New-RscMutationCassandra -RecoverSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCassandra -Operation RecoverSource
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
    (New-RscMutationCassandra -Operation UpdateSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCassandra -Operation UpdateSource
    $entries += @{
        Operation="New-RscMutationCassandra -UpdateSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCassandra -Operation UpdateSource
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
    (New-RscMutationCertificate -Operation AddClusterCertificate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCertificate -Operation AddClusterCertificate
    $entries += @{
        Operation="New-RscMutationCertificate -AddClusterCertificate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCertificate -Operation AddClusterCertificate
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
    (New-RscMutationCertificate -Operation Delete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCertificate -Operation Delete
    $entries += @{
        Operation="New-RscMutationCertificate -Delete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCertificate -Operation Delete
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
    (New-RscMutationCertificate -Operation SetSso).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCertificate -Operation SetSso
    $entries += @{
        Operation="New-RscMutationCertificate -SetSso" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCertificate -Operation SetSso
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
    (New-RscMutationCertificate -Operation SetWebSigned).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCertificate -Operation SetWebSigned
    $entries += @{
        Operation="New-RscMutationCertificate -SetWebSigned" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCertificate -Operation SetWebSigned
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
    (New-RscMutationCertificate -Operation Update).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCertificate -Operation Update
    $entries += @{
        Operation="New-RscMutationCertificate -Update" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCertificate -Operation Update
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
    (New-RscMutationCertificate -Operation UpdateHost).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCertificate -Operation UpdateHost
    $entries += @{
        Operation="New-RscMutationCertificate -UpdateHost" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCertificate -Operation UpdateHost
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
    (New-RscMutationCloudAccount -Operation MapExocomputeAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudAccount -Operation MapExocomputeAccount
    $entries += @{
        Operation="New-RscMutationCloudAccount -MapExocomputeAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudAccount -Operation MapExocomputeAccount
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
    (New-RscMutationCloudAccount -Operation UnmapExocomputeAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudAccount -Operation UnmapExocomputeAccount
    $entries += @{
        Operation="New-RscMutationCloudAccount -UnmapExocomputeAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudAccount -Operation UnmapExocomputeAccount
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
    (New-RscMutationCloudNative -Operation AddSqlServerBackupCredentials).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation AddSqlServerBackupCredentials
    $entries += @{
        Operation="New-RscMutationCloudNative -AddSqlServerBackupCredentials" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation AddSqlServerBackupCredentials
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
    (New-RscMutationCloudNative -Operation CheckRbaConnectivity).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation CheckRbaConnectivity
    $entries += @{
        Operation="New-RscMutationCloudNative -CheckRbaConnectivity" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation CheckRbaConnectivity
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
    (New-RscMutationCloudNative -Operation ClearSqlServerBackupCredentials).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation ClearSqlServerBackupCredentials
    $entries += @{
        Operation="New-RscMutationCloudNative -ClearSqlServerBackupCredentials" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation ClearSqlServerBackupCredentials
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
    (New-RscMutationCloudNative -Operation CreateLabelRule).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation CreateLabelRule
    $entries += @{
        Operation="New-RscMutationCloudNative -CreateLabelRule" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation CreateLabelRule
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
    (New-RscMutationCloudNative -Operation CreateTagRule).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation CreateTagRule
    $entries += @{
        Operation="New-RscMutationCloudNative -CreateTagRule" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation CreateTagRule
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
    (New-RscMutationCloudNative -Operation DeleteLabelRule).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation DeleteLabelRule
    $entries += @{
        Operation="New-RscMutationCloudNative -DeleteLabelRule" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation DeleteLabelRule
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
    (New-RscMutationCloudNative -Operation DeleteTagRule).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation DeleteTagRule
    $entries += @{
        Operation="New-RscMutationCloudNative -DeleteTagRule" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation DeleteTagRule
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
    (New-RscMutationCloudNative -Operation DownloadFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation DownloadFiles
    $entries += @{
        Operation="New-RscMutationCloudNative -DownloadFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation DownloadFiles
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
    (New-RscMutationCloudNative -Operation SetupSqlServerBackup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation SetupSqlServerBackup
    $entries += @{
        Operation="New-RscMutationCloudNative -SetupSqlServerBackup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation SetupSqlServerBackup
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
    (New-RscMutationCloudNative -Operation StartSnapshotsIndexJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation StartSnapshotsIndexJob
    $entries += @{
        Operation="New-RscMutationCloudNative -StartSnapshotsIndexJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation StartSnapshotsIndexJob
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
    (New-RscMutationCloudNative -Operation UpdateIndexingStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation UpdateIndexingStatus
    $entries += @{
        Operation="New-RscMutationCloudNative -UpdateIndexingStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation UpdateIndexingStatus
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
    (New-RscMutationCloudNative -Operation UpdateLabelRule).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation UpdateLabelRule
    $entries += @{
        Operation="New-RscMutationCloudNative -UpdateLabelRule" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation UpdateLabelRule
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
    (New-RscMutationCloudNative -Operation UpdateTagRule).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCloudNative -Operation UpdateTagRule
    $entries += @{
        Operation="New-RscMutationCloudNative -UpdateTagRule" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCloudNative -Operation UpdateTagRule
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
    (New-RscMutationCluster -Operation AddNodesToCloud).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation AddNodesToCloud
    $entries += @{
        Operation="New-RscMutationCluster -AddNodesToCloud" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation AddNodesToCloud
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
    (New-RscMutationCluster -Operation BulkDeleteFailover).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation BulkDeleteFailover
    $entries += @{
        Operation="New-RscMutationCluster -BulkDeleteFailover" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation BulkDeleteFailover
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
    (New-RscMutationCluster -Operation CreateFailover).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation CreateFailover
    $entries += @{
        Operation="New-RscMutationCluster -CreateFailover" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation CreateFailover
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
    (New-RscMutationCluster -Operation DeleteFailover).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation DeleteFailover
    $entries += @{
        Operation="New-RscMutationCluster -DeleteFailover" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation DeleteFailover
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
    (New-RscMutationCluster -Operation RecoverCloud).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation RecoverCloud
    $entries += @{
        Operation="New-RscMutationCluster -RecoverCloud" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation RecoverCloud
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
    (New-RscMutationCluster -Operation RegisterCloud).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation RegisterCloud
    $entries += @{
        Operation="New-RscMutationCluster -RegisterCloud" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation RegisterCloud
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
    (New-RscMutationCluster -Operation RemoveCdm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation RemoveCdm
    $entries += @{
        Operation="New-RscMutationCluster -RemoveCdm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation RemoveCdm
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
    (New-RscMutationCluster -Operation UpdateDatabaseLogReportingProperties).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation UpdateDatabaseLogReportingProperties
    $entries += @{
        Operation="New-RscMutationCluster -UpdateDatabaseLogReportingProperties" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation UpdateDatabaseLogReportingProperties
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
    (New-RscMutationCluster -Operation UpdateFailover).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationCluster -Operation UpdateFailover
    $entries += @{
        Operation="New-RscMutationCluster -UpdateFailover" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationCluster -Operation UpdateFailover
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
    (New-RscMutationDb2 -Operation AddInstance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation AddInstance
    $entries += @{
        Operation="New-RscMutationDb2 -AddInstance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation AddInstance
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
    (New-RscMutationDb2 -Operation CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation CreateOnDemandBackup
    $entries += @{
        Operation="New-RscMutationDb2 -CreateOnDemandBackup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation CreateOnDemandBackup
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
    (New-RscMutationDb2 -Operation DeleteDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation DeleteDatabase
    $entries += @{
        Operation="New-RscMutationDb2 -DeleteDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation DeleteDatabase
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
    (New-RscMutationDb2 -Operation DeleteInstance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation DeleteInstance
    $entries += @{
        Operation="New-RscMutationDb2 -DeleteInstance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation DeleteInstance
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
    (New-RscMutationDb2 -Operation DiscoverInstance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation DiscoverInstance
    $entries += @{
        Operation="New-RscMutationDb2 -DiscoverInstance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation DiscoverInstance
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
    (New-RscMutationDb2 -Operation DownloadSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation DownloadSnapshot
    $entries += @{
        Operation="New-RscMutationDb2 -DownloadSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation DownloadSnapshot
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
    (New-RscMutationDb2 -Operation DownloadSnapshotsForPointInTimeRecovery).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation DownloadSnapshotsForPointInTimeRecovery
    $entries += @{
        Operation="New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation DownloadSnapshotsForPointInTimeRecovery
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
    (New-RscMutationDb2 -Operation ExpireDownloadedSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation ExpireDownloadedSnapshots
    $entries += @{
        Operation="New-RscMutationDb2 -ExpireDownloadedSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation ExpireDownloadedSnapshots
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
    (New-RscMutationDb2 -Operation PatchDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation PatchDatabase
    $entries += @{
        Operation="New-RscMutationDb2 -PatchDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation PatchDatabase
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
    (New-RscMutationDb2 -Operation PatchInstance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation PatchInstance
    $entries += @{
        Operation="New-RscMutationDb2 -PatchInstance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation PatchInstance
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
    (New-RscMutationDb2 -Operation RefreshDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDb2 -Operation RefreshDatabase
    $entries += @{
        Operation="New-RscMutationDb2 -RefreshDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDb2 -Operation RefreshDatabase
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
    (New-RscMutationDownload -Operation AuditLogCsvAsync).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation AuditLogCsvAsync
    $entries += @{
        Operation="New-RscMutationDownload -AuditLogCsvAsync" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation AuditLogCsvAsync
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
    (New-RscMutationDownload -Operation ExchangeSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation ExchangeSnapshot
    $entries += @{
        Operation="New-RscMutationDownload -ExchangeSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation ExchangeSnapshot
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
    (New-RscMutationDownload -Operation FilesetSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation FilesetSnapshot
    $entries += @{
        Operation="New-RscMutationDownload -FilesetSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation FilesetSnapshot
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
    (New-RscMutationDownload -Operation FilesetSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation FilesetSnapshotFromLocation
    $entries += @{
        Operation="New-RscMutationDownload -FilesetSnapshotFromLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation FilesetSnapshotFromLocation
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
    (New-RscMutationDownload -Operation ObjectFilesCsv).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation ObjectFilesCsv
    $entries += @{
        Operation="New-RscMutationDownload -ObjectFilesCsv" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation ObjectFilesCsv
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
    (New-RscMutationDownload -Operation ObjectsListCsv).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation ObjectsListCsv
    $entries += @{
        Operation="New-RscMutationDownload -ObjectsListCsv" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation ObjectsListCsv
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
    (New-RscMutationDownload -Operation ReportCsvAsync).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation ReportCsvAsync
    $entries += @{
        Operation="New-RscMutationDownload -ReportCsvAsync" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation ReportCsvAsync
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
    (New-RscMutationDownload -Operation ReportPdfAsync).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation ReportPdfAsync
    $entries += @{
        Operation="New-RscMutationDownload -ReportPdfAsync" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation ReportPdfAsync
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
    (New-RscMutationDownload -Operation ResultsCsv).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation ResultsCsv
    $entries += @{
        Operation="New-RscMutationDownload -ResultsCsv" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation ResultsCsv
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
    (New-RscMutationDownload -Operation SapHanaSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation SapHanaSnapshot
    $entries += @{
        Operation="New-RscMutationDownload -SapHanaSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation SapHanaSnapshot
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
    (New-RscMutationDownload -Operation SapHanaSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation SapHanaSnapshotFromLocation
    $entries += @{
        Operation="New-RscMutationDownload -SapHanaSnapshotFromLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation SapHanaSnapshotFromLocation
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
    (New-RscMutationDownload -Operation SapHanaSnapshotsForPointInTimeRecovery).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation SapHanaSnapshotsForPointInTimeRecovery
    $entries += @{
        Operation="New-RscMutationDownload -SapHanaSnapshotsForPointInTimeRecovery" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation SapHanaSnapshotsForPointInTimeRecovery
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
    (New-RscMutationDownload -Operation SnapshotResultsCsv).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation SnapshotResultsCsv
    $entries += @{
        Operation="New-RscMutationDownload -SnapshotResultsCsv" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation SnapshotResultsCsv
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
    (New-RscMutationDownload -Operation ThreatHuntCsv).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation ThreatHuntCsv
    $entries += @{
        Operation="New-RscMutationDownload -ThreatHuntCsv" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation ThreatHuntCsv
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
    (New-RscMutationDownload -Operation VolumeGroupSnapshotFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation VolumeGroupSnapshotFiles
    $entries += @{
        Operation="New-RscMutationDownload -VolumeGroupSnapshotFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation VolumeGroupSnapshotFiles
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
    (New-RscMutationDownload -Operation VolumeGroupSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationDownload -Operation VolumeGroupSnapshotFromLocation
    $entries += @{
        Operation="New-RscMutationDownload -VolumeGroupSnapshotFromLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationDownload -Operation VolumeGroupSnapshotFromLocation
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
    (New-RscMutationExchange -Operation BulkUpdateDag).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationExchange -Operation BulkUpdateDag
    $entries += @{
        Operation="New-RscMutationExchange -BulkUpdateDag" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationExchange -Operation BulkUpdateDag
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
    (New-RscMutationExchange -Operation CreateMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationExchange -Operation CreateMount
    $entries += @{
        Operation="New-RscMutationExchange -CreateMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationExchange -Operation CreateMount
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
    (New-RscMutationExchange -Operation CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationExchange -Operation CreateOnDemandBackup
    $entries += @{
        Operation="New-RscMutationExchange -CreateOnDemandBackup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationExchange -Operation CreateOnDemandBackup
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
    (New-RscMutationExchange -Operation DeleteSnapshotMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationExchange -Operation DeleteSnapshotMount
    $entries += @{
        Operation="New-RscMutationExchange -DeleteSnapshotMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationExchange -Operation DeleteSnapshotMount
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
    (New-RscMutationFileset -Operation BulkCreate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationFileset -Operation BulkCreate
    $entries += @{
        Operation="New-RscMutationFileset -BulkCreate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationFileset -Operation BulkCreate
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
    (New-RscMutationFileset -Operation BulkCreateTemplates).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationFileset -Operation BulkCreateTemplates
    $entries += @{
        Operation="New-RscMutationFileset -BulkCreateTemplates" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationFileset -Operation BulkCreateTemplates
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
    (New-RscMutationFileset -Operation BulkDelete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationFileset -Operation BulkDelete
    $entries += @{
        Operation="New-RscMutationFileset -BulkDelete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationFileset -Operation BulkDelete
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
    (New-RscMutationFileset -Operation BulkDeleteTemplate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationFileset -Operation BulkDeleteTemplate
    $entries += @{
        Operation="New-RscMutationFileset -BulkDeleteTemplate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationFileset -Operation BulkDeleteTemplate
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
    (New-RscMutationFileset -Operation BulkUpdateTemplate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationFileset -Operation BulkUpdateTemplate
    $entries += @{
        Operation="New-RscMutationFileset -BulkUpdateTemplate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationFileset -Operation BulkUpdateTemplate
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
    (New-RscMutationFileset -Operation RecoverFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationFileset -Operation RecoverFiles
    $entries += @{
        Operation="New-RscMutationFileset -RecoverFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationFileset -Operation RecoverFiles
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
    (New-RscMutationGcp -Operation CloudAccountAddManualAuthProject).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation CloudAccountAddManualAuthProject
    $entries += @{
        Operation="New-RscMutationGcp -CloudAccountAddManualAuthProject" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation CloudAccountAddManualAuthProject
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
    (New-RscMutationGcp -Operation CloudAccountAddProjects).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation CloudAccountAddProjects
    $entries += @{
        Operation="New-RscMutationGcp -CloudAccountAddProjects" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation CloudAccountAddProjects
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
    (New-RscMutationGcp -Operation CloudAccountDeleteProjects).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation CloudAccountDeleteProjects
    $entries += @{
        Operation="New-RscMutationGcp -CloudAccountDeleteProjects" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation CloudAccountDeleteProjects
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
    (New-RscMutationGcp -Operation CloudAccountOauthComplete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation CloudAccountOauthComplete
    $entries += @{
        Operation="New-RscMutationGcp -CloudAccountOauthComplete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation CloudAccountOauthComplete
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
    (New-RscMutationGcp -Operation CloudAccountOauthInitiate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation CloudAccountOauthInitiate
    $entries += @{
        Operation="New-RscMutationGcp -CloudAccountOauthInitiate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation CloudAccountOauthInitiate
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
    (New-RscMutationGcp -Operation CloudAccountUpgradeProjects).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation CloudAccountUpgradeProjects
    $entries += @{
        Operation="New-RscMutationGcp -CloudAccountUpgradeProjects" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation CloudAccountUpgradeProjects
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
    (New-RscMutationGcp -Operation CreateReaderTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation CreateReaderTarget
    $entries += @{
        Operation="New-RscMutationGcp -CreateReaderTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation CreateReaderTarget
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
    (New-RscMutationGcp -Operation CreateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation CreateTarget
    $entries += @{
        Operation="New-RscMutationGcp -CreateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation CreateTarget
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
    (New-RscMutationGcp -Operation SetDefaultServiceAccountJwtConfig).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation SetDefaultServiceAccountJwtConfig
    $entries += @{
        Operation="New-RscMutationGcp -SetDefaultServiceAccountJwtConfig" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation SetDefaultServiceAccountJwtConfig
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
    (New-RscMutationGcp -Operation UpdateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation UpdateTarget
    $entries += @{
        Operation="New-RscMutationGcp -UpdateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation UpdateTarget
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
    (New-RscMutationGcp -Operation UpgradeCloudAccountPermissionsWithoutOauth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcp -Operation UpgradeCloudAccountPermissionsWithoutOauth
    $entries += @{
        Operation="New-RscMutationGcp -UpgradeCloudAccountPermissionsWithoutOauth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcp -Operation UpgradeCloudAccountPermissionsWithoutOauth
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
    (New-RscMutationGcpNative -Operation DisableProject).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcpNative -Operation DisableProject
    $entries += @{
        Operation="New-RscMutationGcpNative -DisableProject" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcpNative -Operation DisableProject
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
    (New-RscMutationGcpNative -Operation ExcludeDisksFromInstanceSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcpNative -Operation ExcludeDisksFromInstanceSnapshot
    $entries += @{
        Operation="New-RscMutationGcpNative -ExcludeDisksFromInstanceSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcpNative -Operation ExcludeDisksFromInstanceSnapshot
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
    (New-RscMutationGcpNative -Operation ExportDisk).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcpNative -Operation ExportDisk
    $entries += @{
        Operation="New-RscMutationGcpNative -ExportDisk" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcpNative -Operation ExportDisk
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
    (New-RscMutationGcpNative -Operation ExportGceInstance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcpNative -Operation ExportGceInstance
    $entries += @{
        Operation="New-RscMutationGcpNative -ExportGceInstance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcpNative -Operation ExportGceInstance
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
    (New-RscMutationGcpNative -Operation RefreshProjects).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcpNative -Operation RefreshProjects
    $entries += @{
        Operation="New-RscMutationGcpNative -RefreshProjects" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcpNative -Operation RefreshProjects
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
    (New-RscMutationGcpNative -Operation RestoreGceInstance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationGcpNative -Operation RestoreGceInstance
    $entries += @{
        Operation="New-RscMutationGcpNative -RestoreGceInstance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationGcpNative -Operation RestoreGceInstance
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
    (New-RscMutationHost -Operation BulkDelete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHost -Operation BulkDelete
    $entries += @{
        Operation="New-RscMutationHost -BulkDelete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHost -Operation BulkDelete
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
    (New-RscMutationHost -Operation BulkRefresh).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHost -Operation BulkRefresh
    $entries += @{
        Operation="New-RscMutationHost -BulkRefresh" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHost -Operation BulkRefresh
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
    (New-RscMutationHost -Operation BulkRegister).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHost -Operation BulkRegister
    $entries += @{
        Operation="New-RscMutationHost -BulkRegister" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHost -Operation BulkRegister
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
    (New-RscMutationHost -Operation BulkUpdate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHost -Operation BulkUpdate
    $entries += @{
        Operation="New-RscMutationHost -BulkUpdate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHost -Operation BulkUpdate
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
    (New-RscMutationHost -Operation ChangeVfd).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHost -Operation ChangeVfd
    $entries += @{
        Operation="New-RscMutationHost -ChangeVfd" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHost -Operation ChangeVfd
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
    (New-RscMutationHost -Operation Refresh).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHost -Operation Refresh
    $entries += @{
        Operation="New-RscMutationHost -Refresh" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHost -Operation Refresh
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
    (New-RscMutationHyperv -Operation BatchExportVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation BatchExportVm
    $entries += @{
        Operation="New-RscMutationHyperv -BatchExportVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation BatchExportVm
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
    (New-RscMutationHyperv -Operation BatchInstantRecoverVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation BatchInstantRecoverVm
    $entries += @{
        Operation="New-RscMutationHyperv -BatchInstantRecoverVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation BatchInstantRecoverVm
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
    (New-RscMutationHyperv -Operation BatchMountVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation BatchMountVm
    $entries += @{
        Operation="New-RscMutationHyperv -BatchMountVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation BatchMountVm
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
    (New-RscMutationHyperv -Operation BatchOnDemandBackupVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation BatchOnDemandBackupVm
    $entries += @{
        Operation="New-RscMutationHyperv -BatchOnDemandBackupVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation BatchOnDemandBackupVm
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
    (New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotMount
    $entries += @{
        Operation="New-RscMutationHyperv -CreateVirtualMachineSnapshotMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation CreateVirtualMachineSnapshotMount
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
    (New-RscMutationHyperv -Operation DeleteAllSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation DeleteAllSnapshots
    $entries += @{
        Operation="New-RscMutationHyperv -DeleteAllSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation DeleteAllSnapshots
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
    (New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshot
    $entries += @{
        Operation="New-RscMutationHyperv -DeleteVirtualMachineSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshot
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
    (New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshotMount
    $entries += @{
        Operation="New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation DeleteVirtualMachineSnapshotMount
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
    (New-RscMutationHyperv -Operation DownloadSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation DownloadSnapshotFromLocation
    $entries += @{
        Operation="New-RscMutationHyperv -DownloadSnapshotFromLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation DownloadSnapshotFromLocation
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
    (New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshot
    $entries += @{
        Operation="New-RscMutationHyperv -DownloadVirtualMachineSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshot
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
    (New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshotFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshotFiles
    $entries += @{
        Operation="New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation DownloadVirtualMachineSnapshotFiles
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
    (New-RscMutationHyperv -Operation ExportVirtualMachine).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation ExportVirtualMachine
    $entries += @{
        Operation="New-RscMutationHyperv -ExportVirtualMachine" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation ExportVirtualMachine
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
    (New-RscMutationHyperv -Operation InstantRecoverVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation InstantRecoverVirtualMachineSnapshot
    $entries += @{
        Operation="New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation InstantRecoverVirtualMachineSnapshot
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
    (New-RscMutationHyperv -Operation OnDemandSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation OnDemandSnapshot
    $entries += @{
        Operation="New-RscMutationHyperv -OnDemandSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation OnDemandSnapshot
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
    (New-RscMutationHyperv -Operation RefreshScvmm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation RefreshScvmm
    $entries += @{
        Operation="New-RscMutationHyperv -RefreshScvmm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation RefreshScvmm
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
    (New-RscMutationHyperv -Operation RefreshServer).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation RefreshServer
    $entries += @{
        Operation="New-RscMutationHyperv -RefreshServer" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation RefreshServer
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
    (New-RscMutationHyperv -Operation RegisterAgentVirtualMachine).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation RegisterAgentVirtualMachine
    $entries += @{
        Operation="New-RscMutationHyperv -RegisterAgentVirtualMachine" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation RegisterAgentVirtualMachine
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
    (New-RscMutationHyperv -Operation RegisterScvmm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation RegisterScvmm
    $entries += @{
        Operation="New-RscMutationHyperv -RegisterScvmm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation RegisterScvmm
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
    (New-RscMutationHyperv -Operation RestoreVirtualMachineSnapshotFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation RestoreVirtualMachineSnapshotFiles
    $entries += @{
        Operation="New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation RestoreVirtualMachineSnapshotFiles
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
    (New-RscMutationHyperv -Operation ScvmmDelete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation ScvmmDelete
    $entries += @{
        Operation="New-RscMutationHyperv -ScvmmDelete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation ScvmmDelete
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
    (New-RscMutationHyperv -Operation ScvmmUpdate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation ScvmmUpdate
    $entries += @{
        Operation="New-RscMutationHyperv -ScvmmUpdate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation ScvmmUpdate
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
    (New-RscMutationHyperv -Operation UpdateVirtualMachine).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation UpdateVirtualMachine
    $entries += @{
        Operation="New-RscMutationHyperv -UpdateVirtualMachine" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation UpdateVirtualMachine
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
    (New-RscMutationHyperv -Operation UpdateVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationHyperv -Operation UpdateVirtualMachineSnapshotMount
    $entries += @{
        Operation="New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationHyperv -Operation UpdateVirtualMachineSnapshotMount
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
    (New-RscMutationK8s -Operation ArchiveCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationK8s -Operation ArchiveCluster
    $entries += @{
        Operation="New-RscMutationK8s -ArchiveCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationK8s -Operation ArchiveCluster
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
    (New-RscMutationK8s -Operation CreateAgentManifest).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationK8s -Operation CreateAgentManifest
    $entries += @{
        Operation="New-RscMutationK8s -CreateAgentManifest" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationK8s -Operation CreateAgentManifest
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
    (New-RscMutationK8s -Operation CreateCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationK8s -Operation CreateCluster
    $entries += @{
        Operation="New-RscMutationK8s -CreateCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationK8s -Operation CreateCluster
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
    (New-RscMutationK8s -Operation CreateNamespaceSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationK8s -Operation CreateNamespaceSnapshots
    $entries += @{
        Operation="New-RscMutationK8s -CreateNamespaceSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationK8s -Operation CreateNamespaceSnapshots
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
    (New-RscMutationK8s -Operation ExportNamespace).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationK8s -Operation ExportNamespace
    $entries += @{
        Operation="New-RscMutationK8s -ExportNamespace" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationK8s -Operation ExportNamespace
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
    (New-RscMutationK8s -Operation RefreshCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationK8s -Operation RefreshCluster
    $entries += @{
        Operation="New-RscMutationK8s -RefreshCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationK8s -Operation RefreshCluster
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
    (New-RscMutationK8s -Operation RestoreNamespace).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationK8s -Operation RestoreNamespace
    $entries += @{
        Operation="New-RscMutationK8s -RestoreNamespace" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationK8s -Operation RestoreNamespace
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
    (New-RscMutationLdap -Operation DeletePrincipals).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationLdap -Operation DeletePrincipals
    $entries += @{
        Operation="New-RscMutationLdap -DeletePrincipals" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationLdap -Operation DeletePrincipals
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
    (New-RscMutationLdap -Operation RemoveIntegration).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationLdap -Operation RemoveIntegration
    $entries += @{
        Operation="New-RscMutationLdap -RemoveIntegration" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationLdap -Operation RemoveIntegration
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
    (New-RscMutationLdap -Operation SetMfaSetting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationLdap -Operation SetMfaSetting
    $entries += @{
        Operation="New-RscMutationLdap -SetMfaSetting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationLdap -Operation SetMfaSetting
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
    (New-RscMutationLdap -Operation UpdateIntegration).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationLdap -Operation UpdateIntegration
    $entries += @{
        Operation="New-RscMutationLdap -UpdateIntegration" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationLdap -Operation UpdateIntegration
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
    (New-RscMutationM365 -Operation BackupMailbox).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationM365 -Operation BackupMailbox
    $entries += @{
        Operation="New-RscMutationM365 -BackupMailbox" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationM365 -Operation BackupMailbox
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
    (New-RscMutationM365 -Operation BackupOnedrive).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationM365 -Operation BackupOnedrive
    $entries += @{
        Operation="New-RscMutationM365 -BackupOnedrive" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationM365 -Operation BackupOnedrive
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
    (New-RscMutationM365 -Operation BackupSharepointDrive).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationM365 -Operation BackupSharepointDrive
    $entries += @{
        Operation="New-RscMutationM365 -BackupSharepointDrive" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationM365 -Operation BackupSharepointDrive
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
    (New-RscMutationM365 -Operation BackupTeam).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationM365 -Operation BackupTeam
    $entries += @{
        Operation="New-RscMutationM365 -BackupTeam" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationM365 -Operation BackupTeam
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
    (New-RscMutationManagedVolume -Operation Add).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation Add
    $entries += @{
        Operation="New-RscMutationManagedVolume -Add" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation Add
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
    (New-RscMutationManagedVolume -Operation BeginSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation BeginSnapshot
    $entries += @{
        Operation="New-RscMutationManagedVolume -BeginSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation BeginSnapshot
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
    (New-RscMutationManagedVolume -Operation Delete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation Delete
    $entries += @{
        Operation="New-RscMutationManagedVolume -Delete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation Delete
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
    (New-RscMutationManagedVolume -Operation DeleteSnapshotExport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation DeleteSnapshotExport
    $entries += @{
        Operation="New-RscMutationManagedVolume -DeleteSnapshotExport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation DeleteSnapshotExport
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
    (New-RscMutationManagedVolume -Operation DownloadFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation DownloadFiles
    $entries += @{
        Operation="New-RscMutationManagedVolume -DownloadFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation DownloadFiles
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
    (New-RscMutationManagedVolume -Operation DownloadFromLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation DownloadFromLocation
    $entries += @{
        Operation="New-RscMutationManagedVolume -DownloadFromLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation DownloadFromLocation
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
    (New-RscMutationManagedVolume -Operation EndSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation EndSnapshot
    $entries += @{
        Operation="New-RscMutationManagedVolume -EndSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation EndSnapshot
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
    (New-RscMutationManagedVolume -Operation ExportSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation ExportSnapshot
    $entries += @{
        Operation="New-RscMutationManagedVolume -ExportSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation ExportSnapshot
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
    (New-RscMutationManagedVolume -Operation Resize).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation Resize
    $entries += @{
        Operation="New-RscMutationManagedVolume -Resize" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation Resize
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
    (New-RscMutationManagedVolume -Operation TakeOnDemandSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation TakeOnDemandSnapshot
    $entries += @{
        Operation="New-RscMutationManagedVolume -TakeOnDemandSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation TakeOnDemandSnapshot
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
    (New-RscMutationManagedVolume -Operation Update).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationManagedVolume -Operation Update
    $entries += @{
        Operation="New-RscMutationManagedVolume -Update" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationManagedVolume -Operation Update
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
    (New-RscMutationMongo -Operation AddSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation AddSource
    $entries += @{
        Operation="New-RscMutationMongo -AddSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation AddSource
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
    (New-RscMutationMongo -Operation AssignSlaToCollection).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation AssignSlaToCollection
    $entries += @{
        Operation="New-RscMutationMongo -AssignSlaToCollection" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation AssignSlaToCollection
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
    (New-RscMutationMongo -Operation BulkDeleteSources).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation BulkDeleteSources
    $entries += @{
        Operation="New-RscMutationMongo -BulkDeleteSources" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation BulkDeleteSources
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
    (New-RscMutationMongo -Operation CreateSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation CreateSource
    $entries += @{
        Operation="New-RscMutationMongo -CreateSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation CreateSource
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
    (New-RscMutationMongo -Operation DeleteSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation DeleteSource
    $entries += @{
        Operation="New-RscMutationMongo -DeleteSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation DeleteSource
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
    (New-RscMutationMongo -Operation DiscoverSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation DiscoverSource
    $entries += @{
        Operation="New-RscMutationMongo -DiscoverSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation DiscoverSource
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
    (New-RscMutationMongo -Operation PatchSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation PatchSource
    $entries += @{
        Operation="New-RscMutationMongo -PatchSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation PatchSource
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
    (New-RscMutationMongo -Operation RecoverSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation RecoverSource
    $entries += @{
        Operation="New-RscMutationMongo -RecoverSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation RecoverSource
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
    (New-RscMutationMongo -Operation RetryAddSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation RetryAddSource
    $entries += @{
        Operation="New-RscMutationMongo -RetryAddSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation RetryAddSource
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
    (New-RscMutationMongo -Operation UpdateSource).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMongo -Operation UpdateSource
    $entries += @{
        Operation="New-RscMutationMongo -UpdateSource" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMongo -Operation UpdateSource
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
    (New-RscMutationMosaic -Operation AddStore).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMosaic -Operation AddStore
    $entries += @{
        Operation="New-RscMutationMosaic -AddStore" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMosaic -Operation AddStore
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
    (New-RscMutationMosaic -Operation DeleteStore).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMosaic -Operation DeleteStore
    $entries += @{
        Operation="New-RscMutationMosaic -DeleteStore" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMosaic -Operation DeleteStore
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
    (New-RscMutationMosaic -Operation UpdateStore).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMosaic -Operation UpdateStore
    $entries += @{
        Operation="New-RscMutationMosaic -UpdateStore" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMosaic -Operation UpdateStore
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
    (New-RscMutationMssql -Operation AssignSlaDomainProperties).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation AssignSlaDomainProperties
    $entries += @{
        Operation="New-RscMutationMssql -AssignSlaDomainProperties" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation AssignSlaDomainProperties
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
    (New-RscMutationMssql -Operation AssignSlaDomainPropertiesAsync).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation AssignSlaDomainPropertiesAsync
    $entries += @{
        Operation="New-RscMutationMssql -AssignSlaDomainPropertiesAsync" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation AssignSlaDomainPropertiesAsync
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
    (New-RscMutationMssql -Operation BrowseDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation BrowseDatabaseSnapshot
    $entries += @{
        Operation="New-RscMutationMssql -BrowseDatabaseSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation BrowseDatabaseSnapshot
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
    (New-RscMutationMssql -Operation BulkCreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation BulkCreateOnDemandBackup
    $entries += @{
        Operation="New-RscMutationMssql -BulkCreateOnDemandBackup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation BulkCreateOnDemandBackup
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
    (New-RscMutationMssql -Operation BulkUpdateDbs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation BulkUpdateDbs
    $entries += @{
        Operation="New-RscMutationMssql -BulkUpdateDbs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation BulkUpdateDbs
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
    (New-RscMutationMssql -Operation CreateLiveMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation CreateLiveMount
    $entries += @{
        Operation="New-RscMutationMssql -CreateLiveMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation CreateLiveMount
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
    (New-RscMutationMssql -Operation CreateLogShippingConfiguration).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation CreateLogShippingConfiguration
    $entries += @{
        Operation="New-RscMutationMssql -CreateLogShippingConfiguration" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation CreateLogShippingConfiguration
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
    (New-RscMutationMssql -Operation CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation CreateOnDemandBackup
    $entries += @{
        Operation="New-RscMutationMssql -CreateOnDemandBackup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation CreateOnDemandBackup
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
    (New-RscMutationMssql -Operation DeleteDbSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation DeleteDbSnapshots
    $entries += @{
        Operation="New-RscMutationMssql -DeleteDbSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation DeleteDbSnapshots
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
    (New-RscMutationMssql -Operation DeleteLiveMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation DeleteLiveMount
    $entries += @{
        Operation="New-RscMutationMssql -DeleteLiveMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation DeleteLiveMount
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
    (New-RscMutationMssql -Operation DownloadDatabaseBackupFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation DownloadDatabaseBackupFiles
    $entries += @{
        Operation="New-RscMutationMssql -DownloadDatabaseBackupFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation DownloadDatabaseBackupFiles
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
    (New-RscMutationMssql -Operation DownloadDatabaseFilesFromArchivalLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation DownloadDatabaseFilesFromArchivalLocation
    $entries += @{
        Operation="New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation DownloadDatabaseFilesFromArchivalLocation
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
    (New-RscMutationMssql -Operation ExportDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation ExportDatabase
    $entries += @{
        Operation="New-RscMutationMssql -ExportDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation ExportDatabase
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
    (New-RscMutationMssql -Operation RestoreDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation RestoreDatabase
    $entries += @{
        Operation="New-RscMutationMssql -RestoreDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation RestoreDatabase
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
    (New-RscMutationMssql -Operation TakeLogBackup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation TakeLogBackup
    $entries += @{
        Operation="New-RscMutationMssql -TakeLogBackup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation TakeLogBackup
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
    (New-RscMutationMssql -Operation UpdateDefaultProperties).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation UpdateDefaultProperties
    $entries += @{
        Operation="New-RscMutationMssql -UpdateDefaultProperties" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation UpdateDefaultProperties
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
    (New-RscMutationMssql -Operation UpdateLogShippingConfiguration).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationMssql -Operation UpdateLogShippingConfiguration
    $entries += @{
        Operation="New-RscMutationMssql -UpdateLogShippingConfiguration" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationMssql -Operation UpdateLogShippingConfiguration
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
    (New-RscMutationNfs -Operation CreateReaderTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNfs -Operation CreateReaderTarget
    $entries += @{
        Operation="New-RscMutationNfs -CreateReaderTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNfs -Operation CreateReaderTarget
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
    (New-RscMutationNfs -Operation CreateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNfs -Operation CreateTarget
    $entries += @{
        Operation="New-RscMutationNfs -CreateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNfs -Operation CreateTarget
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
    (New-RscMutationNfs -Operation UpdateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNfs -Operation UpdateTarget
    $entries += @{
        Operation="New-RscMutationNfs -UpdateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNfs -Operation UpdateTarget
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
    (New-RscMutationNutanix -Operation BatchExportVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation BatchExportVm
    $entries += @{
        Operation="New-RscMutationNutanix -BatchExportVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation BatchExportVm
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
    (New-RscMutationNutanix -Operation BatchMountVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation BatchMountVm
    $entries += @{
        Operation="New-RscMutationNutanix -BatchMountVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation BatchMountVm
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
    (New-RscMutationNutanix -Operation BulkOnDemandSnapshotVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation BulkOnDemandSnapshotVm
    $entries += @{
        Operation="New-RscMutationNutanix -BulkOnDemandSnapshotVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation BulkOnDemandSnapshotVm
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
    (New-RscMutationNutanix -Operation CreateCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation CreateCluster
    $entries += @{
        Operation="New-RscMutationNutanix -CreateCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation CreateCluster
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
    (New-RscMutationNutanix -Operation CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation CreateOnDemandBackup
    $entries += @{
        Operation="New-RscMutationNutanix -CreateOnDemandBackup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation CreateOnDemandBackup
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
    (New-RscMutationNutanix -Operation CreatePrismCentral).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation CreatePrismCentral
    $entries += @{
        Operation="New-RscMutationNutanix -CreatePrismCentral" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation CreatePrismCentral
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
    (New-RscMutationNutanix -Operation DeleteCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation DeleteCluster
    $entries += @{
        Operation="New-RscMutationNutanix -DeleteCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation DeleteCluster
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
    (New-RscMutationNutanix -Operation DeleteMountV1).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation DeleteMountV1
    $entries += @{
        Operation="New-RscMutationNutanix -DeleteMountV1" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation DeleteMountV1
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
    (New-RscMutationNutanix -Operation DeletePrismCentral).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation DeletePrismCentral
    $entries += @{
        Operation="New-RscMutationNutanix -DeletePrismCentral" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation DeletePrismCentral
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
    (New-RscMutationNutanix -Operation DeleteSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation DeleteSnapshot
    $entries += @{
        Operation="New-RscMutationNutanix -DeleteSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation DeleteSnapshot
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
    (New-RscMutationNutanix -Operation DeleteSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation DeleteSnapshots
    $entries += @{
        Operation="New-RscMutationNutanix -DeleteSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation DeleteSnapshots
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
    (New-RscMutationNutanix -Operation DownloadFilesSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation DownloadFilesSnapshot
    $entries += @{
        Operation="New-RscMutationNutanix -DownloadFilesSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation DownloadFilesSnapshot
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
    (New-RscMutationNutanix -Operation DownloadSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation DownloadSnapshot
    $entries += @{
        Operation="New-RscMutationNutanix -DownloadSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation DownloadSnapshot
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
    (New-RscMutationNutanix -Operation DownloadVmFromLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation DownloadVmFromLocation
    $entries += @{
        Operation="New-RscMutationNutanix -DownloadVmFromLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation DownloadVmFromLocation
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
    (New-RscMutationNutanix -Operation ExportSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation ExportSnapshot
    $entries += @{
        Operation="New-RscMutationNutanix -ExportSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation ExportSnapshot
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
    (New-RscMutationNutanix -Operation MigrateMountV1).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation MigrateMountV1
    $entries += @{
        Operation="New-RscMutationNutanix -MigrateMountV1" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation MigrateMountV1
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
    (New-RscMutationNutanix -Operation MountSnapshotV1).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation MountSnapshotV1
    $entries += @{
        Operation="New-RscMutationNutanix -MountSnapshotV1" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation MountSnapshotV1
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
    (New-RscMutationNutanix -Operation PatchMountV1).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation PatchMountV1
    $entries += @{
        Operation="New-RscMutationNutanix -PatchMountV1" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation PatchMountV1
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
    (New-RscMutationNutanix -Operation RefreshCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation RefreshCluster
    $entries += @{
        Operation="New-RscMutationNutanix -RefreshCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation RefreshCluster
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
    (New-RscMutationNutanix -Operation RefreshPrismCentral).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation RefreshPrismCentral
    $entries += @{
        Operation="New-RscMutationNutanix -RefreshPrismCentral" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation RefreshPrismCentral
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
    (New-RscMutationNutanix -Operation RegisterAgentVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation RegisterAgentVm
    $entries += @{
        Operation="New-RscMutationNutanix -RegisterAgentVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation RegisterAgentVm
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
    (New-RscMutationNutanix -Operation RestoreFilesSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation RestoreFilesSnapshot
    $entries += @{
        Operation="New-RscMutationNutanix -RestoreFilesSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation RestoreFilesSnapshot
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
    (New-RscMutationNutanix -Operation UpdateCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation UpdateCluster
    $entries += @{
        Operation="New-RscMutationNutanix -UpdateCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation UpdateCluster
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
    (New-RscMutationNutanix -Operation UpdatePrismCentral).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation UpdatePrismCentral
    $entries += @{
        Operation="New-RscMutationNutanix -UpdatePrismCentral" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation UpdatePrismCentral
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
    (New-RscMutationNutanix -Operation UpdateVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationNutanix -Operation UpdateVm
    $entries += @{
        Operation="New-RscMutationNutanix -UpdateVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationNutanix -Operation UpdateVm
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
    (New-RscMutationO365 -Operation AddOrg).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation AddOrg
    $entries += @{
        Operation="New-RscMutationO365 -AddOrg" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation AddOrg
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
    (New-RscMutationO365 -Operation BackupMailbox).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation BackupMailbox
    $entries += @{
        Operation="New-RscMutationO365 -BackupMailbox" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation BackupMailbox
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
    (New-RscMutationO365 -Operation BackupOnedrive).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation BackupOnedrive
    $entries += @{
        Operation="New-RscMutationO365 -BackupOnedrive" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation BackupOnedrive
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
    (New-RscMutationO365 -Operation BackupSharePointSite).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation BackupSharePointSite
    $entries += @{
        Operation="New-RscMutationO365 -BackupSharePointSite" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation BackupSharePointSite
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
    (New-RscMutationO365 -Operation BackupSharepointDrive).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation BackupSharepointDrive
    $entries += @{
        Operation="New-RscMutationO365 -BackupSharepointDrive" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation BackupSharepointDrive
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
    (New-RscMutationO365 -Operation BackupSharepointList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation BackupSharepointList
    $entries += @{
        Operation="New-RscMutationO365 -BackupSharepointList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation BackupSharepointList
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
    (New-RscMutationO365 -Operation BackupTeam).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation BackupTeam
    $entries += @{
        Operation="New-RscMutationO365 -BackupTeam" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation BackupTeam
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
    (New-RscMutationO365 -Operation CreateAppComplete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation CreateAppComplete
    $entries += @{
        Operation="New-RscMutationO365 -CreateAppComplete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation CreateAppComplete
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
    (New-RscMutationO365 -Operation CreateAppKickoff).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation CreateAppKickoff
    $entries += @{
        Operation="New-RscMutationO365 -CreateAppKickoff" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation CreateAppKickoff
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
    (New-RscMutationO365 -Operation DeleteAzureApp).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation DeleteAzureApp
    $entries += @{
        Operation="New-RscMutationO365 -DeleteAzureApp" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation DeleteAzureApp
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
    (New-RscMutationO365 -Operation DeleteOrg).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation DeleteOrg
    $entries += @{
        Operation="New-RscMutationO365 -DeleteOrg" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation DeleteOrg
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
    (New-RscMutationO365 -Operation DeleteServiceAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation DeleteServiceAccount
    $entries += @{
        Operation="New-RscMutationO365 -DeleteServiceAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation DeleteServiceAccount
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
    (New-RscMutationO365 -Operation EnableSharePoint).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation EnableSharePoint
    $entries += @{
        Operation="New-RscMutationO365 -EnableSharePoint" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation EnableSharePoint
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
    (New-RscMutationO365 -Operation EnableTeams).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation EnableTeams
    $entries += @{
        Operation="New-RscMutationO365 -EnableTeams" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation EnableTeams
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
    (New-RscMutationO365 -Operation ExportMailbox).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation ExportMailbox
    $entries += @{
        Operation="New-RscMutationO365 -ExportMailbox" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation ExportMailbox
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
    (New-RscMutationO365 -Operation InsertCustomerApp).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation InsertCustomerApp
    $entries += @{
        Operation="New-RscMutationO365 -InsertCustomerApp" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation InsertCustomerApp
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
    (New-RscMutationO365 -Operation OauthConsentComplete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation OauthConsentComplete
    $entries += @{
        Operation="New-RscMutationO365 -OauthConsentComplete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation OauthConsentComplete
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
    (New-RscMutationO365 -Operation OauthConsentKickoff).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation OauthConsentKickoff
    $entries += @{
        Operation="New-RscMutationO365 -OauthConsentKickoff" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation OauthConsentKickoff
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
    (New-RscMutationO365 -Operation PdlGroups).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation PdlGroups
    $entries += @{
        Operation="New-RscMutationO365 -PdlGroups" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation PdlGroups
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
    (New-RscMutationO365 -Operation RefreshOrg).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation RefreshOrg
    $entries += @{
        Operation="New-RscMutationO365 -RefreshOrg" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation RefreshOrg
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
    (New-RscMutationO365 -Operation RestoreMailbox).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation RestoreMailbox
    $entries += @{
        Operation="New-RscMutationO365 -RestoreMailbox" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation RestoreMailbox
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
    (New-RscMutationO365 -Operation RestoreSnappable).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation RestoreSnappable
    $entries += @{
        Operation="New-RscMutationO365 -RestoreSnappable" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation RestoreSnappable
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
    (New-RscMutationO365 -Operation RestoreTeamsConversations).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation RestoreTeamsConversations
    $entries += @{
        Operation="New-RscMutationO365 -RestoreTeamsConversations" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation RestoreTeamsConversations
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
    (New-RscMutationO365 -Operation RestoreTeamsFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation RestoreTeamsFiles
    $entries += @{
        Operation="New-RscMutationO365 -RestoreTeamsFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation RestoreTeamsFiles
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
    (New-RscMutationO365 -Operation SaaSSetupKickoff).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation SaaSSetupKickoff
    $entries += @{
        Operation="New-RscMutationO365 -SaaSSetupKickoff" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation SaaSSetupKickoff
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
    (New-RscMutationO365 -Operation SaasSetupComplete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation SaasSetupComplete
    $entries += @{
        Operation="New-RscMutationO365 -SaasSetupComplete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation SaasSetupComplete
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
    (New-RscMutationO365 -Operation SetServiceAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation SetServiceAccount
    $entries += @{
        Operation="New-RscMutationO365 -SetServiceAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation SetServiceAccount
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
    (New-RscMutationO365 -Operation SetupKickoff).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation SetupKickoff
    $entries += @{
        Operation="New-RscMutationO365 -SetupKickoff" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation SetupKickoff
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
    (New-RscMutationO365 -Operation UpdateAppAuthStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation UpdateAppAuthStatus
    $entries += @{
        Operation="New-RscMutationO365 -UpdateAppAuthStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation UpdateAppAuthStatus
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
    (New-RscMutationO365 -Operation UpdateAppPermissions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation UpdateAppPermissions
    $entries += @{
        Operation="New-RscMutationO365 -UpdateAppPermissions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation UpdateAppPermissions
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
    (New-RscMutationO365 -Operation UpdateOrgCustomName).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationO365 -Operation UpdateOrgCustomName
    $entries += @{
        Operation="New-RscMutationO365 -UpdateOrgCustomName" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationO365 -Operation UpdateOrgCustomName
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
    (New-RscMutationOracle -Operation BulkUpdateDatabases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation BulkUpdateDatabases
    $entries += @{
        Operation="New-RscMutationOracle -BulkUpdateDatabases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation BulkUpdateDatabases
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
    (New-RscMutationOracle -Operation BulkUpdateHosts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation BulkUpdateHosts
    $entries += @{
        Operation="New-RscMutationOracle -BulkUpdateHosts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation BulkUpdateHosts
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
    (New-RscMutationOracle -Operation BulkUpdateRacs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation BulkUpdateRacs
    $entries += @{
        Operation="New-RscMutationOracle -BulkUpdateRacs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation BulkUpdateRacs
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
    (New-RscMutationOracle -Operation CreatePdbRestore).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation CreatePdbRestore
    $entries += @{
        Operation="New-RscMutationOracle -CreatePdbRestore" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation CreatePdbRestore
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
    (New-RscMutationOracle -Operation DeleteAllDatabaseSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation DeleteAllDatabaseSnapshots
    $entries += @{
        Operation="New-RscMutationOracle -DeleteAllDatabaseSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation DeleteAllDatabaseSnapshots
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
    (New-RscMutationOracle -Operation DeleteMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation DeleteMount
    $entries += @{
        Operation="New-RscMutationOracle -DeleteMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation DeleteMount
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
    (New-RscMutationOracle -Operation DownloadDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation DownloadDatabaseSnapshot
    $entries += @{
        Operation="New-RscMutationOracle -DownloadDatabaseSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation DownloadDatabaseSnapshot
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
    (New-RscMutationOracle -Operation ExportDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation ExportDatabase
    $entries += @{
        Operation="New-RscMutationOracle -ExportDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation ExportDatabase
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
    (New-RscMutationOracle -Operation ExportTablespace).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation ExportTablespace
    $entries += @{
        Operation="New-RscMutationOracle -ExportTablespace" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation ExportTablespace
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
    (New-RscMutationOracle -Operation InstantRecoverSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation InstantRecoverSnapshot
    $entries += @{
        Operation="New-RscMutationOracle -InstantRecoverSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation InstantRecoverSnapshot
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
    (New-RscMutationOracle -Operation MountDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation MountDatabase
    $entries += @{
        Operation="New-RscMutationOracle -MountDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation MountDatabase
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
    (New-RscMutationOracle -Operation RefreshDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation RefreshDatabase
    $entries += @{
        Operation="New-RscMutationOracle -RefreshDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation RefreshDatabase
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
    (New-RscMutationOracle -Operation RestoreLogs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation RestoreLogs
    $entries += @{
        Operation="New-RscMutationOracle -RestoreLogs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation RestoreLogs
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
    (New-RscMutationOracle -Operation TakeOnDemandDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation TakeOnDemandDatabaseSnapshot
    $entries += @{
        Operation="New-RscMutationOracle -TakeOnDemandDatabaseSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation TakeOnDemandDatabaseSnapshot
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
    (New-RscMutationOracle -Operation TakeOnDemandLogSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation TakeOnDemandLogSnapshot
    $entries += @{
        Operation="New-RscMutationOracle -TakeOnDemandLogSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation TakeOnDemandLogSnapshot
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
    (New-RscMutationOracle -Operation UpdateDataGuardGroup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation UpdateDataGuardGroup
    $entries += @{
        Operation="New-RscMutationOracle -UpdateDataGuardGroup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation UpdateDataGuardGroup
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
    (New-RscMutationOracle -Operation ValidateAcoFile).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation ValidateAcoFile
    $entries += @{
        Operation="New-RscMutationOracle -ValidateAcoFile" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation ValidateAcoFile
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
    (New-RscMutationOracle -Operation ValidateDatabaseBackups).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationOracle -Operation ValidateDatabaseBackups
    $entries += @{
        Operation="New-RscMutationOracle -ValidateDatabaseBackups" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationOracle -Operation ValidateDatabaseBackups
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
    (New-RscMutationPolicy -Operation Policies).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationPolicy -Operation Policies
    $entries += @{
        Operation="New-RscMutationPolicy -Policies" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationPolicy -Operation Policies
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
    (New-RscMutationRansomware -Operation TriggerDetection).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationRansomware -Operation TriggerDetection
    $entries += @{
        Operation="New-RscMutationRansomware -TriggerDetection" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationRansomware -Operation TriggerDetection
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
    (New-RscMutationRcs -Operation CreateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationRcs -Operation CreateAutomaticTargetMapping
    $entries += @{
        Operation="New-RscMutationRcs -CreateAutomaticTargetMapping" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationRcs -Operation CreateAutomaticTargetMapping
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
    (New-RscMutationRcs -Operation CreateReaderTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationRcs -Operation CreateReaderTarget
    $entries += @{
        Operation="New-RscMutationRcs -CreateReaderTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationRcs -Operation CreateReaderTarget
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
    (New-RscMutationRcs -Operation CreateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationRcs -Operation CreateTarget
    $entries += @{
        Operation="New-RscMutationRcs -CreateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationRcs -Operation CreateTarget
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
    (New-RscMutationRcs -Operation UpdateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationRcs -Operation UpdateAutomaticTargetMapping
    $entries += @{
        Operation="New-RscMutationRcs -UpdateAutomaticTargetMapping" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationRcs -Operation UpdateAutomaticTargetMapping
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
    (New-RscMutationRcv -Operation CreateLocationsFromTemplate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationRcv -Operation CreateLocationsFromTemplate
    $entries += @{
        Operation="New-RscMutationRcv -CreateLocationsFromTemplate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationRcv -Operation CreateLocationsFromTemplate
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
    (New-RscMutationRcv -Operation CreatePrivateEndpointApprovalRequest).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationRcv -Operation CreatePrivateEndpointApprovalRequest
    $entries += @{
        Operation="New-RscMutationRcv -CreatePrivateEndpointApprovalRequest" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationRcv -Operation CreatePrivateEndpointApprovalRequest
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
    (New-RscMutationRcv -Operation UpdateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationRcv -Operation UpdateTarget
    $entries += @{
        Operation="New-RscMutationRcv -UpdateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationRcv -Operation UpdateTarget
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
    (New-RscMutationReplication -Operation CreatePair).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReplication -Operation CreatePair
    $entries += @{
        Operation="New-RscMutationReplication -CreatePair" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReplication -Operation CreatePair
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
    (New-RscMutationReplication -Operation DeletePair).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReplication -Operation DeletePair
    $entries += @{
        Operation="New-RscMutationReplication -DeletePair" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReplication -Operation DeletePair
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
    (New-RscMutationReplication -Operation DisablePause).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReplication -Operation DisablePause
    $entries += @{
        Operation="New-RscMutationReplication -DisablePause" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReplication -Operation DisablePause
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
    (New-RscMutationReplication -Operation EnablePause).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReplication -Operation EnablePause
    $entries += @{
        Operation="New-RscMutationReplication -EnablePause" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReplication -Operation EnablePause
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
    (New-RscMutationReplication -Operation UpdateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReplication -Operation UpdateTarget
    $entries += @{
        Operation="New-RscMutationReplication -UpdateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReplication -Operation UpdateTarget
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
    (New-RscMutationReport -Operation CreateCustom).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation CreateCustom
    $entries += @{
        Operation="New-RscMutationReport -CreateCustom" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation CreateCustom
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
    (New-RscMutationReport -Operation CreateScheduled).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation CreateScheduled
    $entries += @{
        Operation="New-RscMutationReport -CreateScheduled" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation CreateScheduled
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
    (New-RscMutationReport -Operation DeleteCustom).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation DeleteCustom
    $entries += @{
        Operation="New-RscMutationReport -DeleteCustom" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation DeleteCustom
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
    (New-RscMutationReport -Operation DeleteScheduled).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation DeleteScheduled
    $entries += @{
        Operation="New-RscMutationReport -DeleteScheduled" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation DeleteScheduled
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
    (New-RscMutationReport -Operation SendPdf).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation SendPdf
    $entries += @{
        Operation="New-RscMutationReport -SendPdf" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation SendPdf
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
    (New-RscMutationReport -Operation SendScheduledAsync).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation SendScheduledAsync
    $entries += @{
        Operation="New-RscMutationReport -SendScheduledAsync" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation SendScheduledAsync
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
    (New-RscMutationReport -Operation StartClusterMigrationJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation StartClusterMigrationJob
    $entries += @{
        Operation="New-RscMutationReport -StartClusterMigrationJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation StartClusterMigrationJob
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
    (New-RscMutationReport -Operation UpdateCustom).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation UpdateCustom
    $entries += @{
        Operation="New-RscMutationReport -UpdateCustom" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation UpdateCustom
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
    (New-RscMutationReport -Operation UpdateScheduled).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationReport -Operation UpdateScheduled
    $entries += @{
        Operation="New-RscMutationReport -UpdateScheduled" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationReport -Operation UpdateScheduled
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
    (New-RscMutationSapHana -Operation AddSystem).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation AddSystem
    $entries += @{
        Operation="New-RscMutationSapHana -AddSystem" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation AddSystem
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
    (New-RscMutationSapHana -Operation ConfigureRestore).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation ConfigureRestore
    $entries += @{
        Operation="New-RscMutationSapHana -ConfigureRestore" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation ConfigureRestore
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
    (New-RscMutationSapHana -Operation CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation CreateOnDemandBackup
    $entries += @{
        Operation="New-RscMutationSapHana -CreateOnDemandBackup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation CreateOnDemandBackup
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
    (New-RscMutationSapHana -Operation CreateSystemRefresh).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation CreateSystemRefresh
    $entries += @{
        Operation="New-RscMutationSapHana -CreateSystemRefresh" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation CreateSystemRefresh
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
    (New-RscMutationSapHana -Operation DeleteDbSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation DeleteDbSnapshot
    $entries += @{
        Operation="New-RscMutationSapHana -DeleteDbSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation DeleteDbSnapshot
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
    (New-RscMutationSapHana -Operation DeleteSystem).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation DeleteSystem
    $entries += @{
        Operation="New-RscMutationSapHana -DeleteSystem" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation DeleteSystem
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
    (New-RscMutationSapHana -Operation ExpireDownloadedSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation ExpireDownloadedSnapshots
    $entries += @{
        Operation="New-RscMutationSapHana -ExpireDownloadedSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation ExpireDownloadedSnapshots
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
    (New-RscMutationSapHana -Operation PatchSystem).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation PatchSystem
    $entries += @{
        Operation="New-RscMutationSapHana -PatchSystem" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation PatchSystem
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
    (New-RscMutationSapHana -Operation UnconfigureRestore).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSapHana -Operation UnconfigureRestore
    $entries += @{
        Operation="New-RscMutationSapHana -UnconfigureRestore" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSapHana -Operation UnconfigureRestore
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
    (New-RscMutationServiceAccount -Operation Create).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationServiceAccount -Operation Create
    $entries += @{
        Operation="New-RscMutationServiceAccount -Create" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationServiceAccount -Operation Create
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
    (New-RscMutationServiceAccount -Operation Delete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationServiceAccount -Operation Delete
    $entries += @{
        Operation="New-RscMutationServiceAccount -Delete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationServiceAccount -Operation Delete
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
    (New-RscMutationServiceAccount -Operation Rotate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationServiceAccount -Operation Rotate
    $entries += @{
        Operation="New-RscMutationServiceAccount -Rotate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationServiceAccount -Operation Rotate
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
    (New-RscMutationServiceAccount -Operation Update).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationServiceAccount -Operation Update
    $entries += @{
        Operation="New-RscMutationServiceAccount -Update" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationServiceAccount -Operation Update
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
    (New-RscMutationSharepoint -Operation ExcludeObjectsFromProtection).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSharepoint -Operation ExcludeObjectsFromProtection
    $entries += @{
        Operation="New-RscMutationSharepoint -ExcludeObjectsFromProtection" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSharepoint -Operation ExcludeObjectsFromProtection
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
    (New-RscMutationSla -Operation Assign).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation Assign
    $entries += @{
        Operation="New-RscMutationSla -Assign" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation Assign
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
    (New-RscMutationSla -Operation AssignRetentionToSnappables).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation AssignRetentionToSnappables
    $entries += @{
        Operation="New-RscMutationSla -AssignRetentionToSnappables" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation AssignRetentionToSnappables
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
    (New-RscMutationSla -Operation AssignRetentionToSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation AssignRetentionToSnapshots
    $entries += @{
        Operation="New-RscMutationSla -AssignRetentionToSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation AssignRetentionToSnapshots
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
    (New-RscMutationSla -Operation AssignsForSnappableHierarchies).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation AssignsForSnappableHierarchies
    $entries += @{
        Operation="New-RscMutationSla -AssignsForSnappableHierarchies" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation AssignsForSnappableHierarchies
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
    (New-RscMutationSla -Operation CreateGlobal).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation CreateGlobal
    $entries += @{
        Operation="New-RscMutationSla -CreateGlobal" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation CreateGlobal
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
    (New-RscMutationSla -Operation ExportManagedVolumeSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation ExportManagedVolumeSnapshot
    $entries += @{
        Operation="New-RscMutationSla -ExportManagedVolumeSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation ExportManagedVolumeSnapshot
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
    (New-RscMutationSla -Operation GetPendingAssignments).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation GetPendingAssignments
    $entries += @{
        Operation="New-RscMutationSla -GetPendingAssignments" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation GetPendingAssignments
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
    (New-RscMutationSla -Operation Pause).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation Pause
    $entries += @{
        Operation="New-RscMutationSla -Pause" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation Pause
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
    (New-RscMutationSla -Operation UpdateGlobal).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSla -Operation UpdateGlobal
    $entries += @{
        Operation="New-RscMutationSla -UpdateGlobal" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSla -Operation UpdateGlobal
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
    (New-RscMutationSmb -Operation AddAndJoinDomain).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSmb -Operation AddAndJoinDomain
    $entries += @{
        Operation="New-RscMutationSmb -AddAndJoinDomain" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSmb -Operation AddAndJoinDomain
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
    (New-RscMutationSmb -Operation DeleteDomain).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSmb -Operation DeleteDomain
    $entries += @{
        Operation="New-RscMutationSmb -DeleteDomain" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSmb -Operation DeleteDomain
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
    (New-RscMutationSmb -Operation JoinDomain).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSmb -Operation JoinDomain
    $entries += @{
        Operation="New-RscMutationSmb -JoinDomain" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSmb -Operation JoinDomain
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
    (New-RscMutationSmb -Operation PutConfiguration).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSmb -Operation PutConfiguration
    $entries += @{
        Operation="New-RscMutationSmb -PutConfiguration" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSmb -Operation PutConfiguration
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
    (New-RscMutationSnapshot -Operation BatchQuarantine).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation BatchQuarantine
    $entries += @{
        Operation="New-RscMutationSnapshot -BatchQuarantine" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation BatchQuarantine
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
    (New-RscMutationSnapshot -Operation BatchReleaseFromQuarantine).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation BatchReleaseFromQuarantine
    $entries += @{
        Operation="New-RscMutationSnapshot -BatchReleaseFromQuarantine" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation BatchReleaseFromQuarantine
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
    (New-RscMutationSnapshot -Operation BulkTierExistings).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation BulkTierExistings
    $entries += @{
        Operation="New-RscMutationSnapshot -BulkTierExistings" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation BulkTierExistings
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
    (New-RscMutationSnapshot -Operation CreateDownloadForVolumeGroup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation CreateDownloadForVolumeGroup
    $entries += @{
        Operation="New-RscMutationSnapshot -CreateDownloadForVolumeGroup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation CreateDownloadForVolumeGroup
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
    (New-RscMutationSnapshot -Operation CreateFileset).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation CreateFileset
    $entries += @{
        Operation="New-RscMutationSnapshot -CreateFileset" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation CreateFileset
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
    (New-RscMutationSnapshot -Operation DeleteCloudWorkload).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation DeleteCloudWorkload
    $entries += @{
        Operation="New-RscMutationSnapshot -DeleteCloudWorkload" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation DeleteCloudWorkload
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
    (New-RscMutationSnapshot -Operation DeleteFilesets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation DeleteFilesets
    $entries += @{
        Operation="New-RscMutationSnapshot -DeleteFilesets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation DeleteFilesets
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
    (New-RscMutationSnapshot -Operation FilesetDownloadFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation FilesetDownloadFiles
    $entries += @{
        Operation="New-RscMutationSnapshot -FilesetDownloadFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation FilesetDownloadFiles
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
    (New-RscMutationSnapshot -Operation FilesetExportFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation FilesetExportFiles
    $entries += @{
        Operation="New-RscMutationSnapshot -FilesetExportFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation FilesetExportFiles
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
    (New-RscMutationSnapshot -Operation RestoreVolumeGroupFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation RestoreVolumeGroupFiles
    $entries += @{
        Operation="New-RscMutationSnapshot -RestoreVolumeGroupFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation RestoreVolumeGroupFiles
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
    (New-RscMutationSnapshot -Operation StartEc2InstanceExportJob).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation StartEc2InstanceExportJob
    $entries += @{
        Operation="New-RscMutationSnapshot -StartEc2InstanceExportJob" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation StartEc2InstanceExportJob
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
    (New-RscMutationSnapshot -Operation StartRecoverS3Job).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation StartRecoverS3Job
    $entries += @{
        Operation="New-RscMutationSnapshot -StartRecoverS3Job" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation StartRecoverS3Job
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
    (New-RscMutationSnapshot -Operation TakeOnDemand).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation TakeOnDemand
    $entries += @{
        Operation="New-RscMutationSnapshot -TakeOnDemand" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation TakeOnDemand
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
    (New-RscMutationSnapshot -Operation UploadDatabaseToBlobstore).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation UploadDatabaseToBlobstore
    $entries += @{
        Operation="New-RscMutationSnapshot -UploadDatabaseToBlobstore" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation UploadDatabaseToBlobstore
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
    (New-RscMutationSnapshot -Operation VmwareDownloadFromLocation).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationSnapshot -Operation VmwareDownloadFromLocation
    $entries += @{
        Operation="New-RscMutationSnapshot -VmwareDownloadFromLocation" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationSnapshot -Operation VmwareDownloadFromLocation
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
    (New-RscMutationStorageArray -Operation Add).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationStorageArray -Operation Add
    $entries += @{
        Operation="New-RscMutationStorageArray -Add" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationStorageArray -Operation Add
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
    (New-RscMutationStorageArray -Operation Delete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationStorageArray -Operation Delete
    $entries += @{
        Operation="New-RscMutationStorageArray -Delete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationStorageArray -Operation Delete
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
    (New-RscMutationStorageArray -Operation Refresh).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationStorageArray -Operation Refresh
    $entries += @{
        Operation="New-RscMutationStorageArray -Refresh" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationStorageArray -Operation Refresh
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
    (New-RscMutationStorageArray -Operation Update).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationStorageArray -Operation Update
    $entries += @{
        Operation="New-RscMutationStorageArray -Update" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationStorageArray -Operation Update
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
    (New-RscMutationTape -Operation CreateReaderTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationTape -Operation CreateReaderTarget
    $entries += @{
        Operation="New-RscMutationTape -CreateReaderTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationTape -Operation CreateReaderTarget
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
    (New-RscMutationTape -Operation CreateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationTape -Operation CreateTarget
    $entries += @{
        Operation="New-RscMutationTape -CreateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationTape -Operation CreateTarget
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
    (New-RscMutationTape -Operation UpdateTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationTape -Operation UpdateTarget
    $entries += @{
        Operation="New-RscMutationTape -UpdateTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationTape -Operation UpdateTarget
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
    (New-RscMutationThreat -Operation CancelHunt).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationThreat -Operation CancelHunt
    $entries += @{
        Operation="New-RscMutationThreat -CancelHunt" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationThreat -Operation CancelHunt
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
    (New-RscMutationThreat -Operation EnableMonitoring).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationThreat -Operation EnableMonitoring
    $entries += @{
        Operation="New-RscMutationThreat -EnableMonitoring" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationThreat -Operation EnableMonitoring
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
    (New-RscMutationThreat -Operation StartHunt).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationThreat -Operation StartHunt
    $entries += @{
        Operation="New-RscMutationThreat -StartHunt" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationThreat -Operation StartHunt
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
    (New-RscMutationVcenter -Operation Create).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVcenter -Operation Create
    $entries += @{
        Operation="New-RscMutationVcenter -Create" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVcenter -Operation Create
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
    (New-RscMutationVcenter -Operation Delete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVcenter -Operation Delete
    $entries += @{
        Operation="New-RscMutationVcenter -Delete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVcenter -Operation Delete
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
    (New-RscMutationVcenter -Operation Refresh).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVcenter -Operation Refresh
    $entries += @{
        Operation="New-RscMutationVcenter -Refresh" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVcenter -Operation Refresh
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
    (New-RscMutationVcenter -Operation Update).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVcenter -Operation Update
    $entries += @{
        Operation="New-RscMutationVcenter -Update" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVcenter -Operation Update
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
    (New-RscMutationVcenter -Operation UpdateHotAddBandwidth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVcenter -Operation UpdateHotAddBandwidth
    $entries += @{
        Operation="New-RscMutationVcenter -UpdateHotAddBandwidth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVcenter -Operation UpdateHotAddBandwidth
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
    (New-RscMutationVcenter -Operation UpdateHotAddNetwork).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVcenter -Operation UpdateHotAddNetwork
    $entries += @{
        Operation="New-RscMutationVcenter -UpdateHotAddNetwork" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVcenter -Operation UpdateHotAddNetwork
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
    (New-RscMutationVsphere -Operation BulkOnDemandSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphere -Operation BulkOnDemandSnapshot
    $entries += @{
        Operation="New-RscMutationVsphere -BulkOnDemandSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphere -Operation BulkOnDemandSnapshot
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
    (New-RscMutationVsphere -Operation CreateAdvancedTag).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphere -Operation CreateAdvancedTag
    $entries += @{
        Operation="New-RscMutationVsphere -CreateAdvancedTag" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphere -Operation CreateAdvancedTag
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
    (New-RscMutationVsphere -Operation DeleteAdvancedTag).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphere -Operation DeleteAdvancedTag
    $entries += @{
        Operation="New-RscMutationVsphere -DeleteAdvancedTag" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphere -Operation DeleteAdvancedTag
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
    (New-RscMutationVsphere -Operation DeleteLiveMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphere -Operation DeleteLiveMount
    $entries += @{
        Operation="New-RscMutationVsphere -DeleteLiveMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphere -Operation DeleteLiveMount
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
    (New-RscMutationVsphere -Operation DownloadVirtualMachineFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphere -Operation DownloadVirtualMachineFiles
    $entries += @{
        Operation="New-RscMutationVsphere -DownloadVirtualMachineFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphere -Operation DownloadVirtualMachineFiles
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
    (New-RscMutationVsphere -Operation ExportSnapshotToStandaloneHostV2).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphere -Operation ExportSnapshotToStandaloneHostV2
    $entries += @{
        Operation="New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphere -Operation ExportSnapshotToStandaloneHostV2
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
    (New-RscMutationVsphere -Operation OnDemandSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphere -Operation OnDemandSnapshot
    $entries += @{
        Operation="New-RscMutationVsphere -OnDemandSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphere -Operation OnDemandSnapshot
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
    (New-RscMutationVsphere -Operation UpdateAdvancedTag).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphere -Operation UpdateAdvancedTag
    $entries += @{
        Operation="New-RscMutationVsphere -UpdateAdvancedTag" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphere -Operation UpdateAdvancedTag
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
    (New-RscMutationVsphereVm -Operation BatchExport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation BatchExport
    $entries += @{
        Operation="New-RscMutationVsphereVm -BatchExport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation BatchExport
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
    (New-RscMutationVsphereVm -Operation BatchExportV3).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation BatchExportV3
    $entries += @{
        Operation="New-RscMutationVsphereVm -BatchExportV3" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation BatchExportV3
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
    (New-RscMutationVsphereVm -Operation BatchInPlaceRecovery).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation BatchInPlaceRecovery
    $entries += @{
        Operation="New-RscMutationVsphereVm -BatchInPlaceRecovery" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation BatchInPlaceRecovery
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
    (New-RscMutationVsphereVm -Operation DeleteSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation DeleteSnapshot
    $entries += @{
        Operation="New-RscMutationVsphereVm -DeleteSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation DeleteSnapshot
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
    (New-RscMutationVsphereVm -Operation DownloadSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation DownloadSnapshot
    $entries += @{
        Operation="New-RscMutationVsphereVm -DownloadSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation DownloadSnapshot
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
    (New-RscMutationVsphereVm -Operation DownloadSnapshotFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation DownloadSnapshotFiles
    $entries += @{
        Operation="New-RscMutationVsphereVm -DownloadSnapshotFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation DownloadSnapshotFiles
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
    (New-RscMutationVsphereVm -Operation ExcludeVmDisks).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation ExcludeVmDisks
    $entries += @{
        Operation="New-RscMutationVsphereVm -ExcludeVmDisks" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation ExcludeVmDisks
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
    (New-RscMutationVsphereVm -Operation ExportSnapshotV2).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation ExportSnapshotV2
    $entries += @{
        Operation="New-RscMutationVsphereVm -ExportSnapshotV2" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation ExportSnapshotV2
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
    (New-RscMutationVsphereVm -Operation ExportSnapshotV3).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation ExportSnapshotV3
    $entries += @{
        Operation="New-RscMutationVsphereVm -ExportSnapshotV3" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation ExportSnapshotV3
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
    (New-RscMutationVsphereVm -Operation ExportSnapshotWithDownloadFromCloud).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation ExportSnapshotWithDownloadFromCloud
    $entries += @{
        Operation="New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation ExportSnapshotWithDownloadFromCloud
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
    (New-RscMutationVsphereVm -Operation InitiateBatchInstantRecovery).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation InitiateBatchInstantRecovery
    $entries += @{
        Operation="New-RscMutationVsphereVm -InitiateBatchInstantRecovery" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation InitiateBatchInstantRecovery
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
    (New-RscMutationVsphereVm -Operation InitiateBatchLiveMountV2).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation InitiateBatchLiveMountV2
    $entries += @{
        Operation="New-RscMutationVsphereVm -InitiateBatchLiveMountV2" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation InitiateBatchLiveMountV2
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
    (New-RscMutationVsphereVm -Operation InitiateDiskMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation InitiateDiskMount
    $entries += @{
        Operation="New-RscMutationVsphereVm -InitiateDiskMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation InitiateDiskMount
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
    (New-RscMutationVsphereVm -Operation InitiateInPlaceRecovery).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation InitiateInPlaceRecovery
    $entries += @{
        Operation="New-RscMutationVsphereVm -InitiateInPlaceRecovery" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation InitiateInPlaceRecovery
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
    (New-RscMutationVsphereVm -Operation InitiateInstantRecoveryV2).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation InitiateInstantRecoveryV2
    $entries += @{
        Operation="New-RscMutationVsphereVm -InitiateInstantRecoveryV2" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation InitiateInstantRecoveryV2
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
    (New-RscMutationVsphereVm -Operation InitiateLiveMountV2).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation InitiateLiveMountV2
    $entries += @{
        Operation="New-RscMutationVsphereVm -InitiateLiveMountV2" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation InitiateLiveMountV2
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
    (New-RscMutationVsphereVm -Operation ListEsxiDatastores).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation ListEsxiDatastores
    $entries += @{
        Operation="New-RscMutationVsphereVm -ListEsxiDatastores" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation ListEsxiDatastores
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
    (New-RscMutationVsphereVm -Operation MountRelocate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation MountRelocate
    $entries += @{
        Operation="New-RscMutationVsphereVm -MountRelocate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation MountRelocate
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
    (New-RscMutationVsphereVm -Operation MountRelocateV2).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation MountRelocateV2
    $entries += @{
        Operation="New-RscMutationVsphereVm -MountRelocateV2" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation MountRelocateV2
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
    (New-RscMutationVsphereVm -Operation PowerOnOffLiveMount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation PowerOnOffLiveMount
    $entries += @{
        Operation="New-RscMutationVsphereVm -PowerOnOffLiveMount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation PowerOnOffLiveMount
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
    (New-RscMutationVsphereVm -Operation RecoverFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation RecoverFiles
    $entries += @{
        Operation="New-RscMutationVsphereVm -RecoverFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation RecoverFiles
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
    (New-RscMutationVsphereVm -Operation RecoverFilesNew).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation RecoverFilesNew
    $entries += @{
        Operation="New-RscMutationVsphereVm -RecoverFilesNew" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation RecoverFilesNew
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
    (New-RscMutationVsphereVm -Operation RegisterAgent).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation RegisterAgent
    $entries += @{
        Operation="New-RscMutationVsphereVm -RegisterAgent" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation RegisterAgent
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
    (New-RscMutationVsphereVm -Operation Update).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationVsphereVm -Operation Update
    $entries += @{
        Operation="New-RscMutationVsphereVm -Update" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationVsphereVm -Operation Update
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
    (New-RscMutationWebhook -Operation Create).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationWebhook -Operation Create
    $entries += @{
        Operation="New-RscMutationWebhook -Create" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationWebhook -Operation Create
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
    (New-RscMutationWebhook -Operation Delete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationWebhook -Operation Delete
    $entries += @{
        Operation="New-RscMutationWebhook -Delete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationWebhook -Operation Delete
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
    (New-RscMutationWebhook -Operation Test).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationWebhook -Operation Test
    $entries += @{
        Operation="New-RscMutationWebhook -Test" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationWebhook -Operation Test
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
    (New-RscMutationWebhook -Operation TestExisting).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationWebhook -Operation TestExisting
    $entries += @{
        Operation="New-RscMutationWebhook -TestExisting" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationWebhook -Operation TestExisting
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
    (New-RscMutationWebhook -Operation Update).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscMutationWebhook -Operation Update
    $entries += @{
        Operation="New-RscMutationWebhook -Update" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscMutationWebhook -Operation Update
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
    (New-RscQueryAccount -Operation EnabledFeatures).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAccount -Operation EnabledFeatures
    $entries += @{
        Operation="New-RscQueryAccount -EnabledFeatures" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAccount -Operation EnabledFeatures
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
    (New-RscQueryAccount -Operation Id).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAccount -Operation Id
    $entries += @{
        Operation="New-RscQueryAccount -Id" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAccount -Operation Id
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
    (New-RscQueryAccount -Operation Lookup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAccount -Operation Lookup
    $entries += @{
        Operation="New-RscQueryAccount -Lookup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAccount -Operation Lookup
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
    (New-RscQueryAccount -Operation Owners).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAccount -Operation Owners
    $entries += @{
        Operation="New-RscQueryAccount -Owners" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAccount -Operation Owners
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
    (New-RscQueryAccount -Operation Products).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAccount -Operation Products
    $entries += @{
        Operation="New-RscQueryAccount -Products" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAccount -Operation Products
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
    (New-RscQueryAccount -Operation Settings).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAccount -Operation Settings
    $entries += @{
        Operation="New-RscQueryAccount -Settings" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAccount -Operation Settings
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
    (New-RscQueryAccount -Operation Users).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAccount -Operation Users
    $entries += @{
        Operation="New-RscQueryAccount -Users" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAccount -Operation Users
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
    (New-RscQueryActivitySeries -Operation ActivitySeries).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryActivitySeries -Operation ActivitySeries
    $entries += @{
        Operation="New-RscQueryActivitySeries -ActivitySeries" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryActivitySeries -Operation ActivitySeries
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
    (New-RscQueryActivitySeries -Operation List).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryActivitySeries -Operation List
    $entries += @{
        Operation="New-RscQueryActivitySeries -List" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryActivitySeries -Operation List
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
    (New-RscQueryActivitySeries -Operation UserFileTimeline).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryActivitySeries -Operation UserFileTimeline
    $entries += @{
        Operation="New-RscQueryActivitySeries -UserFileTimeline" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryActivitySeries -Operation UserFileTimeline
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
    (New-RscQueryActivitySeries -Operation UserTimeline).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryActivitySeries -Operation UserTimeline
    $entries += @{
        Operation="New-RscQueryActivitySeries -UserTimeline" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryActivitySeries -Operation UserTimeline
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
    (New-RscQueryAws -Operation ArtifactsToDelete).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation ArtifactsToDelete
    $entries += @{
        Operation="New-RscQueryAws -ArtifactsToDelete" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation ArtifactsToDelete
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
    (New-RscQueryAws -Operation AvailabilityZonesByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation AvailabilityZonesByRegion
    $entries += @{
        Operation="New-RscQueryAws -AvailabilityZonesByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation AvailabilityZonesByRegion
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
    (New-RscQueryAws -Operation CdmVersions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation CdmVersions
    $entries += @{
        Operation="New-RscQueryAws -CdmVersions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation CdmVersions
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
    (New-RscQueryAws -Operation CloudAccountConfigs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation CloudAccountConfigs
    $entries += @{
        Operation="New-RscQueryAws -CloudAccountConfigs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation CloudAccountConfigs
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
    (New-RscQueryAws -Operation CloudAccountListSecurityGroups).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation CloudAccountListSecurityGroups
    $entries += @{
        Operation="New-RscQueryAws -CloudAccountListSecurityGroups" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation CloudAccountListSecurityGroups
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
    (New-RscQueryAws -Operation CloudAccountListSubnets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation CloudAccountListSubnets
    $entries += @{
        Operation="New-RscQueryAws -CloudAccountListSubnets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation CloudAccountListSubnets
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
    (New-RscQueryAws -Operation CloudAccountListVpcs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation CloudAccountListVpcs
    $entries += @{
        Operation="New-RscQueryAws -CloudAccountListVpcs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation CloudAccountListVpcs
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
    (New-RscQueryAws -Operation CloudAccountWithFeatures).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation CloudAccountWithFeatures
    $entries += @{
        Operation="New-RscQueryAws -CloudAccountWithFeatures" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation CloudAccountWithFeatures
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
    (New-RscQueryAws -Operation CloudAccountsWithFeatures).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation CloudAccountsWithFeatures
    $entries += @{
        Operation="New-RscQueryAws -CloudAccountsWithFeatures" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation CloudAccountsWithFeatures
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
    (New-RscQueryAws -Operation ComputeSettings).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation ComputeSettings
    $entries += @{
        Operation="New-RscQueryAws -ComputeSettings" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation ComputeSettings
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
    (New-RscQueryAws -Operation DbParameterGroupsByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation DbParameterGroupsByRegion
    $entries += @{
        Operation="New-RscQueryAws -DbParameterGroupsByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation DbParameterGroupsByRegion
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
    (New-RscQueryAws -Operation DbSubnetGroupsByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation DbSubnetGroupsByRegion
    $entries += @{
        Operation="New-RscQueryAws -DbSubnetGroupsByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation DbSubnetGroupsByRegion
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
    (New-RscQueryAws -Operation Ec2KeyPairsByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation Ec2KeyPairsByRegion
    $entries += @{
        Operation="New-RscQueryAws -Ec2KeyPairsByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation Ec2KeyPairsByRegion
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
    (New-RscQueryAws -Operation ExocomputeConfigs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation ExocomputeConfigs
    $entries += @{
        Operation="New-RscQueryAws -ExocomputeConfigs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation ExocomputeConfigs
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
    (New-RscQueryAws -Operation InstanceProfileNames).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation InstanceProfileNames
    $entries += @{
        Operation="New-RscQueryAws -InstanceProfileNames" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation InstanceProfileNames
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
    (New-RscQueryAws -Operation IsS3BucketNameAvailable).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation IsS3BucketNameAvailable
    $entries += @{
        Operation="New-RscQueryAws -IsS3BucketNameAvailable" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation IsS3BucketNameAvailable
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
    (New-RscQueryAws -Operation KmsEncryptionKeysByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation KmsEncryptionKeysByRegion
    $entries += @{
        Operation="New-RscQueryAws -KmsEncryptionKeysByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation KmsEncryptionKeysByRegion
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
    (New-RscQueryAws -Operation OptionGroupsByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation OptionGroupsByRegion
    $entries += @{
        Operation="New-RscQueryAws -OptionGroupsByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation OptionGroupsByRegion
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
    (New-RscQueryAws -Operation PermissionPolicies).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation PermissionPolicies
    $entries += @{
        Operation="New-RscQueryAws -PermissionPolicies" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation PermissionPolicies
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
    (New-RscQueryAws -Operation RdsInstanceDetails).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation RdsInstanceDetails
    $entries += @{
        Operation="New-RscQueryAws -RdsInstanceDetails" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation RdsInstanceDetails
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
    (New-RscQueryAws -Operation Regions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation Regions
    $entries += @{
        Operation="New-RscQueryAws -Regions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation Regions
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
    (New-RscQueryAws -Operation S3BucketStateForRecovery).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation S3BucketStateForRecovery
    $entries += @{
        Operation="New-RscQueryAws -S3BucketStateForRecovery" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation S3BucketStateForRecovery
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
    (New-RscQueryAws -Operation S3Buckets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation S3Buckets
    $entries += @{
        Operation="New-RscQueryAws -S3Buckets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation S3Buckets
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
    (New-RscQueryAws -Operation S3BucketsDetails).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation S3BucketsDetails
    $entries += @{
        Operation="New-RscQueryAws -S3BucketsDetails" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation S3BucketsDetails
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
    (New-RscQueryAws -Operation SupportedRdsDatabaseInstanceClasses).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation SupportedRdsDatabaseInstanceClasses
    $entries += @{
        Operation="New-RscQueryAws -SupportedRdsDatabaseInstanceClasses" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation SupportedRdsDatabaseInstanceClasses
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
    (New-RscQueryAws -Operation TrustPolicy).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation TrustPolicy
    $entries += @{
        Operation="New-RscQueryAws -TrustPolicy" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation TrustPolicy
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
    (New-RscQueryAws -Operation Vpcs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation Vpcs
    $entries += @{
        Operation="New-RscQueryAws -Vpcs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation Vpcs
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
    (New-RscQueryAws -Operation VpcsByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAws -Operation VpcsByRegion
    $entries += @{
        Operation="New-RscQueryAws -VpcsByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAws -Operation VpcsByRegion
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
    (New-RscQueryAwsNative -Operation Account).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation Account
    $entries += @{
        Operation="New-RscQueryAwsNative -Account" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation Account
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
    (New-RscQueryAwsNative -Operation Accounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation Accounts
    $entries += @{
        Operation="New-RscQueryAwsNative -Accounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation Accounts
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
    (New-RscQueryAwsNative -Operation AmiTypeForArchivedSnapshotExport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation AmiTypeForArchivedSnapshotExport
    $entries += @{
        Operation="New-RscQueryAwsNative -AmiTypeForArchivedSnapshotExport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation AmiTypeForArchivedSnapshotExport
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
    (New-RscQueryAwsNative -Operation EbsVolume).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation EbsVolume
    $entries += @{
        Operation="New-RscQueryAwsNative -EbsVolume" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation EbsVolume
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
    (New-RscQueryAwsNative -Operation EbsVolumes).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation EbsVolumes
    $entries += @{
        Operation="New-RscQueryAwsNative -EbsVolumes" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation EbsVolumes
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
    (New-RscQueryAwsNative -Operation EbsVolumesByName).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation EbsVolumesByName
    $entries += @{
        Operation="New-RscQueryAwsNative -EbsVolumesByName" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation EbsVolumesByName
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
    (New-RscQueryAwsNative -Operation Ec2Instance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation Ec2Instance
    $entries += @{
        Operation="New-RscQueryAwsNative -Ec2Instance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation Ec2Instance
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
    (New-RscQueryAwsNative -Operation Ec2Instances).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation Ec2Instances
    $entries += @{
        Operation="New-RscQueryAwsNative -Ec2Instances" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation Ec2Instances
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
    (New-RscQueryAwsNative -Operation Ec2InstancesByName).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation Ec2InstancesByName
    $entries += @{
        Operation="New-RscQueryAwsNative -Ec2InstancesByName" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation Ec2InstancesByName
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
    (New-RscQueryAwsNative -Operation IsEbsVolumeSnapshotRestorable).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation IsEbsVolumeSnapshotRestorable
    $entries += @{
        Operation="New-RscQueryAwsNative -IsEbsVolumeSnapshotRestorable" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation IsEbsVolumeSnapshotRestorable
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
    (New-RscQueryAwsNative -Operation IsRdsInstanceLaunchConfigurationValid).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation IsRdsInstanceLaunchConfigurationValid
    $entries += @{
        Operation="New-RscQueryAwsNative -IsRdsInstanceLaunchConfigurationValid" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation IsRdsInstanceLaunchConfigurationValid
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
    (New-RscQueryAwsNative -Operation RdsExportDefaults).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation RdsExportDefaults
    $entries += @{
        Operation="New-RscQueryAwsNative -RdsExportDefaults" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation RdsExportDefaults
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
    (New-RscQueryAwsNative -Operation RdsInstance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation RdsInstance
    $entries += @{
        Operation="New-RscQueryAwsNative -RdsInstance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation RdsInstance
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
    (New-RscQueryAwsNative -Operation RdsInstances).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation RdsInstances
    $entries += @{
        Operation="New-RscQueryAwsNative -RdsInstances" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation RdsInstances
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
    (New-RscQueryAwsNative -Operation RdsPointInTimeRestoreWindow).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation RdsPointInTimeRestoreWindow
    $entries += @{
        Operation="New-RscQueryAwsNative -RdsPointInTimeRestoreWindow" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation RdsPointInTimeRestoreWindow
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
    (New-RscQueryAwsNative -Operation Root).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation Root
    $entries += @{
        Operation="New-RscQueryAwsNative -Root" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation Root
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
    (New-RscQueryAwsNative -Operation S3Bucket).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation S3Bucket
    $entries += @{
        Operation="New-RscQueryAwsNative -S3Bucket" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation S3Bucket
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
    (New-RscQueryAwsNative -Operation ValidateRdsClusterNameForExport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation ValidateRdsClusterNameForExport
    $entries += @{
        Operation="New-RscQueryAwsNative -ValidateRdsClusterNameForExport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation ValidateRdsClusterNameForExport
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
    (New-RscQueryAwsNative -Operation ValidateRdsInstanceNameForExport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAwsNative -Operation ValidateRdsInstanceNameForExport
    $entries += @{
        Operation="New-RscQueryAwsNative -ValidateRdsInstanceNameForExport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAwsNative -Operation ValidateRdsInstanceNameForExport
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
    (New-RscQueryAzure -Operation AdDirectories).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation AdDirectories
    $entries += @{
        Operation="New-RscQueryAzure -AdDirectories" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation AdDirectories
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
    (New-RscQueryAzure -Operation AdDirectory).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation AdDirectory
    $entries += @{
        Operation="New-RscQueryAzure -AdDirectory" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation AdDirectory
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
    (New-RscQueryAzure -Operation AdObjectsByType).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation AdObjectsByType
    $entries += @{
        Operation="New-RscQueryAzure -AdObjectsByType" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation AdObjectsByType
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
    (New-RscQueryAzure -Operation ArmTemplatesByFeature).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation ArmTemplatesByFeature
    $entries += @{
        Operation="New-RscQueryAzure -ArmTemplatesByFeature" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation ArmTemplatesByFeature
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
    (New-RscQueryAzure -Operation CdmVersions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CdmVersions
    $entries += @{
        Operation="New-RscQueryAzure -CdmVersions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CdmVersions
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
    (New-RscQueryAzure -Operation CheckPersistentStorageSubscriptionCanUnmap).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CheckPersistentStorageSubscriptionCanUnmap
    $entries += @{
        Operation="New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CheckPersistentStorageSubscriptionCanUnmap
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
    (New-RscQueryAzure -Operation CloudAccountMissingPermissions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CloudAccountMissingPermissions
    $entries += @{
        Operation="New-RscQueryAzure -CloudAccountMissingPermissions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CloudAccountMissingPermissions
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
    (New-RscQueryAzure -Operation CloudAccountPermissionConfig).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CloudAccountPermissionConfig
    $entries += @{
        Operation="New-RscQueryAzure -CloudAccountPermissionConfig" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CloudAccountPermissionConfig
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
    (New-RscQueryAzure -Operation CloudAccountSubnetsByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CloudAccountSubnetsByRegion
    $entries += @{
        Operation="New-RscQueryAzure -CloudAccountSubnetsByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CloudAccountSubnetsByRegion
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
    (New-RscQueryAzure -Operation CloudAccountSubscriptionWithFeatures).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CloudAccountSubscriptionWithFeatures
    $entries += @{
        Operation="New-RscQueryAzure -CloudAccountSubscriptionWithFeatures" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CloudAccountSubscriptionWithFeatures
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
    (New-RscQueryAzure -Operation CloudAccountSubscriptionsByFeature).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CloudAccountSubscriptionsByFeature
    $entries += @{
        Operation="New-RscQueryAzure -CloudAccountSubscriptionsByFeature" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CloudAccountSubscriptionsByFeature
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
    (New-RscQueryAzure -Operation CloudAccountTenant).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CloudAccountTenant
    $entries += @{
        Operation="New-RscQueryAzure -CloudAccountTenant" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CloudAccountTenant
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
    (New-RscQueryAzure -Operation CloudAccountTenantWithExoConfigs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CloudAccountTenantWithExoConfigs
    $entries += @{
        Operation="New-RscQueryAzure -CloudAccountTenantWithExoConfigs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CloudAccountTenantWithExoConfigs
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
    (New-RscQueryAzure -Operation CloudAccountTenants).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation CloudAccountTenants
    $entries += @{
        Operation="New-RscQueryAzure -CloudAccountTenants" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation CloudAccountTenants
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
    (New-RscQueryAzure -Operation DiskEncryptionSetsByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation DiskEncryptionSetsByRegion
    $entries += @{
        Operation="New-RscQueryAzure -DiskEncryptionSetsByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation DiskEncryptionSetsByRegion
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
    (New-RscQueryAzure -Operation EncryptionKeys).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation EncryptionKeys
    $entries += @{
        Operation="New-RscQueryAzure -EncryptionKeys" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation EncryptionKeys
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
    (New-RscQueryAzure -Operation ExocomputeConfigsInAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation ExocomputeConfigsInAccount
    $entries += @{
        Operation="New-RscQueryAzure -ExocomputeConfigsInAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation ExocomputeConfigsInAccount
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
    (New-RscQueryAzure -Operation HostedAzureRegions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation HostedAzureRegions
    $entries += @{
        Operation="New-RscQueryAzure -HostedAzureRegions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation HostedAzureRegions
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
    (New-RscQueryAzure -Operation IsStorageAccountNameAvailable).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation IsStorageAccountNameAvailable
    $entries += @{
        Operation="New-RscQueryAzure -IsStorageAccountNameAvailable" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation IsStorageAccountNameAvailable
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
    (New-RscQueryAzure -Operation KeyVaultsByRegion).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation KeyVaultsByRegion
    $entries += @{
        Operation="New-RscQueryAzure -KeyVaultsByRegion" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation KeyVaultsByRegion
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
    (New-RscQueryAzure -Operation ManagedIdentities).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation ManagedIdentities
    $entries += @{
        Operation="New-RscQueryAzure -ManagedIdentities" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation ManagedIdentities
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
    (New-RscQueryAzure -Operation Nsgs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation Nsgs
    $entries += @{
        Operation="New-RscQueryAzure -Nsgs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation Nsgs
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
    (New-RscQueryAzure -Operation Regions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation Regions
    $entries += @{
        Operation="New-RscQueryAzure -Regions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation Regions
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
    (New-RscQueryAzure -Operation ResourceGroups).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation ResourceGroups
    $entries += @{
        Operation="New-RscQueryAzure -ResourceGroups" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation ResourceGroups
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
    (New-RscQueryAzure -Operation SearchAdSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SearchAdSnapshot
    $entries += @{
        Operation="New-RscQueryAzure -SearchAdSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SearchAdSnapshot
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
    (New-RscQueryAzure -Operation SqlDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlDatabase
    $entries += @{
        Operation="New-RscQueryAzure -SqlDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlDatabase
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
    (New-RscQueryAzure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure
    $entries += @{
        Operation="New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlDatabaseDbPointInTimeRestoreWindowFromAzure
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
    (New-RscQueryAzure -Operation SqlDatabaseServer).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlDatabaseServer
    $entries += @{
        Operation="New-RscQueryAzure -SqlDatabaseServer" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlDatabaseServer
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
    (New-RscQueryAzure -Operation SqlDatabaseServerElasticPools).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlDatabaseServerElasticPools
    $entries += @{
        Operation="New-RscQueryAzure -SqlDatabaseServerElasticPools" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlDatabaseServerElasticPools
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
    (New-RscQueryAzure -Operation SqlDatabaseServers).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlDatabaseServers
    $entries += @{
        Operation="New-RscQueryAzure -SqlDatabaseServers" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlDatabaseServers
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
    (New-RscQueryAzure -Operation SqlDatabases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlDatabases
    $entries += @{
        Operation="New-RscQueryAzure -SqlDatabases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlDatabases
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
    (New-RscQueryAzure -Operation SqlManagedInstanceDatabase).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceDatabase
    $entries += @{
        Operation="New-RscQueryAzure -SqlManagedInstanceDatabase" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceDatabase
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
    (New-RscQueryAzure -Operation SqlManagedInstanceDatabases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceDatabases
    $entries += @{
        Operation="New-RscQueryAzure -SqlManagedInstanceDatabases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceDatabases
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
    (New-RscQueryAzure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
    $entries += @{
        Operation="New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
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
    (New-RscQueryAzure -Operation SqlManagedInstanceServer).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceServer
    $entries += @{
        Operation="New-RscQueryAzure -SqlManagedInstanceServer" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceServer
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
    (New-RscQueryAzure -Operation SqlManagedInstanceServers).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceServers
    $entries += @{
        Operation="New-RscQueryAzure -SqlManagedInstanceServers" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SqlManagedInstanceServers
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
    (New-RscQueryAzure -Operation StorageAccounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation StorageAccounts
    $entries += @{
        Operation="New-RscQueryAzure -StorageAccounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation StorageAccounts
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
    (New-RscQueryAzure -Operation Subnets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation Subnets
    $entries += @{
        Operation="New-RscQueryAzure -Subnets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation Subnets
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
    (New-RscQueryAzure -Operation SubscriptionWithExocomputeMappings).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation SubscriptionWithExocomputeMappings
    $entries += @{
        Operation="New-RscQueryAzure -SubscriptionWithExocomputeMappings" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation SubscriptionWithExocomputeMappings
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
    (New-RscQueryAzure -Operation Subscriptions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation Subscriptions
    $entries += @{
        Operation="New-RscQueryAzure -Subscriptions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation Subscriptions
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
    (New-RscQueryAzure -Operation VNets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation VNets
    $entries += @{
        Operation="New-RscQueryAzure -VNets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation VNets
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
    (New-RscQueryAzure -Operation ValidateCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzure -Operation ValidateCloudAccountExocomputeConfigurations
    $entries += @{
        Operation="New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzure -Operation ValidateCloudAccountExocomputeConfigurations
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
    (New-RscQueryAzureNative -Operation AvailabilitySetsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation AvailabilitySetsByRegionFromAzure
    $entries += @{
        Operation="New-RscQueryAzureNative -AvailabilitySetsByRegionFromAzure" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation AvailabilitySetsByRegionFromAzure
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
    (New-RscQueryAzureNative -Operation DoesResourceGroupExist).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation DoesResourceGroupExist
    $entries += @{
        Operation="New-RscQueryAzureNative -DoesResourceGroupExist" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation DoesResourceGroupExist
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
    (New-RscQueryAzureNative -Operation ExportCompatibleDiskTypesByRegionFromAzure).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ExportCompatibleDiskTypesByRegionFromAzure
    $entries += @{
        Operation="New-RscQueryAzureNative -ExportCompatibleDiskTypesByRegionFromAzure" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ExportCompatibleDiskTypesByRegionFromAzure
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
    (New-RscQueryAzureNative -Operation ExportCompatibleVmSizesByRegionFromAzure).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ExportCompatibleVmSizesByRegionFromAzure
    $entries += @{
        Operation="New-RscQueryAzureNative -ExportCompatibleVmSizesByRegionFromAzure" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ExportCompatibleVmSizesByRegionFromAzure
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
    (New-RscQueryAzureNative -Operation IsManagedDiskSnapshotRestorable).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation IsManagedDiskSnapshotRestorable
    $entries += @{
        Operation="New-RscQueryAzureNative -IsManagedDiskSnapshotRestorable" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation IsManagedDiskSnapshotRestorable
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
    (New-RscQueryAzureNative -Operation IsSqlDatabaseSnapshotPersistent).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation IsSqlDatabaseSnapshotPersistent
    $entries += @{
        Operation="New-RscQueryAzureNative -IsSqlDatabaseSnapshotPersistent" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation IsSqlDatabaseSnapshotPersistent
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
    (New-RscQueryAzureNative -Operation ManagedDisk).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ManagedDisk
    $entries += @{
        Operation="New-RscQueryAzureNative -ManagedDisk" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ManagedDisk
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
    (New-RscQueryAzureNative -Operation ManagedDisks).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ManagedDisks
    $entries += @{
        Operation="New-RscQueryAzureNative -ManagedDisks" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ManagedDisks
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
    (New-RscQueryAzureNative -Operation ResourceGroup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ResourceGroup
    $entries += @{
        Operation="New-RscQueryAzureNative -ResourceGroup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ResourceGroup
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
    (New-RscQueryAzureNative -Operation ResourceGroups).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ResourceGroups
    $entries += @{
        Operation="New-RscQueryAzureNative -ResourceGroups" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ResourceGroups
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
    (New-RscQueryAzureNative -Operation ResourceGroupsInfoIfExist).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ResourceGroupsInfoIfExist
    $entries += @{
        Operation="New-RscQueryAzureNative -ResourceGroupsInfoIfExist" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ResourceGroupsInfoIfExist
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
    (New-RscQueryAzureNative -Operation Root).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation Root
    $entries += @{
        Operation="New-RscQueryAzureNative -Root" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation Root
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
    (New-RscQueryAzureNative -Operation SecurityGroupsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation SecurityGroupsByRegionFromAzure
    $entries += @{
        Operation="New-RscQueryAzureNative -SecurityGroupsByRegionFromAzure" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation SecurityGroupsByRegionFromAzure
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
    (New-RscQueryAzureNative -Operation StorageAccountsFromAzure).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation StorageAccountsFromAzure
    $entries += @{
        Operation="New-RscQueryAzureNative -StorageAccountsFromAzure" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation StorageAccountsFromAzure
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
    (New-RscQueryAzureNative -Operation SubnetsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation SubnetsByRegionFromAzure
    $entries += @{
        Operation="New-RscQueryAzureNative -SubnetsByRegionFromAzure" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation SubnetsByRegionFromAzure
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
    (New-RscQueryAzureNative -Operation Subscription).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation Subscription
    $entries += @{
        Operation="New-RscQueryAzureNative -Subscription" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation Subscription
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
    (New-RscQueryAzureNative -Operation Subscriptions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation Subscriptions
    $entries += @{
        Operation="New-RscQueryAzureNative -Subscriptions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation Subscriptions
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
    (New-RscQueryAzureNative -Operation ValidateSqlDatabaseDbNameForExport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ValidateSqlDatabaseDbNameForExport
    $entries += @{
        Operation="New-RscQueryAzureNative -ValidateSqlDatabaseDbNameForExport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ValidateSqlDatabaseDbNameForExport
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
    (New-RscQueryAzureNative -Operation ValidateSqlManagedInstanceDbNameForExport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation ValidateSqlManagedInstanceDbNameForExport
    $entries += @{
        Operation="New-RscQueryAzureNative -ValidateSqlManagedInstanceDbNameForExport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation ValidateSqlManagedInstanceDbNameForExport
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
    (New-RscQueryAzureNative -Operation VirtualMachine).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation VirtualMachine
    $entries += @{
        Operation="New-RscQueryAzureNative -VirtualMachine" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation VirtualMachine
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
    (New-RscQueryAzureNative -Operation VirtualMachineSizes).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation VirtualMachineSizes
    $entries += @{
        Operation="New-RscQueryAzureNative -VirtualMachineSizes" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation VirtualMachineSizes
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
    (New-RscQueryAzureNative -Operation VirtualMachines).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation VirtualMachines
    $entries += @{
        Operation="New-RscQueryAzureNative -VirtualMachines" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation VirtualMachines
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
    (New-RscQueryAzureNative -Operation VirtualNetworks).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureNative -Operation VirtualNetworks
    $entries += @{
        Operation="New-RscQueryAzureNative -VirtualNetworks" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureNative -Operation VirtualNetworks
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
    (New-RscQueryAzureO365 -Operation CheckNSGOutboundRules).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation CheckNSGOutboundRules
    $entries += @{
        Operation="New-RscQueryAzureO365 -CheckNSGOutboundRules" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation CheckNSGOutboundRules
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
    (New-RscQueryAzureO365 -Operation CheckNetworkSubnet).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation CheckNetworkSubnet
    $entries += @{
        Operation="New-RscQueryAzureO365 -CheckNetworkSubnet" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation CheckNetworkSubnet
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
    (New-RscQueryAzureO365 -Operation CheckResourceGroupName).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation CheckResourceGroupName
    $entries += @{
        Operation="New-RscQueryAzureO365 -CheckResourceGroupName" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation CheckResourceGroupName
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
    (New-RscQueryAzureO365 -Operation CheckStorageAccountAccessibility).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation CheckStorageAccountAccessibility
    $entries += @{
        Operation="New-RscQueryAzureO365 -CheckStorageAccountAccessibility" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation CheckStorageAccountAccessibility
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
    (New-RscQueryAzureO365 -Operation CheckStorageAccountName).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation CheckStorageAccountName
    $entries += @{
        Operation="New-RscQueryAzureO365 -CheckStorageAccountName" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation CheckStorageAccountName
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
    (New-RscQueryAzureO365 -Operation CheckSubscriptionQuota).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation CheckSubscriptionQuota
    $entries += @{
        Operation="New-RscQueryAzureO365 -CheckSubscriptionQuota" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation CheckSubscriptionQuota
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
    (New-RscQueryAzureO365 -Operation CheckVirtualNetworkName).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation CheckVirtualNetworkName
    $entries += @{
        Operation="New-RscQueryAzureO365 -CheckVirtualNetworkName" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation CheckVirtualNetworkName
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
    (New-RscQueryAzureO365 -Operation Exocompute).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation Exocompute
    $entries += @{
        Operation="New-RscQueryAzureO365 -Exocompute" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation Exocompute
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
    (New-RscQueryAzureO365 -Operation GetAzureHostType).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation GetAzureHostType
    $entries += @{
        Operation="New-RscQueryAzureO365 -GetAzureHostType" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation GetAzureHostType
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
    (New-RscQueryAzureO365 -Operation GetNetworkSubnetUnusedAddr).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation GetNetworkSubnetUnusedAddr
    $entries += @{
        Operation="New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation GetNetworkSubnetUnusedAddr
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
    (New-RscQueryAzureO365 -Operation ValidateUserRoles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryAzureO365 -Operation ValidateUserRoles
    $entries += @{
        Operation="New-RscQueryAzureO365 -ValidateUserRoles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryAzureO365 -Operation ValidateUserRoles
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
    (New-RscQueryCassandra -Operation ColumnFamilies).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCassandra -Operation ColumnFamilies
    $entries += @{
        Operation="New-RscQueryCassandra -ColumnFamilies" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCassandra -Operation ColumnFamilies
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
    (New-RscQueryCassandra -Operation ColumnFamily).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCassandra -Operation ColumnFamily
    $entries += @{
        Operation="New-RscQueryCassandra -ColumnFamily" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCassandra -Operation ColumnFamily
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
    (New-RscQueryCassandra -Operation ColumnFamilyRecoverableRange).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCassandra -Operation ColumnFamilyRecoverableRange
    $entries += @{
        Operation="New-RscQueryCassandra -ColumnFamilyRecoverableRange" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCassandra -Operation ColumnFamilyRecoverableRange
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
    (New-RscQueryCassandra -Operation ColumnFamilySchema).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCassandra -Operation ColumnFamilySchema
    $entries += @{
        Operation="New-RscQueryCassandra -ColumnFamilySchema" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCassandra -Operation ColumnFamilySchema
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
    (New-RscQueryCassandra -Operation Keyspace).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCassandra -Operation Keyspace
    $entries += @{
        Operation="New-RscQueryCassandra -Keyspace" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCassandra -Operation Keyspace
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
    (New-RscQueryCassandra -Operation Keyspaces).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCassandra -Operation Keyspaces
    $entries += @{
        Operation="New-RscQueryCassandra -Keyspaces" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCassandra -Operation Keyspaces
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
    (New-RscQueryCassandra -Operation Source).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCassandra -Operation Source
    $entries += @{
        Operation="New-RscQueryCassandra -Source" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCassandra -Operation Source
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
    (New-RscQueryCassandra -Operation Sources).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCassandra -Operation Sources
    $entries += @{
        Operation="New-RscQueryCassandra -Sources" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCassandra -Operation Sources
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
    (New-RscQueryCertificate -Operation Certificate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCertificate -Operation Certificate
    $entries += @{
        Operation="New-RscQueryCertificate -Certificate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCertificate -Operation Certificate
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
    (New-RscQueryCertificate -Operation Cluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCertificate -Operation Cluster
    $entries += @{
        Operation="New-RscQueryCertificate -Cluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCertificate -Operation Cluster
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
    (New-RscQueryCertificate -Operation ClusterWebSigned).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCertificate -Operation ClusterWebSigned
    $entries += @{
        Operation="New-RscQueryCertificate -ClusterWebSigned" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCertificate -Operation ClusterWebSigned
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
    (New-RscQueryCertificate -Operation SigningRequest).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCertificate -Operation SigningRequest
    $entries += @{
        Operation="New-RscQueryCertificate -SigningRequest" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCertificate -Operation SigningRequest
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
    (New-RscQueryCertificate -Operation SigningRequests).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCertificate -Operation SigningRequests
    $entries += @{
        Operation="New-RscQueryCertificate -SigningRequests" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCertificate -Operation SigningRequests
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
    (New-RscQueryCertificate -Operation WithKey).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCertificate -Operation WithKey
    $entries += @{
        Operation="New-RscQueryCertificate -WithKey" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCertificate -Operation WithKey
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
    (New-RscQueryCloudAccount -Operation CloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudAccount -Operation CloudAccount
    $entries += @{
        Operation="New-RscQueryCloudAccount -CloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudAccount -Operation CloudAccount
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
    (New-RscQueryCloudAccount -Operation CurrentFeaturePermissions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudAccount -Operation CurrentFeaturePermissions
    $entries += @{
        Operation="New-RscQueryCloudAccount -CurrentFeaturePermissions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudAccount -Operation CurrentFeaturePermissions
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
    (New-RscQueryCloudAccount -Operation ExocomputeMappings).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudAccount -Operation ExocomputeMappings
    $entries += @{
        Operation="New-RscQueryCloudAccount -ExocomputeMappings" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudAccount -Operation ExocomputeMappings
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
    (New-RscQueryCloudAccount -Operation LatestFeaturePermissions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudAccount -Operation LatestFeaturePermissions
    $entries += @{
        Operation="New-RscQueryCloudAccount -LatestFeaturePermissions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudAccount -Operation LatestFeaturePermissions
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
    (New-RscQueryCloudNative -Operation CheckArchivedSnapshotsLocked).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation CheckArchivedSnapshotsLocked
    $entries += @{
        Operation="New-RscQueryCloudNative -CheckArchivedSnapshotsLocked" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation CheckArchivedSnapshotsLocked
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
    (New-RscQueryCloudNative -Operation CheckLabelRuleNameUniqueness).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation CheckLabelRuleNameUniqueness
    $entries += @{
        Operation="New-RscQueryCloudNative -CheckLabelRuleNameUniqueness" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation CheckLabelRuleNameUniqueness
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
    (New-RscQueryCloudNative -Operation CheckRequiredPermissionsForFeature).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation CheckRequiredPermissionsForFeature
    $entries += @{
        Operation="New-RscQueryCloudNative -CheckRequiredPermissionsForFeature" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation CheckRequiredPermissionsForFeature
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
    (New-RscQueryCloudNative -Operation CheckTagRuleNameUniqueness).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation CheckTagRuleNameUniqueness
    $entries += @{
        Operation="New-RscQueryCloudNative -CheckTagRuleNameUniqueness" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation CheckTagRuleNameUniqueness
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
    (New-RscQueryCloudNative -Operation CustomerTags).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation CustomerTags
    $entries += @{
        Operation="New-RscQueryCloudNative -CustomerTags" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation CustomerTags
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
    (New-RscQueryCloudNative -Operation FileRecoveryEligibleSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation FileRecoveryEligibleSnapshots
    $entries += @{
        Operation="New-RscQueryCloudNative -FileRecoveryEligibleSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation FileRecoveryEligibleSnapshots
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
    (New-RscQueryCloudNative -Operation IsFileRecoveryFeasible).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation IsFileRecoveryFeasible
    $entries += @{
        Operation="New-RscQueryCloudNative -IsFileRecoveryFeasible" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation IsFileRecoveryFeasible
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
    (New-RscQueryCloudNative -Operation LabelKeys).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation LabelKeys
    $entries += @{
        Operation="New-RscQueryCloudNative -LabelKeys" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation LabelKeys
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
    (New-RscQueryCloudNative -Operation LabelRules).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation LabelRules
    $entries += @{
        Operation="New-RscQueryCloudNative -LabelRules" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation LabelRules
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
    (New-RscQueryCloudNative -Operation LabelValues).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation LabelValues
    $entries += @{
        Operation="New-RscQueryCloudNative -LabelValues" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation LabelValues
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
    (New-RscQueryCloudNative -Operation RbaInstallers).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation RbaInstallers
    $entries += @{
        Operation="New-RscQueryCloudNative -RbaInstallers" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation RbaInstallers
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
    (New-RscQueryCloudNative -Operation SnapshotDetailsForRecovery).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation SnapshotDetailsForRecovery
    $entries += @{
        Operation="New-RscQueryCloudNative -SnapshotDetailsForRecovery" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation SnapshotDetailsForRecovery
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
    (New-RscQueryCloudNative -Operation SnapshotTypeDetails).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation SnapshotTypeDetails
    $entries += @{
        Operation="New-RscQueryCloudNative -SnapshotTypeDetails" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation SnapshotTypeDetails
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
    (New-RscQueryCloudNative -Operation Snapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation Snapshots
    $entries += @{
        Operation="New-RscQueryCloudNative -Snapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation Snapshots
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
    (New-RscQueryCloudNative -Operation SqlServerSetupScript).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation SqlServerSetupScript
    $entries += @{
        Operation="New-RscQueryCloudNative -SqlServerSetupScript" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation SqlServerSetupScript
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
    (New-RscQueryCloudNative -Operation TagKeys).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation TagKeys
    $entries += @{
        Operation="New-RscQueryCloudNative -TagKeys" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation TagKeys
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
    (New-RscQueryCloudNative -Operation TagRules).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation TagRules
    $entries += @{
        Operation="New-RscQueryCloudNative -TagRules" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation TagRules
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
    (New-RscQueryCloudNative -Operation TagValues).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation TagValues
    $entries += @{
        Operation="New-RscQueryCloudNative -TagValues" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation TagValues
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
    (New-RscQueryCloudNative -Operation WorkloadVersionedFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCloudNative -Operation WorkloadVersionedFiles
    $entries += @{
        Operation="New-RscQueryCloudNative -WorkloadVersionedFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCloudNative -Operation WorkloadVersionedFiles
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
    (New-RscQueryCluster -Operation Cluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Cluster
    $entries += @{
        Operation="New-RscQueryCluster -Cluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Cluster
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
    (New-RscQueryCluster -Operation Connected).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Connected
    $entries += @{
        Operation="New-RscQueryCluster -Connected" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Connected
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
    (New-RscQueryCluster -Operation DatabaseLogReport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation DatabaseLogReport
    $entries += @{
        Operation="New-RscQueryCluster -DatabaseLogReport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation DatabaseLogReport
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
    (New-RscQueryCluster -Operation DatabaseLogReportingProperties).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation DatabaseLogReportingProperties
    $entries += @{
        Operation="New-RscQueryCluster -DatabaseLogReportingProperties" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation DatabaseLogReportingProperties
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
    (New-RscQueryCluster -Operation DefaultGateway).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation DefaultGateway
    $entries += @{
        Operation="New-RscQueryCluster -DefaultGateway" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation DefaultGateway
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
    (New-RscQueryCluster -Operation Dns).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Dns
    $entries += @{
        Operation="New-RscQueryCluster -Dns" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Dns
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
    (New-RscQueryCluster -Operation FloatingIps).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation FloatingIps
    $entries += @{
        Operation="New-RscQueryCluster -FloatingIps" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation FloatingIps
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
    (New-RscQueryCluster -Operation GroupByList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation GroupByList
    $entries += @{
        Operation="New-RscQueryCluster -GroupByList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation GroupByList
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
    (New-RscQueryCluster -Operation HostFailover).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation HostFailover
    $entries += @{
        Operation="New-RscQueryCluster -HostFailover" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation HostFailover
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
    (New-RscQueryCluster -Operation Ipmi).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Ipmi
    $entries += @{
        Operation="New-RscQueryCluster -Ipmi" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Ipmi
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
    (New-RscQueryCluster -Operation Ipv6Mode).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Ipv6Mode
    $entries += @{
        Operation="New-RscQueryCluster -Ipv6Mode" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Ipv6Mode
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
    (New-RscQueryCluster -Operation IsTotpAckNecessary).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation IsTotpAckNecessary
    $entries += @{
        Operation="New-RscQueryCluster -IsTotpAckNecessary" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation IsTotpAckNecessary
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
    (New-RscQueryCluster -Operation List).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation List
    $entries += @{
        Operation="New-RscQueryCluster -List" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation List
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
    (New-RscQueryCluster -Operation NetworkInterfaces).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation NetworkInterfaces
    $entries += @{
        Operation="New-RscQueryCluster -NetworkInterfaces" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation NetworkInterfaces
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
    (New-RscQueryCluster -Operation Nodes).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Nodes
    $entries += @{
        Operation="New-RscQueryCluster -Nodes" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Nodes
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
    (New-RscQueryCluster -Operation NtpServers).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation NtpServers
    $entries += @{
        Operation="New-RscQueryCluster -NtpServers" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation NtpServers
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
    (New-RscQueryCluster -Operation OperationJobProgress).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation OperationJobProgress
    $entries += @{
        Operation="New-RscQueryCluster -OperationJobProgress" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation OperationJobProgress
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
    (New-RscQueryCluster -Operation Proxy).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Proxy
    $entries += @{
        Operation="New-RscQueryCluster -Proxy" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Proxy
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
    (New-RscQueryCluster -Operation RegistrationProductInfo).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation RegistrationProductInfo
    $entries += @{
        Operation="New-RscQueryCluster -RegistrationProductInfo" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation RegistrationProductInfo
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
    (New-RscQueryCluster -Operation ReplicationTargets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation ReplicationTargets
    $entries += @{
        Operation="New-RscQueryCluster -ReplicationTargets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation ReplicationTargets
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
    (New-RscQueryCluster -Operation ReportMigrationCount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation ReportMigrationCount
    $entries += @{
        Operation="New-RscQueryCluster -ReportMigrationCount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation ReportMigrationCount
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
    (New-RscQueryCluster -Operation ReportMigrationJobStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation ReportMigrationJobStatus
    $entries += @{
        Operation="New-RscQueryCluster -ReportMigrationJobStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation ReportMigrationJobStatus
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
    (New-RscQueryCluster -Operation ReportMigrationStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation ReportMigrationStatus
    $entries += @{
        Operation="New-RscQueryCluster -ReportMigrationStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation ReportMigrationStatus
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
    (New-RscQueryCluster -Operation TotpAckStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation TotpAckStatus
    $entries += @{
        Operation="New-RscQueryCluster -TotpAckStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation TotpAckStatus
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
    (New-RscQueryCluster -Operation TypeList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation TypeList
    $entries += @{
        Operation="New-RscQueryCluster -TypeList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation TypeList
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
    (New-RscQueryCluster -Operation Vlans).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Vlans
    $entries += @{
        Operation="New-RscQueryCluster -Vlans" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Vlans
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
    (New-RscQueryCluster -Operation WebCertsAndIpmis).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation WebCertsAndIpmis
    $entries += @{
        Operation="New-RscQueryCluster -WebCertsAndIpmis" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation WebCertsAndIpmis
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
    (New-RscQueryCluster -Operation Windows).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation Windows
    $entries += @{
        Operation="New-RscQueryCluster -Windows" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation Windows
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
    (New-RscQueryCluster -Operation WithUpgradesInfo).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryCluster -Operation WithUpgradesInfo
    $entries += @{
        Operation="New-RscQueryCluster -WithUpgradesInfo" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryCluster -Operation WithUpgradesInfo
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
    (New-RscQueryDb2 -Operation Database).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDb2 -Operation Database
    $entries += @{
        Operation="New-RscQueryDb2 -Database" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDb2 -Operation Database
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
    (New-RscQueryDb2 -Operation Databases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDb2 -Operation Databases
    $entries += @{
        Operation="New-RscQueryDb2 -Databases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDb2 -Operation Databases
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
    (New-RscQueryDb2 -Operation Instance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDb2 -Operation Instance
    $entries += @{
        Operation="New-RscQueryDb2 -Instance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDb2 -Operation Instance
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
    (New-RscQueryDb2 -Operation Instances).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDb2 -Operation Instances
    $entries += @{
        Operation="New-RscQueryDb2 -Instances" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDb2 -Operation Instances
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
    (New-RscQueryDb2 -Operation LogSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDb2 -Operation LogSnapshot
    $entries += @{
        Operation="New-RscQueryDb2 -LogSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDb2 -Operation LogSnapshot
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
    (New-RscQueryDb2 -Operation LogSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDb2 -Operation LogSnapshots
    $entries += @{
        Operation="New-RscQueryDb2 -LogSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDb2 -Operation LogSnapshots
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
    (New-RscQueryDb2 -Operation RecoverableRange).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDb2 -Operation RecoverableRange
    $entries += @{
        Operation="New-RscQueryDb2 -RecoverableRange" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDb2 -Operation RecoverableRange
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
    (New-RscQueryDb2 -Operation RecoverableRanges).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDb2 -Operation RecoverableRanges
    $entries += @{
        Operation="New-RscQueryDb2 -RecoverableRanges" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDb2 -Operation RecoverableRanges
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
    (New-RscQueryDownload -Operation CdmUpgradesPdf).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDownload -Operation CdmUpgradesPdf
    $entries += @{
        Operation="New-RscQueryDownload -CdmUpgradesPdf" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDownload -Operation CdmUpgradesPdf
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
    (New-RscQueryDownload -Operation EdVersionList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDownload -Operation EdVersionList
    $entries += @{
        Operation="New-RscQueryDownload -EdVersionList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDownload -Operation EdVersionList
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
    (New-RscQueryDownload -Operation PackageStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryDownload -Operation PackageStatus
    $entries += @{
        Operation="New-RscQueryDownload -PackageStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryDownload -Operation PackageStatus
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
    (New-RscQueryExchange -Operation Dag).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryExchange -Operation Dag
    $entries += @{
        Operation="New-RscQueryExchange -Dag" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryExchange -Operation Dag
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
    (New-RscQueryExchange -Operation Dags).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryExchange -Operation Dags
    $entries += @{
        Operation="New-RscQueryExchange -Dags" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryExchange -Operation Dags
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
    (New-RscQueryExchange -Operation Database).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryExchange -Operation Database
    $entries += @{
        Operation="New-RscQueryExchange -Database" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryExchange -Operation Database
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
    (New-RscQueryExchange -Operation Databases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryExchange -Operation Databases
    $entries += @{
        Operation="New-RscQueryExchange -Databases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryExchange -Operation Databases
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
    (New-RscQueryExchange -Operation LiveMounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryExchange -Operation LiveMounts
    $entries += @{
        Operation="New-RscQueryExchange -LiveMounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryExchange -Operation LiveMounts
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
    (New-RscQueryExchange -Operation Server).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryExchange -Operation Server
    $entries += @{
        Operation="New-RscQueryExchange -Server" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryExchange -Operation Server
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
    (New-RscQueryExchange -Operation Servers).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryExchange -Operation Servers
    $entries += @{
        Operation="New-RscQueryExchange -Servers" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryExchange -Operation Servers
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
    (New-RscQueryFileset -Operation Linux).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryFileset -Operation Linux
    $entries += @{
        Operation="New-RscQueryFileset -Linux" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryFileset -Operation Linux
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
    (New-RscQueryFileset -Operation RequestStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryFileset -Operation RequestStatus
    $entries += @{
        Operation="New-RscQueryFileset -RequestStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryFileset -Operation RequestStatus
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
    (New-RscQueryFileset -Operation Share).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryFileset -Operation Share
    $entries += @{
        Operation="New-RscQueryFileset -Share" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryFileset -Operation Share
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
    (New-RscQueryFileset -Operation Template).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryFileset -Operation Template
    $entries += @{
        Operation="New-RscQueryFileset -Template" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryFileset -Operation Template
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
    (New-RscQueryFileset -Operation Templates).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryFileset -Operation Templates
    $entries += @{
        Operation="New-RscQueryFileset -Templates" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryFileset -Operation Templates
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
    (New-RscQueryFileset -Operation Windows).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryFileset -Operation Windows
    $entries += @{
        Operation="New-RscQueryFileset -Windows" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryFileset -Operation Windows
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
    (New-RscQueryGcp -Operation CloudAccountMissingPermissionsForAddition).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation CloudAccountMissingPermissionsForAddition
    $entries += @{
        Operation="New-RscQueryGcp -CloudAccountMissingPermissionsForAddition" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation CloudAccountMissingPermissionsForAddition
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
    (New-RscQueryGcp -Operation CloudAccountProjectsByFeature).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation CloudAccountProjectsByFeature
    $entries += @{
        Operation="New-RscQueryGcp -CloudAccountProjectsByFeature" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation CloudAccountProjectsByFeature
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
    (New-RscQueryGcp -Operation CloudAccountProjectsForOauth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation CloudAccountProjectsForOauth
    $entries += @{
        Operation="New-RscQueryGcp -CloudAccountProjectsForOauth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation CloudAccountProjectsForOauth
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
    (New-RscQueryGcp -Operation FeaturePermissionsForCloudAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation FeaturePermissionsForCloudAccount
    $entries += @{
        Operation="New-RscQueryGcp -FeaturePermissionsForCloudAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation FeaturePermissionsForCloudAccount
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
    (New-RscQueryGcp -Operation GetDefaultCredentialsServiceAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation GetDefaultCredentialsServiceAccount
    $entries += @{
        Operation="New-RscQueryGcp -GetDefaultCredentialsServiceAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation GetDefaultCredentialsServiceAccount
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
    (New-RscQueryGcp -Operation NativeAvailableKmsCryptoKeys).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeAvailableKmsCryptoKeys
    $entries += @{
        Operation="New-RscQueryGcp -NativeAvailableKmsCryptoKeys" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeAvailableKmsCryptoKeys
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
    (New-RscQueryGcp -Operation NativeCompatibleMachineTypes).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeCompatibleMachineTypes
    $entries += @{
        Operation="New-RscQueryGcp -NativeCompatibleMachineTypes" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeCompatibleMachineTypes
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
    (New-RscQueryGcp -Operation NativeNetworks).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeNetworks
    $entries += @{
        Operation="New-RscQueryGcp -NativeNetworks" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeNetworks
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
    (New-RscQueryGcp -Operation NativeProjectsWithAccessibleNetworks).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeProjectsWithAccessibleNetworks
    $entries += @{
        Operation="New-RscQueryGcp -NativeProjectsWithAccessibleNetworks" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeProjectsWithAccessibleNetworks
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
    (New-RscQueryGcp -Operation NativeRegions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeRegions
    $entries += @{
        Operation="New-RscQueryGcp -NativeRegions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeRegions
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
    (New-RscQueryGcp -Operation NativeStoredMachineTypes).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeStoredMachineTypes
    $entries += @{
        Operation="New-RscQueryGcp -NativeStoredMachineTypes" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeStoredMachineTypes
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
    (New-RscQueryGcp -Operation NativeStoredMachineTypesInProject).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeStoredMachineTypesInProject
    $entries += @{
        Operation="New-RscQueryGcp -NativeStoredMachineTypesInProject" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeStoredMachineTypesInProject
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
    (New-RscQueryGcp -Operation NativeStoredNetworkNames).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeStoredNetworkNames
    $entries += @{
        Operation="New-RscQueryGcp -NativeStoredNetworkNames" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeStoredNetworkNames
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
    (New-RscQueryGcp -Operation NativeStoredNetworkNamesInProject).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeStoredNetworkNamesInProject
    $entries += @{
        Operation="New-RscQueryGcp -NativeStoredNetworkNamesInProject" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeStoredNetworkNamesInProject
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
    (New-RscQueryGcp -Operation NativeStoredRegions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeStoredRegions
    $entries += @{
        Operation="New-RscQueryGcp -NativeStoredRegions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeStoredRegions
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
    (New-RscQueryGcp -Operation NativeStoredRegionsInProject).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcp -Operation NativeStoredRegionsInProject
    $entries += @{
        Operation="New-RscQueryGcp -NativeStoredRegionsInProject" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcp -Operation NativeStoredRegionsInProject
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
    (New-RscQueryGcpNative -Operation Disk).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcpNative -Operation Disk
    $entries += @{
        Operation="New-RscQueryGcpNative -Disk" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcpNative -Operation Disk
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
    (New-RscQueryGcpNative -Operation Disks).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcpNative -Operation Disks
    $entries += @{
        Operation="New-RscQueryGcpNative -Disks" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcpNative -Operation Disks
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
    (New-RscQueryGcpNative -Operation GceInstance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcpNative -Operation GceInstance
    $entries += @{
        Operation="New-RscQueryGcpNative -GceInstance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcpNative -Operation GceInstance
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
    (New-RscQueryGcpNative -Operation GceInstances).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcpNative -Operation GceInstances
    $entries += @{
        Operation="New-RscQueryGcpNative -GceInstances" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcpNative -Operation GceInstances
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
    (New-RscQueryGcpNative -Operation Project).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcpNative -Operation Project
    $entries += @{
        Operation="New-RscQueryGcpNative -Project" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcpNative -Operation Project
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
    (New-RscQueryGcpNative -Operation Projects).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcpNative -Operation Projects
    $entries += @{
        Operation="New-RscQueryGcpNative -Projects" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcpNative -Operation Projects
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
    (New-RscQueryGcpNative -Operation StoredDiskLocations).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryGcpNative -Operation StoredDiskLocations
    $entries += @{
        Operation="New-RscQueryGcpNative -StoredDiskLocations" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryGcpNative -Operation StoredDiskLocations
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
    (New-RscQueryHost -Operation Diagnosis).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHost -Operation Diagnosis
    $entries += @{
        Operation="New-RscQueryHost -Diagnosis" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHost -Operation Diagnosis
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
    (New-RscQueryHost -Operation PhysicalHost).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHost -Operation PhysicalHost
    $entries += @{
        Operation="New-RscQueryHost -PhysicalHost" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHost -Operation PhysicalHost
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
    (New-RscQueryHost -Operation PhysicalHosts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHost -Operation PhysicalHosts
    $entries += @{
        Operation="New-RscQueryHost -PhysicalHosts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHost -Operation PhysicalHosts
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
    (New-RscQueryHost -Operation Search).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHost -Operation Search
    $entries += @{
        Operation="New-RscQueryHost -Search" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHost -Operation Search
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
    (New-RscQueryHost -Operation Share).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHost -Operation Share
    $entries += @{
        Operation="New-RscQueryHost -Share" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHost -Operation Share
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
    (New-RscQueryHost -Operation Shares).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHost -Operation Shares
    $entries += @{
        Operation="New-RscQueryHost -Shares" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHost -Operation Shares
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
    (New-RscQueryHyperv -Operation Cluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation Cluster
    $entries += @{
        Operation="New-RscQueryHyperv -Cluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation Cluster
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
    (New-RscQueryHyperv -Operation HostAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation HostAsyncRequestStatus
    $entries += @{
        Operation="New-RscQueryHyperv -HostAsyncRequestStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation HostAsyncRequestStatus
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
    (New-RscQueryHyperv -Operation Mounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation Mounts
    $entries += @{
        Operation="New-RscQueryHyperv -Mounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation Mounts
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
    (New-RscQueryHyperv -Operation Scvmm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation Scvmm
    $entries += @{
        Operation="New-RscQueryHyperv -Scvmm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation Scvmm
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
    (New-RscQueryHyperv -Operation ScvmmAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation ScvmmAsyncRequestStatus
    $entries += @{
        Operation="New-RscQueryHyperv -ScvmmAsyncRequestStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation ScvmmAsyncRequestStatus
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
    (New-RscQueryHyperv -Operation Scvmms).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation Scvmms
    $entries += @{
        Operation="New-RscQueryHyperv -Scvmms" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation Scvmms
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
    (New-RscQueryHyperv -Operation Server).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation Server
    $entries += @{
        Operation="New-RscQueryHyperv -Server" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation Server
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
    (New-RscQueryHyperv -Operation Servers).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation Servers
    $entries += @{
        Operation="New-RscQueryHyperv -Servers" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation Servers
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
    (New-RscQueryHyperv -Operation TopLevelDescendants).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation TopLevelDescendants
    $entries += @{
        Operation="New-RscQueryHyperv -TopLevelDescendants" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation TopLevelDescendants
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
    (New-RscQueryHyperv -Operation UniqueServersCount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation UniqueServersCount
    $entries += @{
        Operation="New-RscQueryHyperv -UniqueServersCount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation UniqueServersCount
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
    (New-RscQueryHyperv -Operation VirtualMachine).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation VirtualMachine
    $entries += @{
        Operation="New-RscQueryHyperv -VirtualMachine" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation VirtualMachine
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
    (New-RscQueryHyperv -Operation VirtualMachineAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation VirtualMachineAsyncRequestStatus
    $entries += @{
        Operation="New-RscQueryHyperv -VirtualMachineAsyncRequestStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation VirtualMachineAsyncRequestStatus
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
    (New-RscQueryHyperv -Operation VirtualMachines).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation VirtualMachines
    $entries += @{
        Operation="New-RscQueryHyperv -VirtualMachines" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation VirtualMachines
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
    (New-RscQueryHyperv -Operation VmDetail).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryHyperv -Operation VmDetail
    $entries += @{
        Operation="New-RscQueryHyperv -VmDetail" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryHyperv -Operation VmDetail
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
    (New-RscQueryK8s -Operation AppManifest).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryK8s -Operation AppManifest
    $entries += @{
        Operation="New-RscQueryK8s -AppManifest" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryK8s -Operation AppManifest
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
    (New-RscQueryK8s -Operation Cluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryK8s -Operation Cluster
    $entries += @{
        Operation="New-RscQueryK8s -Cluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryK8s -Operation Cluster
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
    (New-RscQueryK8s -Operation Clusters).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryK8s -Operation Clusters
    $entries += @{
        Operation="New-RscQueryK8s -Clusters" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryK8s -Operation Clusters
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
    (New-RscQueryK8s -Operation Namespace).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryK8s -Operation Namespace
    $entries += @{
        Operation="New-RscQueryK8s -Namespace" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryK8s -Operation Namespace
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
    (New-RscQueryK8s -Operation Namespaces).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryK8s -Operation Namespaces
    $entries += @{
        Operation="New-RscQueryK8s -Namespaces" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryK8s -Operation Namespaces
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
    (New-RscQueryK8s -Operation ReplicaSnapshotInfos).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryK8s -Operation ReplicaSnapshotInfos
    $entries += @{
        Operation="New-RscQueryK8s -ReplicaSnapshotInfos" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryK8s -Operation ReplicaSnapshotInfos
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
    (New-RscQueryK8s -Operation SnapshotInfo).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryK8s -Operation SnapshotInfo
    $entries += @{
        Operation="New-RscQueryK8s -SnapshotInfo" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryK8s -Operation SnapshotInfo
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
    (New-RscQueryLdap -Operation AuthorizedPrincipalList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryLdap -Operation AuthorizedPrincipalList
    $entries += @{
        Operation="New-RscQueryLdap -AuthorizedPrincipalList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryLdap -Operation AuthorizedPrincipalList
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
    (New-RscQueryLdap -Operation IntegrationList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryLdap -Operation IntegrationList
    $entries += @{
        Operation="New-RscQueryLdap -IntegrationList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryLdap -Operation IntegrationList
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
    (New-RscQueryLdap -Operation PrincipalList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryLdap -Operation PrincipalList
    $entries += @{
        Operation="New-RscQueryLdap -PrincipalList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryLdap -Operation PrincipalList
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
    (New-RscQueryM365 -Operation Regions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryM365 -Operation Regions
    $entries += @{
        Operation="New-RscQueryM365 -Regions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryM365 -Operation Regions
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
    (New-RscQueryManagedVolume -Operation InventoryStats).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryManagedVolume -Operation InventoryStats
    $entries += @{
        Operation="New-RscQueryManagedVolume -InventoryStats" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryManagedVolume -Operation InventoryStats
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
    (New-RscQueryManagedVolume -Operation LiveMounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryManagedVolume -Operation LiveMounts
    $entries += @{
        Operation="New-RscQueryManagedVolume -LiveMounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryManagedVolume -Operation LiveMounts
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
    (New-RscQueryManagedVolume -Operation ManagedVolume).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryManagedVolume -Operation ManagedVolume
    $entries += @{
        Operation="New-RscQueryManagedVolume -ManagedVolume" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryManagedVolume -Operation ManagedVolume
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
    (New-RscQueryManagedVolume -Operation ManagedVolumes).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryManagedVolume -Operation ManagedVolumes
    $entries += @{
        Operation="New-RscQueryManagedVolume -ManagedVolumes" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryManagedVolume -Operation ManagedVolumes
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
    (New-RscQueryMongo -Operation BulkRecoverableRange).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation BulkRecoverableRange
    $entries += @{
        Operation="New-RscQueryMongo -BulkRecoverableRange" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation BulkRecoverableRange
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
    (New-RscQueryMongo -Operation BulkRecoverableRanges).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation BulkRecoverableRanges
    $entries += @{
        Operation="New-RscQueryMongo -BulkRecoverableRanges" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation BulkRecoverableRanges
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
    (New-RscQueryMongo -Operation Collection).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation Collection
    $entries += @{
        Operation="New-RscQueryMongo -Collection" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation Collection
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
    (New-RscQueryMongo -Operation CollectionRecoverableRange).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation CollectionRecoverableRange
    $entries += @{
        Operation="New-RscQueryMongo -CollectionRecoverableRange" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation CollectionRecoverableRange
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
    (New-RscQueryMongo -Operation Collections).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation Collections
    $entries += @{
        Operation="New-RscQueryMongo -Collections" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation Collections
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
    (New-RscQueryMongo -Operation Database).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation Database
    $entries += @{
        Operation="New-RscQueryMongo -Database" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation Database
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
    (New-RscQueryMongo -Operation Databases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation Databases
    $entries += @{
        Operation="New-RscQueryMongo -Databases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation Databases
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
    (New-RscQueryMongo -Operation RecoverableRanges).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation RecoverableRanges
    $entries += @{
        Operation="New-RscQueryMongo -RecoverableRanges" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation RecoverableRanges
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
    (New-RscQueryMongo -Operation Source).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation Source
    $entries += @{
        Operation="New-RscQueryMongo -Source" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation Source
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
    (New-RscQueryMongo -Operation Sources).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMongo -Operation Sources
    $entries += @{
        Operation="New-RscQueryMongo -Sources" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMongo -Operation Sources
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
    (New-RscQueryMosaic -Operation BulkRecoveryRange).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMosaic -Operation BulkRecoveryRange
    $entries += @{
        Operation="New-RscQueryMosaic -BulkRecoveryRange" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMosaic -Operation BulkRecoveryRange
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
    (New-RscQueryMosaic -Operation Snapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMosaic -Operation Snapshots
    $entries += @{
        Operation="New-RscQueryMosaic -Snapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMosaic -Operation Snapshots
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
    (New-RscQueryMosaic -Operation Stores).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMosaic -Operation Stores
    $entries += @{
        Operation="New-RscQueryMosaic -Stores" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMosaic -Operation Stores
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
    (New-RscQueryMosaic -Operation Versions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMosaic -Operation Versions
    $entries += @{
        Operation="New-RscQueryMosaic -Versions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMosaic -Operation Versions
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
    (New-RscQueryMssql -Operation AvailabilityGroup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation AvailabilityGroup
    $entries += @{
        Operation="New-RscQueryMssql -AvailabilityGroup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation AvailabilityGroup
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
    (New-RscQueryMssql -Operation CdmLogShippingTarget).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation CdmLogShippingTarget
    $entries += @{
        Operation="New-RscQueryMssql -CdmLogShippingTarget" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation CdmLogShippingTarget
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
    (New-RscQueryMssql -Operation CdmLogShippingTargets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation CdmLogShippingTargets
    $entries += @{
        Operation="New-RscQueryMssql -CdmLogShippingTargets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation CdmLogShippingTargets
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
    (New-RscQueryMssql -Operation CompatibleInstances).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation CompatibleInstances
    $entries += @{
        Operation="New-RscQueryMssql -CompatibleInstances" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation CompatibleInstances
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
    (New-RscQueryMssql -Operation Database).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation Database
    $entries += @{
        Operation="New-RscQueryMssql -Database" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation Database
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
    (New-RscQueryMssql -Operation DatabaseLiveMounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation DatabaseLiveMounts
    $entries += @{
        Operation="New-RscQueryMssql -DatabaseLiveMounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation DatabaseLiveMounts
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
    (New-RscQueryMssql -Operation DatabaseMissedRecoverableRanges).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation DatabaseMissedRecoverableRanges
    $entries += @{
        Operation="New-RscQueryMssql -DatabaseMissedRecoverableRanges" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation DatabaseMissedRecoverableRanges
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
    (New-RscQueryMssql -Operation DatabaseMissedSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation DatabaseMissedSnapshots
    $entries += @{
        Operation="New-RscQueryMssql -DatabaseMissedSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation DatabaseMissedSnapshots
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
    (New-RscQueryMssql -Operation DatabaseRestoreEstimate).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation DatabaseRestoreEstimate
    $entries += @{
        Operation="New-RscQueryMssql -DatabaseRestoreEstimate" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation DatabaseRestoreEstimate
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
    (New-RscQueryMssql -Operation DatabaseRestoreFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation DatabaseRestoreFiles
    $entries += @{
        Operation="New-RscQueryMssql -DatabaseRestoreFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation DatabaseRestoreFiles
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
    (New-RscQueryMssql -Operation Databases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation Databases
    $entries += @{
        Operation="New-RscQueryMssql -Databases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation Databases
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
    (New-RscQueryMssql -Operation DefaultProperties).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation DefaultProperties
    $entries += @{
        Operation="New-RscQueryMssql -DefaultProperties" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation DefaultProperties
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
    (New-RscQueryMssql -Operation Instance).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation Instance
    $entries += @{
        Operation="New-RscQueryMssql -Instance" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation Instance
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
    (New-RscQueryMssql -Operation LogShippingTargets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation LogShippingTargets
    $entries += @{
        Operation="New-RscQueryMssql -LogShippingTargets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation LogShippingTargets
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
    (New-RscQueryMssql -Operation RecoverableRanges).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation RecoverableRanges
    $entries += @{
        Operation="New-RscQueryMssql -RecoverableRanges" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation RecoverableRanges
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
    (New-RscQueryMssql -Operation TopLevelDescendants).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryMssql -Operation TopLevelDescendants
    $entries += @{
        Operation="New-RscQueryMssql -TopLevelDescendants" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryMssql -Operation TopLevelDescendants
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
    (New-RscQueryNas -Operation Fileset).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNas -Operation Fileset
    $entries += @{
        Operation="New-RscQueryNas -Fileset" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNas -Operation Fileset
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
    (New-RscQueryNas -Operation Namespace).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNas -Operation Namespace
    $entries += @{
        Operation="New-RscQueryNas -Namespace" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNas -Operation Namespace
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
    (New-RscQueryNas -Operation Namespaces).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNas -Operation Namespaces
    $entries += @{
        Operation="New-RscQueryNas -Namespaces" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNas -Operation Namespaces
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
    (New-RscQueryNas -Operation Share).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNas -Operation Share
    $entries += @{
        Operation="New-RscQueryNas -Share" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNas -Operation Share
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
    (New-RscQueryNas -Operation System).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNas -Operation System
    $entries += @{
        Operation="New-RscQueryNas -System" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNas -Operation System
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
    (New-RscQueryNas -Operation Systems).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNas -Operation Systems
    $entries += @{
        Operation="New-RscQueryNas -Systems" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNas -Operation Systems
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
    (New-RscQueryNas -Operation TopLevelDescendants).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNas -Operation TopLevelDescendants
    $entries += @{
        Operation="New-RscQueryNas -TopLevelDescendants" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNas -Operation TopLevelDescendants
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
    (New-RscQueryNas -Operation Volume).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNas -Operation Volume
    $entries += @{
        Operation="New-RscQueryNas -Volume" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNas -Operation Volume
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
    (New-RscQueryNutanix -Operation BrowseSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation BrowseSnapshot
    $entries += @{
        Operation="New-RscQueryNutanix -BrowseSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation BrowseSnapshot
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
    (New-RscQueryNutanix -Operation Category).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation Category
    $entries += @{
        Operation="New-RscQueryNutanix -Category" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation Category
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
    (New-RscQueryNutanix -Operation CategoryValue).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation CategoryValue
    $entries += @{
        Operation="New-RscQueryNutanix -CategoryValue" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation CategoryValue
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
    (New-RscQueryNutanix -Operation Cluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation Cluster
    $entries += @{
        Operation="New-RscQueryNutanix -Cluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation Cluster
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
    (New-RscQueryNutanix -Operation ClusterAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation ClusterAsyncRequestStatus
    $entries += @{
        Operation="New-RscQueryNutanix -ClusterAsyncRequestStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation ClusterAsyncRequestStatus
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
    (New-RscQueryNutanix -Operation ClusterContainers).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation ClusterContainers
    $entries += @{
        Operation="New-RscQueryNutanix -ClusterContainers" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation ClusterContainers
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
    (New-RscQueryNutanix -Operation ClusterNetworks).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation ClusterNetworks
    $entries += @{
        Operation="New-RscQueryNutanix -ClusterNetworks" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation ClusterNetworks
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
    (New-RscQueryNutanix -Operation Clusters).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation Clusters
    $entries += @{
        Operation="New-RscQueryNutanix -Clusters" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation Clusters
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
    (New-RscQueryNutanix -Operation Mounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation Mounts
    $entries += @{
        Operation="New-RscQueryNutanix -Mounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation Mounts
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
    (New-RscQueryNutanix -Operation PrismCentral).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation PrismCentral
    $entries += @{
        Operation="New-RscQueryNutanix -PrismCentral" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation PrismCentral
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
    (New-RscQueryNutanix -Operation PrismCentrals).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation PrismCentrals
    $entries += @{
        Operation="New-RscQueryNutanix -PrismCentrals" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation PrismCentrals
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
    (New-RscQueryNutanix -Operation SearchVm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation SearchVm
    $entries += @{
        Operation="New-RscQueryNutanix -SearchVm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation SearchVm
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
    (New-RscQueryNutanix -Operation SnapshotDetail).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation SnapshotDetail
    $entries += @{
        Operation="New-RscQueryNutanix -SnapshotDetail" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation SnapshotDetail
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
    (New-RscQueryNutanix -Operation TopLevelDescendants).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation TopLevelDescendants
    $entries += @{
        Operation="New-RscQueryNutanix -TopLevelDescendants" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation TopLevelDescendants
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
    (New-RscQueryNutanix -Operation Vm).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation Vm
    $entries += @{
        Operation="New-RscQueryNutanix -Vm" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation Vm
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
    (New-RscQueryNutanix -Operation VmAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation VmAsyncRequestStatus
    $entries += @{
        Operation="New-RscQueryNutanix -VmAsyncRequestStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation VmAsyncRequestStatus
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
    (New-RscQueryNutanix -Operation VmMissedSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation VmMissedSnapshots
    $entries += @{
        Operation="New-RscQueryNutanix -VmMissedSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation VmMissedSnapshots
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
    (New-RscQueryNutanix -Operation Vms).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryNutanix -Operation Vms
    $entries += @{
        Operation="New-RscQueryNutanix -Vms" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryNutanix -Operation Vms
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
    (New-RscQueryO365 -Operation AdGroups).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation AdGroups
    $entries += @{
        Operation="New-RscQueryO365 -AdGroups" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation AdGroups
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
    (New-RscQueryO365 -Operation BrowseTeamConvChannels).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation BrowseTeamConvChannels
    $entries += @{
        Operation="New-RscQueryO365 -BrowseTeamConvChannels" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation BrowseTeamConvChannels
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
    (New-RscQueryO365 -Operation Calendar).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Calendar
    $entries += @{
        Operation="New-RscQueryO365 -Calendar" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Calendar
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
    (New-RscQueryO365 -Operation Groups).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Groups
    $entries += @{
        Operation="New-RscQueryO365 -Groups" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Groups
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
    (New-RscQueryO365 -Operation License).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation License
    $entries += @{
        Operation="New-RscQueryO365 -License" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation License
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
    (New-RscQueryO365 -Operation ListApps).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation ListApps
    $entries += @{
        Operation="New-RscQueryO365 -ListApps" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation ListApps
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
    (New-RscQueryO365 -Operation Mailbox).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Mailbox
    $entries += @{
        Operation="New-RscQueryO365 -Mailbox" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Mailbox
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
    (New-RscQueryO365 -Operation Mailboxes).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Mailboxes
    $entries += @{
        Operation="New-RscQueryO365 -Mailboxes" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Mailboxes
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
    (New-RscQueryO365 -Operation ObjectAncestors).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation ObjectAncestors
    $entries += @{
        Operation="New-RscQueryO365 -ObjectAncestors" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation ObjectAncestors
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
    (New-RscQueryO365 -Operation Onedrive).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Onedrive
    $entries += @{
        Operation="New-RscQueryO365 -Onedrive" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Onedrive
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
    (New-RscQueryO365 -Operation Onedrives).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Onedrives
    $entries += @{
        Operation="New-RscQueryO365 -Onedrives" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Onedrives
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
    (New-RscQueryO365 -Operation Org).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Org
    $entries += @{
        Operation="New-RscQueryO365 -Org" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Org
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
    (New-RscQueryO365 -Operation OrgAtSnappableLevel).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation OrgAtSnappableLevel
    $entries += @{
        Operation="New-RscQueryO365 -OrgAtSnappableLevel" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation OrgAtSnappableLevel
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
    (New-RscQueryO365 -Operation OrgStatuses).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation OrgStatuses
    $entries += @{
        Operation="New-RscQueryO365 -OrgStatuses" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation OrgStatuses
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
    (New-RscQueryO365 -Operation OrgSummaries).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation OrgSummaries
    $entries += @{
        Operation="New-RscQueryO365 -OrgSummaries" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation OrgSummaries
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
    (New-RscQueryO365 -Operation Orgs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Orgs
    $entries += @{
        Operation="New-RscQueryO365 -Orgs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Orgs
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
    (New-RscQueryO365 -Operation ServiceAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation ServiceAccount
    $entries += @{
        Operation="New-RscQueryO365 -ServiceAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation ServiceAccount
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
    (New-RscQueryO365 -Operation ServiceStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation ServiceStatus
    $entries += @{
        Operation="New-RscQueryO365 -ServiceStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation ServiceStatus
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
    (New-RscQueryO365 -Operation SharepointDrive).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SharepointDrive
    $entries += @{
        Operation="New-RscQueryO365 -SharepointDrive" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SharepointDrive
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
    (New-RscQueryO365 -Operation SharepointDrives).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SharepointDrives
    $entries += @{
        Operation="New-RscQueryO365 -SharepointDrives" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SharepointDrives
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
    (New-RscQueryO365 -Operation SharepointList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SharepointList
    $entries += @{
        Operation="New-RscQueryO365 -SharepointList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SharepointList
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
    (New-RscQueryO365 -Operation SharepointLists).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SharepointLists
    $entries += @{
        Operation="New-RscQueryO365 -SharepointLists" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SharepointLists
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
    (New-RscQueryO365 -Operation SharepointObjectList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SharepointObjectList
    $entries += @{
        Operation="New-RscQueryO365 -SharepointObjectList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SharepointObjectList
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
    (New-RscQueryO365 -Operation SharepointObjects).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SharepointObjects
    $entries += @{
        Operation="New-RscQueryO365 -SharepointObjects" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SharepointObjects
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
    (New-RscQueryO365 -Operation SharepointSite).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SharepointSite
    $entries += @{
        Operation="New-RscQueryO365 -SharepointSite" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SharepointSite
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
    (New-RscQueryO365 -Operation SharepointSites).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SharepointSites
    $entries += @{
        Operation="New-RscQueryO365 -SharepointSites" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SharepointSites
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
    (New-RscQueryO365 -Operation Site).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Site
    $entries += @{
        Operation="New-RscQueryO365 -Site" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Site
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
    (New-RscQueryO365 -Operation Sites).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Sites
    $entries += @{
        Operation="New-RscQueryO365 -Sites" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Sites
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
    (New-RscQueryO365 -Operation StorageStats).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation StorageStats
    $entries += @{
        Operation="New-RscQueryO365 -StorageStats" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation StorageStats
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
    (New-RscQueryO365 -Operation SubscriptionsAppTypeCounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation SubscriptionsAppTypeCounts
    $entries += @{
        Operation="New-RscQueryO365 -SubscriptionsAppTypeCounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation SubscriptionsAppTypeCounts
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
    (New-RscQueryO365 -Operation Team).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Team
    $entries += @{
        Operation="New-RscQueryO365 -Team" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Team
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
    (New-RscQueryO365 -Operation TeamChannels).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation TeamChannels
    $entries += @{
        Operation="New-RscQueryO365 -TeamChannels" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation TeamChannels
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
    (New-RscQueryO365 -Operation TeamConversationsFolderID).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation TeamConversationsFolderID
    $entries += @{
        Operation="New-RscQueryO365 -TeamConversationsFolderID" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation TeamConversationsFolderID
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
    (New-RscQueryO365 -Operation TeamPostedBy).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation TeamPostedBy
    $entries += @{
        Operation="New-RscQueryO365 -TeamPostedBy" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation TeamPostedBy
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
    (New-RscQueryO365 -Operation Teams).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation Teams
    $entries += @{
        Operation="New-RscQueryO365 -Teams" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation Teams
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
    (New-RscQueryO365 -Operation User).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation User
    $entries += @{
        Operation="New-RscQueryO365 -User" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation User
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
    (New-RscQueryO365 -Operation UserObjects).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryO365 -Operation UserObjects
    $entries += @{
        Operation="New-RscQueryO365 -UserObjects" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryO365 -Operation UserObjects
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
    (New-RscQueryOracle -Operation AcoExampleDownloadLink).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation AcoExampleDownloadLink
    $entries += @{
        Operation="New-RscQueryOracle -AcoExampleDownloadLink" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation AcoExampleDownloadLink
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
    (New-RscQueryOracle -Operation AcoParameters).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation AcoParameters
    $entries += @{
        Operation="New-RscQueryOracle -AcoParameters" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation AcoParameters
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
    (New-RscQueryOracle -Operation DataGuardGroup).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation DataGuardGroup
    $entries += @{
        Operation="New-RscQueryOracle -DataGuardGroup" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation DataGuardGroup
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
    (New-RscQueryOracle -Operation Database).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation Database
    $entries += @{
        Operation="New-RscQueryOracle -Database" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation Database
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
    (New-RscQueryOracle -Operation DatabaseLogBackupConfig).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation DatabaseLogBackupConfig
    $entries += @{
        Operation="New-RscQueryOracle -DatabaseLogBackupConfig" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation DatabaseLogBackupConfig
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
    (New-RscQueryOracle -Operation Databases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation Databases
    $entries += @{
        Operation="New-RscQueryOracle -Databases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation Databases
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
    (New-RscQueryOracle -Operation Host).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation Host
    $entries += @{
        Operation="New-RscQueryOracle -Host" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation Host
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
    (New-RscQueryOracle -Operation HostLogBackupConfig).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation HostLogBackupConfig
    $entries += @{
        Operation="New-RscQueryOracle -HostLogBackupConfig" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation HostLogBackupConfig
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
    (New-RscQueryOracle -Operation LiveMounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation LiveMounts
    $entries += @{
        Operation="New-RscQueryOracle -LiveMounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation LiveMounts
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
    (New-RscQueryOracle -Operation MissedRecoverableRanges).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation MissedRecoverableRanges
    $entries += @{
        Operation="New-RscQueryOracle -MissedRecoverableRanges" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation MissedRecoverableRanges
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
    (New-RscQueryOracle -Operation MissedSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation MissedSnapshots
    $entries += @{
        Operation="New-RscQueryOracle -MissedSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation MissedSnapshots
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
    (New-RscQueryOracle -Operation PdbDetails).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation PdbDetails
    $entries += @{
        Operation="New-RscQueryOracle -PdbDetails" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation PdbDetails
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
    (New-RscQueryOracle -Operation Rac).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation Rac
    $entries += @{
        Operation="New-RscQueryOracle -Rac" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation Rac
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
    (New-RscQueryOracle -Operation RacLogBackupConfig).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation RacLogBackupConfig
    $entries += @{
        Operation="New-RscQueryOracle -RacLogBackupConfig" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation RacLogBackupConfig
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
    (New-RscQueryOracle -Operation RecoverableRanges).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation RecoverableRanges
    $entries += @{
        Operation="New-RscQueryOracle -RecoverableRanges" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation RecoverableRanges
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
    (New-RscQueryOracle -Operation TopLevelDescendants).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryOracle -Operation TopLevelDescendants
    $entries += @{
        Operation="New-RscQueryOracle -TopLevelDescendants" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryOracle -Operation TopLevelDescendants
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
    (New-RscQueryPolicy -Operation Details).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryPolicy -Operation Details
    $entries += @{
        Operation="New-RscQueryPolicy -Details" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryPolicy -Operation Details
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
    (New-RscQueryPolicy -Operation Obj).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryPolicy -Operation Obj
    $entries += @{
        Operation="New-RscQueryPolicy -Obj" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryPolicy -Operation Obj
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
    (New-RscQueryPolicy -Operation ObjectUsages).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryPolicy -Operation ObjectUsages
    $entries += @{
        Operation="New-RscQueryPolicy -ObjectUsages" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryPolicy -Operation ObjectUsages
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
    (New-RscQueryPolicy -Operation Objs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryPolicy -Operation Objs
    $entries += @{
        Operation="New-RscQueryPolicy -Objs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryPolicy -Operation Objs
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
    (New-RscQueryPolicy -Operation Policies).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryPolicy -Operation Policies
    $entries += @{
        Operation="New-RscQueryPolicy -Policies" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryPolicy -Operation Policies
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
    (New-RscQueryPolicy -Operation Policy).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryPolicy -Operation Policy
    $entries += @{
        Operation="New-RscQueryPolicy -Policy" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryPolicy -Operation Policy
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
    (New-RscQueryRansomware -Operation DetectionWorkloadLocations).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation DetectionWorkloadLocations
    $entries += @{
        Operation="New-RscQueryRansomware -DetectionWorkloadLocations" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation DetectionWorkloadLocations
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
    (New-RscQueryRansomware -Operation InvestigationAnalysisSummary).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation InvestigationAnalysisSummary
    $entries += @{
        Operation="New-RscQueryRansomware -InvestigationAnalysisSummary" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation InvestigationAnalysisSummary
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
    (New-RscQueryRansomware -Operation InvestigationEnablement).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation InvestigationEnablement
    $entries += @{
        Operation="New-RscQueryRansomware -InvestigationEnablement" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation InvestigationEnablement
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
    (New-RscQueryRansomware -Operation InvestigationWorkloadScannedCount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation InvestigationWorkloadScannedCount
    $entries += @{
        Operation="New-RscQueryRansomware -InvestigationWorkloadScannedCount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation InvestigationWorkloadScannedCount
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
    (New-RscQueryRansomware -Operation OverallInvestigationSummary).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation OverallInvestigationSummary
    $entries += @{
        Operation="New-RscQueryRansomware -OverallInvestigationSummary" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation OverallInvestigationSummary
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
    (New-RscQueryRansomware -Operation PendingInvestigationResultsCount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation PendingInvestigationResultsCount
    $entries += @{
        Operation="New-RscQueryRansomware -PendingInvestigationResultsCount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation PendingInvestigationResultsCount
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
    (New-RscQueryRansomware -Operation ProcessedInvestigationWorkloadCount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation ProcessedInvestigationWorkloadCount
    $entries += @{
        Operation="New-RscQueryRansomware -ProcessedInvestigationWorkloadCount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation ProcessedInvestigationWorkloadCount
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
    (New-RscQueryRansomware -Operation ProtectedInvestigationWorkloadCount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation ProtectedInvestigationWorkloadCount
    $entries += @{
        Operation="New-RscQueryRansomware -ProtectedInvestigationWorkloadCount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation ProtectedInvestigationWorkloadCount
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
    (New-RscQueryRansomware -Operation Result).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation Result
    $entries += @{
        Operation="New-RscQueryRansomware -Result" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation Result
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
    (New-RscQueryRansomware -Operation ResultOpt).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation ResultOpt
    $entries += @{
        Operation="New-RscQueryRansomware -ResultOpt" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation ResultOpt
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
    (New-RscQueryRansomware -Operation Results).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation Results
    $entries += @{
        Operation="New-RscQueryRansomware -Results" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation Results
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
    (New-RscQueryRansomware -Operation ResultsGrouped).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRansomware -Operation ResultsGrouped
    $entries += @{
        Operation="New-RscQueryRansomware -ResultsGrouped" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRansomware -Operation ResultsGrouped
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
    (New-RscQueryRcs -Operation ArchivalLocationsConsumptionStats).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRcs -Operation ArchivalLocationsConsumptionStats
    $entries += @{
        Operation="New-RscQueryRcs -ArchivalLocationsConsumptionStats" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRcs -Operation ArchivalLocationsConsumptionStats
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
    (New-RscQueryRcs -Operation Cluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRcs -Operation Cluster
    $entries += @{
        Operation="New-RscQueryRcs -Cluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRcs -Operation Cluster
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
    (New-RscQueryRcs -Operation Dhcores).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRcs -Operation Dhcores
    $entries += @{
        Operation="New-RscQueryRcs -Dhcores" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRcs -Operation Dhcores
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
    (New-RscQueryRcv -Operation AccountEntitlement).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryRcv -Operation AccountEntitlement
    $entries += @{
        Operation="New-RscQueryRcv -AccountEntitlement" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryRcv -Operation AccountEntitlement
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
    (New-RscQueryReplication -Operation IncomingStats).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryReplication -Operation IncomingStats
    $entries += @{
        Operation="New-RscQueryReplication -IncomingStats" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryReplication -Operation IncomingStats
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
    (New-RscQueryReplication -Operation OutgoingStats).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryReplication -Operation OutgoingStats
    $entries += @{
        Operation="New-RscQueryReplication -OutgoingStats" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryReplication -Operation OutgoingStats
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
    (New-RscQueryReplication -Operation Pairs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryReplication -Operation Pairs
    $entries += @{
        Operation="New-RscQueryReplication -Pairs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryReplication -Operation Pairs
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
    (New-RscQueryReplication -Operation ValidTargets).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryReplication -Operation ValidTargets
    $entries += @{
        Operation="New-RscQueryReplication -ValidTargets" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryReplication -Operation ValidTargets
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
    (New-RscQueryReport -Operation Data).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryReport -Operation Data
    $entries += @{
        Operation="New-RscQueryReport -Data" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryReport -Operation Data
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
    (New-RscQueryReport -Operation Scheduled).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryReport -Operation Scheduled
    $entries += @{
        Operation="New-RscQueryReport -Scheduled" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryReport -Operation Scheduled
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
    (New-RscQuerySapHana -Operation Database).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySapHana -Operation Database
    $entries += @{
        Operation="New-RscQuerySapHana -Database" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySapHana -Operation Database
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
    (New-RscQuerySapHana -Operation Databases).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySapHana -Operation Databases
    $entries += @{
        Operation="New-RscQuerySapHana -Databases" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySapHana -Operation Databases
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
    (New-RscQuerySapHana -Operation LogSnapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySapHana -Operation LogSnapshot
    $entries += @{
        Operation="New-RscQuerySapHana -LogSnapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySapHana -Operation LogSnapshot
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
    (New-RscQuerySapHana -Operation LogSnapshots).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySapHana -Operation LogSnapshots
    $entries += @{
        Operation="New-RscQuerySapHana -LogSnapshots" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySapHana -Operation LogSnapshots
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
    (New-RscQuerySapHana -Operation RecoverableRange).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySapHana -Operation RecoverableRange
    $entries += @{
        Operation="New-RscQuerySapHana -RecoverableRange" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySapHana -Operation RecoverableRange
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
    (New-RscQuerySapHana -Operation RecoverableRanges).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySapHana -Operation RecoverableRanges
    $entries += @{
        Operation="New-RscQuerySapHana -RecoverableRanges" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySapHana -Operation RecoverableRanges
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
    (New-RscQuerySapHana -Operation System).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySapHana -Operation System
    $entries += @{
        Operation="New-RscQuerySapHana -System" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySapHana -Operation System
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
    (New-RscQuerySapHana -Operation Systems).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySapHana -Operation Systems
    $entries += @{
        Operation="New-RscQuerySapHana -Systems" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySapHana -Operation Systems
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
    (New-RscQueryServiceAccount -Operation ServiceAccount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryServiceAccount -Operation ServiceAccount
    $entries += @{
        Operation="New-RscQueryServiceAccount -ServiceAccount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryServiceAccount -Operation ServiceAccount
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
    (New-RscQuerySharepoint -Operation BrowseDrive).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySharepoint -Operation BrowseDrive
    $entries += @{
        Operation="New-RscQuerySharepoint -BrowseDrive" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySharepoint -Operation BrowseDrive
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
    (New-RscQuerySharepoint -Operation BrowseList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySharepoint -Operation BrowseList
    $entries += @{
        Operation="New-RscQuerySharepoint -BrowseList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySharepoint -Operation BrowseList
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
    (New-RscQuerySharepoint -Operation SiteDescendants).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySharepoint -Operation SiteDescendants
    $entries += @{
        Operation="New-RscQuerySharepoint -SiteDescendants" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySharepoint -Operation SiteDescendants
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
    (New-RscQuerySharepoint -Operation SiteExclusions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySharepoint -Operation SiteExclusions
    $entries += @{
        Operation="New-RscQuerySharepoint -SiteExclusions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySharepoint -Operation SiteExclusions
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
    (New-RscQuerySharepoint -Operation SiteSearch).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySharepoint -Operation SiteSearch
    $entries += @{
        Operation="New-RscQuerySharepoint -SiteSearch" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySharepoint -Operation SiteSearch
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
    (New-RscQuerySharepoint -Operation SnappableDriveSearch).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySharepoint -Operation SnappableDriveSearch
    $entries += @{
        Operation="New-RscQuerySharepoint -SnappableDriveSearch" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySharepoint -Operation SnappableDriveSearch
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
    (New-RscQuerySharepoint -Operation SnappableListSearch).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySharepoint -Operation SnappableListSearch
    $entries += @{
        Operation="New-RscQuerySharepoint -SnappableListSearch" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySharepoint -Operation SnappableListSearch
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
    (New-RscQuerySharepoint -Operation SnapshotDriveSearch).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySharepoint -Operation SnapshotDriveSearch
    $entries += @{
        Operation="New-RscQuerySharepoint -SnapshotDriveSearch" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySharepoint -Operation SnapshotDriveSearch
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
    (New-RscQuerySla -Operation AuditDetail).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation AuditDetail
    $entries += @{
        Operation="New-RscQuerySla -AuditDetail" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation AuditDetail
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
    (New-RscQuerySla -Operation ClusterDomains).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation ClusterDomains
    $entries += @{
        Operation="New-RscQuerySla -ClusterDomains" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation ClusterDomains
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
    (New-RscQuerySla -Operation ClusterGlobals).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation ClusterGlobals
    $entries += @{
        Operation="New-RscQuerySla -ClusterGlobals" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation ClusterGlobals
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
    (New-RscQuerySla -Operation ConflictObjects).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation ConflictObjects
    $entries += @{
        Operation="New-RscQuerySla -ConflictObjects" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation ConflictObjects
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
    (New-RscQuerySla -Operation CountOfObjectsProtected).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation CountOfObjectsProtected
    $entries += @{
        Operation="New-RscQuerySla -CountOfObjectsProtected" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation CountOfObjectsProtected
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
    (New-RscQuerySla -Operation Domain).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation Domain
    $entries += @{
        Operation="New-RscQuerySla -Domain" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation Domain
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
    (New-RscQuerySla -Operation Domains).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation Domains
    $entries += @{
        Operation="New-RscQuerySla -Domains" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation Domains
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
    (New-RscQuerySla -Operation GlobalFilterList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation GlobalFilterList
    $entries += @{
        Operation="New-RscQuerySla -GlobalFilterList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation GlobalFilterList
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
    (New-RscQuerySla -Operation GlobalStatuses).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation GlobalStatuses
    $entries += @{
        Operation="New-RscQuerySla -GlobalStatuses" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation GlobalStatuses
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
    (New-RscQuerySla -Operation ManagedVolume).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation ManagedVolume
    $entries += @{
        Operation="New-RscQuerySla -ManagedVolume" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation ManagedVolume
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
    (New-RscQuerySla -Operation ManagedVolumes).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation ManagedVolumes
    $entries += @{
        Operation="New-RscQuerySla -ManagedVolumes" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation ManagedVolumes
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
    (New-RscQuerySla -Operation NcdComplianceData).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation NcdComplianceData
    $entries += @{
        Operation="New-RscQuerySla -NcdComplianceData" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation NcdComplianceData
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
    (New-RscQuerySla -Operation SummariesByIds).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation SummariesByIds
    $entries += @{
        Operation="New-RscQuerySla -SummariesByIds" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation SummariesByIds
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
    (New-RscQuerySla -Operation VerifyWithReplicationToCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySla -Operation VerifyWithReplicationToCluster
    $entries += @{
        Operation="New-RscQuerySla -VerifyWithReplicationToCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySla -Operation VerifyWithReplicationToCluster
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
    (New-RscQuerySmb -Operation Configuration).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySmb -Operation Configuration
    $entries += @{
        Operation="New-RscQuerySmb -Configuration" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySmb -Operation Configuration
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
    (New-RscQuerySmb -Operation Domains).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySmb -Operation Domains
    $entries += @{
        Operation="New-RscQuerySmb -Domains" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySmb -Operation Domains
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
    (New-RscQuerySnapshot -Operation BrowseFileList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation BrowseFileList
    $entries += @{
        Operation="New-RscQuerySnapshot -BrowseFileList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation BrowseFileList
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
    (New-RscQuerySnapshot -Operation ClosestToPointInTime).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation ClosestToPointInTime
    $entries += @{
        Operation="New-RscQuerySnapshot -ClosestToPointInTime" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation ClosestToPointInTime
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
    (New-RscQuerySnapshot -Operation EmailSearch).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation EmailSearch
    $entries += @{
        Operation="New-RscQuerySnapshot -EmailSearch" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation EmailSearch
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
    (New-RscQuerySnapshot -Operation EventSearch).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation EventSearch
    $entries += @{
        Operation="New-RscQuerySnapshot -EventSearch" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation EventSearch
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
    (New-RscQuerySnapshot -Operation FilesDelta).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation FilesDelta
    $entries += @{
        Operation="New-RscQuerySnapshot -FilesDelta" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation FilesDelta
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
    (New-RscQuerySnapshot -Operation FilesDeltaV2).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation FilesDeltaV2
    $entries += @{
        Operation="New-RscQuerySnapshot -FilesDeltaV2" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation FilesDeltaV2
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
    (New-RscQuerySnapshot -Operation Fileset).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation Fileset
    $entries += @{
        Operation="New-RscQuerySnapshot -Fileset" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation Fileset
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
    (New-RscQuerySnapshot -Operation FilesetFiles).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation FilesetFiles
    $entries += @{
        Operation="New-RscQuerySnapshot -FilesetFiles" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation FilesetFiles
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
    (New-RscQuerySnapshot -Operation LegalHoldSnappable).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation LegalHoldSnappable
    $entries += @{
        Operation="New-RscQuerySnapshot -LegalHoldSnappable" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation LegalHoldSnappable
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
    (New-RscQuerySnapshot -Operation OnedriveSearch).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation OnedriveSearch
    $entries += @{
        Operation="New-RscQuerySnapshot -OnedriveSearch" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation OnedriveSearch
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
    (New-RscQuerySnapshot -Operation Polaris).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation Polaris
    $entries += @{
        Operation="New-RscQuerySnapshot -Polaris" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation Polaris
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
    (New-RscQuerySnapshot -Operation Pvcs).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation Pvcs
    $entries += @{
        Operation="New-RscQuerySnapshot -Pvcs" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation Pvcs
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
    (New-RscQuerySnapshot -Operation QuarantinedDetails).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation QuarantinedDetails
    $entries += @{
        Operation="New-RscQuerySnapshot -QuarantinedDetails" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation QuarantinedDetails
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
    (New-RscQuerySnapshot -Operation Results).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation Results
    $entries += @{
        Operation="New-RscQuerySnapshot -Results" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation Results
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
    (New-RscQuerySnapshot -Operation SnappableList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation SnappableList
    $entries += @{
        Operation="New-RscQuerySnapshot -SnappableList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation SnappableList
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
    (New-RscQuerySnapshot -Operation SnappablesList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation SnappablesList
    $entries += @{
        Operation="New-RscQuerySnapshot -SnappablesList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation SnappablesList
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
    (New-RscQuerySnapshot -Operation SnappablesWithLegalHoldsSummary).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation SnappablesWithLegalHoldsSummary
    $entries += @{
        Operation="New-RscQuerySnapshot -SnappablesWithLegalHoldsSummary" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation SnappablesWithLegalHoldsSummary
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
    (New-RscQuerySnapshot -Operation Snapshot).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation Snapshot
    $entries += @{
        Operation="New-RscQuerySnapshot -Snapshot" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation Snapshot
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
    (New-RscQuerySnapshot -Operation UnmanagedObject).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation UnmanagedObject
    $entries += @{
        Operation="New-RscQuerySnapshot -UnmanagedObject" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation UnmanagedObject
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
    (New-RscQuerySnapshot -Operation VappInstantRecoveryOptions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation VappInstantRecoveryOptions
    $entries += @{
        Operation="New-RscQuerySnapshot -VappInstantRecoveryOptions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation VappInstantRecoveryOptions
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
    (New-RscQuerySnapshot -Operation VappTemplateExportOptions).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySnapshot -Operation VappTemplateExportOptions
    $entries += @{
        Operation="New-RscQuerySnapshot -VappTemplateExportOptions" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySnapshot -Operation VappTemplateExportOptions
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
    (New-RscQuerySonar -Operation ContentReport).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySonar -Operation ContentReport
    $entries += @{
        Operation="New-RscQuerySonar -ContentReport" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySonar -Operation ContentReport
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
    (New-RscQuerySonar -Operation Report).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySonar -Operation Report
    $entries += @{
        Operation="New-RscQuerySonar -Report" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySonar -Operation Report
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
    (New-RscQuerySonar -Operation ReportRow).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySonar -Operation ReportRow
    $entries += @{
        Operation="New-RscQuerySonar -ReportRow" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySonar -Operation ReportRow
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
    (New-RscQuerySonar -Operation UserGroups).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySonar -Operation UserGroups
    $entries += @{
        Operation="New-RscQuerySonar -UserGroups" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySonar -Operation UserGroups
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
    (New-RscQuerySonar -Operation Users).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQuerySonar -Operation Users
    $entries += @{
        Operation="New-RscQuerySonar -Users" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQuerySonar -Operation Users
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
    (New-RscQueryStorageArray -Operation StorageArray).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryStorageArray -Operation StorageArray
    $entries += @{
        Operation="New-RscQueryStorageArray -StorageArray" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryStorageArray -Operation StorageArray
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
    (New-RscQueryThreat -Operation HuntDetail).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryThreat -Operation HuntDetail
    $entries += @{
        Operation="New-RscQueryThreat -HuntDetail" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryThreat -Operation HuntDetail
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
    (New-RscQueryThreat -Operation HuntResult).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryThreat -Operation HuntResult
    $entries += @{
        Operation="New-RscQueryThreat -HuntResult" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryThreat -Operation HuntResult
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
    (New-RscQueryThreat -Operation HuntSummary).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryThreat -Operation HuntSummary
    $entries += @{
        Operation="New-RscQueryThreat -HuntSummary" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryThreat -Operation HuntSummary
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
    (New-RscQueryThreat -Operation Hunts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryThreat -Operation Hunts
    $entries += @{
        Operation="New-RscQueryThreat -Hunts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryThreat -Operation Hunts
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
    (New-RscQueryVcenter -Operation AdvancedTagPreview).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation AdvancedTagPreview
    $entries += @{
        Operation="New-RscQueryVcenter -AdvancedTagPreview" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation AdvancedTagPreview
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
    (New-RscQueryVcenter -Operation HotAddBandwidth).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation HotAddBandwidth
    $entries += @{
        Operation="New-RscQueryVcenter -HotAddBandwidth" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation HotAddBandwidth
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
    (New-RscQueryVcenter -Operation HotAddNetwork).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation HotAddNetwork
    $entries += @{
        Operation="New-RscQueryVcenter -HotAddNetwork" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation HotAddNetwork
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
    (New-RscQueryVcenter -Operation HotAddProxy).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation HotAddProxy
    $entries += @{
        Operation="New-RscQueryVcenter -HotAddProxy" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation HotAddProxy
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
    (New-RscQueryVcenter -Operation List).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation List
    $entries += @{
        Operation="New-RscQueryVcenter -List" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation List
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
    (New-RscQueryVcenter -Operation Networks).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation Networks
    $entries += @{
        Operation="New-RscQueryVcenter -Networks" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation Networks
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
    (New-RscQueryVcenter -Operation NumProxiesNeeded).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation NumProxiesNeeded
    $entries += @{
        Operation="New-RscQueryVcenter -NumProxiesNeeded" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation NumProxiesNeeded
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
    (New-RscQueryVcenter -Operation PreAddInfo).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation PreAddInfo
    $entries += @{
        Operation="New-RscQueryVcenter -PreAddInfo" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation PreAddInfo
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
    (New-RscQueryVcenter -Operation Vcenter).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVcenter -Operation Vcenter
    $entries += @{
        Operation="New-RscQueryVcenter -Vcenter" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVcenter -Operation Vcenter
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
    (New-RscQueryVsphere -Operation ComputeCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation ComputeCluster
    $entries += @{
        Operation="New-RscQueryVsphere -ComputeCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation ComputeCluster
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
    (New-RscQueryVsphere -Operation ComputeClusters).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation ComputeClusters
    $entries += @{
        Operation="New-RscQueryVsphere -ComputeClusters" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation ComputeClusters
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
    (New-RscQueryVsphere -Operation Datacenter).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation Datacenter
    $entries += @{
        Operation="New-RscQueryVsphere -Datacenter" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation Datacenter
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
    (New-RscQueryVsphere -Operation Datastore).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation Datastore
    $entries += @{
        Operation="New-RscQueryVsphere -Datastore" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation Datastore
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
    (New-RscQueryVsphere -Operation DatastoreCluster).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation DatastoreCluster
    $entries += @{
        Operation="New-RscQueryVsphere -DatastoreCluster" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation DatastoreCluster
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
    (New-RscQueryVsphere -Operation DatastoreClusters).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation DatastoreClusters
    $entries += @{
        Operation="New-RscQueryVsphere -DatastoreClusters" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation DatastoreClusters
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
    (New-RscQueryVsphere -Operation DatastoreList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation DatastoreList
    $entries += @{
        Operation="New-RscQueryVsphere -DatastoreList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation DatastoreList
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
    (New-RscQueryVsphere -Operation Folder).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation Folder
    $entries += @{
        Operation="New-RscQueryVsphere -Folder" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation Folder
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
    (New-RscQueryVsphere -Operation Folders).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation Folders
    $entries += @{
        Operation="New-RscQueryVsphere -Folders" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation Folders
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
    (New-RscQueryVsphere -Operation Host).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation Host
    $entries += @{
        Operation="New-RscQueryVsphere -Host" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation Host
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
    (New-RscQueryVsphere -Operation HostDetails).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation HostDetails
    $entries += @{
        Operation="New-RscQueryVsphere -HostDetails" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation HostDetails
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
    (New-RscQueryVsphere -Operation HostList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation HostList
    $entries += @{
        Operation="New-RscQueryVsphere -HostList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation HostList
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
    (New-RscQueryVsphere -Operation HostsByFids).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation HostsByFids
    $entries += @{
        Operation="New-RscQueryVsphere -HostsByFids" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation HostsByFids
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
    (New-RscQueryVsphere -Operation LiveMounts).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation LiveMounts
    $entries += @{
        Operation="New-RscQueryVsphere -LiveMounts" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation LiveMounts
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
    (New-RscQueryVsphere -Operation Mount).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation Mount
    $entries += @{
        Operation="New-RscQueryVsphere -Mount" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation Mount
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
    (New-RscQueryVsphere -Operation MountList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation MountList
    $entries += @{
        Operation="New-RscQueryVsphere -MountList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation MountList
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
    (New-RscQueryVsphere -Operation Network).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation Network
    $entries += @{
        Operation="New-RscQueryVsphere -Network" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation Network
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
    (New-RscQueryVsphere -Operation ResourcePool).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation ResourcePool
    $entries += @{
        Operation="New-RscQueryVsphere -ResourcePool" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation ResourcePool
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
    (New-RscQueryVsphere -Operation RootRecoveryHierarchy).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation RootRecoveryHierarchy
    $entries += @{
        Operation="New-RscQueryVsphere -RootRecoveryHierarchy" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation RootRecoveryHierarchy
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
    (New-RscQueryVsphere -Operation Tag).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation Tag
    $entries += @{
        Operation="New-RscQueryVsphere -Tag" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation Tag
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
    (New-RscQueryVsphere -Operation TagCategory).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation TagCategory
    $entries += @{
        Operation="New-RscQueryVsphere -TagCategory" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation TagCategory
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
    (New-RscQueryVsphere -Operation TopLevelDescendantsList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation TopLevelDescendantsList
    $entries += @{
        Operation="New-RscQueryVsphere -TopLevelDescendantsList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation TopLevelDescendantsList
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
    (New-RscQueryVsphere -Operation VmwareCdpLiveInfo).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphere -Operation VmwareCdpLiveInfo
    $entries += @{
        Operation="New-RscQueryVsphere -VmwareCdpLiveInfo" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphere -Operation VmwareCdpLiveInfo
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
    (New-RscQueryVsphereVm -Operation AsyncRequestStatus).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphereVm -Operation AsyncRequestStatus
    $entries += @{
        Operation="New-RscQueryVsphereVm -AsyncRequestStatus" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphereVm -Operation AsyncRequestStatus
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
    (New-RscQueryVsphereVm -Operation MissedRecoverableRange).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphereVm -Operation MissedRecoverableRange
    $entries += @{
        Operation="New-RscQueryVsphereVm -MissedRecoverableRange" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphereVm -Operation MissedRecoverableRange
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
    (New-RscQueryVsphereVm -Operation New).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphereVm -Operation New
    $entries += @{
        Operation="New-RscQueryVsphereVm -New" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphereVm -Operation New
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
    (New-RscQueryVsphereVm -Operation NewList).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphereVm -Operation NewList
    $entries += @{
        Operation="New-RscQueryVsphereVm -NewList" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphereVm -Operation NewList
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
    (New-RscQueryVsphereVm -Operation RecoverableRange).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphereVm -Operation RecoverableRange
    $entries += @{
        Operation="New-RscQueryVsphereVm -RecoverableRange" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphereVm -Operation RecoverableRange
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
    (New-RscQueryVsphereVm -Operation RecoverableRangeInBatch).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryVsphereVm -Operation RecoverableRangeInBatch
    $entries += @{
        Operation="New-RscQueryVsphereVm -RecoverableRangeInBatch" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryVsphereVm -Operation RecoverableRangeInBatch
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
    (New-RscQueryWebhook -Operation Webhook).GqlRequest().SaveQueryToFile()
} elseif ($FieldCounts) {
    $query = New-RscQueryWebhook -Operation Webhook
    $entries += @{
        Operation="New-RscQueryWebhook -Webhook" ;
        AllFieldsCount = $query.Field.AllFields().Count ; 
        SelectedFieldsCount = $query.Field.SelectedFields().Count }
} else {
    $query = New-RscQueryWebhook -Operation Webhook
    $query.Info()
    $query.VarTemplate()
    $query.GqlRequest($false)
    $query.ToString()
    $query.Var.Info()
    $query.Var.Example()
    $query.Var.ToString()
}


if ($entries.Count -gt 0) {
    $results = $entries | ForEach-Object {
        [PSCustomObject]@{
            Operation           = $_.Operation
            AllFieldsCount      = $_.AllFieldsCount
            SelectedFieldsCount = $_.SelectedFieldsCount
        }
    }
    $results
}