### AzureAdRelatedObjectsInput
Configuration to get an Azure AD object's related objects, given a set of relationship types.

- snapshotFid: System.String
  - ID of the snapshot to retrieve the related objects from.
- workloadFid: System.String
  - Workload Fid of the Azure AD Directory to get related objects.
- azureAdObjectUuid: System.String
  - Natural ID of the Azure AD object for which the related objects are being retrieved.
- azureAdCommonSearchKeyword: System.String
  - Keyword used to search.
- azureAdObjectType: AzureAdObjectType
  - Type of the Azure AD object for which the related objects are being retrieved.
- azureAdRelationshipType: list of AzureAdRelationshipTypeInputs
  - Types of relationship to retrieve the related objects with.
- azureAdCommonSearchKeywordType: AzureAdObjectCommonSearchType
  - Type of the keyword.
- azureAdRelatedObjectTypeFilter: list of AzureAdObjectTypes
  - Types of related objects to filter.
