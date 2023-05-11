### ValidateBlueprintInput
Input for ValidateBlueprint.

- blueprintFailoverProperties: BlueprintFailoverPropertiesInput
  - Blueprint failover related properties.
- blueprintId: System.String
  - Blueprint uuid.
- childSnappableFailoverInfos: a list of ChildSnappableFailoverInfoInputs
  - List of snappable ids and recovery points.
- enableRecoveryWithRba: System.Boolean
  - Flag to enable recoveries using Rubrik backup agent.
- skipSnappableRecoveryStatusValidation: System.Boolean
  - Specifies whether to skip validation for the workload recovery job status.
