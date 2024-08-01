### CannotMigrateReasonEnum
Explains why the RBAC entity cannot be migrated, applicable if the 'canMigrate' field is false.

- CANNOT_MIGRATE_REASON_UNSPECIFIED - Specific migration issue reason is unspecified.
- SSO_GROUP_WRONG_AUTH_DOMAIN - SSO Group's auth domain does not align with the one configured in RSC's global org.
- SSO_GROUP_NO_ROLES - No roles assigned to the SSO Group.
- USER_NOT_LOCAL - This is not a local user.
- USER_NO_ROLES - No roles assigned to the user.
- ROLE_NOT_SUPPORTED - Role is not supported for migration.
- RULE_NOT_SUPPORTED - Rule is not supported for migration.
- ROLE_HAS_NO_RULES - Role includes no migrated rules.
- USER_INVALID_EMAIL - The user has an invalid email address.
- USER_DUPLICATE_EMAIL - The user has an email that duplicates another user's during migration. On RSC, emails of local users must be unique.
- ROLE_MIGRATION_ERROR - Encountered an error while migrating this role.
