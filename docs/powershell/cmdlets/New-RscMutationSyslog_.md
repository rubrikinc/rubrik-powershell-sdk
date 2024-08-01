# New-RscMutationSyslog
## Subcommands
### addconfiguration
- There are 7 arguments.
    - hostName - System.String: Host name for your SMTP configuration.
    - port - System.Int32: Port number for your SMTP configuration.
    - networkProtocolType - NetworkProtocolTypeEnum: Network type to use.
    - useTLS - System.Boolean: Specifies whether to use TLS or not.
    - syslogFacility - SyslogFacilityTypeEnum: Filter syslog by facility.
    - syslogSeverity - SyslogSeverityTypeEnum: Filter syslog by severity.
    - trustedCerts - System.String: Trusted certificate to use for your SMTP configuration.
- Returns System.Boolean.
### addexportrule
Add a new syslog export rule

Supported in v5.1+
Adds a new rule specifying where to export the specified syslog information.

- There is a single argument of type AddSyslogExportRuleInput.
- Returns AddSyslogExportRuleReply.
### deleteconfiguration
- There is a single argument of type list of System.Strings.
- Returns System.Boolean.
### deleteexportrule
Delete the specified syslog export rule

Supported in v5.1+
Delete the syslog export rule specified by the given id.

- There is a single argument of type DeleteSyslogExportRuleInput.
- Returns System.String.
### sendtest
- There is a single argument of type SyslogConfigInputType.
- Returns System.Boolean.
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
