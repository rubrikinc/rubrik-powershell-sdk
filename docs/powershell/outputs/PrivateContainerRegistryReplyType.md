### PrivateContainerRegistryReplyType
Response to the request to retrieve details of a PCR.

- pcrDetails: PrivateContainerRegistryDetailsType
  - Details of PCR consisting of registry URL and how user pulls images into their registry from their AWS account.
- pcrLatestApprovedBundleVersion: System.String
  - Latest approved Exotask bundle version for your Private Container. If no approved bundle is available, this field will be empty.
