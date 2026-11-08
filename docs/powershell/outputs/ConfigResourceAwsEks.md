### ConfigResourceAwsEks
AWS EKS cluster specific details for config resources.

- kubernetesVersion: System.String
  - Kubernetes version of the cluster (e.g., 1.30).
- vpcName: System.String
  - Name of the VPC the cluster is associated with.
- accessType: AwsEksAccessType
  - Cluster API server endpoint access type.
- computeType: AwsEksComputeType
  - Compute type used by the cluster (node groups, Fargate profiles, or both).
