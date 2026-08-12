### CcesProxyPasswordSecretRefInput
Cloud-namespaced reference to the customer-owned proxy password secret.

- awsSsm: AwsSsmSecretRef
  - AWS SSM Parameter Store reference (set for AWS Rubrik clusters).
- azureKeyVault: AzureKeyVaultSecretRef
  - Azure Key Vault reference (set for Azure Rubrik clusters).
- gcpSecretManager: GcpSecretManagerRef
  - GCP Secret Manager reference (set for GCP Rubrik clusters).
