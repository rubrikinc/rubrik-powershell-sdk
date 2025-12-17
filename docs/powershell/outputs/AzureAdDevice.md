### AzureAdDevice
Entra ID device.

- displayName: System.String
  - Display name of the Entra ID device.
- accountEnabled: System.Boolean
  - Specifies whether the device account is enabled in Entra ID.
- operatingSystem: System.String
  - Operating system running on the device.
- operatingSystemVersion: System.String
  - Version of the operating system.
- trustType: AzureAdDeviceTrustType
  - Trust relationship type between the device and Entra ID.
- registeredOwner: System.String
  - Display name of the user who registered the device.
- userPrincipalName: System.String
  - Principal name of the user who registered the device.
- mdm: System.String
  - Mobile Device Management (MDM) authority managing the device.
- isCompliant: System.Boolean
  - Specifies whether the device is compliant with organizational policies.
Can be null if compliance status is unknown.
- registrationDateTime: DateTime
  - Date and time when the device was registered in Entra ID.
- lastSignInDateTime: DateTime
  - Date and time of the device's last sign-in activity.
- onPremSyncStatus: AzureAdOnPremSyncStatus
  - On-premises sync status of the Entra ID device.
- deviceId: System.String
  - ID of the device set by Azure Device Registration Service at the time of registration.
