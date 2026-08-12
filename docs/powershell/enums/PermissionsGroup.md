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
- EXPORT_POWER_ON - Represents the set of permissions required for export operations for
AWS EC2/EBS. These permissions are applicable to the cloud native
protection feature.
- EXPORT_POWER_OFF - Represents the set of permissions required for export operations specifically
in the powered-off state for AWS EC2/EBS. These permissions are applicable to
the cloud native protection feature.
- RESTORE - Represents the set of permissions required for restore operations for
AWS EC2/EBS. These permissions are applicable to the cloud native
protection feature.
- DOWNLOAD_FILE - Represents the set of permissions required for file level recovery for
AWS EC2/EBS. These permissions are applicable to the cloud native
protection feature.
- NAT_GATEWAY - Represents the set of permissions required for NAT gateway operations.
These permissions are applicable to the Laminar Outpost Application
feature.
- CLOUDSQL - Represents the set of permissions required for CloudSQL operations.
These permissions are applicable to the GCP Exocompute feature.
- RECOVERY_NETWORKING - Represents the set of permissions required for networking recovery
operations in AWS Config Protection (App Resilience). These permissions
cover VPC, ELB, and Route 53 resources.
- ALLOYDB - Represents the set of permissions required for AlloyDb operations.
These permissions are applicable to the GCP AlloyDB Protection feature.
- BAAS_BASIC - Represents the basic set of permissions required for BaaS feature
These permissions may be applicable to any feature that can run on BaaS.
- KMS_KEY_SHARING - Represents the permissions for automated KMS key sharing with the
exocompute account (kms:CreateGrant on customer CMKs). Applicable to the
cloud native protection feature.
- ADVANCED_DIAGNOSTICS - Represents the set of read-only diagnostic permissions for Exocompute.
These permissions let RSC surface Exocompute reachability, networking,
scaling, and worker-node boot diagnostics. Currently applicable only to
the AWS Exocompute feature.
- INVENTORY_GENERATION - Represents the set of permissions required to create, read, update, and
delete the Azure Blob Storage Inventory rule used by the scaled Azure
Blob backup pipeline. Applicable to the Azure Blob Protection feature.
- BASIC_2 - Represents the networking-discovery permissions carved out of BASIC for
the granular AWS Config Protection (App Resilience) split. Applicable to
the cloud native config protection feature when the granular split is
enabled.
- RECOVERY_2 - Represents the compute-recovery permissions carved out of RECOVERY for
the granular AWS Config Protection (App Resilience) split (EC2,
autoscaling, instance-profile, and the relocated ELB/route-table
statements). Applicable to the cloud native config protection feature.
- RECOVERY_3 - Represents the networking-recovery permissions for the granular AWS
Config Protection (App Resilience) split (VPC, ELB, and Route 53
resources); carries the same content as RECOVERY_NETWORKING under a
numbered name. Applicable to the cloud native config protection feature.
- RECOVERY_4 - Represents the container/EKS recovery permissions for the granular AWS
Config Protection (App Resilience) split (EKS, IAM OIDC provider, and
ServiceQuotas). Applicable to the cloud native config protection feature.
- GATEWAY_KEY_CREATION - Represents the permissions for creating and replicating the RSC gateway
KMS key (kms:ReplicateKey) used for automated key sharing. This
permission group is applicable to the cloud native protection feature
and implies KMS_KEY_SHARING.
- SURGICAL_RECOVERY - Represents the set of permissions required for surgical recovery:
snapshot relocation and cleanup operations
(ec2:CopySnapshot, ec2:CreateSnapshot, ec2:DeleteSnapshot,
ec2:ModifySnapshotAttribute, ec2:DescribeSnapshotAttribute), tag-gated on
rk_component where AWS supports it. Applicable to the AWS Exocompute
feature.
- RECOVER_TO_S3 - Represents the least-privilege S3 write-set required to recover an RDS
or Aurora PostgreSQL snapshot to S3. Applicable to the RDS protection
feature.
