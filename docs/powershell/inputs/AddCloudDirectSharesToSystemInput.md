### AddCloudDirectSharesToSystemInput
Request to add new shares (NFS, NFS4, or SMB) to an existing system.

- clusterUuid: System.String
  - NCD cluster UUID.
- systemId: System.String
  - UUID of the system to add shares to.
- shares: list of System.Strings
  - List of share paths to existing generic NAS systems.
