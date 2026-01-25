### ValidateOracleAcoFileInput
Specifies input for ValidateOracleAcoFileRequest including the Oracle database ID.

- acoContentsBase64: System.String
  - Required. Contents of the Advanced Cloning Options file in base64 encoded format.
- clusterUuid: System.String
  - Required. Specifies UUID used to identify the cluster the request goes to.
- isLiveMount: System.Boolean
  - Required. Boolean that determines whether the ACO file is being used for a Live Mount.
- isDifferentTargetDbName: System.Boolean
  - Optional. Specifies whether the Clone or Live Mount is being performed with a target database name that is different from the source database name.
- dbId: System.String
  - ID of the Oracle database.
