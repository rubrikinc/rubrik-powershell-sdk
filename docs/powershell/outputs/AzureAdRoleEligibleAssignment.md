### AzureAdRoleEligibleAssignment
Entra ID role-eligible assignment.

- id: System.String
  - ID of the role-eligible assignment.
- principalId: System.String
  - Principal ID of the eligible principal.
- roleDefinitionId: System.String
  - Role definition ID that the principal is eligible for.
- directoryScopeId: System.String
  - Directory scope ID for the eligibility.
- memberType: AzureAdPimEligibilityMemberType
  - Member type of the eligibility.
- status: AzureAdPimEligibilityStatus
  - Status of the eligible assignment.
- startDateTime: DateTime
  - Eligibility start time, parsed from the schedule info.
- endDateTime: DateTime
  - Eligibility expiration time, parsed from the schedule
info expiration. Unset for permanent (noExpiration)
eligibilities.
- roleName: System.String
  - Name of the role definition for which the principal is eligible.
- scopeObjId: System.String
  - ID of the directory scope object for the eligibility.
- scopeObjName: System.String
  - Name of the directory scope object for the eligibility.
- scopeObjType: AzureAdRoleAssignmentScopeType
  - Type of the directory scope object for the eligibility.
- principalObject: AzureAdPimEligibilityPrincipalObject
  - Entra ID object eligible for the role.
