### AwsNativeProtectionFeature
AWS native protection features.

- EC2 - AWS native protection feature is EC2.
- RDS - AWS native protection feature is RDS.
- S3 - AWS native protection feature is S3.
- DYNAMODB - AWS native protection feature is DynamoDB.
- CLOUD_DISCOVERY - AWS native protection feature is Cloud Discovery.
- CONFIG - AWS native protection feature is Config.
- GLUE_ICEBERG - AWS native protection feature is Glue Iceberg.
- S3_TABLES_ICEBERG - AWS native protection feature is S3 Tables Iceberg.
- CLOUD_COST_REPORT - AWS native protection feature is Cloud Cost Report. Present so the
feature can be removed through startAwsNativeAccountDisableJob, the same
route CLOUD_DISCOVERY uses; it protects no workload of its own.
