### SlaManagedVolumeScriptSummary
Supported in v5.3+

- runAsUser: System.String
  - Required. Supported in v5.3+
Name of the user running the script on the host.
- scriptCommand: System.String
  - Required. The full command, with arguments, to run the script.
- timeout: System.Int64
  - Supported in v5.3+
(Optional) Timeout period, in seconds, for the script. Specifying 0, or not including a value, indicates there is no timeout period.
