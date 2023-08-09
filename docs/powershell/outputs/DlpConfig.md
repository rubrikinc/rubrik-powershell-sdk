### DlpConfig
Holds the configuration for the Data Loss Prevention integration.

- policies: list of System.Strings
  - Policies to which the configuration applies.
- targetType: DlpConfigTargetType
  - The target to use when exporting files for fingerprinting.
- genericNas: DlpConfigGenericNas
  - The generic NAS target configuration.
- vmwareVm: DlpConfigVmwareVm
  - The VMware virtual machine target configuration.
