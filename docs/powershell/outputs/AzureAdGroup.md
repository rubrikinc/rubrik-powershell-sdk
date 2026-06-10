### AzureAdGroup
Entra ID group.

- displayName: System.String
  - Display name of the Entra ID group.
- groupType: System.String
  - Group type of the Entra ID group.
- email: System.String
  - Email address of the M365 group.
- onPremSyncStatus: AzureAdOnPremSyncStatus
  - On-prem sync status of the Azure AD group.
- onPremSyncInfo: AzureAdOnPremSyncInfo
  - On-prem sync information of the Entra ID group.
- isPimEnabled: System.Boolean
  - Whether this group has PIM enabled.
- memberPolicy: AzureAdPimPolicy
  - PIM member access-type policy.
- ownerPolicy: AzureAdPimPolicy
  - PIM owner access-type policy.
