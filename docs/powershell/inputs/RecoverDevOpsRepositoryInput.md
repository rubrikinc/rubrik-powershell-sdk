### RecoverDevOpsRepositoryInput
Request message for the API to recover a DevOps repository from a snapshot.

- repositoryId: System.String
  - RSC-assigned UUID of the source DevOps repository to recover from.
- repoType: DevopsOrgType
  - The type of DevOps organization — AZURE_DEVOPS or GITHUB.
- orgId: System.String
  - RSC-assigned UUID of the destination organization where the repository
will be recovered.
- repositoryName: System.String
  - Name for the recovered repository in the destination organization. Must
be unique within the destination organization and follow the platform's
naming rules (e.g., no spaces for GitHub).
- devopsTypeRestoreConfig: DevOpsTypeRepositoryRecoveryConfig
  - Platform-specific configuration for the recovery. Required for Azure
DevOps (specifies the destination project).
- authConfig: RecoveryAuthConfig
  - Authentication config for recovery. Required when recovering to a
destination that needs separate authorization (e.g., security token auth).
- snapshotId: System.String
  - RSC-assigned UUID of the snapshot to recover from. Retrieve available
snapshots for the repository using its workload ID.
- includePipelines: System.Boolean
  - Whether to include CI/CD pipelines (e.g., Azure Pipelines YAML
definitions) in the recovery.
