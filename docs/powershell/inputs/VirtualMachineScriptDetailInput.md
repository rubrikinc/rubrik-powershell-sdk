### VirtualMachineScriptDetailInput
Supported in v5.0+

- failureHandling: VirtualMachineScriptDetailFailureHandling
  - Required. Supported in v5.0+
Action to take if the script returns an error or times out.
- scriptPath: System.String
  - Required. Supported in v5.0+
The command to be run in VM guest OS.
- timeoutMs: System.Int64
  - Required. Supported in v5.0+
Time (in ms) after which the script will be terminated if it has not completed.
