### ValidateBlueprintInput
Input for ValidateBlueprint.

- blueprintId: System.String
  - Blueprint uuid.
- blueprintFailoverProperties: BlueprintFailoverPropertiesInput
  - Blueprint failover related properties.
- childSnappableFailoverInfos: list of ChildSnappableFailoverInfoInputs
  - List of snappable ids and recovery points.
- enableRecoveryWithRba: System.Boolean
  - Flag to enable recoveries using Rubrik backup agent.
- skipSnappableRecoveryStatusValidation: System.Boolean
  - Specifies whether to skip validation for the workload recovery job status.
