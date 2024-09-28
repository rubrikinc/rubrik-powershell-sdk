### TprRulesMap
Mapping of TPR rules to their categories.

- systemConfigurationCluster: list of TprRules
  - Cluster-level rules applicable when creating a system configuration
 TPR policy.
- systemConfigurationGlobal: list of TprRules
  - Global rules applicable when creating a system configuration
 TPR policy.
- dataManagementByCluster: list of TprRules
  - Rules applicable when creating a data management TPR policy by cluster.
- dataManagementBySlaDomain: list of TprRules
  - Rules applicable when creating a data management TPR policy by SLA Domain.
- dataManagementByObject: list of TprRules
  - Rules applicable when creating a data management TPR policy by object.
- dataManagementByObjectWorkloads: list of InventorySubHierarchyRootEnums
  - Workloads allowed when creating a data management TPR policy by object.
