### UpdateRecoveryPlanInput
Input for updating a Recovery Plan.

- name: System.String
  - The name of the Recovery Plan.
- id: System.String
  - The ID of the Recovery Plan.
- targetLocationId: System.String
  - The ID of the target location.
- targetLocationType: BlueprintLocationType
  - The type of the target location.
- children: list of AppBlueprintChildInputs
  - The children of the Recovery Plan.
- version: System.Int32
  - The version of the Recovery Plan.
- isHydrationEnabled: System.Boolean
  - Specifies whether hydration is enabled for the Recovery Plan.
- pauseBetweenPriorityGroups: list of System.Int64s
  - A list of numbers representing the length of time, in minutes, to pause between each priority group during recovery. The numbers are ordered to align with the order of the priority groups. For example, consider a Recovery Plan with 3 priority groups. For this Recovery Plan, a value of [5,10,0] implies that there is a 5-minute pause between the 1st and 2nd priority groups and a 10-minute pause between the 2nd and 3rd priority groups. The last value in the list is always 0.
- isVisible: System.Boolean
  - Specifies whether the Recovery Plan is visible.
