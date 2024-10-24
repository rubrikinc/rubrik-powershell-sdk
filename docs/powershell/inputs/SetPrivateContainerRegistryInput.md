### SetPrivateContainerRegistryInput
Input for setting Private Container Registry details.

- exocomputeAccountId: System.String
  - Rubrik ID of the Exocompute account.
- registryUrl: System.String
  - URL of user's Private Container Registry.
- cloudType: CloudType
  - Cloud type for which PCR is being set up.
- pcrAwsImagePullDetails: PcrAwsImagePullDetailsInput
  - Details on how users can retrieve images from Rubrik's AWS container registry into their PCR.
- pcrAzureImagePullDetails: PcrAzureImagePullDetailsInput
  - Details on how users can retrieve images from Rubrik's Azure container registry into their PCR.
