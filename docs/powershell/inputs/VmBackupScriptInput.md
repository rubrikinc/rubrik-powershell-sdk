### VmBackupScriptInput
Configuration for a pre/post backup script that runs on an RBA-installed host as part of a Pure Storage protection group's app-consistent snapshot.

- scriptPath: System.String
  - Required. Supported in v9.6+
The absolute path of the script to invoke on the agent host. Can be a maximum of 1024 characters (enforced by the PATCH validation; the swagger codegen does not enforce a server-side maxLength constraint on this field). Must satisfy the cluster's trusted-path allowlist when the enableBackupScriptChecks toggle is on.
- timeoutMs: System.Int64
  - Required. Supported in v9.6+
The duration, in milliseconds, after which the script is terminated.
- failureHandling: VmBackupScriptFailureHandling
  - Required. Supported in v9.6+
Action to take if the script returns an error or times out. ABORT causes the backup job to fail; CONTINUE logs the error and proceeds with the backup. ABORT is honored only for PRE_BACKUP scripts; POST_SNAP and POST_BACKUP failures always degrade to CONTINUE.
