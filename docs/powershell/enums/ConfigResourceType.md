### ConfigResourceType
Supported cloud configuration resource types (AWS, Azure, GCP).

- AWS_VPC - AWS Virtual Private Cloud.
- AWS_SUBNET - AWS Subnet.
- AWS_SECURITY_GROUP - AWS Security Group.
- AWS_LOAD_BALANCER - AWS Load Balancer.
- AWS_TARGET_GROUP - AWS Target Group.
- AWS_VPC_ENDPOINT_SERVICE - AWS VPC Endpoint Service.
- AWS_VPC_ENDPOINT - AWS VPC Endpoint.
- AWS_VPC_ROUTE_SERVER - AWS VPC Route Server.
- AWS_PREFIX_LIST - AWS Prefix List.
- AWS_ADDRESS - AWS Address.
- AWS_IAM_ROLE - AWS IAM Role.
- AWS_IAM_POLICY - AWS IAM Policy.
- AWS_AUTOSCALING_GROUP - AWS Auto Scaling Group.
- AWS_LAUNCH_TEMPLATE - AWS Launch Template.
- AWS_KMS_KEY - AWS KMS Key.
- AWS_KMS_ALIAS - AWS KMS Alias.
- AWS_HOSTED_ZONE - AWS Route53 Hosted Zone.
- AWS_EC2_INSTANCE_CONNECT_ENDPOINT - AWS EC2 Instance Connect Endpoint.
- AWS_EC2_INSTANCE_PROFILE - AWS EC2 Instance Profile.
- AWS_RDS_OPTION_GROUP - AWS RDS Option Group.
- AWS_RDS_PARAMETER_GROUP - AWS RDS Parameter Group.
- AWS_RDS_SUBNET_GROUP - AWS RDS Subnet Group.
- INTERNAL_PRE_HOOK - Internal: pre-recovery hook configuration.
- INTERNAL_POST_HOOK - Internal: post-recovery hook configuration.
- INTERNAL_EC2 - Internal: EC2 instance configuration. Also types EC2 instance workloads
in the account resource dependency graph.
- INTERNAL_RDS - Internal: RDS instance configuration. Also types RDS instance workloads
in the account resource dependency graph.
- INTERNAL_WORKLOAD_GROUPING - Internal: workload grouping from a config snapshot.
Cloud-agnostic: used to group workload IDs by
object type across all cloud providers.
- INTERNAL_RECONCILE - Internal: post-creation reconciliation.
- AWS_LAUNCH_TEMPLATE_VERSION - AWS Launch Template Version.
- INTERNAL_CONNECTIONS - Internal: cloud agnostic connections file.
- INTERNAL_ACM_CERTIFICATES - Internal: ACM Certificates.
- AWS_SECRET - AWS Secrets Manager.
- AWS_LAMBDA - AWS Lambda.
- AWS_ECR - AWS ECR.
- AWS_EKS - AWS EKS.
- AWS_ELASTICACHE - AWS Elasticache.
- AWS_ELASTICACHE_PARAMETER_GROUP - AWS Elasticache Parameter Group.
- AWS_ELASTICACHE_SUBNET_GROUP - AWS Elasticache Subnet Group.
- INTERNAL_S3 - Internal: S3. Also types S3 bucket workloads in the account resource
dependency graph.
- AWS_ECS_CLUSTER - AWS ECS Cluster.
- AWS_ECS_TASK_DEFINITION - AWS ECS Task Definition.
- AWS_S3_ACCESS_POINT - AWS S3 Access Point.
- INTERNAL_RDS_CONNECTIVITY - Internal: temporary cross-account RDS recovery connectivity.
- AWS_ELASTICACHE_USER - AWS Elasticache User (RBAC identity attached to Redis / Valkey
replication groups and serverless caches).
- AWS_ELASTICACHE_USER_GROUP - AWS Elasticache User Group (bundle of Users attached to
replication groups and serverless caches).
- INTERNAL_LAMBDA_LAYER - Internal: a Lambda layer version republished into the target account
during resource-data rehydration.
- INTERNAL_S3_DESTINATION - Internal: the source S3 bucket to destination bucket mapping the recovery
mutation persists for every S3 bucket recovery target, before the S3 data
recovery taskchain runs. Created by the recovery orchestrator, not by a
per-resource recovery and not from snapshot data.
