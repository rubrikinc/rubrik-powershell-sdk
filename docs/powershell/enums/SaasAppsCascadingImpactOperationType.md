### SaasAppsCascadingImpactOperationType
SaasAppsCascadingImpactOperationType defines the types of operations that
can trigger a SaaS app cascading impact job.

- UNSPECIFIED - UNSPECIFIED is the default value and should not be used.
- RESTORE - RESTORE indicates the job is triggered as part of a restore operation.
- SANDBOX_SEEDING - SANDBOX_SEEDING indicates the job is triggered as part of a sandbox
seeding.
- CREATE_SEEDING_TEMPLATE - CREATE_SEEDING_TEMPLATE indicates the job is triggered during the
create seeding template flow.
- EDIT_SEEDING_TEMPLATE - EDIT_SEEDING_TEMPLATE indicates the job is triggered during the
edit seeding template flow.
