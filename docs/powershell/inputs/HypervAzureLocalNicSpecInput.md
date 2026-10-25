### HypervAzureLocalNicSpecInput
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
- ipConfig: NicIpConfigInput
  - IP configuration for this NIC. Only DHCP is supported by the Azure Local
recovery flow. See SPARK-914317.
