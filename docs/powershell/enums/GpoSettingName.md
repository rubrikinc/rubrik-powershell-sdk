### GpoSettingName
Identifies a specific leaf-level Group Policy setting that a GPO can
configure. Every value names one leaf setting whose configured value is a
concrete number or boolean; that value is stored in the encrypted
setting_value column, while GpoSetting records whether the setting is
configured. Category-presence tags are intentionally excluded -- each value
here is a value-bearing leaf. Values are drawn from two SecuritySettings
families: the Account policies (Password, Account Lockout, and Kerberos),
keyed by <Name>; and the Security Options (registry-backed local policy
settings), keyed by the registry <KeyName>. Numbers are stable wire IDs
(append-only).

- GPO_SETTING_NAME_MINIMUM_PASSWORD_AGE - Minimum password age policy setting.
- GPO_SETTING_NAME_MAXIMUM_PASSWORD_AGE - Maximum password age policy setting.
- GPO_SETTING_NAME_MINIMUM_PASSWORD_LENGTH - Minimum password length policy setting.
- GPO_SETTING_NAME_PASSWORD_COMPLEXITY - Password must meet complexity requirements policy setting.
- GPO_SETTING_NAME_PASSWORD_HISTORY_SIZE - Enforce password history (number of remembered passwords) policy setting.
- GPO_SETTING_NAME_CLEAR_TEXT_PASSWORD - Store passwords using reversible encryption policy setting.
- GPO_SETTING_NAME_LOCKOUT_BAD_COUNT - Account lockout threshold (invalid logon attempts) policy setting.
- GPO_SETTING_NAME_LOCKOUT_DURATION - Account lockout duration policy setting.
- GPO_SETTING_NAME_RESET_LOCKOUT_COUNT - Reset account lockout counter after policy setting.
- GPO_SETTING_NAME_MAX_TICKET_AGE - Maximum lifetime for a Kerberos user ticket policy setting.
- GPO_SETTING_NAME_MAX_RENEW_AGE - Maximum lifetime for Kerberos user ticket renewal policy setting.
- GPO_SETTING_NAME_MAX_SERVICE_AGE - Maximum lifetime for a Kerberos service ticket policy setting.
- GPO_SETTING_NAME_MAX_CLOCK_SKEW - Maximum tolerance for Kerberos computer clock synchronization policy setting.
- GPO_SETTING_NAME_TICKET_VALIDATE_CLIENT - Enforce Kerberos user logon restrictions (validate client) policy setting.
- GPO_SETTING_NAME_NO_LM_HASH - Security Options.

"Network security: Do not store LAN Manager hash value on next password
change" security option, backed by the registry value NoLMHash under
MACHINE\System\CurrentControlSet\Control\Lsa. The configured value is 1
when LM hashes are not stored (secure) and 0 when they are stored
(insecure).
