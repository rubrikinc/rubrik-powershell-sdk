### ActiveDirectoryDownloadFilesJobConfigInput
Supported in v9.5+

- zipPassword: System.String
  - Supported in v9.5+
Password to protect the generated zip file.
- paths: list of System.Strings
  - Required. Supported in v9.5+
Array containing the full source path of each file and folder that is part of the download job. The array must contain at least one path. When the source is a Windows domain controller, the paths must all be on the same disk.
- legalHoldDownloadConfig: LegalHoldDownloadConfigInput
  - Supported in v9.5+
Optional Boolean argument indicating if the download is being triggered due to a Legal Hold.
