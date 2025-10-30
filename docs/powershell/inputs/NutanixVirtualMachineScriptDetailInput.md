### NutanixVirtualMachineScriptDetailInput
Supported in v6.0+

- failureHandling: NutanixVirtualMachineScriptDetailFailureHandling
  - Required. Supported in v6.0+
      Action to take if the script returns an error or times out.
- scriptPath: System.String
  - Required. The command to be run in virtual machine guest OS.
- timeoutMs: System.Int64
  - Required. Supported in v6.0+
      Time (in ms) after which the script will be terminated if it has not completed.
