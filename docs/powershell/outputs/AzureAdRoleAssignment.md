### AzureAdRoleAssignment
Represents the details of a role assignment between a principal object, role definition, and scope object.

- id: System.String
  - ID of the Azure AD role assignment.
- roleId: System.String
  - ID of the role definition.
- principalId: System.String
  - ID of the principal object to which the role is assigned.
- scopeObjId: System.String
  - ID of the directory scope object where the role is assigned.
- scopeObjName: System.String
  - Name of the directory scope object where the role is assigned.
- principalObject: PrincipalObject
  - Azure AD object to which the role is assigned.
- roleObject: AzureAdRole
  - The Azure AD role object associated with this assignment.
- principalType: AzureAdRoleAssignmentPrincipalType
  - Type of the principal object.
- scopeObjType: AzureAdRoleAssignmentScopeType
  - Type of the directory scope object.
