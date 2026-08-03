### RestoreAzureAdObjectsWithPasswordsInput
Configuration to initiate recovery of AzureAdDirectory with multiple
passwords.

- workloadFid: System.String
  - Workload Fid of the Azure AD Directory to recover.
- snapshotFid: System.String
  - Snapshot FID of the Azure AD directory snapshot from which to recover.
- passwordByUserIdMap: list of PasswordByUserIds
  - Map of user IDs to password.
- objectTypeToIdMap: list of ObjectInfoTypes
  - Map of azureAdObjectType to object IDs.
- forceChangePasswordWithMfa: System.Boolean
  - Specifies whether to enable MFA during the recovery of one or more users.
- relationshipRestoreMode: AzureAdRelationshipRestoreModeEnumType
  - Represents the modes for relationship restore for Azure AD objects.
- objectRecoveryOptions: ObjectRecoveryOptionsType
  - Represents recovery options for every AzureAdObjectType.
- attributeRecoveryMode: AttributeRecoveryMode
  - Represents the modes for attributes restore for Azure AD objects.
- attributeRecoveryOptions: AttributeRecoveryOptions
  - Represents attribute recovery options for each Azure AD object.
- ctrConfig: EntraIdCrossTenantRecoveryConfig
  - Configuration for cross tenant recovery.
- relationshipConflictResolutionMode: RelationshipConflictResolutionState
  - Deprecated, this field is no longer used and will be ignored.
- objectsToDelete: list of ObjectInfoTypes
  - List of Entra ID objects to soft-delete from the target tenant after
restore completes.
- cleanRecoverySessionId: System.String
  - Identifier of the clean-recovery session being committed. When set, the
operator-approved set of objects and attributes is read from the
granular-recovery data written during StartCleanRecovery, and the
in-request selection is ignored.
