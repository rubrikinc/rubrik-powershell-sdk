### FilesetDownloadFilesJobConfigInput
Supported in v5.0+

- legalHoldDownloadConfig: LegalHoldDownloadConfigInput
  - Supported in v5.2+
      An optional argument containing a Boolean parameter to depict if the download is being triggered for Legal Hold use case.
- sourceDirs: a list of System.Strings
  - Required. Supported in v5.0+
      An array containing the full source path of each file and folder that is part of the download job. The array must contain at least one path.
