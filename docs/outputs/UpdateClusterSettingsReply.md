### UpdateClusterSettingsReply
Response from updating CDM cluster settings.

- acceptedEulaVersion: System.String
  - Version of the EULA accepted by admin.
- apiVersion: System.String
  - REST API version.
- clusterUuid: System.String
  - ID of the Rubrik cluster.
- geolocation: ClusterGeolocation
  - Cluster geolocation.
- latestEulaVersion: System.String
  - Latest version of the EULA that must be accepted by admin.
- name: System.String
  - Name of the cluster.
- registeredMode: RegisteredMode
  - Mode of registration.
- rubrikUrl: System.String
  - Global manager URL.
- timezone: ClusterTimezone
  - Cluster time zone.
- version: System.String
  - Rubrik cluster software version.
