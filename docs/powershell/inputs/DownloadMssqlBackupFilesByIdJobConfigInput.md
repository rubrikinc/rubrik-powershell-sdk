### DownloadMssqlBackupFilesByIdJobConfigInput
Supported in v5.2+

- items: list of System.Strings
  - Required. Supported in v5.2+
A list of snapshots and logs to download.
- legalHoldDownloadConfig: LegalHoldDownloadConfigInput
  - Supported in v5.2+
v5.2: Optional. A Boolean that specifies whether the download is in response to a Legal Hold.
v5.3+: Optional. A Boolean that specifies if the download is in response to a Legal Hold.
