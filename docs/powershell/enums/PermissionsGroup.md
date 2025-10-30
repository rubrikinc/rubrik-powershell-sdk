### PermissionsGroup
PermissionsGroup represents the collection of various permission groups that
exist across all features. However, not all permission groups are applicable
to every feature. PermissionsGroup serves as a superset encompassing all
available permission groups. The specific context of permissions within a
group depends on the feature to which it is onboarded.

- GROUP_UNSPECIFIED - Unspecified permission group.
- BASIC - Represents the basic set of permissions required to onboard a feature.
These permissions are applicable to all the features.
- EXPORT_AND_RESTORE - Represents the set of permissions required for export and restore
operations. These permissions are applicable to the cloud native
protection feature.
- FILE_LEVEL_RECOVERY - Represents the set of permissions required for file-level recovery
operation. These permissions are applicable to the cloud native
protection feature.
- ENCRYPTION - Represents the set of permissions required for encryption
operation. These permissions are applicable to the cloud native archival
encryption feature.
- RECOVERY - Represents the set of permissions required for all recovery
operations. These permissions are applicable to the following features:
- SQL DB
- SQL MI features
- Azure Devops Repository.
- BACKUP_V2 - Represents the set of permissions required for immutable backup V2
operations. These permissions are applicable to the cloud native SQL DB
and SQL MI features.
- CLOUD_CLUSTER_ES - Represents the set of permissions required for Cloud Cluster ES
operation. These permissions are applicable to the cloud native
protection feature.
- SNAPSHOT_PRIVATE_ACCESS - Represents the set of permissions required for private access to disk
snapshots. These permissions are applicable to the cloud native
protection feature.
- PRIVATE_ENDPOINTS - Represents the set of permissions required for usage of private
endpoints. These permissions are applicable to exocompute feature.
- RSC_MANAGED_CLUSTER - Represents the set of permissions required for the Rubrik-managed
Exocompute cluster. Currently, these permissions apply only to the
AWS Exocompute feature.
- SAP_HANA_SS_BASIC - Represents the required permissions for the basic operation of
SAP HANA SS. These permissions are applicable to the cloud cluster ES
feature.
- SAP_HANA_SS_RECOVERY - Represents the required permissions for the recovery operation of
SAP HANA SS. These permissions are applicable to the cloud cluster ES
feature.
- DATA_CENTER_KMS - Represents the set of permissions required to use AWS KMS feature for
data center archival location.
These permission are applicable to the Data Center Role-based archival
feature.
- DATA_CENTER_CONSOLIDATION - Represents the set of permissions required to enabled the Consolidation
feature for data center archival location.
These permission are applicable to the Data Center Role-based archival
feature.
- DATA_CENTER_IMMUTABILITY - Represents the set of permission required to enable the Immutability feature
for data center archival location.
These permission are applicable to the Data Center Role-based archival
feature.
- SQL_ARCHIVAL - Represents the permissions required to enable Azure AD authorization to
store Azure SQL and MI snapshots in an archival location using Colossus.
These permissions apply to Cloud Native Archival Feature.
- CUSTOMER_MANAGED_BASIC - Represents the permissions required to enable customer-managed Exocompute feature.
These permissions apply only to the Azure Exocompute feature.
- CUSTOMER_HOSTED_LOGGING - Represents the permissions required to enable customer hosted logging.
These permissions apply only to the Azure Exocompute feature.
- CUSTOMER_MANAGED_STORAGE_INDEXING - Represents the permissions required to store and retrieve index files
from customer hosted storage account.
These permissions apply only for Azure cloud type.
- AUTOMATED_NETWORKING_SETUP - Represents the permissions required to setup networking for exocompute.
- SERVICE_ENDPOINT_AUTOMATION - Represents the permissions for service endpoint automation.
- AKS_CUSTOM_PRIVATE_DNS_ZONE - Represents the permissions required to use custom private DNS zones for
private AKS clusters.
- EXPORT_AND_RESTORE_POWER_OFF_VM - Represents the set of permissions required for export and restore
power off operations. These permissions are applicable to the cloud
native protection feature.
