# New-RscQueryCloudNative
## Subcommands
### checkarchivedsnapshotslocked
Archived snapshot locking related details for a workload. If no snapshots IDs are passed, all the expired source snapshots and the source snapshots that have a unexpired archival copy will be checked.

- There are 2 arguments.
    - workloadId - System.String: Workload ID.
    - snapshotIds - list of System.Strings: List of snapshot IDs.
- Returns CheckArchivedSnapshotsLockedReply.
### checklabelrulenameuniqueness
Check if label rule name is unique or not

- There are 2 arguments.
    - ruleName - System.String: Name for the rule
    - objectType - CloudNativeLabelObjectType: Type of managed object on which label rule will be applied.
- Returns IsCloudNativeTagRuleNameUniqueReply.
### checkrequiredpermissionsforfeature
Queries whether Polaris has the required permissions for a particular feature.

- There are 2 arguments.
    - cloudNativeAccountId - System.String: Cloud native account ID
    - featurePermissionCheck - CloudNativeFeatureForPermissionsCheck: Feature for which required permissions have to be checked.
- Returns System.Boolean.
### checktagrulenameuniqueness
Check if tag rule name is unique or not

- There are 2 arguments.
    - ruleName - System.String: Name for the rule
    - objectType - CloudNativeTagObjectType: Type of managed object on which tag rule will be applied.
- Returns IsCloudNativeTagRuleNameUniqueReply.
### customertags
Retrieves the list of all customer-specified tags and the corresponding value indicating whether resource tags should be overridden by customer-specified tags for a specific cloud type.

- There are 2 arguments.
    - cloudVendor - CloudVendor: Vendor of the cloud account.
    - cloudAccountId - System.String: The Rubrik ID of the cloud account.
- Returns CloudNativeCustomerTagsReply.
### filerecoveryeligiblesnapshots
List of snapshots for which file recovery is feasible.

- There is a single argument of type System.String.
- Returns list of System.Strings.
### isfilerecoveryfeasible
List of snapshots with their file recovery feasibility status

- There is a single argument of type list of System.Strings.
- Returns ValidateCloudNativeFileRecoveryFeasibilityReply.
### labelkeys
List of cloud native label keys matched by substring.

- There are 3 arguments.
    - keySubStr - System.String: Key substring to filter by.
    - limit - System.Int32: Number of results to return.
    - objectType - CloudNativeLabelObjectType: Type of managed object on which label rule will be applied.
- Returns list of System.Strings.
### labelrules
Cloud native label rules.

- There are 4 arguments.
    - objectType - CloudNativeLabelObjectType: Type of managed object on which label rule will be applied.
    - filters - list of CloudNativeFilters: Fields and values according to which rules will be filtered.
    - sortBy - CloudNativeTagRuleSortByFields
    - sortOrder - SortOrder: Sort order of result.
- Returns GetCloudNativeLabelRulesReply.
### labelvalues
List of cloud native label values matched by substring.

- There are 4 arguments.
    - valueSubStr - System.String: Value substring to filter by.
    - key - System.String: Key value used only when searching for values.
    - limit - System.Int32: Number of results to return.
    - objectType - CloudNativeLabelObjectType: Type of managed object on which label rule will be applied.
- Returns list of System.Strings.
### rbainstallers
Fetches the URLs for the windows, linux and debian RBA installers.

- The rbainstallers subcommand takes no arguments.
- Returns RbaInstallerUrls.
### snapshotdetailsforrecovery
Details of snapshot types available for recovery.

- There is a single argument of type System.String.
- Returns CloudNativeSnapshotDetailsForRecoveryReply.
### snapshots
List of all files and directories in a given path with the given prefix in name.

- There are 5 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - path - System.String: The path under which you want your search to run.
    - snapshotFid - System.String: ID of the snapshot to be searched or browsed.
    - searchPrefix - System.String: Name prefix to search for files within a snapshot.
- Returns SnapshotFileConnection.
### snapshottypedetails
Details of the available snapshot types.

- There is a single argument of type System.String.
- Returns CloudNativeSnapshotTypeDetailsReply.
### sqlserversetupscript
Returns the script to setup backup for a SQL Server database.

- The sqlserversetupscript subcommand takes no arguments.
- Returns CloudNativeSqlServerSetupScript.
### tagkeys
List of cloud native tag keys matched by substring.

- There are 3 arguments.
    - keySubStr - System.String: Key substring to filter by.
    - limit - System.Int32: Number of results to return.
    - objectType - CloudNativeTagObjectType: Type of managed object on which tag rule will be applied.
- Returns list of System.Strings.
### tagrules
Cloud native tag rules.

- There are 4 arguments.
    - objectType - CloudNativeTagObjectType: Type of managed object on which tag rule will be applied.
    - filters - list of CloudNativeFilters: Fields and values according to which rules will be filtered.
    - sortBy - CloudNativeTagRuleSortByFields
    - sortOrder - SortOrder: Sort order of result.
- Returns GetCloudNativeTagRulesReply.
### tagvalues
List of cloud native tag values matched by substring.

- There are 4 arguments.
    - valueSubStr - System.String: Value substring to filter by.
    - key - System.String: Key value used only when searching for values.
    - limit - System.Int32: Number of results to return.
    - objectType - CloudNativeTagObjectType: Type of managed object on which tag rule will be applied.
- Returns list of System.Strings.
### workloadversionedfiles
List all files and directories in a given snappable with the given prefix in name.

- There are 4 arguments.
    - first - System.Int32: Returns the first n elements from the list.
    - after - System.String: Returns the elements in the list that come after the specified cursor.
    - snappableId - System.String: Snappable ID.
    - searchQuery - System.String: Specify either the name or path prefix argument to search for files within a workload.
- Returns CloudNativeVersionedFileConnection.
