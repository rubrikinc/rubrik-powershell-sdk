### AttachmentSpecForEbsVolume
Host AWS EC2 instance specifications for AWS EBS volume.

- awsNativeEc2InstanceId: System.String
  - EC2 instance ID.
- devicePath: System.String
  - The device path of the EBS volume on the instance.
- isExcludedFromSnapshot: System.Boolean
  - Specifies whether the EBS volume is excluded from snapshots of the EC2 instance..
- isRootVolume: System.Boolean
  - Specifies whether the EBS volume is the root volume.
