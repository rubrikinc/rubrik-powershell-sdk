### SapHanaSystemSummary
Supported in v5.3+

- containerType: SapHanaSystemSummaryContainerType
  - The container type of SAP HANA system.
- hosts: a list of SapHanaHosts
  - Required. Supported in v5.3+
- id: System.String
  - Required. Supported in v5.3+
  The ID of the SAP HANA system.
- instanceNumber: System.String
  - Required. Supported in v5.3+
  The instance number of the SAP HANA system.
- isArchived: System.Boolean
  - Supported in v7.0+
  Specifies whether a SAP HANA system is archived.
- lastRefreshTime: DateTime
  - Supported in v5.3+
  The UTC timestamp for when the SAP HANA system was last refreshed.
- numDbs: System.Int32
  - Required. Supported in v5.3+
  The number of databases in the SAP HANA system.
- sid: System.String
  - Required. Supported in v5.3+
  The SAP System Identification (SID) code for the SAP HANA system.
- slaAssignable: SlaAssignable
  - Details of the SLA Domain assigned to the SAP HANA system.
- sslInfo: SapHanaSslInfo
  - Supported in v5.3+
- status: SapHanaSystemSummaryStatus
  - Supported in v5.3+
  The status of the SAP HANA system.
- statusMessage: System.String
  - Supported in v5.3+
  The message associated with the current SAP HANA system status.
- systemInfo: SapHanaSystemInfo
  - Supported in v5.3+
- username: System.String
  - Required. Supported in v5.3+
  The username of the SAP HANA system.
