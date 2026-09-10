### M365AccessRecoveryState
Per-directory state of Automated M365 Access Recovery, which restores a
user's or group's M365 resources and licenses alongside the directory object.

- M365_ACCESS_RECOVERY_STATE_UNSPECIFIED - The directory carries no explicit selection, so it follows whether its
account passes the M365 access recovery eligibility check: on when the
account is eligible, and off for every other account. This is the state a
directory holds until it is explicitly turned on or turned off.
- M365_ACCESS_RECOVERY_STATE_ENABLED - M365 access recovery is turned on for the directory. It applies while the
account passes the eligibility check, the same condition a directory with
no explicit selection follows.
- M365_ACCESS_RECOVERY_STATE_DISABLED - M365 access recovery is turned off for the directory, regardless of
whether the account is eligible for it.
