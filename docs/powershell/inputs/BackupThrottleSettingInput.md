### BackupThrottleSettingInput
Backup throttle settings.

- clusterUuid: System.String
  - UUID used to identify the cluster the request goes to.
- enableThrottling: System.Boolean
  - Backup throttle is enabled when it's true.
- vmwareThrottlingSettings: VmwareThrottlingSettingsInput
  - Backup throttle settings related to VMware.
