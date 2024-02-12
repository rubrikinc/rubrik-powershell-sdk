### AzureAdObject
Response to the azureAdObjectsByType API.

- objectId: System.String
  - ID of the Azure AD object.
- snapshotId: System.String
  - ID of the snapshot containing Azure AD Object.
- relationships: Map
  - Relationships of the Azure AD object.
- reverseRelationships: list of AzureAdReverseRelationships
  - Reverse relationships of the Azure Active Directory object.
- azureAdObjects: AzureAdObjects
  - Populate either AzureAdUser or AzureAdGroup.
- type: AzureAdObjectType
  - Azure AD object type.
