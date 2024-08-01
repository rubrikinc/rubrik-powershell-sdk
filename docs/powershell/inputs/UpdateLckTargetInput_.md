### UpdateLckTargetInput
Input for updating a LCK archival location.

- id: System.String
  - ID of the LCK target to be edited.
- name: System.String
  - Name of the target.
- roleName: System.String
  - Field for specifying role name of the LCK archival location.
- agency: System.String
  - Agency for the LCK archival target.
- storageClass: AwsStorageClass
  - Field for specifying storage class of the LCK archival location.
- geoAxisEndpoint: System.String
  - GeoAxIS endpoint for LCK archival target.
- accountName: System.String
  - Account name of the LCK archival target.
- certificateContent: System.String
  - Field for specifying csr certificate content of the LCK archival location.
- awsRetrievalTier: AwsRetrievalTier
  - Field for specifying retrieval tier for this target.
