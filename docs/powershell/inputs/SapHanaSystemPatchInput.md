### SapHanaSystemPatchInput
Supported in v5.3+

- configuredSlaDomainId: System.String
  - Supported in v5.3+
      The ID of the SLA Domain that is configured for the SAP HANA system.
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
