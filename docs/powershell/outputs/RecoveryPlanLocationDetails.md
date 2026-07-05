### RecoveryPlanLocationDetails
Details for a recovery plan location. Exactly one of the fields is set,
depending on whether the location is a CDM cluster, AWS account, or Azure
subscription.

- cdmCluster: RecoveryPlanCdmCluster
  - CDM cluster details. Populated when the location is a CDM cluster.
- awsAccount: RecoveryPlanAwsAccount
  - AWS account details. Populated when the location is an AWS account.
- azureSubscription: RecoveryPlanAzureSubscription
  - Azure subscription details. Populated when the location is an Azure
subscription.
