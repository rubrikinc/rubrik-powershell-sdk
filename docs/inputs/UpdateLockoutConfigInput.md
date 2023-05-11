### UpdateLockoutConfigInput
Specifies the input required to update the lockout config by the admin.

- accountAutoUnlockDurationInMins: System.Int32
  - Specifies the time after which the account is unlocked automatically.
- isAutoUnlockFeatureEnabled: System.Boolean
  - Specifies whether the auto unlock feature is enabled on the UI.
- isBruteForceLockoutEnabled: System.Boolean
  - Specifies whether the account lockout feature is enabled on the UI.
- isSelfServiceEnabled: System.Boolean
  - Specifies whether self service is enabled for all users in this organization.
- loginAttemptsLimit: System.Int32
  - Specifies the number of failed login attempts allowed after which the account is locked.
- selfServiceAttemptsLimit: System.Int32
  - Specifies the number of times self-service is allowed to unlock the account.
- selfServiceTokenValidityInMins: System.Int32
  - Specifies the validity of the current self service token.
