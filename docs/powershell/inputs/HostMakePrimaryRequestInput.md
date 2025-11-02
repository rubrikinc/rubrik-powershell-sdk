### HostMakePrimaryRequestInput
Supported in v5.3+

- ids: list of System.Strings
  - Supported in v5.3+
IDs of hosts to migrate.
- shouldSkipCertificateUpdateOnSecondaryClusters: HostMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters
  - Supported in v9.4+
Controls whether to skip updating the trusted root certificate in secondary clusters during the makePrimary operation. The default value is SKIP_NONE.
- oldPrimaryClusterUuid: System.String
  - Supported in v5.3+
For all hosts and virtual machines registered with this cluster, make itself the primary if the current primary is oldPrimaryClusterUuid.
