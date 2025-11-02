### GetWhitelistReply
Get IP whitelist configuration.

- enabled: System.Boolean
  - Specifies whether the IP allowlist is enabled.
- mode: WhitelistModeEnum
  - The mode of the IP allowlist.
- ipCidrs: list of System.Strings
  - The list of IP addresses in the allowlist.
- ipInfos: list of IpInfos
  - List of all IP entries in the allowlist.
