### UpdateLockoutConfigReply
Specifies information about lockout configuration.

- loginAttemptsLimit: System.Int32
  - Specifies the number of failed login attempts allowed after which the account is locked.
- selfServiceTokenValidityInMins: System.Int32
  - Specifies the validity of the current self service token.
- selfServiceAttemptsLimit: System.Int32
  - Specifies the number of times self service is allowed to unlock the account.
- isSelfServiceEnabled: System.Boolean
  - Specifies whether self service is enabled for all users in this organization.
- accountAutoUnlockDurationInMins: System.Int32
  - Specifies the time after which the account is unlocked automatically.
- isBruteForceLockoutEnabled: System.Boolean
  - Specifies whether the account lockout feature is enabled on the UI.
- isAutoUnlockFeatureEnabled: System.Boolean
  - Specifies whether the auto unlock feature is enabled on the UI.
- inactiveLockoutConfig: InactiveLockoutConfig
  - Specifies information about inactive lockout configuration.
