### AzureRole
Azure Role details.

- roleDefinitionId: System.String
  - ID of the role definition.
- roleDisplayName: System.String
  - Name of the role.
- roleAssignmentName: System.String
  - Name of the role assignment.
- scope: System.String
  - Scope of the role in Azure. The format of the scope is `/subscriptions/<subscription-native-id>`.
- isRubrikManaged: System.Boolean
  - Specifies whether role is created by Rubrik via OAuth flow or manually by the customer without OAuth flow.
