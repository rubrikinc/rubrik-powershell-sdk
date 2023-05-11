### VirtualMachineScriptDetail
Supported in v5.0+

- failureHandling: VirtualMachineScriptDetailFailureHandling
  - 
- scriptPath: System.String
  - Required. Supported in v5.0+
  The command to be run in VM guest OS.
- timeoutMs: System.Int64
  - Required. Supported in v5.0+
  Time (in ms) after which the script will be terminated if it has not completed.
