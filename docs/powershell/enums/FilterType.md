### FilterType
FilterType represents the possible types of filters.

- FILTER_TYPE_UNSPECIFIED - Unspecified filter type.
- SECURITY_SNAPPABLE_CLOUD_ACCOUNT - Object-level is backup filter.
- SECURITY_SNAPPABLE_BACKUP - Object-level is backup filter.
- SECURITY_SNAPPABLE_ENCRYPTION - Object-level is encrypted filter.
- SECURITY_SNAPPABLE_LOGGING - Is logging enabled filter.
- SECURITY_SNAPPABLE_NAME - Object-level name filter.
- SECURITY_SNAPPABLE_NETWORK_ACCESS - Object-level network access filter.
- SECURITY_SNAPPABLE_REGION - Region filter.
- SECURITY_SNAPPABLE_TAG - Object-level tag key/name filter.
- SECURITY_SNAPPABLE_TYPE - Object type filter.
- SECURITY_SNAPPABLE_CREATED_AT - Object-level created at filter.
- SECURITY_DOCUMENT_DATA_CATEGORY - Document-level data type category filter.
- SECURITY_DOCUMENT_DATA_TYPE - Document-level data type filter.
- SECURITY_DOCUMENT_EXPOSURE - Document-level exposure filter.
- SECURITY_DOCUMENT_LAST_ACCESS - Document-level last accessed time filter.
- SECURITY_DOCUMENT_LAST_MODIFIED - Document-level last modified time filter.
- SECURITY_DOCUMENT_SENSITIVITY - Document-level sensitivity filter.
- SECURITY_DOCUMENT_MIP_LABEL - Document-level MIP label filter.
- SECURITY_DOCUMENT_DOCUMENT_TYPE - Document-level document-type filter.
- SECURITY_DOCUMENT_HIT_COUNT - Document-level hit count filter.
- SECURITY_IDENTITY_NAME - Identity name filter.
- SECURITY_IDENTITY_METADATA_LABEL - Identity-level metadata label filter.
- SECURITY_IDENTITY_PRIVILEGE_TYPE - Identity-level privilege-type filter.
- SECURITY_IDENTITY_SERVICE_PRINCIPAL_NAME - Identity-level service principal name filter.
- SECURITY_IDENTITY_TYPE - Identity type filter.
- SECURITY_IDENTITY_ORIGIN - Identity origin filter.
- SECURITY_IDENTITY_TITLE - Identity job title filter.
- SECURITY_IDENTITY_IDP_TYPE - Identity provider filter.
- SECURITY_IDENTITY_UNIQUE_IDENTIFIER - Identity unique identifier filter.
- SECURITY_IDENTITY_DEPARTMENT - Identity department.
- SECURITY_IDENTITY_GROUP_MEMBERSHIP - Identity group membership filter.
- SECURITY_IDENTITY_METADATA - Identity-level metadata filter.
- SECURITY_IDENTITY_NATIVE_CREATION_TIME - Identity first observed filter.
- SECURITY_IDENTITY_DESCENDANT_USERS_COUNT - Deprecated. Use SECURITY_IDENTITY_DIRECT_DESCENDANT_COUNT instead.
- SECURITY_IDENTITY_SECRET_CREATION_TIME - Identity secret creation time filter.
- SECURITY_IDENTITY_SYNCED_ONPREM_PRIVILEGED_ACCOUNT - Identity is synced to an on-prem privileged account filter.
- SECURITY_IDENTITY_SECRET_EXPIRY_TIME - Identity secret expiry time filter.
- SECURITY_IDENTITY_NUMBER_OF_SECRETS - Identity number of secrets filter.
- SECURITY_IDENTITY_MFA_STRENGTH - Identity MFA strength filter for users.
- SECURITY_IDENTITY_DIRECT_DESCENDANT_COUNT - Identity direct descendant count filter.
- SECURITY_IDENTITY_PWD_AGE - Identity password age filter.
- SECURITY_IDENTITY_STATUS - Identity status filter.
- SECURITY_IDENTITY_CAP_METADATA - Conditional access policy metadata filter.
- SECURITY_IDENTITY_IDP_METADATA_LABEL - Identity provider metadata label filter.
- SECURITY_IDENTITY_METADATA_LIST_LENGTH - Identity metadata list length comparison filter (JSON_LENGTH with relational operator).
- SECURITY_IDENTITY_METADATA_BITMASK - Identity metadata bitmask check filter (bit SET/NOT_SET).
- SECURITY_IDENTITY_METADATA_VALUES - Identity metadata values filter (CONTAINS / DOES_NOT_CONTAIN).
- SECURITY_IDENTITY_DOMAIN - Identity domain scope filter.
- SECURITY_IDENTITY_PASSWORD_NOT_REQUIRED - Identity password-not-required boolean filter.
- SECURITY_IDENTITY_PASSWORD_REVERSIBLE_ENCRYPTION - Identity password stored in reversible encryption boolean filter.
- SECURITY_IDENTITY_PRE_AUTH_NOT_ENABLED - Identity pre-authentication not enabled boolean filter.
- SECURITY_IDENTITY_DES_ENCRYPTION_ENABLED - Identity DES encryption enabled boolean filter.
- SECURITY_IDENTITY_AES_ENCRYPTION_SUPPORTED - Identity AES encryption supported boolean filter.
- SECURITY_IDENTITY_RC4_ENCRYPTION_SUPPORTED - Identity RC4 encryption supported boolean filter.
- SECURITY_IDENTITY_UNCONSTRAINED_DELEGATION - Identity unconstrained delegation enabled boolean filter.
- SECURITY_IDENTITY_RESOURCE_BASED_CONSTRAINED_DELEGATION - Identity resource-based constrained delegation enabled boolean filter.
- SECURITY_IDENTITY_IS_DOMAIN_CONTROLLER - Identity is domain controller boolean filter.
- SECURITY_IDENTITY_SENSITIVE_CANNOT_DELEGATE - Identity is sensitive and cannot delegate boolean filter.
- SECURITY_IDENTITY_PASSWORD_NEVER_EXPIRES - Identity password-never-expires boolean filter.
- SECURITY_IDENTITY_HAS_ROLES - Identity has-roles filter (descendant of a role).
- SECURITY_IDENTITY_HAS_API_PERMISSIONS - Identity has-API-permissions filter (NHI permissions).
- SECURITY_IDENTITY_INSIGHT - Identity insight category filter (Is Privileged, At Risk, Highly Sensitive).
- SECURITY_IDENTITY_LAST_SIGN_IN_TIME - Identity last successful sign-in time filter.
- SECURITY_IDENTITY_APP_REG_NO_ACTIVE_USER_OWNER - Entra ID App Registration linked to this service principal has no active
user owner.
- SECURITY_GPO_NO_LM_HASH - Filter for GPOs that configure the "Do not store LAN Manager hash value"
security option. Selects GPOs where the NoLMHash setting is configured
to store LM hashes (NoLMHash = 0).
- SECURITY_GPO_LDAP_SIGNING - GPO "LDAP signing not required" filter. Selects GPOs that configure the
LDAPServerIntegrity security option and flags those whose decrypted value
is not 2 (Require signing). Values: 0 = None (insecure), 1 = Negotiate
signing (accepts unsigned, insecure), 2 = Require signing (secure).
- SECURITY_GPO_LLMNR_ENABLED - GPO "LLMNR explicitly enabled" filter. Selects GPOs that configure the
EnableMulticast registry value under DNSClient to 1, explicitly re-enabling
LLMNR and creating a credential interception risk.
- SECURITY_GPO_RISKY_MACHINE_SCRIPT - GPO "risky machine script path" filter. Selects GPOs that configure a
Startup or Shutdown machine script whose Command path falls outside the
GPO's own SYSVOL directory (gPCFileSysPath), indicating an externally-
sourced script that may be used for persistence or privilege escalation.
- SECURITY_GPO_SE_DEBUG_PRIVILEGE - Filter for GPOs that grant the "Debug programs" (SeDebugPrivilege) user right to a
non-default principal. Flags GPOs where the privilege membership includes
an unexpected account.
- SECURITY_GPO_SE_BACKUP_PRIVILEGE - Filter for GPOs that grant the "Back up files and directories" (SeBackupPrivilege) user
right to a non-default principal.
- SECURITY_GPO_SE_RESTORE_PRIVILEGE - Filter for GPOs that grant the "Restore files and directories" (SeRestorePrivilege) user
right to a non-default principal.
- SECURITY_GPO_SE_TAKE_OWNERSHIP_PRIVILEGE - Filter for GPOs that grant the "Take ownership of files or other objects"
(SeTakeOwnershipPrivilege) user right to a non-default principal.
- SECURITY_GPO_SE_LOAD_DRIVER_PRIVILEGE - Filter for GPOs that grant the "Load and unload device drivers" (SeLoadDriverPrivilege)
user right to a non-default principal.
- SECURITY_GPO_SE_IMPERSONATE_PRIVILEGE - Filter for GPOs that grant the "Impersonate a client after authentication"
(SeImpersonatePrivilege) user right to a non-default principal.
- SECURITY_GPO_SE_ASSIGN_PRIMARY_TOKEN_PRIVILEGE - Filter for GPOs that grant the "Replace a process level token"
(SeAssignPrimaryTokenPrivilege) user right to a non-default principal.
- SECURITY_GPO_SE_TRUSTED_CRED_MAN_ACCESS_PRIVILEGE - Filter for GPOs that grant the "Access Credential Manager as a trusted caller"
(SeTrustedCredManAccessPrivilege) user right to a non-default principal.
- SECURITY_GPO_SE_ENABLE_DELEGATION_PRIVILEGE - Filter for GPOs that grant the "Enable computer and user accounts to be trusted for
delegation" (SeEnableDelegationPrivilege) user right to a non-default
principal.
- SECURITY_GPO_SE_REMOTE_INTERACTIVE_LOGON_RIGHT - Filter for GPOs that grant the "Allow log on through Remote Desktop Services"
(SeRemoteInteractiveLogonRight) user right to a non-default principal.
- SECURITY_GPO_SE_TCB_PRIVILEGE - Filter for GPOs that grant the "Act as part of the operating system" (SeTcbPrivilege) user
right to a non-default principal.
- SECURITY_IDP_METADATA_LABEL - Identity Provider domain level metadata label filter.
- SECURITY_IDP_HAS_GROUP_WITH_LABEL - Identity Provider domain has a group-with-label filter.
- SECURITY_IDP_HAS_USER_WITH_LABEL - Identity Provider domain has a user-with-label filter.
- SECURITY_IDP_PRIVILEGED_ACCOUNT_COUNT - Identity Provider priviliged account count filter.
- SECURITY_IDP_PRIVILEGED_USER_COUNT - Identity Provider priviliged user count filter.
- SECURITY_IDP_TYPE - Identity Provider type filter.
- SECURITY_IDP_CAP_METADATA - Identity provider conditional access policy filter.
- SECURITY_IDP_CRITICAL_APP_COVERAGE - Identity provider critical application coverage by conditional access policy filter.
- SECURITY_IDP_METADATA_VALUE_LENGTH - Domain-level metadata value length filter for the identity provider.
- SECURITY_IDP_METADATA_NUMERIC_COMPARISON - IDP metadata numeric comparison filter (relational operator on numeric value).
- SECURITY_IDP_DOMAIN - IDP domain scope filter.
- SECURITY_IDP_WEAK_PASSWORD_POLICY - IDP weak default password policy boolean filter.
- SECURITY_IDP_WEAK_LOCKOUT_POLICY - IDP weak default account lockout policy boolean filter.
- SECURITY_IDP_ANONYMOUS_ACCESS_ENABLED - IDP anonymous access enabled boolean filter.
- SECURITY_IDP_SECURITY_DEFAULTS_ENABLED - IDP Entra ID security defaults enabled boolean filter.
- SECURITY_IDP_PIM_MFA_FOR_PRIVILEGED_ROLES - IDP PIM MFA required for privileged role activation boolean filter.
- SECURITY_IDP_PIM_APPROVAL_FOR_SENSITIVE_ROLES - IDP PIM approval required for sensitive role activation boolean filter.
- SECURITY_IDP_INHERITANCE_ENABLED - IDP inheritance enabled boolean filter.
- SECURITY_IDENTITY_EVENT_TYPE - Identity event type filter.
- SECURITY_IDENTITY_EVENT_ACTOR - Identity event actor filter.
- SECURITY_IDENTITY_EVENT_ACTION_TYPE - Identity event action type.
- SECURITY_IDENTITY_EVENT_TARGET_ENTITY - Identity event target entity.
- SECURITY_IDENTITY_EVENT_TARGET_ENTITY_TYPE - Identity event target entity type.
- SECURITY_IDENTITY_EVENT_SOURCE_ENTITY_ID - Identity event source entity ID.
- SECURITY_IDENTITY_EVENT_TIMESTAMP - Identity event timestamp.
- SECURITY_IDENTITY_EVENT_DC_NAME - Identity event domain controller name.
- SECURITY_IDENTITY_EVENT_CHANGED_ATTRIBUTE - Identity event changed attribute.
- SECURITY_IDENTITY_EVENT_CHANGED_ATT_OLD_VAL - Identity event changed attribute old value.
- SECURITY_IDENTITY_EVENT_CHANGED_ATT_NEW_VAL - Identity event changed attribute new value.
- SECURITY_IDENTITY_EVENT_TITLE - Identity event title attribute.
- SECURITY_IDENTITY_EVENT_GROUP_IS_PRIVILEGED - Identity event group is privileged filter.
- SECURITY_IDENTITY_EVENT_GPO_CHANGE_LABEL - Filters identity events by their Group Policy Object (GPO) change label.
Applies to Active Directory events only.
- SECURITY_IDENTITY_ACCOUNT_EXPIRY_TIME - Identity account expiry time filter.
- SECURITY_SIGNIN_ANOMALY_PER_CAP_SPIKE - Sign-in failure spike attributed to a single Conditional Access Policy.
- SECURITY_IDENTITY_EVENT_POLICY_INSIGHTS - Filters identity events by the policy insight surfaced by a Group Policy
Object (GPO) change. Applies to Active Directory events only.
