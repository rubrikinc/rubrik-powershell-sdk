### PrivateContainerRegistryDetailsType
Details of Private Container Registry, consisting of registry URL and details related to how user will be pulling image from our container registry.

- registryUrl: System.String
  - URL of user's Private Container Registry.
- imagePullDetails: PcrImagePullDetails
  - Details of how a user retrieves images to their AWS account from our container registry.
