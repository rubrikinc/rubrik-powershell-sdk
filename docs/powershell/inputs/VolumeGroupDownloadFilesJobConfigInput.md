### VolumeGroupDownloadFilesJobConfigInput
Supported in v5.0+

- legalHoldDownloadConfig: LegalHoldDownloadConfigInput
  - Supported in v5.2+
      v5.2-v7.0: An optional argument containing a Boolean parameter to depict if the download is being triggered for Legal Hold use case.
      v8.0+: Optional Boolean argument indicating if the download is being triggered due to a Legal Hold.
- paths: list of System.Strings
  - Required. Supported in v5.0+
      v5.0-v7.0: An array containing the full source path of each file and folder that is part of the download job. The array must contain at least one path.
      v8.0+: Array containing the full source path of each file and folder that is part of the download job. The array must contain at least one path.
