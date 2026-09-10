### NetworkPreservationMode
Network preservation mode for a recovered virtual machine.

- KEEP_MAC_NO_OS_CONFIG - Keep the original MAC address without modifying the guest OS network configuration.
- KEEP_MAC_OS_CONFIG - Keep MAC address and configure guest OS network.
- NEW_MAC_NO_OS_CONFIG - Assign a new MAC address without modifying the guest OS network configuration.
- NEW_MAC_OS_CONFIG - Assign new MAC address and configure guest OS network.
- REMOVE_ALL - Remove all network devices from the recovered virtual machine.
