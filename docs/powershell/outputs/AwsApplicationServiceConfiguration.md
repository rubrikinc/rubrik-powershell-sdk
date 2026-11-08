### AwsApplicationServiceConfiguration
AWS service configuration for application.

- ec2Enabled: System.Boolean
  - Whether EC2 instance protection is enabled.
- rdsEnabled: System.Boolean
  - Whether RDS database protection is enabled.
- ebsEnabled: System.Boolean
  - Whether EBS volume protection is enabled.
- elbEnabled: System.Boolean
  - Whether Elastic Load Balancer protection is enabled.
- s3Enabled: System.Boolean
  - Whether S3 bucket protection is enabled.
- secretsEnabled: System.Boolean
  - Whether AWS Secrets Manager protection is enabled.
- elasticacheEnabled: System.Boolean
  - Whether ElastiCache protection is enabled.
- eksEnabled: System.Boolean
  - Whether EKS protection is enabled.
- ecrEnabled: System.Boolean
  - Whether ECR protection is enabled.
- lambdaEnabled: System.Boolean
  - Whether Lambda protection is enabled.
- isEcsEnabled: System.Boolean
  - Whether ECS protection is enabled.
