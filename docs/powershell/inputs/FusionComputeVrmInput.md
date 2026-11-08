### FusionComputeVrmInput
The hostname and account credentials of a FusionCompute Virtual Resource Management (VRM) instance.

- userType: FusionComputeVrmUserType
  - Supported in Rubrik CDM v9.6.2+. Type of the VRM user account that Rubrik logs in with. When omitted, Rubrik logs in as a local user.
- caCerts: System.String
  - Supported in v9.6+
Optional CA certificate content for SSL verification.
- endpointUri: System.String
  - Required. Supported in v9.6+
The address of the new FusionCompute VRM instance.
- password: System.String
  - Required. Supported in v9.6+
The password for authenticating with the FusionCompute VRM.
- username: System.String
  - Required. Supported in v9.6+
The username of the FusionCompute VRM.
