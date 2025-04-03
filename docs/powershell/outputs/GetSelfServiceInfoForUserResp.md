### GetSelfServiceInfoForUserResp
Self service information for the logged-in user.

- name: System.String
  - Name of the logged-in user.
- orgId: System.String
  - RSC ID of the M365 organization to which the user belongs.
- onedrive: OnedriveForSelfService
  - Onedrive object, if any, belonging to the user.
- mailbox: MailboxForSelfService
  - Mailbox object, if any, belonging to the user.
