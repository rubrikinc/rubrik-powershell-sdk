### UpdateSyslogExportRuleInput
Input for updating a syslog export rule.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- id: System.String
  - Required. The ID of syslog export rule.
- syslogSettingsV51: SyslogExportRuleUpdateInput
  - Syslog export rule for Rubrik CDM version 5.1.
- syslogSettingsV52: SyslogExportRulePartialInput
  - Syslog export rule for Rubrik CDM version 5.2.
- syslogSettingsV53: SyslogExportRulePartialInput
  - Syslog export rule for Rubrik CDM version 5.3.
- syslogSettingsV60: SyslogExportRulePartialInput
  - Syslog export rule for Rubrik CDM version 6.0.
- syslogSettingsV70: SyslogExportRulePartialInput
  - Syslog export rule for Rubrik CDM version 7.0.
- syslogSettingsV80: SyslogExportRulePartialInput
  - Syslog export rule for Rubrik CDM version 8.0.
- syslogSettingsV81: SyslogExportRulePartialInput
  - Syslog export rule for Rubrik CDM version 8.1.
- syslogSettingsV90: SyslogExportRulePartialInput
  - Syslog export rule for Rubrik CDM version 9.0.
- syslogSettingsV91: SyslogExportRulePartialInput
  - Syslog export rule.
- syslogSettingsV92: SyslogExportRulePartialInput
  - Syslog export rule.
- syslogSettingsV93: SyslogExportRulePartialInput
  - Syslog export rule.
