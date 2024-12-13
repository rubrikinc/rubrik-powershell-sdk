### IpInfo
Information about an entry in the IP allowlist.

- id: System.Int64
  - ID of the entry.
- ipCidr: System.String
  - The IP address/range/subnet of the entry.
- description: System.String
  - Description of the entry.
- containsCurrentIpAddress: System.Boolean
  - Whether the entry contains the user's current IP address.
- isGlobalEntry: System.Boolean
  - Whether the entry is inherited from the global IP allowlist.
- createdAt: DateTime
  - The timestamp for when the entry was first created.
- updatedAt: DateTime
  - The timestamp for when the entry was last updated.
