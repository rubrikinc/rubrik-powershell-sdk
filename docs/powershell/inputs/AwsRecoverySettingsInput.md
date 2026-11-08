### AwsRecoverySettingsInput
AwsRecoverySettings holds all AWS-specific settings for application
recovery. Each nested field is optional; absent fields imply default
cloud behaviour.

- networking: AwsNetworkingSettingsInput
  - Networking strategy (optional).
- kms: AwsKmsSettingsInput
  - KMS encryption settings (optional -- absent means no KMS override).
- dns: AwsRoute53Input
  - DNS settings (optional -- absent means no DNS updates).
- s3: AwsS3RecoverySettingsInput
  - S3 bucket recovery settings (optional -- absent means no S3
buckets are being recovered).
