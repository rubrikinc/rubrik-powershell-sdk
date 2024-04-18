### SearchAzureAdSnapshotInput
Configuration for the searchAzureAdSnapshot API.

- snapshotId: System.String
  - Snapshot ID to retrieve Azure AD objects.
- workloadFid: System.String
  - Workload FID of the Azure AD directory.
- keywordSearchFilters: list of AzureAdKeywordSearchFilterInputs
  - Search keyword filter for Azure AD objects.
- azureAdObjectType: AzureAdObjectType
  - Azure AD object type.
