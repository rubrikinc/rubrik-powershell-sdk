### AddSapHanaSystemInput
Input for adding a SAP HANA system.

- clusterUuid: System.String
  - Required. UUID used to identify the cluster the request goes to.
- sapHanaSystem: SapHanaSystemConfigInput
  - Required. Add a SAP HANA system to the Rubrik cluster. Contains parameters like username, list of hosts, password required while adding a SAP HANA system.
