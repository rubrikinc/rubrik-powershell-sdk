### SnoozedDirectory
A directory that has been snoozed.

- directory: System.String
  - The directory path.
- falsePositiveType: AnomalyFalsePositiveType
  - The type of false positive.
- userAccount: System.String
  - The account user that snoozed the directory.
- status: SnoozeStatus
  - The status of the snooze.
- expirationDate: DateTime
  - The expiration date of the snooze.
- createdDate: DateTime
  - The date the snooze was created.
- otherReason: System.String
  - The reason for snoozing the directory (if falsePositiveType equals to OTHER).
