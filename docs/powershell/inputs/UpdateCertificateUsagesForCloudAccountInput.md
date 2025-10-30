### UpdateCertificateUsagesForCloudAccountInput
Input required to update certificate usage for a cloud account.

- cloudAccountId: System.String
  - The unique identifier for a cloud account used to update certificate usage.
- cloudNativeAccountId: System.String
  - Deprecated: Use cloudAccountId instead.
- selectedCertificateIds: list of System.Strings
  - List of certificate IDs used by the cloud account.
- cloudType: CloudType
  - Cloud provider type. For example, AWS, Azure, or GCP.
