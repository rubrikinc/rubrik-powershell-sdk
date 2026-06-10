### AzureAdReverseRelationshipType
Reverse relationships of an Azure Active Directory object.

- REVERSE_RELATIONSHIP_TYPE_UNKNOWN - Unknown reverse relationship type.
- MEMBER_OF - Member of the relationship. For example, a user of a group.
- OWNER_OF - Owner of the relationship. For example, an owner of a group.
- ROLE_ASSIGNMENT_OF - Assignee of a role. For example, a user assigned to the admin role.
- INCLUDED_IN_POLICY - Component of a policy. For example, a named location included in the policy.
- APPLIED_POLICY - Directory object to which the policy is applied.
- POLICY_SCRIPT_OF - Script associated with a compliance policy.
- PIM_POLICY_APPROVER_OF - Approver of a PIM policy. For example, a user who approves role activations.
- INTUNE_ROLE_ASSIGNMENT_MEMBER_OF - Member of an Intune role assignment. For example, a group that is a
member of an Intune role assignment.
- REUSABLE_SETTING_REFERENCE_OF - Reusable setting reference for a policy.
- INTUNE_ROLE_ASSIGNMENT_SCOPE_OF - Scope of an Intune role assignment scope. For example, a group whose
resources can be managed under an Intune role assignment.
- INTUNE_ROLE_ASSIGNMENT_SCOPE_TAG_OF - Role scope tag of an Intune role assignment. For example, a scope
tag referenced by an Intune role assignment.
- ROLE_SCOPE_TAG_REFERENCE_OF - Role scope tag reference of an Intune object.
- SCOPE_TAG_ASSIGNMENT_OF - Group assigned to a role scope tag.
- REGISTERED_CATALOG_RESOURCE_OF - Registered as a resource in an Entitlement Management (EM) catalog (Group, ServicePrincipal, or Application).
- CATALOG_ROLE_ASSIGNMENT_OF - Granted an Entitlement Management (EM) catalog-scoped role assignment (User, Group, or ServicePrincipal).
- BOUND_TO_CONFIG - Intune policy object referenced by a config binding.
- ACCESS_PACKAGE_RESOURCE_OF - Resource (Group, ServicePrincipal, or Application) exposed through an Entitlement Management access package resource role scope.
- RESOURCE_ROLE_SCOPE_OF - Catalog resource bound to an Access Package via a resource role scope.
- ACCESS_PACKAGE_POLICY_PRINCIPAL_OF - Principal (User, Group, or ServicePrincipal) referenced in an Access Package assignment policy.
- ACCESS_PACKAGE_ASSIGNMENT_OF - Principal (User, Group, or ServicePrincipal) with an active Access Package assignment.
- INCOMPATIBLE_ACCESS_PACKAGE_OF - Access Package marked incompatible with another Access Package.
- INCOMPATIBLE_GROUP_OF - Group marked incompatible with an Access Package.
