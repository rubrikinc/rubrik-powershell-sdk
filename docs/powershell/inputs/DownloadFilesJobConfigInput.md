### DownloadFilesJobConfigInput
Supported in v5.0+

- zipPassword: System.String
  - Supported in v9.0+
      Password to protect generated zip with.
- legalHoldDownloadConfig: LegalHoldDownloadConfigInput
  - Supported in v5.2+
      v5.2-v7.0: An optional argument containing a Boolean parameter to depict if the download is being triggered for Legal Hold use case.
      v8.0+: Optional Boolean argument indicating if the download is being triggered due to a Legal Hold.
- paths: list of System.Strings
  - Required. Supported in v5.0+
      Array with the full paths of files and folders to download.
