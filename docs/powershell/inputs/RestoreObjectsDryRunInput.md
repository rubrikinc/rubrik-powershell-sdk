### RestoreObjectsDryRunInput
Input for a dry run of granular restore in Active Directory.

- exportId: System.String
  - Specifies the export to use if the snapshot was previously exposed using Live Mount.
- shouldReportOnlyChangedValues: System.Boolean
  - Specifies whether to report only the changed values for an attribute in the object diff.
- shouldReportOnlyChangedAttrs: System.Boolean
  - Specifies whether to report only attributes whose values have changed.
- config: ActiveDirectoryObjectRecoveryConfigInput
  - Required. Configuration for the dry run of object recovery.
- id: System.String
  - Required. Snapshot ID to be used for dummy recovery of selected objects.
- instanceId: System.String
  - A randomly generated instance ID for the RSC user. This ID serves as a handle identifier and associates with the opening instance of the NTDS database. All requests from an RSC user use the same instance ID.
