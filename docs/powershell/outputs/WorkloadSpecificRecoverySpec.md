### WorkloadSpecificRecoverySpec
Platform-specific recovery specification.

- vmwareVm: VsphereVmRecoverySpec
  - VMware virtual machine recovery specification.
- nutanixVm: NutanixVmRecoverySpec
  - Nutanix virtual machine recovery specification.
- azureVm: AzureNativeVmRecoverySpec
  - Azure native virtual machine recovery specification.
- awsEc2Instance: AwsEc2InstanceRecoverySpec
  - AWS EC2 instance recovery specification.
- awsRdsInstance: AwsRdsInstanceRecoverySpec
  - AWS RDS instance recovery specification.
- adfr: AdfrRecoverySpec
  - Active Directory Forest Recovery specification.
- addc: AddcRecoverySpec
  - Active Directory Domain Controller recovery specification.
