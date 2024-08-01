### AppItemRestoreConfig
Represents the configuration for the items to be restored.

- orgId: System.String
  - ID of this workloads's organization.
- workloadId: System.String
  - Rubrik ID of the workload whose data items needs to be restored.
- appItemTypeToken: System.String
  - Token specifying the type of the item. The token should exactly match with the token retrieved from query field response.
- itemsToRestore: list of RestoreItemInfos
  - List of items of item type that needs to be restored
- excludePaths: list of System.Strings
  - List of paths that is excluded when restoring items that are cascaded from the selected items. A path is a list of appItemTypeToken as returned in the saasAppCascadingImpact query.
- destinationOrgId: System.String
  - The ID of the destination organization for the restore, if different from the source organization.
- hierarchyDepth: System.Int32
  - The maximum depth of the cascaded hierarchy. A larger value may result in a longer response time.
- saasAppSpecificConfig: SaasAppSpecificRestoreConfig
  - SaaS app specific configuration for the restore.
