### RecoveryPlanRecoverySpecMap
Recovery plan recovery specification mapping containing recovery
configuration for all workloads.

- recoveryType: RecoveryType
  - Type of recovery that the following recovery specifications correspond to.
- targetLocationInfo: RecoveryPlanLocation
  - Target location information, where the recovery is taking place.
- userData: System.String
  - Custom configuration data for the recovery.
- childRecoverySpecs: list of ChildRecoverySpecMapV2s
  - Recovery specifications for all the children in the recovery plan.
- recoverySpecType: RecoverySpecTypeV2
  - Recovery specification type.
- recoveryId: System.String
  - Recovery ID that the recovery specification corresponds to, if any.
- sourceLocationInfo: RecoveryPlanLocation
  - Source location information. Must always be populated for the ad hoc
recovery case.
- recoverySpecId: System.String
  - Recovery specification ID.
- pauseBetweenPriorityGroups: list of System.Int64s
  - Pause between priority groups is a list of numbers representing the
length of time, in minutes, to pause between each priority group during
recovery. The numbers are ordered to align with the order of the priority
groups. For example, consider a recovery plan with 3 priority groups. For this
recovery plan, a value of [5,10,0] implies that there is a 5-minute pause
between the 1st and 2nd priority groups and a 10-minute pause between the
2nd and 3rd priority groups. The last value in the list is always 0.
- config: RecoverySpecConfig
  - Configuration settings as key-value pairs.
