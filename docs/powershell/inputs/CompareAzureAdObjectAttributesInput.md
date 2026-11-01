### CompareAzureAdObjectAttributesInput
Compares an Azure AD object's live Entra ID attributes with its snapshot
attributes.

- objectId: System.String
  - Object ID of the Azure AD object.
- objectIdString: System.String
  - String ID of the Entra ID object.
- workloadFid: System.String
  - Workload FID of the Azure AD directory.
- azureAdObjectType: AzureAdObjectType
  - Azure AD object type.
- snapshotId: System.String
  - Snapshot ID to retrieve Azure AD objects.
- alteredOnly: System.Boolean
  - Keyword used to return only altered attributes.
