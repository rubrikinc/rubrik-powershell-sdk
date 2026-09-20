### M365RecoveryOptionsInput
Options for automated M365 Access Recovery during a granular restore.
Absent means no M365 recovery; a standard Entra ID restore runs instead.

- shouldIncludeExchange: System.Boolean
  - When true, recover the principal's Exchange Online mailbox alongside the
Entra ID object.
- shouldIncludeOneDrive: System.Boolean
  - When true, recover the principal's OneDrive access alongside the Entra ID
object. Recovering content from a permanently removed OneDrive site is not
supported.
