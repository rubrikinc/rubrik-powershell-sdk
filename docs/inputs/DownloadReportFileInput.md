### DownloadReportFileInput
Parameters for downloading a CSV or PDF of the report.

- config: CustomReportConfigInput
  - Customized NG related report configuration.
- fileType: FileTypeEnum
  - Type of the file to be downloaded.
- reportId: System.Int64
  - ID of the report. This will only be used if the config is empty, otherwise, it will be 0.
- timezone: System.String
  - The timezone to be used for the downloaded report data.
