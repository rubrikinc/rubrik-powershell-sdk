### UpdateNutanixPrismCentralReply
Response for the update Nutanix Prism Central operation.

- connectionStatus: RefreshableObjectConnectionStatus
  - Supported in v9.0+
  Connection status of the Nutanix Prism Central.
- hostname: System.String
  - Required. Supported in v9.0+
  Hostname for the Nutanix Prism Central that we use for all the cluster connections.
- slaAssignable: SlaAssignable
  - Details of the SLA Domain assigned to Nutanix Prism Central.
- username: System.String
  - Required. Supported in v9.0+
  Username for the Nutanix Prism Central that we use for all the cluster connections.
- pendingSlaDomain: ManagedObjectPendingSlaInfo
  - Supported in v9.0+
  Describes any pending SLA Domain assignment on this object.
- refreshJobAsyncReqStatus: AsyncRequestStatus
  - Supported in v9.1+
  Displays the status of the initiated refresh job.
