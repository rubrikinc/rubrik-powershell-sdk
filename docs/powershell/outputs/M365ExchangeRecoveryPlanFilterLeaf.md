### M365ExchangeRecoveryPlanFilterLeaf
A leaf predicate for Exchange mailbox items.
Exactly one primitive field must be set.

- sender: M365StringListFilter
  - Filter by sender email address.
- toRecipients: M365StringListFilter
  - Filter by recipient email addresses.
- importance: M365StringListFilter
  - Filter by importance level. Valid values: HIGH, NORMAL, LOW.
- isDraft: System.Boolean
  - Filter by draft status.
- isRead: System.Boolean
  - Filter by read status.
