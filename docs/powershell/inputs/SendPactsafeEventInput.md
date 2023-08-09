### SendPactsafeEventInput
Input required to send an event to Pactsafe regarding a contract.

- contractType: ContractType
- versionId: System.String
  - The version ID of the contract.
- event: PactsafeEvent
  - The event type.
- customData: CustomPactsafeDataInput
  - The information regarding the user.
