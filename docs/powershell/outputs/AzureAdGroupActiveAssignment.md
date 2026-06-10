### AzureAdGroupActiveAssignment
Entra ID PIM group active assignment.

- id: System.String
  - ID of the group active assignment.
- principalId: System.String
  - Principal ID of the assigned principal.
- groupId: System.String
  - Group ID that the principal is assigned to.
- accessId: AzureAdPimGroupAccessType
  - Access type for the assignment (member or owner).
- assignmentType: AzureAdPimAssignmentType
  - How this assignment was created.
- memberType: AzureAdPimEligibilityMemberType
  - Member type of the assignment.
- status: AzureAdPimEligibilityStatus
  - Status of the active assignment.
- startDateTime: DateTime
  - Assignment start time.
- endDateTime: DateTime
  - Assignment expiration time. Unset for permanent assignments.
- groupName: System.String
  - Name of the group to which the principal is assigned.
- principalObject: AzureAdPimActivePrincipalObject
  - Entra ID object assigned to the group.
