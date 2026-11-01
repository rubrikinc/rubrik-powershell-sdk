### AwsPermissionModification
AwsPermissionModification is an action granted on both sides with the same
effect but a different resource scope or condition. Before = previous +
unchanged; after = latest + unchanged.

- action: System.String
  - The IAM action whose grant changed.
- previous: list of AwsPermissionStatements
  - The action's deployed grants that the latest model does not require.
- latest: list of AwsPermissionStatements
  - The action's grants the latest model requires that are not deployed.
- effect: System.String
  - Effect of the grants, "Allow" or "Deny". The same on both sides; a change
of effect is reported as a removal plus an addition.
- unchanged: list of AwsPermissionStatements
  - The action's grants that are identical on both sides. With
include_existing they are also listed in the entry's existing.
