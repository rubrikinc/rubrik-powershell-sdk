### PrivateContainerRegistryDetailsType
Details of Private Container Registry, consisting of registry URL and details related to how user will be pulling image from our container registry.

- registryUrl: System.String
  - URL of user's Private Container Registry.
- imagePullDetails: PcrImagePullDetails
  - Details on how users can retrieve images from Rubrik's container registry to their private container registry.
