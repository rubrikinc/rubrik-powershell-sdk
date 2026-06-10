### AzureAdEmExpiration
Expiration settings for access package assignments.

- type: EmExpirationType
  - Expiration mode (duration, date and time, or never).
- durationSeconds: System.Int64
  - Duration before assignments expire, in seconds (e.g. P30D -> 2592000).
Zero when the expiration mode is not duration-based.
- endDateTime: DateTime
  - Date and time when assignments expire.
