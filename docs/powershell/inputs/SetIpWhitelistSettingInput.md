### SetIpWhitelistSettingInput
Specifies the input required to update the IP allowlist settings.

- currentIpAddress: System.String
  - Optional. The IP address of the client making the request. Added to the
allowlist so that the requestor does not get locked out.
- isIpWhitelistEnabled: System.Boolean
  - Required. Specifies whether the IP allowlist is enabled.
- currentIpDescription: System.String
  - Optional. Specifies the description for the current IP address.
- mode: WhitelistModeEnum
  - Required. Specifies the mode of the IP allowlist.
