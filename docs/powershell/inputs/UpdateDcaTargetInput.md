### UpdateDcaTargetInput
Input for updating a DCA archival location.

- id: System.String
  - ID of the DCA target to be edited.
- name: System.String
  - Name of the DCA archival location.
- roleName: System.String
  - Field for specifying role name of the DCA archival location.
- agency: System.String
  - Agency for the DCA archival target.
- mission: System.String
  - Field for specifying mission of the target.
- tokenDuration: System.Int32
  - Field for specifying token duration in minutes.
- capEndPoint: System.String
  - Cap endpoint of the DCA archival location.
- certificateContent: System.String
  - Field for specifying certificate content of the DCA archival location.
- storageClass: AwsStorageClass
  - Field for specifying storage class of the DCA archival location.
- awsRetrievalTier: AwsRetrievalTier
  - Field for specifying retrieval tier for this target.
