### ObjectTypeUsage
Object type usage (consumption and user) information.

- objectType: O365SnappableType
  - Type of the object (e.g., O365Mailbox, O365OneDrive, O365Site).
- totalConsumption: System.Int64
  - Total consumption for this object type in bytes.
- totalProtectedUsers: System.Int32
  - Total protected users for this object type.
- userMailboxCount: System.Int32
  - Only populated for Exchange.
Count of protected user mailboxes (licensed).
- sharedMailboxCount: System.Int32
  - Count of all shared mailboxes.
- resourceMailboxCount: System.Int32
  - Count of protected resource mailboxes (room/equipment).
