### AssignProtectionInput
Represents the assign protection input.

- globalSlaOptionalFid: System.String
  - Global SLA Domain forever UUID.
- globalSlaAssignType: SlaAssignTypeEnum
  - Corresponds to the assignment type for the global SLA.
- objectIds: list of System.Strings
  - A list of object forever UUIDs to assign to the global SLA Domain.
- backupInput: MosaicSlaInfoInput
  - Specifies backup input parameters of the protection.
