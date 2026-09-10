### UpdateClusterSettingsReply
Response from updating CDM cluster settings.

- acceptedEulaVersion: System.String
  - Version of the EULA accepted by admin.
- apiVersion: System.String
  - REST API version.
- geolocation: ClusterGeolocation
  - Cluster geolocation.
- clusterUuid: System.String
  - ID of the Rubrik cluster.
- latestEulaVersion: System.String
  - Latest version of the EULA that must be accepted by admin.
- name: System.String
  - Name of the cluster.
- timezone: ClusterTimezone
  - Cluster time zone.
- version: System.String
  - Rubrik cluster software version.
- registeredMode: RegisteredMode
  - Supported in v8.0+
Mode of registration for the Rubrik cluster.
- rubrikUrl: System.String
  - Supported in v8.0+
Global manager URL.
