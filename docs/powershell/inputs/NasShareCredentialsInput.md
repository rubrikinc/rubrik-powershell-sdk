### NasShareCredentialsInput
Credentials to add or update for NAS shares, NAS namespaces, or NAS systems.

- password: System.String
  - Password associated with the NAS user account.
- username: System.String
  - Required. Username to access the NAS server and share. If the username is empty, the credentials will be removed from the underlying NAS share, NAS namespace, or NAS system object.
