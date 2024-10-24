### PrivateContainerRegistryReplyType
Response to the request to retrieve details of a PCR.

- pcrDetails: PrivateContainerRegistryDetailsType
  - Details of PCR, including the registry URL and how users retrieve images from Rubrik's container registry into their registry.
- pcrLatestApprovedBundleVersion: System.String
  - Latest approved Exotask bundle version for your Private Container. If no approved bundle is available, this field will be empty.
