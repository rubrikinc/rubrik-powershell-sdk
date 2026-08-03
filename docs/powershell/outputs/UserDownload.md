### UserDownload
A user-initiated download.

- id: System.Int64
  - The ID of the download.
- name: System.String
  - The name of the download.
- status: DownloadStatusEnum
  - The status of the download.
- progress: System.Int32
  - The progress of the download, where 0 <= progress <= 100.
- identifier: DownloadIdentifierEnum
  - The identifier of the download.
- createTime: System.String
  - The time at which the download was created.
- completeTime: System.String
  - The time at which the download completed.
