### AzureAdRoleAssignment
Represents the details of a role assignment between a principal object, role definition, and scope object.

- id: System.String
  - ID of the Entra ID role assignment.
- roleId: System.String
  - ID of the role definition.
- roleObject: AzureAdRole
  - The Entra ID role object associated with this assignment.
- principalId: System.String
  - ID of the principal object to which the role is assigned.
- principalType: AzureAdRoleAssignmentPrincipalType
  - Type of the principal object.
- scopeObjId: System.String
  - ID of the directory scope object where the role is assigned.
- scopeObjType: AzureAdRoleAssignmentScopeType
  - Type of the directory scope object.
- scopeObjName: System.String
  - Name of the directory scope object where the role is assigned.
- principalName: System.String
  - Name of the principal object to which the role is assigned.
- roleName: System.String
  - Name of the role object associated with this assignment.
- principalObject: PrincipalObject
  - The Entra ID object to which the role is assigned.
