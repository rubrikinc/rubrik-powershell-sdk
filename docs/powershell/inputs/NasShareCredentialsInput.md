### NasShareCredentialsInput
Supported in v8.1+
  Credentials to add or update for NAS shares, NAS namespaces, or NAS systems.

- password: System.String
  - Supported in v8.1+
      Password associated with the NAS user account.
- username: System.String
  - Required. Supported in v8.1+
      Username to access the NAS server and share. If the username is empty, the credentials will be removed from the underlying NAS share, NAS namespace, or NAS system object.
