# New-RscQuerySyslog
## Subcommands
### configuration
- The configuration subcommand takes no arguments.
- Returns GetSyslogConfigurationReply.
### exportrules
Get the configured syslog export rules

Supported in v5.1+
Return the list of all configured syslog export rules.

- There is a single argument of type GetSyslogExportRulesInput.
- Returns SyslogExportRuleSummaryListResponse.
