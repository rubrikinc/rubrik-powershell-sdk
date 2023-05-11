### AwsNativeEc2InstanceFilters
Filters for list of AWS EC2 instances.

- accountFilter: AwsNativeAccountFilter
  - Filter by AWS account.
- appProtectionStatusFilter: CloudNativeInstaceAppProtectionFilter
  - Filter by the protection status of the App.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- fileRecoveryStatusFilter: AwsNativeEc2InstanceFileRecoveryStatusFilter
  - Filter by file recovery status.
- nameOrIdSubstringFilter: AwsNativeEc2InstanceNameOrIdSubstringFilter
  - Filter by name or ID substring.
- orgFilter: OrgFilter
  - Filter by organization ID.
- rbsStatusFilter: AwsInstanceCcOrCnpRbsConnectionStatusFilter
  - Filter by RBS connection status.
- regionFilter: AwsNativeRegionFilter
  - Filter by region.
- relicFilter: RelicFilter
  - Filter by relic status.
- tagFilter: AwsNativeTagFilter
  - Filter by tags.
- typeFilter: AwsNativeEc2InstanceTypeFilter
  - Filter by EC2 instance type.
- vpcFilter: AwsNativeVpcFilter
  - Filter by VPC.
