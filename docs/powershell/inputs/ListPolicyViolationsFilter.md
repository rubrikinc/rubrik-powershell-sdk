### ListPolicyViolationsFilter
Filter for listing policy violations.

- policyIds: list of System.Strings
  - List of policy IDs to filter by.
- resourceIds: list of System.Strings
  - Resource IDs to filter by.
- statuses: list of PolicyViolationStatuss
  - List of policy violation statuses to filter by.
- policyViolationIds: list of System.Strings
  - Policy violation IDs to filter by.
- resourceTypes: list of PolicyResourceTypes
  - List of resource types to filter by.
- sensitivityLevels: list of SensitivityLevels
  - List of sensitivity levels to filter by.
- detectionDateRange: PolicyDateTimeRange
  - Date range for when the violations were detected.
- updateDateRange: PolicyDateTimeRange
  - Date range for when the violations were last updated.
- resourceType: PolicyResourceType
  - Resource type to filter by.
- parentViolationId: System.String
  - Get secondary violations by primary violation ID.
If the field is not set, it will return primary violations.
- dataCategoryIds: list of System.Strings
  - List of data category IDs to filter by.
- dataTypeIds: list of System.Strings
  - List of data type IDs to filter by.
- documentTypeIds: list of System.Strings
  - List of document type IDs to filter by.
- originId: System.String
  - Origin IDs to filter policy violations by.
- originIds: list of System.Strings
  - List of origin IDs to filter policy violations by.
- policyViolationNameSearch: System.String
  - Policy violation name to search for (substring match).
- statusReasons: list of PolicyViolationStatusReasons
  - List of policy violation status reasons to filter by.
- ticketNumbers: list of System.Strings
  - Filter violations by ticket numbers.
- violationNames: list of System.Strings
  - List of exact violation_name values to filter by. OR-combined with
policy_ids: a row matches if its policy_id is in policy_ids OR its
violation_name is in violation_names. Distinct from
policy_violation_name_search (single substring, AND-combined).
