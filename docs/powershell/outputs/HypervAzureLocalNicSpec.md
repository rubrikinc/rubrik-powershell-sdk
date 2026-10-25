### HypervAzureLocalNicSpec
Network configuration for an Azure Local NIC at recovery time.

- nicInstanceId: System.String
  - WMI instance ID of the source NIC, used to correlate NIC selections across
recovery-spec revisions.
- sourceNicIndex: System.Int32
  - Zero-based index of the source NIC on the original virtual machine, in
source NIC order.
- logicalNetworkId: System.String
  - ARM ID of the target Azure Local logical network
(Microsoft.AzureStackHCI/logicalNetworks).
- logicalNetworkName: System.String
  - Name of the target logical network, resolved from logical_network_id.
Recovery reports render the recorded name, so a network renamed or deleted
after the recovery does not turn a historical report into a bare ARM ID.
- ipConfig: NicIpConfig
  - IP configuration for this NIC. Only DHCP is supported by the Azure Local
recovery flow. See SPARK-914317.
