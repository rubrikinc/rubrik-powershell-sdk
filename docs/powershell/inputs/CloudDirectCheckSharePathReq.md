### CloudDirectCheckSharePathReq
CloudDirectCheckSharePathReq represents a request to check if a share path is accessible.

- clusterId: System.String
  - The UUID of the cluster to use for validation.
- protocol: CloudDirectNasProtocolType
  - Protocol of the export to check
- host: System.String
  - The host or server address to check.
- path: System.String
  - The export path to validate.
- user: System.String
  - SMB username for authentication, optional and only used for SMB shares.
- password: System.String
  - SMB password for authentication, optional and only used for SMB shares.
