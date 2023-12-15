### AzureAdObject
Response to the azureAdObjectsByType API.

- objectId: System.String
  - ID of the Azure AD object.
- snapshotId: System.String
  - ID of the snapshot containing Azure AD Object.
- azureAdObjects: AzureAdObjects
  - Populate either AzureAdUser or AzureAdGroup.
- type: AzureAdObjectType
  - Azure AD object type.
