### CreateRcsTargetInput
Input to create RCS location.

- clusterUuid: System.String
  - Rubrik cluster UUID.
- name: System.String
  - Name of the RCS location.
- tier: RcsTierEnumType
  - Tier for the RCS location.
- instanceType: InstanceTypeEnum
  - Instance type of the RCS location.
- rsaKey: System.String
  - RSA key for the RCS location.
- region: RcsRegionEnumType
  - Region for the RCS location.
- spaceUsageAlertThreshold: System.Int32
  - Space usage threshold of RCS location above which alert will be raised.
- lockDurationDays: System.Int64
  - Immutability lock period, in days.
- shouldBypassProxy: System.Boolean
  - Specifies whether the proxy settings must be bypassed for  the RCV archival target.
- redundancy: RcvRedundancy
  - Redundancy for the RCV location.
