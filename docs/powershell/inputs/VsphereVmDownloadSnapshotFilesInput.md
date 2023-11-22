### VsphereVmDownloadSnapshotFilesInput
Input for downloading vSphere snapshot files.

- snapshotFid: System.String
  - Required. ID of the virtual machine snapshot.
- paths: list of System.Strings
  - Required. Paths of the files.
- deltaTypeFilter: list of DeltaTypes
  - The delta type options which the files will be filtered on.
- nextSnapshotFid: System.String
  - The fid of the next snapshot to perform the delta on.
- isLegalHoldDownload: System.Boolean
  - Supported in v5.2+.
        v5.2+: Specifies whether the download action is in response to a Legal Hold. This download generates a SHA1 checksum of downloaded data that is used for integrity verification by external bodies.
- userNote: System.String
  - User note to associate with audits.
- zipPassword: System.String
  - Supported in 9.0.1+.
        v9.0.1+: Password for zip archive created.
