### VmMakePrimaryInput
IDs of vSphere virtual machines whose RBS installation needs to be switched to a different primary Rubrik cluster.

- ids: list of System.Strings
  - Required. IDs of hosts to migrate.
- shouldSkipCertificateUpdateOnSecondaryClusters: V1VmMakePrimaryRequestShouldSkipCertificateUpdateOnSecondaryClusters
  - Controls whether to skip updating the trusted root certificate in secondary clusters during the makePrimary operation. The default value is SKIP_NONE.
