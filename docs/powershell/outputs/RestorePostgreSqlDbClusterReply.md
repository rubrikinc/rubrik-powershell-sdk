### RestorePostgreSqlDbClusterReply
Response for the PostgreSQL database cluster restore request in the provided host.

- id: System.String
  - Required. Supported in v9.4+
v9.4-v9.5: ID of the new restore instance created for the restore of the PostgreSQL database cluster.
v9.6: ID of the new restore instance created for the restore of the PostgreSQL database cluster. For multi-host requests, this carries the first object's restore instance ID; consumers that need per-object IDs should read perObjectAsyncRequestStatuses.
- asyncRequestStatus: AsyncRequestStatus
  - Required. Supported in v9.4+
v9.4-v9.5: Status of the asynchronous job triggered when you initiate the recovery operation for the PostgreSQL database cluster.
v9.6: Status of the asynchronous job triggered when you initiate the recovery operation for the PostgreSQL database cluster. For multi-host requests, this carries the status of the first object's job; consumers that need per-object status should read perObjectAsyncRequestStatuses.
- perObjectAsyncRequestStatuses: list of KosmosPerObjectAsyncRequestStatuss
  - Per-object job statuses. Always populated when present and contains one entry per restore object (length 1 for single-host restores). New consumers should prefer this over the top-level asyncRequestStatus and id fields.
