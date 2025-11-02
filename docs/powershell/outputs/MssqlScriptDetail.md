### MssqlScriptDetail
Supported in v5.0+

- scriptErrorAction: ScriptErrorAction
  - Required. Supported in v5.0+
Action to take if the script returns an error or times out.
- scriptPath: System.String
  - Required. Supported in v5.0+
The script to be run.
- timeoutMs: System.Int64
  - Required. Supported in v5.0+
Time (in ms) after which the script will be terminated if it has not completed.
