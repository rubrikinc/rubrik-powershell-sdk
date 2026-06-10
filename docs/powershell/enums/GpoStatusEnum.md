### GpoStatusEnum
GPO enable/disable status derived from the AD flags attribute (0=ENABLED, 1=USER_DISABLED, 2=COMPUTER_DISABLED, 3=ALL_DISABLED).

- GPO_ENABLED - All GPO settings are enabled (flags = 0).
- GPO_USER_SETTINGS_DISABLED - User configuration settings are disabled (flags = 1).
- GPO_COMPUTER_SETTINGS_DISABLED - Computer configuration settings are disabled (flags = 2).
- GPO_ALL_SETTINGS_DISABLED - All settings (user and computer) are disabled (flags = 3).
