### VpcOptionInput
VPC strategy for the recovery.

- cloneVpcSameCidr: AwsCloneVpcSameCidrInput
  - Clone VPCs preserving the original CIDR blocks.
- cloneVpcAlternateCidr: AwsCloneVpcAlternateCidrInput
  - Clone VPCs with alternate CIDR blocks (per-VPC remapping required).
- useExistingVpc: AwsUseExistingVpcInput
  - Use pre-existing VPCs in the recovery account.
