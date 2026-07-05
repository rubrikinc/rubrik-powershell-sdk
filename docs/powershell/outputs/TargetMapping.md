### TargetMapping
Target mapping information.

- id: System.String
  - The ID of the target mapping.
- name: System.String
  - The name of the target mapping.
- groupType: ArchivalGroupType
  - The type of the target mapping (manual or automatic).
- targetType: TargetType
  - The type of targets in this target mapping.
- targets: list of Targets
  - The targets in this target mapping.
- targetTemplate: TargetTemplate
  - The target template for this target mapping (if automatic).
- connectionStatus: ArchivalGroupConnectionStatus
  - Connection status for the target mapping.
- tieringStatus: list of ArchivalGroupTieringStatuss
  - Tiering status for the target mapping.
