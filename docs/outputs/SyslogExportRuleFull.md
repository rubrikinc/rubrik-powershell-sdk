### SyslogExportRuleFull
Supported in v5.1+

- certificateId: System.String
  - Supported in v5.2+
  The ID corresponding to the imported certificate used by the syslog server.
- enableTls: System.Boolean
  - Required. Supported in v5.1+
  Specifies whether TLS should be used to communicate with the syslog server.
- facility: SyslogFacility
  - Supported in v5.1+
- hostname: System.String
  - Required. Supported in v5.1+
- port: System.Int32
  - Required. Supported in v5.1+
- protocol: TransportLayerProtocol
  - Supported in v5.1+
- severity: SyslogSeverity
  - Supported in v5.1+
