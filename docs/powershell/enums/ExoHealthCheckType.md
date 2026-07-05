### ExoHealthCheckType
ExoHealthCheckType represents the type of health check.

- CHECK_TYPE_UNSPECIFIED - This is the default value and must not be used.
- GCP_CONNECTIVITY - GCP connectivity check.
- AZURE_PLATFORM_IP_CONNECTIVITY - Azure platform IP connectivity check.
- RSC_IP_CONNECTIVITY - RSC IP addresses connectivity check.
- ACR_CONNECTIVITY - Azure container registry connectivity check.
- CLOUDSLAB_CONNECTIVITY_OPTIONAL - Cloudslab connectivity check from Exocompute.
- ARCHIVAL_LOCATION_CONNECTIVITY_OPTIONAL - Archival location connectivity check from Exocompute.
- GCS_CONNECTIVITY_OPTIONAL - GCS connectivity check from Exocompute.
- AUTOSCALER_CONNECTIVITY - Autoscaler connectivity check from Exocompute.
- KMS_CONNECTIVITY - KMS Service connectivity check from Exocompute.
- EC2_CONNECTIVITY - EC2 Service connectivity check from Exocompute.
- STS_CONNECTIVITY - STS Service connectivity check from Exocompute.
- HOST_CONNECTIVITY - RSC sub-domain connectivity check from Exocompute.
- EKS_CONNECTIVITY - AWS EKS connectivity check.
- ECR_CONNECTIVITY - AWS ECR connectivity check.
- ADDITIONAL_CONNECTIVITY - Additional connectivity check from Exocompute.
- GCP_ARTIFACT_REGISTRY_CONNECTIVITY - GCP Artifact Registry connectivity check.
- SQL_DB_CONNECTIVITY_OPTIONAL - Azure SQL DB (logical server) connectivity check from Exocompute.
- SQL_MI_CONNECTIVITY_OPTIONAL - Azure SQL Managed Instance connectivity check from Exocompute.
- DNS_RESOLUTION - DNS resolution check.
- NETWORK_PATH_TRACE - Network path trace diagnostic.
- AWS_NETWORK_CONFIG - AWS network configuration check. Reads the exocompute VPC networking
(route tables, VPC endpoints, security groups, NACLs, ENIs/subnets) in a
single pass and reports per-resource findings in one result.
- AWS_NODE_SCALING_DIAGNOSTICS - AWS node scaling diagnostics.
- AWS_NODE_BOOT_DIAGNOSTICS - AWS node boot diagnostics.
