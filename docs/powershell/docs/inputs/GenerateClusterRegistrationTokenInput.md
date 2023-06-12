### GenerateClusterRegistrationTokenInput
Input required for providing cluster configuration details for registration.

- managedByPolaris: System.Boolean
  - If true, generate a token for registering a Hybrid cluster. If false, generate a token for registering LifeOfDevice cluster. If it's not passed, the product type is inferred automatically. Value would be absent in case of single SKU.
- nodeConfigs: list of NodeRegistrationConfigsInputs
  - Configuration details for nodes in the cluster. Input is optional as all CDM releases don't support this configuration generation.
- isOfflineRegistration: System.Boolean
  - Indicates whethere the registration is being performed in offline mode or online. Input is optional as all CDM releases don't support offline registration.
