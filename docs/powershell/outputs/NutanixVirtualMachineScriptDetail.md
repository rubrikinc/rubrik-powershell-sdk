### NutanixVirtualMachineScriptDetail
Supported in v6.0+

- scriptPath: System.String
  - Required. Supported in v6.0+
  v6.0-v8.0: The command to be run in VM guest OS.
  v8.1+: The command to be run in virtual machine guest OS.
- timeoutMs: System.Int64
  - Required. Supported in v6.0+
  Time (in ms) after which the script will be terminated if it has not completed.
- failureHandling: NutanixVirtualMachineScriptDetailFailureHandling
  - 
