### SapHanaSystemPatchInput
Supported in v5.3+

- configuredSlaDomainId: System.String
  - Supported in v5.3+
      v5.3-v8.1: The ID of the SLA Domain that is configured for the SAP HANA system.
      v9.0+: Deprecated. Make sure to use the SLA APIs for updating the SLA Domain of the SAP HANA database.
- hostIds: list of System.Strings
  - Supported in v5.3+
      The SAP HANA system hosts.
- instanceNumber: System.String
  - Supported in v5.3+
      The instance number of the SAP HANA system.
- password: System.String
  - Supported in v5.3+
      The password of the SAP HANA system.
- sid: System.String
  - Supported in v5.3+
      The SAP System Identification (SID) code for the SAP HANA system.
- username: System.String
  - Supported in v5.3+
      The username of the SAP HANA system.
- sslInfo: SapHanaSslInfoInput
  - Supported in v7.0+
      Information required to connect to SAP HANA database over SSL.
- authTypeSpec: SapHanaSystemAuthTypeSpecInput
  - Supported in v9.0+
      Specifies the authentication type for the SAP HANA system.
- azureFeatureId: System.String
  - The Rubrik ID of the SAP HANA Azure Feature.
