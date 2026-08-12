### Filter
A set of parameters to filter objects.

- field: HierarchyFilterField
  - The hierarchy object attribute to filter on.
- texts: list of System.Strings
  - The relationship between each string will be OR.
- tagFilterParams: list of TagFilterParamss
  - Params for tag based filter. Required only when filtering by
AWS or Azure tags. The relationship between each set of params
will be OR.
- objectTypeFilterParams: list of ManagedObjectTypes
  - Params for object type related filter.
- awsNativeProtectionFeatureNames: list of AwsNativeProtectionFeatures
  - Param for AWS native account enabled feature filter.
- isNegative: System.Boolean
  - Whether to negate the filter and exclude matching objects.
- isSlowSearchEnabled: System.Boolean
  - Enable slow search for location-based filters.
- azureNativeProtectionFeatureNames: list of AzureNativeProtectionFeatures
  - Param for Azure native subscription enabled feature filter.
- unmanagedObjectAvailabilityFilter: list of UnmanagedObjectAvailabilityFilters
  - Param for filtering unmanaged objects based on availability.
- gcpNativeProtectionFeatureNames: list of GcpNativeProtectionFeatures
  - Param for GCP native project enabled feature filter.
- timeParam: DateTime
  - Timestamp param; semantics determined by the filter field.
- nativeTagFilterParams: list of NativeTagFilterParamss
  - Params for the linked-native-tag filter. Each entry carries a
(source, sourceTagIds) pair. The relationship between
entries is OR.
