### AgentDeploymentSettingsInput
Supported in v5.0+

- guestCredentialId: System.String
  - Supported in v9.2+
      ID of the guest OS credential to be used for authentication to the virtual machine guest OS.
- isAutomatic: System.Boolean
  - Required. Supported in v5.0+
      Determines whether the Rubrik cluster automatically deploys the Rubrik Backup Service to the guest OS at the first backup. Set to true to permit automatic deployment. Set to false to prevent automatic deployment.
