### DownloadCaseAttachmentReply
Response containing the downloaded case attachment content.

- data: System.String
  - Raw file bytes (Base64-encoded in GraphQL).
- contentType: System.String
  - MIME type detected from the file content, e.g. "application/pdf".
- fileName: System.String
  - Full filename including extension, e.g. "diagnostics.log".
