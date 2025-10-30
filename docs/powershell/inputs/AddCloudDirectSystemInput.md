### AddCloudDirectSystemInput
Details of the Cloud Direct System to be added.

- clusterId: System.String
  - NCD cluster ID.
- systemType: CloudDirectNasVendorType
  - Type of the NCD System.
- host: System.String
  - IP address or hostname of the management interface of the system.
- username: System.String
  - Username to authenticate with the system.
- password: System.String
  - Password to authenticate with the system.
- managementInfo: NcdManagementInfo
  - Additional information for connecting to a NCD system.
- skipServiceAccountCreation: System.Boolean
  - Skip creating the NCD service account and save the provided credentials.
- region: System.String
  - Region for the NCD system.
- verifySsl: System.Boolean
  - Verify the SSL certificate in generic S3.
- certificateData: System.String
  - Certificate fields for client certificate authentication.
- certificateType: CloudDirectCertificateType
  - Certificate type for client certificate authentication.
- certificateKeyPassword: System.String
  - Password for encrypted certificate keys.
