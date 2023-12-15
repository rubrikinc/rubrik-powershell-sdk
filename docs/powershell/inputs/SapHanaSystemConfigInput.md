### SapHanaSystemConfigInput
Supported in v5.3+

- dataPathSpec: SapHanaSystemDataPathSpecInput
  - Supported in v6.0+
      Data path details of the SAP HANA system.
- sslInfo: SapHanaSslInfoInput
  - Supported in v7.0+
      Information required to connect to SAP HANA database over SSL.
- authTypeSpec: SapHanaSystemAuthTypeSpecInput
  - Supported in v9.0+
      The authentication type for the SAP HANA system.
- azureFeatureId: System.String
  - The Rubrik ID of the SAP HANA Azure Feature.
- hostIds: list of System.Strings
  - Required. Supported in v5.3+
      The SAP HANA system hosts.
- instanceNumber: System.String
  - Required. Supported in v5.3+
      The instance number of the SAP HANA system.
- password: System.String
  - Required. Supported in v5.3+
      The password of the SAP HANA system.
- sid: System.String
  - Required. Supported in v5.3+
      The SAP System Identification (SID) code for the SAP HANA system.
- username: System.String
  - Required. Supported in v5.3+
      The username of the SAP HANA system.
