### SlaManagedVolumeScriptConfigInput
Supported in v5.3+

- scriptCommand: System.String
  - The full command, with arguments, to run the script.
- timeout: System.Int64
  - Supported in v5.3+
      v5.3-v6.0: An optional timeout for the script in seconds. When this value is 0 or unspecified no timeout is used.
      v7.0+: Optional timeout, in seconds, for the script. When this value is 0 or unspecified, the script does not use a timeout.
