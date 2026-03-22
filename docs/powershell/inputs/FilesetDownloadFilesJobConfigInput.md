### FilesetDownloadFilesJobConfigInput
Supported in v5.0+

- sourceDirs: list of System.Strings
  - Required. Supported in v5.0+
An array containing the full source path of each file and folder that is part of the download job. The array must contain at least one path.
- legalHoldDownloadConfig: LegalHoldDownloadConfigInput
  - Supported in v5.2+
An optional argument containing a Boolean parameter to depict if the download is being triggered for Legal Hold use case.
- shouldUseStrongEncryption: System.Boolean
  - Supported in v9.6
When true, uses AES-256 encryption for the generated zip file. When absent, falls back to the per-workload or global configuration.
- zipPassword: System.String
  - Supported in v9.0+
Password to protect generated zip with.
