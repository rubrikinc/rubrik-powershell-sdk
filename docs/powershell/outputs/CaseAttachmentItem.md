### CaseAttachmentItem
Metadata for a single file attached to a support case.

- id: System.String
  - Salesforce ContentDocument ID.
- title: System.String
  - File name without extension.
- fileExtension: System.String
  - File extension, e.g. "pdf".
- contentSize: System.Int64
  - File size in bytes.
- createdDate: DateTime
  - Upload timestamp.
- createdByName: System.String
  - Display name of the uploader.
