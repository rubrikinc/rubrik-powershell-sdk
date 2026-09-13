### OlvmBackupScript
Pre/post backup script configuration for an OLVM virtual machine.

- scriptPath: System.String
  - Command to run in the virtual machine guest OS.
- timeoutMs: System.Int64
  - Time, in milliseconds, after which the script is terminated.
- failureHandling: OlvmBackupScriptFailureHandling
  - Action to take if the script returns an error or times out.
