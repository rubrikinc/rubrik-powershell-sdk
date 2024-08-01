### ArtifactPolicy
Represents the trust policy for a role.

- externalArtifactKey: AwsCloudExternalArtifact
  - The role for the trust policy.
- trustPolicyDoc: System.String
  - Trust policy JSON document to be attached to the role.
- errorMessage: System.String
  - Message denoting the status of trust policy retrieval for the role (Empty if no error).
