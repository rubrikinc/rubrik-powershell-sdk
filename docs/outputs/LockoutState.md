### LockoutState
User account lockout details.

- isLocked: System.Boolean
  - Specifies whether the account is locked.
- lockMethod: LockMethod
  - Mechanism for locking the user account.
- lockedAt: DateTime
  - The time at which the account was previously locked.
- unlockMethod: UnlockMethod
  - Method for unlocking the locked account. Possible values are: self-service, administrative-unlocking, support-unlocking.
- unlockedAt: DateTime
  - The time at which the account was previously unlocked.
