### UpdateCertificateCloudAccountMappingsInput
Input required to update certificates mapped to a cloud account.

- cloudNativeAccountId: System.String
  - Cloud-native account ID.
- certificates: list of CertificateInfoInputs
  - List of certificates to map to the cloud account.
- cloudType: CloudType
  - Cloud provider type, such as AWS, Azure, or GCP.
