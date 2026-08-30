### DownloadSalesforcePermissionsInput
Request message for the DownloadSalesforcePermissions API.

- orgId: System.String
  - Rubrik ID of the Salesforce organization.
- permissionIds: list of System.Strings
  - List of permission IDs to be downloaded.
- permissionReportType: PermissionReportType
  - Type of permission report to process.
- path: list of System.Strings
  - Object names whose field permissions are included.
Matches all field permissions under each named object.
Additive with permissionIds and permissionTypes.
- permissionTypes: list of PermissionTypes
  - Permission type categories to include. Resolves to all
permissions of those types. Additive with permissionIds
and path. If FIELD is included, path is redundant
(FIELD is a superset).
