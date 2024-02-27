### SearchAzureAdSnapshotInput
Configuration for the searchAzureAdSnapshot API.

- snapshotId: System.String
  - Snapshot ID to retrieve Azure AD objects.
- azureAdSearchKeyword: System.String
  - Keyword used to search [Deprecated - Use keywordSearchFilters instead].
- workloadFid: System.String
  - Workload FID of the Azure AD directory.
- keywordSearchFilters: list of AzureAdKeywordSearchFilterInputs
  - Search keyword filter for Azure AD objects.
- azureAdObjectType: AzureAdObjectType
  - Azure AD object type.
- azureAdSearchKeywordType: AzureAdObjectSearchType
  - Type of the keyword [Deprecated - Use keywordSearchFilters instead].
