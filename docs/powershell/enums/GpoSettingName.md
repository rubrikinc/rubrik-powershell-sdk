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
- GPO_SETTING_NAME_LDAP_SERVER_INTEGRITY - The "Domain controller: LDAP server signing requirements" security
option, backed by the registry value LDAPServerIntegrity under
MACHINE\System\CurrentControlSet\Services\NTDS\Parameters. The configured
value is 0 (None), 1 (Negotiate signing), or 2 (Require signing). A value
other than 2 means DCs accept unsigned LDAP and is a security risk.
- GPO_SETTING_NAME_ENABLE_MULTICAST - Registry Settings (Admin Templates / Registry extension namespace).

"Turn off multicast name resolution (LLMNR)" administrative template
setting, backed by the registry value EnableMulticast under
HKLM\Software\Policies\Microsoft\Windows NT\DNSClient. A value of 1
explicitly re-enables LLMNR (which can override an org-wide disable),
allowing credential interception attacks.
- GPO_SETTING_NAME_MACHINE_SCRIPT_COMMAND - Scripts extension settings.

Command paths from all Startup and Shutdown machine scripts configured by
this GPO (Scripts extension). Used to identify script commands that
reference paths outside the GPO's own SYSVOL directory, indicating a
potentially risky external script path.
- GPO_SETTING_NAME_SE_DEBUG_PRIVILEGE - The "Debug programs" (SeDebugPrivilege) user right, which lets its holder
attach a debugger to any process and read or modify its memory, including
processes that hold credentials.
- GPO_SETTING_NAME_SE_BACKUP_PRIVILEGE - The "Back up files and directories" (SeBackupPrivilege) user right, which
lets its holder read any file or registry key regardless of its ACL.
- GPO_SETTING_NAME_SE_RESTORE_PRIVILEGE - The "Restore files and directories" (SeRestorePrivilege) user right, which
lets its holder write any file or registry key and set object ownership
regardless of its ACL.
- GPO_SETTING_NAME_SE_TAKE_OWNERSHIP_PRIVILEGE - The "Take ownership of files or other objects" (SeTakeOwnershipPrivilege)
user right, which lets its holder take ownership of any securable object
regardless of its ACL.
- GPO_SETTING_NAME_SE_LOAD_DRIVER_PRIVILEGE - The "Load and unload device drivers" (SeLoadDriverPrivilege) user right,
which lets its holder load and unload kernel-mode device drivers.
- GPO_SETTING_NAME_SE_IMPERSONATE_PRIVILEGE - The "Impersonate a client after authentication" (SeImpersonatePrivilege)
user right, which lets its holder impersonate the security context of a
client it is serving.
- GPO_SETTING_NAME_SE_ASSIGN_PRIMARY_TOKEN_PRIVILEGE - The "Replace a process level token" (SeAssignPrimaryTokenPrivilege) user
right, which lets its holder replace the primary access token of a
process.
- GPO_SETTING_NAME_SE_TRUSTED_CRED_MAN_ACCESS_PRIVILEGE - The "Access Credential Manager as a trusted caller"
(SeTrustedCredManAccessPrivilege) user right, which lets its holder
retrieve credentials stored in Windows Credential Manager.
- GPO_SETTING_NAME_SE_ENABLE_DELEGATION_PRIVILEGE - The "Enable computer and user accounts to be trusted for delegation"
(SeEnableDelegationPrivilege) user right, which lets its holder mark
accounts as trusted for Kerberos delegation.
- GPO_SETTING_NAME_SE_REMOTE_INTERACTIVE_LOGON_RIGHT - The "Allow log on through Remote Desktop Services"
(SeRemoteInteractiveLogonRight) user right, which lets its holder log on
interactively over Remote Desktop Services.
- GPO_SETTING_NAME_SE_TCB_PRIVILEGE - The "Act as part of the operating system" (SeTcbPrivilege) user right,
which lets its holder assume the identity of any user and obtain access as
that user.
