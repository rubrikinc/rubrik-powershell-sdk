### AwsNativeEbsVolumeFilters
Filters for list of AWS EBS volumes.

- nameOrIdSubstringFilter: AwsNativeEbsVolumeNameOrIdSubstringFilter
  - Filter by name or ID substring.
- fileRecoveryStatusFilter: AwsNativeEbsVolumeFileRecoveryStatusFilter
  - Filter by file recovery status.
- typeFilter: AwsNativeEbsVolumeTypeFilter
  - Filter by EBS volume type.
- attachedInstanceFilter: AwsNativeAttachedInstanceFilter
  - Filter by attached EC2 instance.
- effectiveSlaFilter: EffectiveSlaFilter
  - Filter by effective SLA Domain.
- accountFilter: AwsNativeAccountFilter
  - Filter by AWS account.
- regionFilter: AwsNativeRegionFilter
  - Filter by region.
- relicFilter: RelicFilter
  - Filter by relic status.
- unaccessedFilter: UnaccessedFilter
  - Filter by unaccessed status.
- sensitivityStatusFilter: SensitivityStatusFilter
  - Filter by sensitivity status.
- protectionStatusFilter: ProtectionStatusFilter
  - Filter by protection status.
- tagFilter: AwsNativeTagFilter
  - Filter by tags.
- orgFilter: OrgFilter
  - Filter by organization ID.
- awsNativeFeatureStatusFilter: AwsNativeFeatureStatusFilter
  - Filter by connected status for the AWS native feature.
- awsNativeIsEligibleForEbsProtectionFilter: AwsNativeIsEligibleForEc2ProtectionFilter
  - Filter workloads based on their eligibility for protection.
