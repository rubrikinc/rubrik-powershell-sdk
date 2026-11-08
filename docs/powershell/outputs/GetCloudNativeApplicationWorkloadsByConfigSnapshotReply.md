### GetCloudNativeApplicationWorkloadsByConfigSnapshotReply
Reply for
GetCloudNativeApplicationWorkloadsByConfigSnapshot.

- workloadGroups: list of CloudNativeApplicationWorkloadss
  - Workload groups, one per cloud native object type.
- presentConfigTypes: list of ConfigResourceTypes
  - Config resource types present in this snapshot.
- configResources: list of ConfigResourceInfos
  - Config resources with name, type, and native URI.
