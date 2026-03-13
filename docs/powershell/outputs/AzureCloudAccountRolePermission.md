### AzureCloudAccountRolePermission
AzureRolePermission represents the list of role permissions required for
setting up an Azure subscription.
An Action is allowed if it is present in the list of included actions, but
not in the list of excluded actions. Similarly, a Data Action is allowed if
it is included in the list of included data actions, but not in the list of
excluded data actions.

- includedActions: list of System.Strings
  - Actions which should be allowed on the Azure role for the subscription.
- excludedActions: list of System.Strings
  - Actions which should be explicitly disallowed on the Azure role for the subscription.
- includedDataActions: list of System.Strings
  - Data actions which should be allowed on the Azure role for the subscription.
- excludedDataActions: list of System.Strings
  - Data actions which should be explicitly disallowed on the Azure role for the subscription.
- includedActionsWithUseCase: list of AzurePermissionWithUseCases
  - Actions with use-case descriptions for the Azure role.
- excludedActionsWithUseCase: list of AzurePermissionWithUseCases
  - Excluded actions with use-case descriptions for the Azure role.
- includedDataActionsWithUseCase: list of AzurePermissionWithUseCases
  - Data actions with use-case descriptions for the Azure role.
- excludedDataActionsWithUseCase: list of AzurePermissionWithUseCases
  - Excluded data actions with use-case descriptions for the Azure role.
