### SlaMigrationIneligibilityReason
Reasons for the SLA being ineligible for migration.

- NOT_APPLICABLE - SLA Domain is eligible for migration.
- INVALID_LOCAL_SLA - SLA Domain is not associated with a Rubrik cluster.
- CLUSTER_DISCONNECTED - Rubrik cluster associated with the SLA Domain is disconnected.
- INVALID_CLUSTER_VERSION - The version of the Rubrik cluster associated with the SLA Domain is not valid for SLA migration.
- REPLICATION_TARGET_DISCONNECTED - Replication targets associated with the SLA Domain are disconnected.
- INVALID_REPLICATION_TARGET_VERSION - Replication targets associated with the SLA Domain have invalid cluster version for migration.
- CASCADED_ARCHIVAL_CONFIGURED - The remote SLA Domain has an archival policy configured, which is not supported in Rubrik currently.
- INVALID_REPLICATION_TARGET - The type of replication targets is invalid for migration.
- RETENTION_LOCK_CONFIGURED - The SLA Domain has retention lock configured, which is not supported in Rubrik currently.
- MINUTE_FREQUENCY_CONFIGURED - The SLA Domain has frequency configured in minutes, which is currently not supported in Rubrik.
- UNSUPPORTED_PROTECTED_OBJECTS - The SLA Domain is protecting some objects which are currently not supported for upgrade.
- TPR_ENABLED_ON_CLUSTER - The Two-person rule is enabled on the Rubrik cluster, which is not supported for SLA Domain migration.
- INVALID_CASCADING_ARCHIVAL_VERSION - This SLA Domain has cascading archival configured. However, the Rubrik CDM version on the replication target cluster does not support migration of SLA Domains with cascading archival configured.
- UNSUPPORTED_PROTECTED_OBJECTS_MINUTE_FREQUENCY_CONFIGURED - The SLA Domain has frequency configured in minutes, which is currently not supported for objects other than Managed Volumes.
- COMPLIANCE_RETENTION_LOCK_CONFIGURED - To upgrade to retention-locked SLA Domain in compliance mode, contact Rubrik Support to enable compliance mode. Also, make sure quorum authorization is enabled in RSC and your Rubrik cluster is running CDM version 7.0.2 or later.
- GOVERNANCE_RETENTION_LOCK_CONFIGURED - To upgrade to a retention-locked SLA Domain in governance mode, make sure quorum authorization is enabled in RSC and your Rubrik cluster is running CDM version 9.0.1 or later.
- GOV_CLOUD_ARCHIVAL_LOCATION_REGISTERED_ON_CLUSTER - The commercial instance of RSC doesn't support archival to GovCloud regions. Contact the Rubrik Support team for more information.
- GOVERNANCE_RETENTION_LOCK_UNSUPPORTED_CLUSTER_VERSION - To upgrade to a retention-locked SLA Domain in governance mode, make sure your Rubrik cluster is running CDM version 9.0.1 or later.
- RETENTION_LOCKED_SLA_WITH_CROSS_ACCOUNT_REPLICATION_TARGETS - The SLA Domain is retention-locked and has cross-account replication targets configured in it. Upgrading such SLA Domains is not supported.
- UNSUPPORTED_PROTECTED_OBJECTS_SHARE_FILESET - The SLA Domain protecting NAS on CDM is currently not eligible for upgrade.
