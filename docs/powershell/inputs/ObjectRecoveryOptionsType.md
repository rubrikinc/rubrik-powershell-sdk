### ObjectRecoveryOptionsType
Configuration to retrieve Azure AD object recovery.

- servicePrincipalRecoveryOption: ServicePrincipalRecoveryOptionType
  - Specifies the recovery option of an Azure AD service principal.
- applicationRecoveryOption: ApplicationRecoveryOptionType
  - Specifies the recovery option of an Azure AD application.
- userRecoveryOption: UserRecoveryOptionType
  - Specifies the recovery option of an Azure AD user.
- conditionalAccessPolicyRecoveryOption: ConditionalAccessPolicyRecoveryOption
  - Specifies the recovery option of Azure AD conditional access policy.
- administrativeUnitRecoveryOption: AdministrativeUnitRecoveryOption
  - Deprecated, this field is no longer used and will be ignored.
- deviceConfigPolicyRecoveryOption: DeviceConfigPolicyRecoveryOption
  - Specifies the recovery option for device configuration policies.
- governanceRecoveryOption: GovernanceRecoveryOptionType
  - Specifies the governance-aware classifier configuration for Member, Owner, and RoleAssignment edge restore.
