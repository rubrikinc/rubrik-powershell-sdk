### OperationalRecoverySpec
Operational recovery spec.

- mailboxOperationalRecoverySpec: MailboxOperationalRecoverySpec
  - Specify the operational recovery requirements for the mailbox.
- calendarOperationalRecoverySpec: CalendarOperationalRecoverySpec
  - Specify the operational recovery requirements for the calendar.
- operationalRecoveryStage: OperationalRecoveryStage
  - Specify the current stage of operational recovery.
- shouldAutoComplete: System.Boolean
  - Specify if completion of operational recovery should be triggered automatically.
- sharepointOperationalRecoverySpec: SharepointOperationalRecoverySpec
  - Specify the operational recovery requirements for SharePoint.
- onedriveOperationalRecoverySpec: OnedriveOperationalRecoverySpec
  - Specify the operational recovery requirements for OneDrive.
- lastPhaseRecoveryJobId: System.String
  - Specify the initial operational recovery Job ID.
