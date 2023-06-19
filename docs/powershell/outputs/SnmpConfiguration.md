### SnmpConfiguration
Supported in v5.0+
  v5.0-v5.1: SNMP service configuration object.
  v5.2+: SNMP service configuration object summary.

- communityString: System.String
  - Supported in v5.0+
  v5.0-v5.1: communicatyString is a user specified string for authentication to access SNMP statistics.
  
  v5.2+: communityString is a user specified string for authentication to access SNMP statistics. Provides access to MIBs using SNMP v2c.
- isEnabled: System.Boolean
  - Required. Supported in v5.0+
  Boolean value that specifies whether the SNMP service is enabled. Set the value to true to enable the SNMP service and false to disable the SNMP service.
- snmpAgentPort: System.Int32
  - Required. Supported in v5.0+
  The SNMP agent port on the Rubrik cluster node.
- trapReceiverConfigs: list of SnmpTrapReceiverConfigs
  - Supported in v5.0+
  Array of SNMP trap receivers for the SNMP service.
- users: list of System.Strings
  - Supported in v5.2+
  Array of usernames for the SNMP service. Provides access to MIBs using SNMP v3.
