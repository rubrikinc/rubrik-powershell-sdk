### PatchSapHanaSystemInput
Input for editing a SAP HANA system.

- id: System.String
  - Required. The ID of the SAP HANA system.
- updateProperties: SapHanaSystemPatchInput
  - Required. v5.3-v9.0: An object that contains the updated SLA Domain ID for the SAP HANA system.
      v9.1: An object that contains the system properties to be updated for the SAP HANA system.
