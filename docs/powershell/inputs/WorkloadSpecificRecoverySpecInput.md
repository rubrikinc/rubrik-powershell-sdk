### WorkloadSpecificRecoverySpecInput
Platform-specific recovery specification.

- vmwareVm: VsphereVmRecoverySpecInput
  - VMware virtual machine recovery specification.
- nutanixVm: NutanixVmRecoverySpecInput
  - Nutanix virtual machine recovery specification.
- azureVm: AzureNativeVmRecoverySpecInput
  - Azure native virtual machine recovery specification.
- awsEc2Instance: AwsEc2InstanceRecoverySpecInput
  - AWS EC2 instance recovery specification.
- awsRdsInstance: AwsRdsInstanceRecoverySpecInput
  - AWS RDS instance recovery specification.
- adfr: AdfrRecoverySpecInput
  - Active Directory Forest Recovery specification.
- addc: AddcRecoverySpecInput
  - Active Directory Domain Controller recovery specification.
