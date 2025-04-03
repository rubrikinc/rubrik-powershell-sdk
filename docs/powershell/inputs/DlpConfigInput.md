### DlpConfigInput
Holds the configuration for the Data Loss Prevention integration.

- policies: list of System.Strings
  - Policies to which the configuration applies.
- genericNas: DlpConfigGenericNasInput
  - The generic NAS target configuration.
- vmwareVm: DlpConfigVmwareVmInput
  - The VMware virtual machine target configuration.
- serviceAccountId: System.String
  - The service account ID. Optional, if empty the Data Loss Prevention job
runs with administrator privileges.
- serviceAccountName: System.String
  - The service account name. Optional, if empty the integration name is used
to create a service account name.
- status: DlpStatusInput
  - The status of the integration.
- targetType: DlpConfigTargetType
  - The target to use when exporting files for fingerprinting.
