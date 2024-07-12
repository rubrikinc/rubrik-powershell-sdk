### EndManagedVolumeSnapshotInput
Input for invoking the API endpoint to end a Managed Volume snapshot.

- endSnapshotDelayInSeconds: System.Int32
  - Specifies an interval in seconds. The snapshot will not end before the specified interval elapses. When this value is defined, the end snapshot operation happens asynchronously after the API call returns.
- ownerId: System.String
  - A string representing the owner of a snapshot. The end snapshot request fails when the owner of the in-flight snapshot is different from the one specified in the request.
- id: System.String
  - Required. ID of Managed Volume.
- params: EndSnapshotManagedVolumeRequestInput
  - Snapshot parameters. By default, all Managed Volume snapshots follow the SLA Domain assigned to the Managed Volume. To assign a different SLA Domain to this snapshot, specify the ID of the overriding SLA Domain here. Assigning an overriding SLA Domain turns this snapshot into an on-demand snapshot.
