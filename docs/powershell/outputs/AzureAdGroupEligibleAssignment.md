### AzureAdGroupEligibleAssignment
Entra ID group-eligible assignment.

- id: System.String
  - ID of the group-eligible assignment.
- principalId: System.String
  - Principal ID of the eligible principal.
- groupId: System.String
  - Group ID that the principal is eligible for.
- accessId: AzureAdPimGroupAccessType
  - Access type for the eligibility (member or owner).
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
- groupName: System.String
  - Name of the group for which the principal is eligible.
- principalObject: AzureAdPimEligibilityPrincipalObject
  - Entra ID object eligible for the group.
