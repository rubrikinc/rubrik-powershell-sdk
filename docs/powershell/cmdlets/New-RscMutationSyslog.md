# New-RscMutationSyslog
## Subcommands
### addexportrule
Add a new syslog export rule

Supported in v5.1+
Adds a new rule specifying where to export the specified syslog information.

- There is a single argument of type AddSyslogExportRuleInput.
- Returns AddSyslogExportRuleReply.
### deleteexportrule
Delete the specified syslog export rule

Supported in v5.1+
Delete the syslog export rule specified by the given id.

- There is a single argument of type DeleteSyslogExportRuleInput.
- Returns System.String.
### testexportrule
Test the specified syslog export rule

Supported in v5.1+
Send a test message using the syslog export rule specified by the given id.

- There is a single argument of type TestSyslogExportRuleInput.
- Returns TestSyslogExportRuleReply.
### updateexportrule
Update the specified syslog export rule

Supported in v5.1+
Update the syslog export rule specified by the given id.

- There is a single argument of type UpdateSyslogExportRuleInput.
- Returns UpdateSyslogExportRuleReply.
