### CustomerFacingFile
CustomerFacingFile is all the information that this service has stored
about a file except the Internal ID. It also simplifies the fields so
they can be displayed on the UI easier.

- externalId: System.String
  - File external ID.
- type: FileTypeEnumType
  - File type.
- createdAt: DateTime
  - Timestamp when the file was created.
- expiresAt: DateTime
  - Timestamp when the file will expire.
- creator: System.String
  - Creator of the file.
- state: FileStateEnumType
  - File state.
- filename: System.String
  - Name of the file.
- completedAt: DateTime
  - Timestamp when the file generation was completed.
