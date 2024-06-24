### SnmpConfigurationPatchInput
Supported in v5.2+
  SNMP service configuration object.

- communityString: System.String
  - Supported in v5.2+
      communityString is a user specified string for authentication to access SNMP statistics. Provides access to MIBs using SNMP v2c.
- isEnabled: System.Boolean
  - Required. Supported in v5.2+
      Boolean value that specifies whether the SNMP service is enabled. Set the value to true to enable the SNMP service and false to disable the SNMP service.
- snmpAgentPort: System.Int32
  - Required. Supported in v5.2+
      The SNMP agent port on the Rubrik cluster node.
- trapReceiverConfigs: list of SnmpTrapReceiverConfigInputs
  - Supported in v5.2+
      Array of SNMP trap receivers for the SNMP service.
- users: list of SnmpUserConfigInputs
  - Supported in v5.2+
      Array of users for the SNMP service. Provides access to MIBs using SNMP v3.
