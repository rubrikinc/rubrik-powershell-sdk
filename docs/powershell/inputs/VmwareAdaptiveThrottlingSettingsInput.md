### VmwareAdaptiveThrottlingSettingsInput
Supported in v5.0+

- cpuUtilizationThreshold: System.Int32
  - Supported in v5.0+
      Threshold virtual machine CPU utilization value that determines whether to postpone a scheduled snapshot of a vSphere virtual machine. Specify the threshold value as a percentage.
- datastoreIoLatencyThreshold: System.Int32
  - Supported in v5.0+
      Threshold datastore latency value, measured across all datastores, that determines whether to postpone a scheduled snapshot of a vSphere virtual machine. Specify the threshold value in milliseconds (ms).
- ioLatencyThreshold: System.Int32
  - Supported in v5.0+
      Threshold virtual machine latency value that determines whether to postpone a scheduled snapshot of the vSphere virtual machine. Specify the threshold value in milliseconds (ms).
