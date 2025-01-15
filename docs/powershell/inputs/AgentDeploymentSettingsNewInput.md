### AgentDeploymentSettingsNewInput
Input for Rubrik Backup Service deployment settings.

- guestCredential: GuestCredentialDefinitionInput
  - Guest credentials for the virtual machine.
- guestCredentialId: System.String
  - FID of guest credential assigned to the virtual machine.
- isAutomatic: System.Boolean
  - Determines whether the Rubrik cluster automatically deploys the Rubrik Backup Service to the guest OS during the first backup. Set to true to permit automatic deployment. Set to false to prevent automatic deployment.
