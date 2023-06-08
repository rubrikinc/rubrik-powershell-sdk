### SnmpTrapReceiverConfigInput
Supported in v5.0+
  SNMP trap receiver configuration object.

- user: System.String
  - Supported in v5.2+
      Specifies the user for the SNMP trap receiver host. A valid user is required in order to use SNMP v3. The specified user must be a valid user in the users field of the SNMP configuration. When no user is specified, SNMP v2c traps are sent to the SNMP trap receiver host. If a trap receiver user is specified, the trap receiver security level must also be specified.
- securityLevel: SnmpSecurityLevel
  - Supported in v5.2+
      Specifies the security level for the SNMP trap receiver host. If a trap receiver user is specified, a securityLevel must be specified.
- address: System.String
  - Required. Supported in v5.0+
      IPv4 address or FQDN of the SNMP trap receiver host.
- port: System.Int32
  - Required. Supported in v5.0+
      v5.0-v5.1: The snmp trap port on the SNMP trap receiver host.
      v5.2+: The SNMP trap port on the SNMP trap receiver host.
