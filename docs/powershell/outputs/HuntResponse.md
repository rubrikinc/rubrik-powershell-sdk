### HuntResponse
Response of the individual threat hunts as part of the bulk request.

- huntName: System.String
  - Name of the triggered threat hunt.
- config: HuntConfig
  - Hunt configuration containing the Cluster UUIDs and Object-FIDs.
- status: HuntTriggerStatus
  - Status of the triggered threat hunt.
- huntId: System.String
  - ID of the triggered threat hunt.
