### ApplicationServiceConfiguration
Cloud-agnostic service configuration wrapper using oneof.

- configurationEnabled: System.Boolean
  - Whether configuration (security groups, etc.) protection is enabled.
- applicationCloudConfig: ApplicationCloudConfig
  - The cloud-specific configuration.
