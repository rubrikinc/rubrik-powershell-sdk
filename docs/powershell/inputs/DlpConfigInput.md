### DlpConfigInput
Holds the configuration for the Data Loss Prevention integration.

- genericNas: DlpConfigGenericNasInput
  - The generic NAS target configuration.
- vmwareVm: DlpConfigVmwareVmInput
  - The VMware virtual machine target configuration.
- policies: list of System.Strings
  - Policies to which the configuration applies.
- targetType: DlpConfigTargetType
  - The target to use when exporting files for fingerprinting.
