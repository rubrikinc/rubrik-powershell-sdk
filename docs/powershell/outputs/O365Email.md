### O365Email
An email message.

- subject: System.String
  - The subject of the email.
- from: System.String
  - The sender of the email.
- toRecipients: list of System.Strings
  - The recipients of the email.
- sentDateTime: DateTime
  - The timestamp when the email was sent.
- receivedDateTime: DateTime
  - The timestamp when the email was received.
- snapshotNum: System.Int32
  - The snapshot number of this version of the email.
- hierarchyType: ExchangeItemHierarchyType
  - Type of hierarchy for the specified email.
- lastModifiedDateTime: DateTime
  - The timestamp when the email was last modified.
- snapshotId: System.String
  - The snapshot ID of this version of the email.
- id: System.String
  - The ID of the Microsoft 365 Exchange object.
- parentFolderId: System.String
  - The parent folder ID of the object (ROOT indicates root folder).
