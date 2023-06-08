### AwsNativeEc2InstanceFilters
Filters for list of AWS EC2 instances.

- nameOrIdSubstringFilter: AwsNativeEc2InstanceNameOrIdSubstringFilter
  - Filter by name or ID substring.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- accountFilter: AwsNativeAccountFilter
  - Filter by AWS account.
- fileRecoveryStatusFilter: AwsNativeEc2InstanceFileRecoveryStatusFilter
  - Filter by file recovery status.
- regionFilter: AwsNativeRegionFilter
  - Filter by region.
- typeFilter: AwsNativeEc2InstanceTypeFilter
  - Filter by EC2 instance type.
- vpcFilter: AwsNativeVpcFilter
  - Filter by VPC.
- relicFilter: RelicFilter
  - Filter by relic status.
- tagFilter: AwsNativeTagFilter
  - Filter by tags.
- appProtectionStatusFilter: CloudNativeInstaceAppProtectionFilter
  - Filter by the protection status of the App.
- rbsStatusFilter: AwsInstanceCcOrCnpRbsConnectionStatusFilter
  - Filter by RBS connection status.
- orgFilter: OrgFilter
  - Filter by organization ID.
