### DlpConfig
Holds the configuration for the Data Loss Prevention integration.

- targetType: DlpConfigTargetType
  - The target to use when exporting files for fingerprinting.
- genericNas: DlpConfigGenericNas
  - The generic NAS target configuration.
- vmwareVm: DlpConfigVmwareVm
  - The VMware virtual machine target configuration.
- policies: list of System.Strings
  - Policies to which the configuration applies.
- serviceAccountId: System.String
  - The service account ID. Optional, if empty the Data Loss Prevention job
runs with administrator privileges.
- serviceAccountName: System.String
  - The service account name. Optional, if empty the integration name is used
to create a service account name.
- status: DlpStatus
  - The status of the integration.
