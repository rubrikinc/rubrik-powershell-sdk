### ArtifactPolicy
Represents the trust policy for a role.

- externalArtifactKey: AwsCloudExternalArtifact
  - The ID of the artifact where the trust policy should be attached.
- trustPolicyDoc: System.String
  - A JSON policy document which basically defines which
principals(includes users, roles, accounts, services) can assume
the roles and under what conditions can they assume the role.
- errorMessage: System.String
  - Message denoting the status of trust policy retrieval
for the role (Empty if no error).
