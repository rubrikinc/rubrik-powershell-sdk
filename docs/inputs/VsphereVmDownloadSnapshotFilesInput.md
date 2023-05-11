### VsphereVmDownloadSnapshotFilesInput
Input for downloading vSphere snapshot files.

- deltaTypeFilter: a list of DeltaTypes
  - The delta type options which the files will be filtered on.
- isLegalHoldDownload: System.Boolean
  - Supported in v5.2+.
        v5.2+: Specifies whether the download action is in response to a Legal Hold. This download generates a SHA1 checksum of downloaded data that is used for integrity verification by external bodies.
- nextSnapshotFid: System.String
  - The fid of the next snapshot to perform the delta on.
- paths: a list of System.Strings
  - Required. Paths of the files.
- snapshotFid: System.String
  - Required. ID of the virtual machine snapshot.
- userNote: System.String
  - User note to associate with audits.
