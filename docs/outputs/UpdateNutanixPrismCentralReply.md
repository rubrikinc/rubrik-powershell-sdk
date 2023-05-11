### UpdateNutanixPrismCentralReply
Response for the update Nutanix Prism Central operation.

- connectionStatus: RefreshableObjectConnectionStatus
  - Connection status of the Nutanix Prism Central.
- hostname: System.String
  - Required. Hostname for the Nutanix Prism Central that we use for all the cluster connections.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Describes any pending SLA Domain assignment on this object.
- slaAssignable: SlaAssignable
  - Details of the SLA Domain assigned to Nutanix Prism Central.
- username: System.String
  - Required. Username for the Nutanix Prism Central that we use for all the cluster connections.
